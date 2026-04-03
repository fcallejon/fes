// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated


open Fes.Generated.Types

module Converters =

    type FailureStoreStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalBulk.FailureStoreStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalBulk.FailureStoreStatus.NotApplicableOrUnknown -> "not_applicable_or_unknown"
                | GlobalBulk.FailureStoreStatus.Used -> "used"
                | GlobalBulk.FailureStoreStatus.NotEnabled -> "not_enabled"
                | GlobalBulk.FailureStoreStatus.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "not_applicable_or_unknown" -> GlobalBulk.FailureStoreStatus.NotApplicableOrUnknown
            | "used" -> GlobalBulk.FailureStoreStatus.Used
            | "not_enabled" -> GlobalBulk.FailureStoreStatus.NotEnabled
            | "failed" -> GlobalBulk.FailureStoreStatus.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FailureStoreStatus"))

    type OperationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalBulk.OperationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | GlobalBulk.OperationContainer.Index v ->
                writer.WritePropertyName("index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalBulk.OperationContainer.Create v ->
                writer.WritePropertyName("create")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalBulk.OperationContainer.Update v ->
                writer.WritePropertyName("update")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalBulk.OperationContainer.Delete v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalBulk.IndexOperation>(ref reader, options)
                    GlobalBulk.OperationContainer.Index v
                | "create" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalBulk.CreateOperation>(ref reader, options)
                    GlobalBulk.OperationContainer.Create v
                | "update" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalBulk.UpdateOperation>(ref reader, options)
                    GlobalBulk.OperationContainer.Update v
                | "delete" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalBulk.DeleteOperation>(ref reader, options)
                    GlobalBulk.OperationContainer.Delete v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for OperationContainer"))
            reader.Read() |> ignore // EndObject
            result

    type OperationTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalBulk.OperationType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalBulk.OperationType.Index -> "index"
                | GlobalBulk.OperationType.Create -> "create"
                | GlobalBulk.OperationType.Update -> "update"
                | GlobalBulk.OperationType.Delete -> "delete"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> GlobalBulk.OperationType.Index
            | "create" -> GlobalBulk.OperationType.Create
            | "update" -> GlobalBulk.OperationType.Update
            | "delete" -> GlobalBulk.OperationType.Delete
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OperationType"))

    type RestMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalCapabilities.RestMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalCapabilities.RestMethod.GET -> "GET"
                | GlobalCapabilities.RestMethod.HEAD -> "HEAD"
                | GlobalCapabilities.RestMethod.POST -> "POST"
                | GlobalCapabilities.RestMethod.PUT -> "PUT"
                | GlobalCapabilities.RestMethod.DELETE -> "DELETE"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "GET" -> GlobalCapabilities.RestMethod.GET
            | "HEAD" -> GlobalCapabilities.RestMethod.HEAD
            | "POST" -> GlobalCapabilities.RestMethod.POST
            | "PUT" -> GlobalCapabilities.RestMethod.PUT
            | "DELETE" -> GlobalCapabilities.RestMethod.DELETE
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RestMethod"))

    type ImpactAreaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalHealthReport.ImpactArea>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalHealthReport.ImpactArea.Search -> "search"
                | GlobalHealthReport.ImpactArea.Ingest -> "ingest"
                | GlobalHealthReport.ImpactArea.Backup -> "backup"
                | GlobalHealthReport.ImpactArea.DeploymentManagement -> "deployment_management"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "search" -> GlobalHealthReport.ImpactArea.Search
            | "ingest" -> GlobalHealthReport.ImpactArea.Ingest
            | "backup" -> GlobalHealthReport.ImpactArea.Backup
            | "deployment_management" -> GlobalHealthReport.ImpactArea.DeploymentManagement
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ImpactArea"))

    type IndicatorHealthStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalHealthReport.IndicatorHealthStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalHealthReport.IndicatorHealthStatus.Green -> "green"
                | GlobalHealthReport.IndicatorHealthStatus.Yellow -> "yellow"
                | GlobalHealthReport.IndicatorHealthStatus.Red -> "red"
                | GlobalHealthReport.IndicatorHealthStatus.Unknown -> "unknown"
                | GlobalHealthReport.IndicatorHealthStatus.Unavailable -> "unavailable"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "green" -> GlobalHealthReport.IndicatorHealthStatus.Green
            | "yellow" -> GlobalHealthReport.IndicatorHealthStatus.Yellow
            | "red" -> GlobalHealthReport.IndicatorHealthStatus.Red
            | "unknown" -> GlobalHealthReport.IndicatorHealthStatus.Unknown
            | "unavailable" -> GlobalHealthReport.IndicatorHealthStatus.Unavailable
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndicatorHealthStatus"))

    type PainlessContextConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalScriptsPainlessExecute.PainlessContext>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalScriptsPainlessExecute.PainlessContext.PainlessTest -> "painless_test"
                | GlobalScriptsPainlessExecute.PainlessContext.Filter -> "filter"
                | GlobalScriptsPainlessExecute.PainlessContext.Score -> "score"
                | GlobalScriptsPainlessExecute.PainlessContext.BooleanField -> "boolean_field"
                | GlobalScriptsPainlessExecute.PainlessContext.DateField -> "date_field"
                | GlobalScriptsPainlessExecute.PainlessContext.DoubleField -> "double_field"
                | GlobalScriptsPainlessExecute.PainlessContext.GeoPointField -> "geo_point_field"
                | GlobalScriptsPainlessExecute.PainlessContext.IpField -> "ip_field"
                | GlobalScriptsPainlessExecute.PainlessContext.KeywordField -> "keyword_field"
                | GlobalScriptsPainlessExecute.PainlessContext.LongField -> "long_field"
                | GlobalScriptsPainlessExecute.PainlessContext.CompositeField -> "composite_field"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "painless_test" -> GlobalScriptsPainlessExecute.PainlessContext.PainlessTest
            | "filter" -> GlobalScriptsPainlessExecute.PainlessContext.Filter
            | "score" -> GlobalScriptsPainlessExecute.PainlessContext.Score
            | "boolean_field" -> GlobalScriptsPainlessExecute.PainlessContext.BooleanField
            | "date_field" -> GlobalScriptsPainlessExecute.PainlessContext.DateField
            | "double_field" -> GlobalScriptsPainlessExecute.PainlessContext.DoubleField
            | "geo_point_field" -> GlobalScriptsPainlessExecute.PainlessContext.GeoPointField
            | "ip_field" -> GlobalScriptsPainlessExecute.PainlessContext.IpField
            | "keyword_field" -> GlobalScriptsPainlessExecute.PainlessContext.KeywordField
            | "long_field" -> GlobalScriptsPainlessExecute.PainlessContext.LongField
            | "composite_field" -> GlobalScriptsPainlessExecute.PainlessContext.CompositeField
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PainlessContext"))

    type BoundaryScannerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.BoundaryScanner>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.BoundaryScanner.Chars -> "chars"
                | GlobalSearchTypes.BoundaryScanner.Sentence -> "sentence"
                | GlobalSearchTypes.BoundaryScanner.Word -> "word"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chars" -> GlobalSearchTypes.BoundaryScanner.Chars
            | "sentence" -> GlobalSearchTypes.BoundaryScanner.Sentence
            | "word" -> GlobalSearchTypes.BoundaryScanner.Word
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for BoundaryScanner"))

    type FieldSuggesterConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.FieldSuggester>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | GlobalSearchTypes.FieldSuggester.Completion v ->
                writer.WritePropertyName("completion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.FieldSuggester.Phrase v ->
                writer.WritePropertyName("phrase")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.FieldSuggester.Term v ->
                writer.WritePropertyName("term")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.FieldSuggester.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.CompletionSuggester>(ref reader, options)
                    GlobalSearchTypes.FieldSuggester.Completion v
                | "phrase" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.PhraseSuggester>(ref reader, options)
                    GlobalSearchTypes.FieldSuggester.Phrase v
                | "term" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.TermSuggester>(ref reader, options)
                    GlobalSearchTypes.FieldSuggester.Term v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    GlobalSearchTypes.FieldSuggester.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type HighlighterEncoderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.HighlighterEncoder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.HighlighterEncoder.Default -> "default"
                | GlobalSearchTypes.HighlighterEncoder.Html -> "html"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "default" -> GlobalSearchTypes.HighlighterEncoder.Default
            | "html" -> GlobalSearchTypes.HighlighterEncoder.Html
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterEncoder"))

    type HighlighterFragmenterConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.HighlighterFragmenter>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.HighlighterFragmenter.Simple -> "simple"
                | GlobalSearchTypes.HighlighterFragmenter.Span -> "span"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "simple" -> GlobalSearchTypes.HighlighterFragmenter.Simple
            | "span" -> GlobalSearchTypes.HighlighterFragmenter.Span
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterFragmenter"))

    type HighlighterOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.HighlighterOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.HighlighterOrder.Score -> "score"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "score" -> GlobalSearchTypes.HighlighterOrder.Score
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterOrder"))

    type HighlighterTagsSchemaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.HighlighterTagsSchema>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.HighlighterTagsSchema.Styled -> "styled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "styled" -> GlobalSearchTypes.HighlighterTagsSchema.Styled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HighlighterTagsSchema"))

    type HighlighterTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.HighlighterType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.HighlighterType.Plain -> "plain"
                | GlobalSearchTypes.HighlighterType.Fvh -> "fvh"
                | GlobalSearchTypes.HighlighterType.Unified -> "unified"
                | GlobalSearchTypes.HighlighterType.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "plain" -> GlobalSearchTypes.HighlighterType.Plain
            | "fvh" -> GlobalSearchTypes.HighlighterType.Fvh
            | "unified" -> GlobalSearchTypes.HighlighterType.Unified
            | other -> GlobalSearchTypes.HighlighterType.Custom other

    type RescoreConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.Rescore>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | GlobalSearchTypes.Rescore.Query v ->
                writer.WritePropertyName("query")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.Rescore.LearningToRank v ->
                writer.WritePropertyName("learning_to_rank")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.Rescore.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.Rescore.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.RescoreQuery>(ref reader, options)
                    GlobalSearchTypes.Rescore.Query v
                | "learning_to_rank" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.LearningToRank>(ref reader, options)
                    GlobalSearchTypes.Rescore.LearningToRank v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.ScriptRescore>(ref reader, options)
                    GlobalSearchTypes.Rescore.Script v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    GlobalSearchTypes.Rescore.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type ScoreModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.ScoreMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.ScoreMode.Avg -> "avg"
                | GlobalSearchTypes.ScoreMode.Max -> "max"
                | GlobalSearchTypes.ScoreMode.Min -> "min"
                | GlobalSearchTypes.ScoreMode.Multiply -> "multiply"
                | GlobalSearchTypes.ScoreMode.Total -> "total"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "avg" -> GlobalSearchTypes.ScoreMode.Avg
            | "max" -> GlobalSearchTypes.ScoreMode.Max
            | "min" -> GlobalSearchTypes.ScoreMode.Min
            | "multiply" -> GlobalSearchTypes.ScoreMode.Multiply
            | "total" -> GlobalSearchTypes.ScoreMode.Total
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ScoreMode"))

    type SmoothingModelContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.SmoothingModelContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | GlobalSearchTypes.SmoothingModelContainer.Laplace v ->
                writer.WritePropertyName("laplace")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.SmoothingModelContainer.LinearInterpolation v ->
                writer.WritePropertyName("linear_interpolation")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | GlobalSearchTypes.SmoothingModelContainer.StupidBackoff v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.LaplaceSmoothingModel>(ref reader, options)
                    GlobalSearchTypes.SmoothingModelContainer.Laplace v
                | "linear_interpolation" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.LinearInterpolationSmoothingModel>(ref reader, options)
                    GlobalSearchTypes.SmoothingModelContainer.LinearInterpolation v
                | "stupid_backoff" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<GlobalSearchTypes.StupidBackoffSmoothingModel>(ref reader, options)
                    GlobalSearchTypes.SmoothingModelContainer.StupidBackoff v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SmoothingModelContainer"))
            reader.Read() |> ignore // EndObject
            result

    type StringDistanceConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.StringDistance>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.StringDistance.Internal -> "internal"
                | GlobalSearchTypes.StringDistance.DamerauLevenshtein -> "damerau_levenshtein"
                | GlobalSearchTypes.StringDistance.Levenshtein -> "levenshtein"
                | GlobalSearchTypes.StringDistance.JaroWinkler -> "jaro_winkler"
                | GlobalSearchTypes.StringDistance.Ngram -> "ngram"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "internal" -> GlobalSearchTypes.StringDistance.Internal
            | "damerau_levenshtein" -> GlobalSearchTypes.StringDistance.DamerauLevenshtein
            | "levenshtein" -> GlobalSearchTypes.StringDistance.Levenshtein
            | "jaro_winkler" -> GlobalSearchTypes.StringDistance.JaroWinkler
            | "ngram" -> GlobalSearchTypes.StringDistance.Ngram
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StringDistance"))

    type SuggestSortConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.SuggestSort>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.SuggestSort.Score -> "score"
                | GlobalSearchTypes.SuggestSort.Frequency -> "frequency"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "score" -> GlobalSearchTypes.SuggestSort.Score
            | "frequency" -> GlobalSearchTypes.SuggestSort.Frequency
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SuggestSort"))

    type TotalHitsRelationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchTypes.TotalHitsRelation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchTypes.TotalHitsRelation.Eq -> "eq"
                | GlobalSearchTypes.TotalHitsRelation.Gte -> "gte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "eq" -> GlobalSearchTypes.TotalHitsRelation.Eq
            | "gte" -> GlobalSearchTypes.TotalHitsRelation.Gte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TotalHitsRelation"))

    type GridAggregationTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchMvtTypes.GridAggregationType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchMvtTypes.GridAggregationType.Geotile -> "geotile"
                | GlobalSearchMvtTypes.GridAggregationType.Geohex -> "geohex"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geotile" -> GlobalSearchMvtTypes.GridAggregationType.Geotile
            | "geohex" -> GlobalSearchMvtTypes.GridAggregationType.Geohex
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GridAggregationType"))

    type GridTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<GlobalSearchMvtTypes.GridType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | GlobalSearchMvtTypes.GridType.Grid -> "grid"
                | GlobalSearchMvtTypes.GridType.Point -> "point"
                | GlobalSearchMvtTypes.GridType.Centroid -> "centroid"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "grid" -> GlobalSearchMvtTypes.GridType.Grid
            | "point" -> GlobalSearchMvtTypes.GridType.Point
            | "centroid" -> GlobalSearchMvtTypes.GridType.Centroid
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GridType"))

    type BytesConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.Bytes>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.Bytes.B -> "b"
                | Types.Bytes.Kb -> "kb"
                | Types.Bytes.Mb -> "mb"
                | Types.Bytes.Gb -> "gb"
                | Types.Bytes.Tb -> "tb"
                | Types.Bytes.Pb -> "pb"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "b" -> Types.Bytes.B
            | "kb" -> Types.Bytes.Kb
            | "mb" -> Types.Bytes.Mb
            | "gb" -> Types.Bytes.Gb
            | "tb" -> Types.Bytes.Tb
            | "pb" -> Types.Bytes.Pb
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Bytes"))

    type ClusterInfoTargetConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.ClusterInfoTarget>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.ClusterInfoTarget.All -> "_all"
                | Types.ClusterInfoTarget.Http -> "http"
                | Types.ClusterInfoTarget.Ingest -> "ingest"
                | Types.ClusterInfoTarget.ThreadPool -> "thread_pool"
                | Types.ClusterInfoTarget.Script -> "script"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> Types.ClusterInfoTarget.All
            | "http" -> Types.ClusterInfoTarget.Http
            | "ingest" -> Types.ClusterInfoTarget.Ingest
            | "thread_pool" -> Types.ClusterInfoTarget.ThreadPool
            | "script" -> Types.ClusterInfoTarget.Script
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ClusterInfoTarget"))

    type ClusterSearchStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.ClusterSearchStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.ClusterSearchStatus.Running -> "running"
                | Types.ClusterSearchStatus.Successful -> "successful"
                | Types.ClusterSearchStatus.Partial -> "partial"
                | Types.ClusterSearchStatus.Skipped -> "skipped"
                | Types.ClusterSearchStatus.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "running" -> Types.ClusterSearchStatus.Running
            | "successful" -> Types.ClusterSearchStatus.Successful
            | "partial" -> Types.ClusterSearchStatus.Partial
            | "skipped" -> Types.ClusterSearchStatus.Skipped
            | "failed" -> Types.ClusterSearchStatus.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ClusterSearchStatus"))

    type CommonStatsFlagConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.CommonStatsFlag>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.CommonStatsFlag.All -> "_all"
                | Types.CommonStatsFlag.Store -> "store"
                | Types.CommonStatsFlag.Indexing -> "indexing"
                | Types.CommonStatsFlag.Get -> "get"
                | Types.CommonStatsFlag.Search -> "search"
                | Types.CommonStatsFlag.Merge -> "merge"
                | Types.CommonStatsFlag.Flush -> "flush"
                | Types.CommonStatsFlag.Refresh -> "refresh"
                | Types.CommonStatsFlag.QueryCache -> "query_cache"
                | Types.CommonStatsFlag.Fielddata -> "fielddata"
                | Types.CommonStatsFlag.Docs -> "docs"
                | Types.CommonStatsFlag.Warmer -> "warmer"
                | Types.CommonStatsFlag.Completion -> "completion"
                | Types.CommonStatsFlag.Segments -> "segments"
                | Types.CommonStatsFlag.Translog -> "translog"
                | Types.CommonStatsFlag.RequestCache -> "request_cache"
                | Types.CommonStatsFlag.Recovery -> "recovery"
                | Types.CommonStatsFlag.Bulk -> "bulk"
                | Types.CommonStatsFlag.ShardStats -> "shard_stats"
                | Types.CommonStatsFlag.Mappings -> "mappings"
                | Types.CommonStatsFlag.DenseVector -> "dense_vector"
                | Types.CommonStatsFlag.SparseVector -> "sparse_vector"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> Types.CommonStatsFlag.All
            | "store" -> Types.CommonStatsFlag.Store
            | "indexing" -> Types.CommonStatsFlag.Indexing
            | "get" -> Types.CommonStatsFlag.Get
            | "search" -> Types.CommonStatsFlag.Search
            | "merge" -> Types.CommonStatsFlag.Merge
            | "flush" -> Types.CommonStatsFlag.Flush
            | "refresh" -> Types.CommonStatsFlag.Refresh
            | "query_cache" -> Types.CommonStatsFlag.QueryCache
            | "fielddata" -> Types.CommonStatsFlag.Fielddata
            | "docs" -> Types.CommonStatsFlag.Docs
            | "warmer" -> Types.CommonStatsFlag.Warmer
            | "completion" -> Types.CommonStatsFlag.Completion
            | "segments" -> Types.CommonStatsFlag.Segments
            | "translog" -> Types.CommonStatsFlag.Translog
            | "request_cache" -> Types.CommonStatsFlag.RequestCache
            | "recovery" -> Types.CommonStatsFlag.Recovery
            | "bulk" -> Types.CommonStatsFlag.Bulk
            | "shard_stats" -> Types.CommonStatsFlag.ShardStats
            | "mappings" -> Types.CommonStatsFlag.Mappings
            | "dense_vector" -> Types.CommonStatsFlag.DenseVector
            | "sparse_vector" -> Types.CommonStatsFlag.SparseVector
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CommonStatsFlag"))

    type ConflictsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.Conflicts>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.Conflicts.Abort -> "abort"
                | Types.Conflicts.Proceed -> "proceed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "abort" -> Types.Conflicts.Abort
            | "proceed" -> Types.Conflicts.Proceed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Conflicts"))

    type DFIIndependenceMeasureConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.DFIIndependenceMeasure>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.DFIIndependenceMeasure.Standardized -> "standardized"
                | Types.DFIIndependenceMeasure.Saturated -> "saturated"
                | Types.DFIIndependenceMeasure.Chisquared -> "chisquared"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "standardized" -> Types.DFIIndependenceMeasure.Standardized
            | "saturated" -> Types.DFIIndependenceMeasure.Saturated
            | "chisquared" -> Types.DFIIndependenceMeasure.Chisquared
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DFIIndependenceMeasure"))

    type DFRAfterEffectConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.DFRAfterEffect>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.DFRAfterEffect.No -> "no"
                | Types.DFRAfterEffect.B -> "b"
                | Types.DFRAfterEffect.L -> "l"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> Types.DFRAfterEffect.No
            | "b" -> Types.DFRAfterEffect.B
            | "l" -> Types.DFRAfterEffect.L
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DFRAfterEffect"))

    type DFRBasicModelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.DFRBasicModel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.DFRBasicModel.Be -> "be"
                | Types.DFRBasicModel.D -> "d"
                | Types.DFRBasicModel.G -> "g"
                | Types.DFRBasicModel.If -> "if"
                | Types.DFRBasicModel.In -> "in"
                | Types.DFRBasicModel.Ine -> "ine"
                | Types.DFRBasicModel.P -> "p"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "be" -> Types.DFRBasicModel.Be
            | "d" -> Types.DFRBasicModel.D
            | "g" -> Types.DFRBasicModel.G
            | "if" -> Types.DFRBasicModel.If
            | "in" -> Types.DFRBasicModel.In
            | "ine" -> Types.DFRBasicModel.Ine
            | "p" -> Types.DFRBasicModel.P
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DFRBasicModel"))

    type DistanceUnitConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.DistanceUnit>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.DistanceUnit.In -> "in"
                | Types.DistanceUnit.Ft -> "ft"
                | Types.DistanceUnit.Yd -> "yd"
                | Types.DistanceUnit.Mi -> "mi"
                | Types.DistanceUnit.Nmi -> "nmi"
                | Types.DistanceUnit.Km -> "km"
                | Types.DistanceUnit.M -> "m"
                | Types.DistanceUnit.Cm -> "cm"
                | Types.DistanceUnit.Mm -> "mm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "in" -> Types.DistanceUnit.In
            | "ft" -> Types.DistanceUnit.Ft
            | "yd" -> Types.DistanceUnit.Yd
            | "mi" -> Types.DistanceUnit.Mi
            | "nmi" -> Types.DistanceUnit.Nmi
            | "km" -> Types.DistanceUnit.Km
            | "m" -> Types.DistanceUnit.M
            | "cm" -> Types.DistanceUnit.Cm
            | "mm" -> Types.DistanceUnit.Mm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DistanceUnit"))

    type DiversifyRetrieverTypesConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.DiversifyRetrieverTypes>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.DiversifyRetrieverTypes.Mmr -> "mmr"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "mmr" -> Types.DiversifyRetrieverTypes.Mmr
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DiversifyRetrieverTypes"))

    type ExpandWildcardConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.ExpandWildcard>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.ExpandWildcard.All -> "all"
                | Types.ExpandWildcard.Open -> "open"
                | Types.ExpandWildcard.Closed -> "closed"
                | Types.ExpandWildcard.Hidden -> "hidden"
                | Types.ExpandWildcard.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> Types.ExpandWildcard.All
            | "open" -> Types.ExpandWildcard.Open
            | "closed" -> Types.ExpandWildcard.Closed
            | "hidden" -> Types.ExpandWildcard.Hidden
            | "none" -> Types.ExpandWildcard.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExpandWildcard"))

    type FieldSortNumericTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.FieldSortNumericType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.FieldSortNumericType.Long -> "long"
                | Types.FieldSortNumericType.Double -> "double"
                | Types.FieldSortNumericType.Date -> "date"
                | Types.FieldSortNumericType.DateNanos -> "date_nanos"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "long" -> Types.FieldSortNumericType.Long
            | "double" -> Types.FieldSortNumericType.Double
            | "date" -> Types.FieldSortNumericType.Date
            | "date_nanos" -> Types.FieldSortNumericType.DateNanos
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldSortNumericType"))

    type GeoDistanceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.GeoDistanceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.GeoDistanceType.Arc -> "arc"
                | Types.GeoDistanceType.Plane -> "plane"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "arc" -> Types.GeoDistanceType.Arc
            | "plane" -> Types.GeoDistanceType.Plane
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoDistanceType"))

    type GeoShapeRelationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.GeoShapeRelation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.GeoShapeRelation.Intersects -> "intersects"
                | Types.GeoShapeRelation.Disjoint -> "disjoint"
                | Types.GeoShapeRelation.Within -> "within"
                | Types.GeoShapeRelation.Contains -> "contains"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "intersects" -> Types.GeoShapeRelation.Intersects
            | "disjoint" -> Types.GeoShapeRelation.Disjoint
            | "within" -> Types.GeoShapeRelation.Within
            | "contains" -> Types.GeoShapeRelation.Contains
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoShapeRelation"))

    type HealthStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.HealthStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.HealthStatus.Green -> "green"
                | Types.HealthStatus.Yellow -> "yellow"
                | Types.HealthStatus.Red -> "red"
                | Types.HealthStatus.Unknown -> "unknown"
                | Types.HealthStatus.Unavailable -> "unavailable"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "green" -> Types.HealthStatus.Green
            | "yellow" -> Types.HealthStatus.Yellow
            | "red" -> Types.HealthStatus.Red
            | "unknown" -> Types.HealthStatus.Unknown
            | "unavailable" -> Types.HealthStatus.Unavailable
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HealthStatus"))

    type IBDistributionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.IBDistribution>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.IBDistribution.Ll -> "ll"
                | Types.IBDistribution.Spl -> "spl"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ll" -> Types.IBDistribution.Ll
            | "spl" -> Types.IBDistribution.Spl
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IBDistribution"))

    type IBLambdaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.IBLambda>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.IBLambda.Df -> "df"
                | Types.IBLambda.Ttf -> "ttf"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "df" -> Types.IBLambda.Df
            | "ttf" -> Types.IBLambda.Ttf
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IBLambda"))

    type LevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.Level>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.Level.Cluster -> "cluster"
                | Types.Level.Indices -> "indices"
                | Types.Level.Shards -> "shards"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cluster" -> Types.Level.Cluster
            | "indices" -> Types.Level.Indices
            | "shards" -> Types.Level.Shards
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Level"))

    type LifecycleOperationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.LifecycleOperationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.LifecycleOperationMode.RUNNING -> "RUNNING"
                | Types.LifecycleOperationMode.STOPPING -> "STOPPING"
                | Types.LifecycleOperationMode.STOPPED -> "STOPPED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "RUNNING" -> Types.LifecycleOperationMode.RUNNING
            | "STOPPING" -> Types.LifecycleOperationMode.STOPPING
            | "STOPPED" -> Types.LifecycleOperationMode.STOPPED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LifecycleOperationMode"))

    type NodeRoleConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.NodeRole>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.NodeRole.Master -> "master"
                | Types.NodeRole.Data -> "data"
                | Types.NodeRole.DataCold -> "data_cold"
                | Types.NodeRole.DataContent -> "data_content"
                | Types.NodeRole.DataFrozen -> "data_frozen"
                | Types.NodeRole.DataHot -> "data_hot"
                | Types.NodeRole.DataWarm -> "data_warm"
                | Types.NodeRole.Client -> "client"
                | Types.NodeRole.Ingest -> "ingest"
                | Types.NodeRole.Ml -> "ml"
                | Types.NodeRole.VotingOnly -> "voting_only"
                | Types.NodeRole.Transform -> "transform"
                | Types.NodeRole.RemoteClusterClient -> "remote_cluster_client"
                | Types.NodeRole.CoordinatingOnly -> "coordinating_only"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "master" -> Types.NodeRole.Master
            | "data" -> Types.NodeRole.Data
            | "data_cold" -> Types.NodeRole.DataCold
            | "data_content" -> Types.NodeRole.DataContent
            | "data_frozen" -> Types.NodeRole.DataFrozen
            | "data_hot" -> Types.NodeRole.DataHot
            | "data_warm" -> Types.NodeRole.DataWarm
            | "client" -> Types.NodeRole.Client
            | "ingest" -> Types.NodeRole.Ingest
            | "ml" -> Types.NodeRole.Ml
            | "voting_only" -> Types.NodeRole.VotingOnly
            | "transform" -> Types.NodeRole.Transform
            | "remote_cluster_client" -> Types.NodeRole.RemoteClusterClient
            | "coordinating_only" -> Types.NodeRole.CoordinatingOnly
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodeRole"))

    type NodeStatsLevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.NodeStatsLevel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.NodeStatsLevel.Node -> "node"
                | Types.NodeStatsLevel.Indices -> "indices"
                | Types.NodeStatsLevel.Shards -> "shards"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "node" -> Types.NodeStatsLevel.Node
            | "indices" -> Types.NodeStatsLevel.Indices
            | "shards" -> Types.NodeStatsLevel.Shards
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodeStatsLevel"))

    type NormalizationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.Normalization>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.Normalization.No -> "no"
                | Types.Normalization.H1 -> "h1"
                | Types.Normalization.H2 -> "h2"
                | Types.Normalization.H3 -> "h3"
                | Types.Normalization.Z -> "z"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> Types.Normalization.No
            | "h1" -> Types.Normalization.H1
            | "h2" -> Types.Normalization.H2
            | "h3" -> Types.Normalization.H3
            | "z" -> Types.Normalization.Z
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Normalization"))

    type OpTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.OpType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.OpType.Index -> "index"
                | Types.OpType.Create -> "create"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> Types.OpType.Index
            | "create" -> Types.OpType.Create
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpType"))

    type QueryVectorBuilderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.QueryVectorBuilder>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | Types.QueryVectorBuilder.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.QueryVectorBuilder.Lookup v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextEmbedding>(ref reader, options)
                    Types.QueryVectorBuilder.TextEmbedding v
                | "lookup" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LookupQueryVectorBuilder>(ref reader, options)
                    Types.QueryVectorBuilder.Lookup v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for QueryVectorBuilder"))
            reader.Read() |> ignore // EndObject
            result

    type RankContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.RankContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | Types.RankContainer.Rrf v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RrfRank>(ref reader, options)
                    Types.RankContainer.Rrf v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RankContainer"))
            reader.Read() |> ignore // EndObject
            result

    type RefreshConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.Refresh>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.Refresh.True -> "true"
                | Types.Refresh.False -> "false"
                | Types.Refresh.WaitFor -> "wait_for"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "true" -> Types.Refresh.True
            | "false" -> Types.Refresh.False
            | "wait_for" -> Types.Refresh.WaitFor
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Refresh"))

    type ResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.Result>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.Result.Created -> "created"
                | Types.Result.Updated -> "updated"
                | Types.Result.Deleted -> "deleted"
                | Types.Result.NotFound -> "not_found"
                | Types.Result.Noop -> "noop"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "created" -> Types.Result.Created
            | "updated" -> Types.Result.Updated
            | "deleted" -> Types.Result.Deleted
            | "not_found" -> Types.Result.NotFound
            | "noop" -> Types.Result.Noop
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Result"))

    type RetrieverContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.RetrieverContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | Types.RetrieverContainer.Standard v ->
                writer.WritePropertyName("standard")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.Knn v ->
                writer.WritePropertyName("knn")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.Rrf v ->
                writer.WritePropertyName("rrf")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.TextSimilarityReranker v ->
                writer.WritePropertyName("text_similarity_reranker")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.Rule v ->
                writer.WritePropertyName("rule")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.Rescorer v ->
                writer.WritePropertyName("rescorer")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.Linear v ->
                writer.WritePropertyName("linear")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.Pinned v ->
                writer.WritePropertyName("pinned")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.RetrieverContainer.Diversify v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.StandardRetriever>(ref reader, options)
                    Types.RetrieverContainer.Standard v
                | "knn" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.KnnRetriever>(ref reader, options)
                    Types.RetrieverContainer.Knn v
                | "rrf" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RRFRetriever>(ref reader, options)
                    Types.RetrieverContainer.Rrf v
                | "text_similarity_reranker" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TextSimilarityReranker>(ref reader, options)
                    Types.RetrieverContainer.TextSimilarityReranker v
                | "rule" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RuleRetriever>(ref reader, options)
                    Types.RetrieverContainer.Rule v
                | "rescorer" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.RescorerRetriever>(ref reader, options)
                    Types.RetrieverContainer.Rescorer v
                | "linear" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.LinearRetriever>(ref reader, options)
                    Types.RetrieverContainer.Linear v
                | "pinned" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.PinnedRetriever>(ref reader, options)
                    Types.RetrieverContainer.Pinned v
                | "diversify" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.DiversifyRetriever>(ref reader, options)
                    Types.RetrieverContainer.Diversify v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RetrieverContainer"))
            reader.Read() |> ignore // EndObject
            result

    type ScoreNormalizerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.ScoreNormalizer>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.ScoreNormalizer.None -> "none"
                | Types.ScoreNormalizer.Minmax -> "minmax"
                | Types.ScoreNormalizer.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> Types.ScoreNormalizer.None
            | "minmax" -> Types.ScoreNormalizer.Minmax
            | "l2_norm" -> Types.ScoreNormalizer.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ScoreNormalizer"))

    type ScriptLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.ScriptLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.ScriptLanguage.Painless -> "painless"
                | Types.ScriptLanguage.Expression -> "expression"
                | Types.ScriptLanguage.Mustache -> "mustache"
                | Types.ScriptLanguage.Java -> "java"
                | Types.ScriptLanguage.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "painless" -> Types.ScriptLanguage.Painless
            | "expression" -> Types.ScriptLanguage.Expression
            | "mustache" -> Types.ScriptLanguage.Mustache
            | "java" -> Types.ScriptLanguage.Java
            | other -> Types.ScriptLanguage.Custom other

    type ScriptSortTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.ScriptSortType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.ScriptSortType.String -> "string"
                | Types.ScriptSortType.Number -> "number"
                | Types.ScriptSortType.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "string" -> Types.ScriptSortType.String
            | "number" -> Types.ScriptSortType.Number
            | "version" -> Types.ScriptSortType.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ScriptSortType"))

    type SearchTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.SearchType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.SearchType.QueryThenFetch -> "query_then_fetch"
                | Types.SearchType.DfsQueryThenFetch -> "dfs_query_then_fetch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "query_then_fetch" -> Types.SearchType.QueryThenFetch
            | "dfs_query_then_fetch" -> Types.SearchType.DfsQueryThenFetch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SearchType"))

    type SlicesCalculationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.SlicesCalculation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.SlicesCalculation.Auto -> "auto"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> Types.SlicesCalculation.Auto
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SlicesCalculation"))

    type SortModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.SortMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.SortMode.Min -> "min"
                | Types.SortMode.Max -> "max"
                | Types.SortMode.Sum -> "sum"
                | Types.SortMode.Avg -> "avg"
                | Types.SortMode.Median -> "median"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> Types.SortMode.Min
            | "max" -> Types.SortMode.Max
            | "sum" -> Types.SortMode.Sum
            | "avg" -> Types.SortMode.Avg
            | "median" -> Types.SortMode.Median
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SortMode"))

    type SortOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.SortOptions>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | Types.SortOptions.Score v ->
                writer.WritePropertyName("_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.SortOptions.Doc v ->
                writer.WritePropertyName("_doc")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.SortOptions.GeoDistance v ->
                writer.WritePropertyName("_geo_distance")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.SortOptions.Script v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScoreSort>(ref reader, options)
                    Types.SortOptions.Score v
                | "_doc" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScoreSort>(ref reader, options)
                    Types.SortOptions.Doc v
                | "_geo_distance" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoDistanceSort>(ref reader, options)
                    Types.SortOptions.GeoDistance v
                | "_script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptSort>(ref reader, options)
                    Types.SortOptions.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SortOptions"))
            reader.Read() |> ignore // EndObject
            result

    type SortOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.SortOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.SortOrder.Asc -> "asc"
                | Types.SortOrder.Desc -> "desc"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "asc" -> Types.SortOrder.Asc
            | "desc" -> Types.SortOrder.Desc
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SortOrder"))

    type SuggestModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.SuggestMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.SuggestMode.Missing -> "missing"
                | Types.SuggestMode.Popular -> "popular"
                | Types.SuggestMode.Always -> "always"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "missing" -> Types.SuggestMode.Missing
            | "popular" -> Types.SuggestMode.Popular
            | "always" -> Types.SuggestMode.Always
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SuggestMode"))

    type ThreadTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.ThreadType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.ThreadType.Cpu -> "cpu"
                | Types.ThreadType.Wait -> "wait"
                | Types.ThreadType.Block -> "block"
                | Types.ThreadType.Gpu -> "gpu"
                | Types.ThreadType.Mem -> "mem"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cpu" -> Types.ThreadType.Cpu
            | "wait" -> Types.ThreadType.Wait
            | "block" -> Types.ThreadType.Block
            | "gpu" -> Types.ThreadType.Gpu
            | "mem" -> Types.ThreadType.Mem
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ThreadType"))

    type TimeUnitConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.TimeUnit>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.TimeUnit.Nanos -> "nanos"
                | Types.TimeUnit.Micros -> "micros"
                | Types.TimeUnit.Ms -> "ms"
                | Types.TimeUnit.S -> "s"
                | Types.TimeUnit.M -> "m"
                | Types.TimeUnit.H -> "h"
                | Types.TimeUnit.D -> "d"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nanos" -> Types.TimeUnit.Nanos
            | "micros" -> Types.TimeUnit.Micros
            | "ms" -> Types.TimeUnit.Ms
            | "s" -> Types.TimeUnit.S
            | "m" -> Types.TimeUnit.M
            | "h" -> Types.TimeUnit.H
            | "d" -> Types.TimeUnit.D
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TimeUnit"))

    type TransformContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.TransformContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | Types.TransformContainer.Chain v ->
                writer.WritePropertyName("chain")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.TransformContainer.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | Types.TransformContainer.Search v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.TransformContainer list>(ref reader, options)
                    Types.TransformContainer.Chain v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.ScriptTransform>(ref reader, options)
                    Types.TransformContainer.Script v
                | "search" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.SearchTransform>(ref reader, options)
                    Types.TransformContainer.Search v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TransformContainer"))
            reader.Read() |> ignore // EndObject
            result

    type VersionTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.VersionType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.VersionType.Internal -> "internal"
                | Types.VersionType.External -> "external"
                | Types.VersionType.ExternalGte -> "external_gte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "internal" -> Types.VersionType.Internal
            | "external" -> Types.VersionType.External
            | "external_gte" -> Types.VersionType.ExternalGte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for VersionType"))

    type WaitForActiveShardOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.WaitForActiveShardOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.WaitForActiveShardOptions.All -> "all"
                | Types.WaitForActiveShardOptions.IndexSetting -> "index-setting"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> Types.WaitForActiveShardOptions.All
            | "index-setting" -> Types.WaitForActiveShardOptions.IndexSetting
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WaitForActiveShardOptions"))

    type WaitForEventsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<Types.WaitForEvents>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | Types.WaitForEvents.Immediate -> "immediate"
                | Types.WaitForEvents.Urgent -> "urgent"
                | Types.WaitForEvents.High -> "high"
                | Types.WaitForEvents.Normal -> "normal"
                | Types.WaitForEvents.Low -> "low"
                | Types.WaitForEvents.Languid -> "languid"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "immediate" -> Types.WaitForEvents.Immediate
            | "urgent" -> Types.WaitForEvents.Urgent
            | "high" -> Types.WaitForEvents.High
            | "normal" -> Types.WaitForEvents.Normal
            | "low" -> Types.WaitForEvents.Low
            | "languid" -> Types.WaitForEvents.Languid
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WaitForEvents"))

    type AggregationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.AggregationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesAggregations.AggregationContainer.AdjacencyMatrix v ->
                writer.WritePropertyName("adjacency_matrix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.AutoDateHistogram v ->
                writer.WritePropertyName("auto_date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Avg v ->
                writer.WritePropertyName("avg")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.AvgBucket v ->
                writer.WritePropertyName("avg_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Boxplot v ->
                writer.WritePropertyName("boxplot")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.BucketScript v ->
                writer.WritePropertyName("bucket_script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.BucketSelector v ->
                writer.WritePropertyName("bucket_selector")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.BucketSort v ->
                writer.WritePropertyName("bucket_sort")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.BucketCountKsTest v ->
                writer.WritePropertyName("bucket_count_ks_test")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.BucketCorrelation v ->
                writer.WritePropertyName("bucket_correlation")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Cardinality v ->
                writer.WritePropertyName("cardinality")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.CartesianBounds v ->
                writer.WritePropertyName("cartesian_bounds")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.CartesianCentroid v ->
                writer.WritePropertyName("cartesian_centroid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.CategorizeText v ->
                writer.WritePropertyName("categorize_text")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.ChangePoint v ->
                writer.WritePropertyName("change_point")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Children v ->
                writer.WritePropertyName("children")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Composite v ->
                writer.WritePropertyName("composite")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.CumulativeCardinality v ->
                writer.WritePropertyName("cumulative_cardinality")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.CumulativeSum v ->
                writer.WritePropertyName("cumulative_sum")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.DateHistogram v ->
                writer.WritePropertyName("date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.DateRange v ->
                writer.WritePropertyName("date_range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Derivative v ->
                writer.WritePropertyName("derivative")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.DiversifiedSampler v ->
                writer.WritePropertyName("diversified_sampler")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.ExtendedStats v ->
                writer.WritePropertyName("extended_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.ExtendedStatsBucket v ->
                writer.WritePropertyName("extended_stats_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.FrequentItemSets v ->
                writer.WritePropertyName("frequent_item_sets")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Filter v ->
                writer.WritePropertyName("filter")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Filters v ->
                writer.WritePropertyName("filters")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.GeoBounds v ->
                writer.WritePropertyName("geo_bounds")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.GeoCentroid v ->
                writer.WritePropertyName("geo_centroid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.GeoDistance v ->
                writer.WritePropertyName("geo_distance")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.GeohashGrid v ->
                writer.WritePropertyName("geohash_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.GeoLine v ->
                writer.WritePropertyName("geo_line")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.GeotileGrid v ->
                writer.WritePropertyName("geotile_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.GeohexGrid v ->
                writer.WritePropertyName("geohex_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Global v ->
                writer.WritePropertyName("global")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Histogram v ->
                writer.WritePropertyName("histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.IpRange v ->
                writer.WritePropertyName("ip_range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.IpPrefix v ->
                writer.WritePropertyName("ip_prefix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Inference v ->
                writer.WritePropertyName("inference")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Line v ->
                writer.WritePropertyName("line")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MatrixStats v ->
                writer.WritePropertyName("matrix_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Max v ->
                writer.WritePropertyName("max")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MaxBucket v ->
                writer.WritePropertyName("max_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MedianAbsoluteDeviation v ->
                writer.WritePropertyName("median_absolute_deviation")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Min v ->
                writer.WritePropertyName("min")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MinBucket v ->
                writer.WritePropertyName("min_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Missing v ->
                writer.WritePropertyName("missing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MovingAvg v ->
                writer.WritePropertyName("moving_avg")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MovingPercentiles v ->
                writer.WritePropertyName("moving_percentiles")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MovingFn v ->
                writer.WritePropertyName("moving_fn")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.MultiTerms v ->
                writer.WritePropertyName("multi_terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Nested v ->
                writer.WritePropertyName("nested")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Normalize v ->
                writer.WritePropertyName("normalize")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Parent v ->
                writer.WritePropertyName("parent")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.PercentileRanks v ->
                writer.WritePropertyName("percentile_ranks")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Percentiles v ->
                writer.WritePropertyName("percentiles")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.PercentilesBucket v ->
                writer.WritePropertyName("percentiles_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.RareTerms v ->
                writer.WritePropertyName("rare_terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Rate v ->
                writer.WritePropertyName("rate")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.ReverseNested v ->
                writer.WritePropertyName("reverse_nested")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.RandomSampler v ->
                writer.WritePropertyName("random_sampler")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Sampler v ->
                writer.WritePropertyName("sampler")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.ScriptedMetric v ->
                writer.WritePropertyName("scripted_metric")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.SerialDiff v ->
                writer.WritePropertyName("serial_diff")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.SignificantTerms v ->
                writer.WritePropertyName("significant_terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.SignificantText v ->
                writer.WritePropertyName("significant_text")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Stats v ->
                writer.WritePropertyName("stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.StatsBucket v ->
                writer.WritePropertyName("stats_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.StringStats v ->
                writer.WritePropertyName("string_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Sum v ->
                writer.WritePropertyName("sum")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.SumBucket v ->
                writer.WritePropertyName("sum_bucket")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.TimeSeries v ->
                writer.WritePropertyName("time_series")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.TopHits v ->
                writer.WritePropertyName("top_hits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.TTest v ->
                writer.WritePropertyName("t_test")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.TopMetrics v ->
                writer.WritePropertyName("top_metrics")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.ValueCount v ->
                writer.WritePropertyName("value_count")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.WeightedAvg v ->
                writer.WritePropertyName("weighted_avg")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.VariableWidthHistogram v ->
                writer.WritePropertyName("variable_width_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.AggregationContainer.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.AdjacencyMatrixAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.AdjacencyMatrix v
                | "auto_date_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.AutoDateHistogramAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.AutoDateHistogram v
                | "avg" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.AverageAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Avg v
                | "avg_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.AverageBucketAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.AvgBucket v
                | "boxplot" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.BoxplotAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Boxplot v
                | "bucket_script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.BucketScriptAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.BucketScript v
                | "bucket_selector" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.BucketSelectorAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.BucketSelector v
                | "bucket_sort" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.BucketSortAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.BucketSort v
                | "bucket_count_ks_test" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.BucketKsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.BucketCountKsTest v
                | "bucket_correlation" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.BucketCorrelationAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.BucketCorrelation v
                | "cardinality" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CardinalityAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Cardinality v
                | "cartesian_bounds" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CartesianBoundsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.CartesianBounds v
                | "cartesian_centroid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CartesianCentroidAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.CartesianCentroid v
                | "categorize_text" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CategorizeTextAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.CategorizeText v
                | "change_point" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ChangePointAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.ChangePoint v
                | "children" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ChildrenAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Children v
                | "composite" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CompositeAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Composite v
                | "cumulative_cardinality" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CumulativeCardinalityAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.CumulativeCardinality v
                | "cumulative_sum" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CumulativeSumAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.CumulativeSum v
                | "date_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.DateHistogramAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.DateHistogram v
                | "date_range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.DateRangeAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.DateRange v
                | "derivative" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.DerivativeAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Derivative v
                | "diversified_sampler" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.DiversifiedSamplerAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.DiversifiedSampler v
                | "extended_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ExtendedStatsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.ExtendedStats v
                | "extended_stats_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ExtendedStatsBucketAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.ExtendedStatsBucket v
                | "frequent_item_sets" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.FrequentItemSetsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.FrequentItemSets v
                | "filter" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.QueryContainer>(ref reader, options)
                    TypesAggregations.AggregationContainer.Filter v
                | "filters" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.FiltersAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Filters v
                | "geo_bounds" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoBoundsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.GeoBounds v
                | "geo_centroid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoCentroidAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.GeoCentroid v
                | "geo_distance" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoDistanceAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.GeoDistance v
                | "geohash_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoHashGridAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.GeohashGrid v
                | "geo_line" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoLineAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.GeoLine v
                | "geotile_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoTileGridAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.GeotileGrid v
                | "geohex_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeohexGridAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.GeohexGrid v
                | "global" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GlobalAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Global v
                | "histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.HistogramAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Histogram v
                | "ip_range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.IpRangeAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.IpRange v
                | "ip_prefix" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.IpPrefixAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.IpPrefix v
                | "inference" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.InferenceAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Inference v
                | "line" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoLineAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Line v
                | "matrix_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MatrixStatsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MatrixStats v
                | "max" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MaxAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Max v
                | "max_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MaxBucketAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MaxBucket v
                | "median_absolute_deviation" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MedianAbsoluteDeviationAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MedianAbsoluteDeviation v
                | "min" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MinAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Min v
                | "min_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MinBucketAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MinBucket v
                | "missing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MissingAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Missing v
                | "moving_avg" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MovingAverageAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MovingAvg v
                | "moving_percentiles" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MovingPercentilesAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MovingPercentiles v
                | "moving_fn" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MovingFunctionAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MovingFn v
                | "multi_terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MultiTermsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.MultiTerms v
                | "nested" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.NestedAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Nested v
                | "normalize" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.NormalizeAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Normalize v
                | "parent" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ParentAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Parent v
                | "percentile_ranks" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.PercentileRanksAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.PercentileRanks v
                | "percentiles" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.PercentilesAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Percentiles v
                | "percentiles_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.PercentilesBucketAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.PercentilesBucket v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.RangeAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Range v
                | "rare_terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.RareTermsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.RareTerms v
                | "rate" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.RateAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Rate v
                | "reverse_nested" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ReverseNestedAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.ReverseNested v
                | "random_sampler" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.RandomSamplerAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.RandomSampler v
                | "sampler" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.SamplerAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Sampler v
                | "scripted_metric" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ScriptedMetricAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.ScriptedMetric v
                | "serial_diff" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.SerialDifferencingAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.SerialDiff v
                | "significant_terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.SignificantTermsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.SignificantTerms v
                | "significant_text" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.SignificantTextAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.SignificantText v
                | "stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.StatsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Stats v
                | "stats_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.StatsBucketAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.StatsBucket v
                | "string_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.StringStatsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.StringStats v
                | "sum" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.SumAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Sum v
                | "sum_bucket" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.SumBucketAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.SumBucket v
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TermsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.Terms v
                | "time_series" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TimeSeriesAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.TimeSeries v
                | "top_hits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TopHitsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.TopHits v
                | "t_test" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TTestAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.TTest v
                | "top_metrics" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TopMetricsAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.TopMetrics v
                | "value_count" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ValueCountAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.ValueCount v
                | "weighted_avg" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.WeightedAverageAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.WeightedAvg v
                | "variable_width_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.VariableWidthHistogramAggregation>(ref reader, options)
                    TypesAggregations.AggregationContainer.VariableWidthHistogram v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    TypesAggregations.AggregationContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type CalendarIntervalConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.CalendarInterval>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.CalendarInterval.Second -> "second"
                | TypesAggregations.CalendarInterval.Minute -> "minute"
                | TypesAggregations.CalendarInterval.Hour -> "hour"
                | TypesAggregations.CalendarInterval.Day -> "day"
                | TypesAggregations.CalendarInterval.Week -> "week"
                | TypesAggregations.CalendarInterval.Month -> "month"
                | TypesAggregations.CalendarInterval.Quarter -> "quarter"
                | TypesAggregations.CalendarInterval.Year -> "year"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "second" -> TypesAggregations.CalendarInterval.Second
            | "minute" -> TypesAggregations.CalendarInterval.Minute
            | "hour" -> TypesAggregations.CalendarInterval.Hour
            | "day" -> TypesAggregations.CalendarInterval.Day
            | "week" -> TypesAggregations.CalendarInterval.Week
            | "month" -> TypesAggregations.CalendarInterval.Month
            | "quarter" -> TypesAggregations.CalendarInterval.Quarter
            | "year" -> TypesAggregations.CalendarInterval.Year
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CalendarInterval"))

    type CardinalityExecutionModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.CardinalityExecutionMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.CardinalityExecutionMode.GlobalOrdinals -> "global_ordinals"
                | TypesAggregations.CardinalityExecutionMode.SegmentOrdinals -> "segment_ordinals"
                | TypesAggregations.CardinalityExecutionMode.Direct -> "direct"
                | TypesAggregations.CardinalityExecutionMode.SaveMemoryHeuristic -> "save_memory_heuristic"
                | TypesAggregations.CardinalityExecutionMode.SaveTimeHeuristic -> "save_time_heuristic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "global_ordinals" -> TypesAggregations.CardinalityExecutionMode.GlobalOrdinals
            | "segment_ordinals" -> TypesAggregations.CardinalityExecutionMode.SegmentOrdinals
            | "direct" -> TypesAggregations.CardinalityExecutionMode.Direct
            | "save_memory_heuristic" -> TypesAggregations.CardinalityExecutionMode.SaveMemoryHeuristic
            | "save_time_heuristic" -> TypesAggregations.CardinalityExecutionMode.SaveTimeHeuristic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CardinalityExecutionMode"))

    type ChangeTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.ChangeType>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesAggregations.ChangeType.Dip v ->
                writer.WritePropertyName("dip")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.ChangeType.DistributionChange v ->
                writer.WritePropertyName("distribution_change")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.ChangeType.Indeterminable v ->
                writer.WritePropertyName("indeterminable")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.ChangeType.NonStationary v ->
                writer.WritePropertyName("non_stationary")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.ChangeType.Spike v ->
                writer.WritePropertyName("spike")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.ChangeType.Stationary v ->
                writer.WritePropertyName("stationary")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.ChangeType.StepChange v ->
                writer.WritePropertyName("step_change")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.ChangeType.TrendChange v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.Dip>(ref reader, options)
                    TypesAggregations.ChangeType.Dip v
                | "distribution_change" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.DistributionChange>(ref reader, options)
                    TypesAggregations.ChangeType.DistributionChange v
                | "indeterminable" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.Indeterminable>(ref reader, options)
                    TypesAggregations.ChangeType.Indeterminable v
                | "non_stationary" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.NonStationary>(ref reader, options)
                    TypesAggregations.ChangeType.NonStationary v
                | "spike" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.Spike>(ref reader, options)
                    TypesAggregations.ChangeType.Spike v
                | "stationary" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.Stationary>(ref reader, options)
                    TypesAggregations.ChangeType.Stationary v
                | "step_change" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.StepChange>(ref reader, options)
                    TypesAggregations.ChangeType.StepChange v
                | "trend_change" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TrendChange>(ref reader, options)
                    TypesAggregations.ChangeType.TrendChange v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for ChangeType"))
            reader.Read() |> ignore // EndObject
            result

    type CompositeAggregationSourceConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.CompositeAggregationSource>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesAggregations.CompositeAggregationSource.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.CompositeAggregationSource.Histogram v ->
                writer.WritePropertyName("histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.CompositeAggregationSource.DateHistogram v ->
                writer.WritePropertyName("date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.CompositeAggregationSource.GeotileGrid v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CompositeTermsAggregation>(ref reader, options)
                    TypesAggregations.CompositeAggregationSource.Terms v
                | "histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CompositeHistogramAggregation>(ref reader, options)
                    TypesAggregations.CompositeAggregationSource.Histogram v
                | "date_histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CompositeDateHistogramAggregation>(ref reader, options)
                    TypesAggregations.CompositeAggregationSource.DateHistogram v
                | "geotile_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CompositeGeoTileGridAggregation>(ref reader, options)
                    TypesAggregations.CompositeAggregationSource.GeotileGrid v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for CompositeAggregationSource"))
            reader.Read() |> ignore // EndObject
            result

    type GapPolicyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.GapPolicy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.GapPolicy.Skip -> "skip"
                | TypesAggregations.GapPolicy.InsertZeros -> "insert_zeros"
                | TypesAggregations.GapPolicy.KeepValues -> "keep_values"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "skip" -> TypesAggregations.GapPolicy.Skip
            | "insert_zeros" -> TypesAggregations.GapPolicy.InsertZeros
            | "keep_values" -> TypesAggregations.GapPolicy.KeepValues
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GapPolicy"))

    type HoltWintersTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.HoltWintersType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.HoltWintersType.Add -> "add"
                | TypesAggregations.HoltWintersType.Mult -> "mult"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "add" -> TypesAggregations.HoltWintersType.Add
            | "mult" -> TypesAggregations.HoltWintersType.Mult
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HoltWintersType"))

    type InferenceConfigContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.InferenceConfigContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesAggregations.InferenceConfigContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.InferenceConfigContainer.Classification v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.RegressionInferenceOptions>(ref reader, options)
                    TypesAggregations.InferenceConfigContainer.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.ClassificationInferenceOptions>(ref reader, options)
                    TypesAggregations.InferenceConfigContainer.Classification v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfigContainer"))
            reader.Read() |> ignore // EndObject
            result

    type MinimumIntervalConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.MinimumInterval>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.MinimumInterval.Second -> "second"
                | TypesAggregations.MinimumInterval.Minute -> "minute"
                | TypesAggregations.MinimumInterval.Hour -> "hour"
                | TypesAggregations.MinimumInterval.Day -> "day"
                | TypesAggregations.MinimumInterval.Month -> "month"
                | TypesAggregations.MinimumInterval.Year -> "year"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "second" -> TypesAggregations.MinimumInterval.Second
            | "minute" -> TypesAggregations.MinimumInterval.Minute
            | "hour" -> TypesAggregations.MinimumInterval.Hour
            | "day" -> TypesAggregations.MinimumInterval.Day
            | "month" -> TypesAggregations.MinimumInterval.Month
            | "year" -> TypesAggregations.MinimumInterval.Year
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MinimumInterval"))

    type MissingOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.MissingOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.MissingOrder.First -> "first"
                | TypesAggregations.MissingOrder.Last -> "last"
                | TypesAggregations.MissingOrder.Default -> "default"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "first" -> TypesAggregations.MissingOrder.First
            | "last" -> TypesAggregations.MissingOrder.Last
            | "default" -> TypesAggregations.MissingOrder.Default
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MissingOrder"))

    type MovingAverageAggregationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.MovingAverageAggregation>()

        override _.Write(writer, value, options) =
            match value with
            | TypesAggregations.MovingAverageAggregation.LinearMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.MovingAverageAggregation.SimpleMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.MovingAverageAggregation.EwmaMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.MovingAverageAggregation.HoltMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.MovingAverageAggregation.HoltWintersMovingAverageAggregation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("model") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "linearmovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.LinearMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                TypesAggregations.MovingAverageAggregation.LinearMovingAverageAggregation v
            | "simplemovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.SimpleMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                TypesAggregations.MovingAverageAggregation.SimpleMovingAverageAggregation v
            | "ewmamovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.EwmaMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                TypesAggregations.MovingAverageAggregation.EwmaMovingAverageAggregation v
            | "holtmovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.HoltMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                TypesAggregations.MovingAverageAggregation.HoltMovingAverageAggregation v
            | "holtwintersmovingaverageaggregation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.HoltWintersMovingAverageAggregation>(doc.RootElement.GetRawText(), options)
                TypesAggregations.MovingAverageAggregation.HoltWintersMovingAverageAggregation v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for MovingAverageAggregation"))

    type MultiTermLookupConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.MultiTermLookup>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesAggregations.MultiTermLookup.Field v ->
                writer.WritePropertyName("field")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAggregations.MultiTermLookup.Script v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Field>(ref reader, options)
                    TypesAggregations.MultiTermLookup.Field v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Script>(ref reader, options)
                    TypesAggregations.MultiTermLookup.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for MultiTermLookup"))
            reader.Read() |> ignore // EndObject
            result

    type NormalizeMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.NormalizeMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.NormalizeMethod.Rescale01 -> "rescale_0_1"
                | TypesAggregations.NormalizeMethod.Rescale0100 -> "rescale_0_100"
                | TypesAggregations.NormalizeMethod.PercentOfSum -> "percent_of_sum"
                | TypesAggregations.NormalizeMethod.Mean -> "mean"
                | TypesAggregations.NormalizeMethod.ZScore -> "z-score"
                | TypesAggregations.NormalizeMethod.Softmax -> "softmax"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rescale_0_1" -> TypesAggregations.NormalizeMethod.Rescale01
            | "rescale_0_100" -> TypesAggregations.NormalizeMethod.Rescale0100
            | "percent_of_sum" -> TypesAggregations.NormalizeMethod.PercentOfSum
            | "mean" -> TypesAggregations.NormalizeMethod.Mean
            | "z-score" -> TypesAggregations.NormalizeMethod.ZScore
            | "softmax" -> TypesAggregations.NormalizeMethod.Softmax
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NormalizeMethod"))

    type RateModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.RateMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.RateMode.Sum -> "sum"
                | TypesAggregations.RateMode.ValueCount -> "value_count"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sum" -> TypesAggregations.RateMode.Sum
            | "value_count" -> TypesAggregations.RateMode.ValueCount
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RateMode"))

    type SamplerAggregationExecutionHintConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.SamplerAggregationExecutionHint>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.SamplerAggregationExecutionHint.Map -> "map"
                | TypesAggregations.SamplerAggregationExecutionHint.GlobalOrdinals -> "global_ordinals"
                | TypesAggregations.SamplerAggregationExecutionHint.BytesHash -> "bytes_hash"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "map" -> TypesAggregations.SamplerAggregationExecutionHint.Map
            | "global_ordinals" -> TypesAggregations.SamplerAggregationExecutionHint.GlobalOrdinals
            | "bytes_hash" -> TypesAggregations.SamplerAggregationExecutionHint.BytesHash
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SamplerAggregationExecutionHint"))

    type TDigestExecutionHintConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.TDigestExecutionHint>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.TDigestExecutionHint.Default -> "default"
                | TypesAggregations.TDigestExecutionHint.HighAccuracy -> "high_accuracy"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "default" -> TypesAggregations.TDigestExecutionHint.Default
            | "high_accuracy" -> TypesAggregations.TDigestExecutionHint.HighAccuracy
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TDigestExecutionHint"))

    type TTestTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.TTestType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.TTestType.Paired -> "paired"
                | TypesAggregations.TTestType.Homoscedastic -> "homoscedastic"
                | TypesAggregations.TTestType.Heteroscedastic -> "heteroscedastic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "paired" -> TypesAggregations.TTestType.Paired
            | "homoscedastic" -> TypesAggregations.TTestType.Homoscedastic
            | "heteroscedastic" -> TypesAggregations.TTestType.Heteroscedastic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TTestType"))

    type TermsAggregationCollectModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.TermsAggregationCollectMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.TermsAggregationCollectMode.DepthFirst -> "depth_first"
                | TypesAggregations.TermsAggregationCollectMode.BreadthFirst -> "breadth_first"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "depth_first" -> TypesAggregations.TermsAggregationCollectMode.DepthFirst
            | "breadth_first" -> TypesAggregations.TermsAggregationCollectMode.BreadthFirst
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TermsAggregationCollectMode"))

    type TermsAggregationExecutionHintConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.TermsAggregationExecutionHint>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.TermsAggregationExecutionHint.Map -> "map"
                | TypesAggregations.TermsAggregationExecutionHint.GlobalOrdinals -> "global_ordinals"
                | TypesAggregations.TermsAggregationExecutionHint.GlobalOrdinalsHash -> "global_ordinals_hash"
                | TypesAggregations.TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality -> "global_ordinals_low_cardinality"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "map" -> TypesAggregations.TermsAggregationExecutionHint.Map
            | "global_ordinals" -> TypesAggregations.TermsAggregationExecutionHint.GlobalOrdinals
            | "global_ordinals_hash" -> TypesAggregations.TermsAggregationExecutionHint.GlobalOrdinalsHash
            | "global_ordinals_low_cardinality" -> TypesAggregations.TermsAggregationExecutionHint.GlobalOrdinalsLowCardinality
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TermsAggregationExecutionHint"))

    type ValueTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAggregations.ValueType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAggregations.ValueType.String -> "string"
                | TypesAggregations.ValueType.Long -> "long"
                | TypesAggregations.ValueType.Double -> "double"
                | TypesAggregations.ValueType.Number -> "number"
                | TypesAggregations.ValueType.Date -> "date"
                | TypesAggregations.ValueType.DateNanos -> "date_nanos"
                | TypesAggregations.ValueType.Ip -> "ip"
                | TypesAggregations.ValueType.Numeric -> "numeric"
                | TypesAggregations.ValueType.GeoPoint -> "geo_point"
                | TypesAggregations.ValueType.Boolean -> "boolean"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "string" -> TypesAggregations.ValueType.String
            | "long" -> TypesAggregations.ValueType.Long
            | "double" -> TypesAggregations.ValueType.Double
            | "number" -> TypesAggregations.ValueType.Number
            | "date" -> TypesAggregations.ValueType.Date
            | "date_nanos" -> TypesAggregations.ValueType.DateNanos
            | "ip" -> TypesAggregations.ValueType.Ip
            | "numeric" -> TypesAggregations.ValueType.Numeric
            | "geo_point" -> TypesAggregations.ValueType.GeoPoint
            | "boolean" -> TypesAggregations.ValueType.Boolean
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ValueType"))

    type AnalyzerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.Analyzer>()

        override _.Write(writer, value, options) =
            match value with
            | TypesAnalysis.Analyzer.CustomAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.FingerprintAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.KeywordAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.NoriAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.PatternAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.SimpleAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.StandardAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.StopAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.WhitespaceAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.IcuAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.KuromojiAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.SnowballAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.ArabicAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.ArmenianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.BasqueAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.BengaliAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.BrazilianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.BulgarianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.CatalanAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.ChineseAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.CjkAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.CzechAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.DanishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.DutchAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.EnglishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.EstonianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.FinnishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.FrenchAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.GalicianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.GermanAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.GreekAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.HindiAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.HungarianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.IndonesianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.IrishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.ItalianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.LatvianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.LithuanianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.NorwegianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.PersianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.PortugueseAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.RomanianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.RussianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.SerbianAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.SoraniAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.SpanishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.SwedishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.TurkishAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.ThaiAnalyzer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Analyzer.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "customanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CustomAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.CustomAnalyzer v
            | "fingerprintanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.FingerprintAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.FingerprintAnalyzer v
            | "keywordanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KeywordAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.KeywordAnalyzer v
            | "norianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.NoriAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.NoriAnalyzer v
            | "patternanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PatternAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.PatternAnalyzer v
            | "simpleanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SimpleAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.SimpleAnalyzer v
            | "standardanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.StandardAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.StandardAnalyzer v
            | "stopanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.StopAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.StopAnalyzer v
            | "whitespaceanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.WhitespaceAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.WhitespaceAnalyzer v
            | "icuanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IcuAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.IcuAnalyzer v
            | "kuromojianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KuromojiAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.KuromojiAnalyzer v
            | "snowballanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SnowballAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.SnowballAnalyzer v
            | "arabicanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ArabicAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.ArabicAnalyzer v
            | "armeniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ArmenianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.ArmenianAnalyzer v
            | "basqueanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.BasqueAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.BasqueAnalyzer v
            | "bengalianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.BengaliAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.BengaliAnalyzer v
            | "braziliananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.BrazilianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.BrazilianAnalyzer v
            | "bulgariananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.BulgarianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.BulgarianAnalyzer v
            | "catalananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CatalanAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.CatalanAnalyzer v
            | "chineseanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ChineseAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.ChineseAnalyzer v
            | "cjkanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CjkAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.CjkAnalyzer v
            | "czechanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CzechAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.CzechAnalyzer v
            | "danishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.DanishAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.DanishAnalyzer v
            | "dutchanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.DutchAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.DutchAnalyzer v
            | "englishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.EnglishAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.EnglishAnalyzer v
            | "estoniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.EstonianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.EstonianAnalyzer v
            | "finnishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.FinnishAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.FinnishAnalyzer v
            | "frenchanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.FrenchAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.FrenchAnalyzer v
            | "galiciananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.GalicianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.GalicianAnalyzer v
            | "germananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.GermanAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.GermanAnalyzer v
            | "greekanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.GreekAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.GreekAnalyzer v
            | "hindianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.HindiAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.HindiAnalyzer v
            | "hungariananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.HungarianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.HungarianAnalyzer v
            | "indonesiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IndonesianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.IndonesianAnalyzer v
            | "irishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IrishAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.IrishAnalyzer v
            | "italiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ItalianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.ItalianAnalyzer v
            | "latviananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LatvianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.LatvianAnalyzer v
            | "lithuaniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LithuanianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.LithuanianAnalyzer v
            | "norwegiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.NorwegianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.NorwegianAnalyzer v
            | "persiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PersianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.PersianAnalyzer v
            | "portugueseanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PortugueseAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.PortugueseAnalyzer v
            | "romaniananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.RomanianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.RomanianAnalyzer v
            | "russiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.RussianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.RussianAnalyzer v
            | "serbiananalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SerbianAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.SerbianAnalyzer v
            | "soranianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SoraniAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.SoraniAnalyzer v
            | "spanishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SpanishAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.SpanishAnalyzer v
            | "swedishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SwedishAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.SwedishAnalyzer v
            | "turkishanalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.TurkishAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.TurkishAnalyzer v
            | "thaianalyzer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ThaiAnalyzer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Analyzer.ThaiAnalyzer v
            | _ -> TypesAnalysis.Analyzer.Unknown (tagValue, doc.RootElement.Clone())

    type CharFilterDefinitionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.CharFilterDefinition>()

        override _.Write(writer, value, options) =
            match value with
            | TypesAnalysis.CharFilterDefinition.HtmlStripCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.CharFilterDefinition.MappingCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.CharFilterDefinition.PatternReplaceCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.CharFilterDefinition.IcuNormalizationCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.CharFilterDefinition.KuromojiIterationMarkCharFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.CharFilterDefinition.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "htmlstripcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.HtmlStripCharFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.CharFilterDefinition.HtmlStripCharFilter v
            | "mappingcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.MappingCharFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.CharFilterDefinition.MappingCharFilter v
            | "patternreplacecharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PatternReplaceCharFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.CharFilterDefinition.PatternReplaceCharFilter v
            | "icunormalizationcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IcuNormalizationCharFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.CharFilterDefinition.IcuNormalizationCharFilter v
            | "kuromojiiterationmarkcharfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KuromojiIterationMarkCharFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.CharFilterDefinition.KuromojiIterationMarkCharFilter v
            | _ -> TypesAnalysis.CharFilterDefinition.Unknown (tagValue, doc.RootElement.Clone())

    type CjkBigramIgnoredScriptConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.CjkBigramIgnoredScript>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.CjkBigramIgnoredScript.Han -> "han"
                | TypesAnalysis.CjkBigramIgnoredScript.Hangul -> "hangul"
                | TypesAnalysis.CjkBigramIgnoredScript.Hiragana -> "hiragana"
                | TypesAnalysis.CjkBigramIgnoredScript.Katakana -> "katakana"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "han" -> TypesAnalysis.CjkBigramIgnoredScript.Han
            | "hangul" -> TypesAnalysis.CjkBigramIgnoredScript.Hangul
            | "hiragana" -> TypesAnalysis.CjkBigramIgnoredScript.Hiragana
            | "katakana" -> TypesAnalysis.CjkBigramIgnoredScript.Katakana
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CjkBigramIgnoredScript"))

    type DelimitedPayloadEncodingConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.DelimitedPayloadEncoding>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.DelimitedPayloadEncoding.Int -> "int"
                | TypesAnalysis.DelimitedPayloadEncoding.Float -> "float"
                | TypesAnalysis.DelimitedPayloadEncoding.Identity -> "identity"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "int" -> TypesAnalysis.DelimitedPayloadEncoding.Int
            | "float" -> TypesAnalysis.DelimitedPayloadEncoding.Float
            | "identity" -> TypesAnalysis.DelimitedPayloadEncoding.Identity
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DelimitedPayloadEncoding"))

    type EdgeNGramSideConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.EdgeNGramSide>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.EdgeNGramSide.Front -> "front"
                | TypesAnalysis.EdgeNGramSide.Back -> "back"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "front" -> TypesAnalysis.EdgeNGramSide.Front
            | "back" -> TypesAnalysis.EdgeNGramSide.Back
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EdgeNGramSide"))

    type IcuCollationAlternateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.IcuCollationAlternate>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.IcuCollationAlternate.Shifted -> "shifted"
                | TypesAnalysis.IcuCollationAlternate.NonIgnorable -> "non-ignorable"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "shifted" -> TypesAnalysis.IcuCollationAlternate.Shifted
            | "non-ignorable" -> TypesAnalysis.IcuCollationAlternate.NonIgnorable
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationAlternate"))

    type IcuCollationCaseFirstConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.IcuCollationCaseFirst>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.IcuCollationCaseFirst.Lower -> "lower"
                | TypesAnalysis.IcuCollationCaseFirst.Upper -> "upper"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "lower" -> TypesAnalysis.IcuCollationCaseFirst.Lower
            | "upper" -> TypesAnalysis.IcuCollationCaseFirst.Upper
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationCaseFirst"))

    type IcuCollationDecompositionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.IcuCollationDecomposition>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.IcuCollationDecomposition.No -> "no"
                | TypesAnalysis.IcuCollationDecomposition.Identical -> "identical"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> TypesAnalysis.IcuCollationDecomposition.No
            | "identical" -> TypesAnalysis.IcuCollationDecomposition.Identical
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationDecomposition"))

    type IcuCollationStrengthConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.IcuCollationStrength>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.IcuCollationStrength.Primary -> "primary"
                | TypesAnalysis.IcuCollationStrength.Secondary -> "secondary"
                | TypesAnalysis.IcuCollationStrength.Tertiary -> "tertiary"
                | TypesAnalysis.IcuCollationStrength.Quaternary -> "quaternary"
                | TypesAnalysis.IcuCollationStrength.Identical -> "identical"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "primary" -> TypesAnalysis.IcuCollationStrength.Primary
            | "secondary" -> TypesAnalysis.IcuCollationStrength.Secondary
            | "tertiary" -> TypesAnalysis.IcuCollationStrength.Tertiary
            | "quaternary" -> TypesAnalysis.IcuCollationStrength.Quaternary
            | "identical" -> TypesAnalysis.IcuCollationStrength.Identical
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuCollationStrength"))

    type IcuNormalizationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.IcuNormalizationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.IcuNormalizationMode.Decompose -> "decompose"
                | TypesAnalysis.IcuNormalizationMode.Compose -> "compose"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "decompose" -> TypesAnalysis.IcuNormalizationMode.Decompose
            | "compose" -> TypesAnalysis.IcuNormalizationMode.Compose
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuNormalizationMode"))

    type IcuNormalizationTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.IcuNormalizationType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.IcuNormalizationType.Nfc -> "nfc"
                | TypesAnalysis.IcuNormalizationType.Nfkc -> "nfkc"
                | TypesAnalysis.IcuNormalizationType.NfkcCf -> "nfkc_cf"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nfc" -> TypesAnalysis.IcuNormalizationType.Nfc
            | "nfkc" -> TypesAnalysis.IcuNormalizationType.Nfkc
            | "nfkc_cf" -> TypesAnalysis.IcuNormalizationType.NfkcCf
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuNormalizationType"))

    type IcuTransformDirectionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.IcuTransformDirection>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.IcuTransformDirection.Forward -> "forward"
                | TypesAnalysis.IcuTransformDirection.Reverse -> "reverse"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "forward" -> TypesAnalysis.IcuTransformDirection.Forward
            | "reverse" -> TypesAnalysis.IcuTransformDirection.Reverse
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IcuTransformDirection"))

    type KeepTypesModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.KeepTypesMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.KeepTypesMode.Include -> "include"
                | TypesAnalysis.KeepTypesMode.Exclude -> "exclude"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "include" -> TypesAnalysis.KeepTypesMode.Include
            | "exclude" -> TypesAnalysis.KeepTypesMode.Exclude
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for KeepTypesMode"))

    type KuromojiTokenizationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.KuromojiTokenizationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.KuromojiTokenizationMode.Normal -> "normal"
                | TypesAnalysis.KuromojiTokenizationMode.Search -> "search"
                | TypesAnalysis.KuromojiTokenizationMode.Extended -> "extended"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "normal" -> TypesAnalysis.KuromojiTokenizationMode.Normal
            | "search" -> TypesAnalysis.KuromojiTokenizationMode.Search
            | "extended" -> TypesAnalysis.KuromojiTokenizationMode.Extended
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for KuromojiTokenizationMode"))

    type LowercaseTokenFilterLanguagesConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.LowercaseTokenFilterLanguages>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.LowercaseTokenFilterLanguages.Greek -> "greek"
                | TypesAnalysis.LowercaseTokenFilterLanguages.Irish -> "irish"
                | TypesAnalysis.LowercaseTokenFilterLanguages.Turkish -> "turkish"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "greek" -> TypesAnalysis.LowercaseTokenFilterLanguages.Greek
            | "irish" -> TypesAnalysis.LowercaseTokenFilterLanguages.Irish
            | "turkish" -> TypesAnalysis.LowercaseTokenFilterLanguages.Turkish
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LowercaseTokenFilterLanguages"))

    type NoriDecompoundModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.NoriDecompoundMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.NoriDecompoundMode.Discard -> "discard"
                | TypesAnalysis.NoriDecompoundMode.None -> "none"
                | TypesAnalysis.NoriDecompoundMode.Mixed -> "mixed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "discard" -> TypesAnalysis.NoriDecompoundMode.Discard
            | "none" -> TypesAnalysis.NoriDecompoundMode.None
            | "mixed" -> TypesAnalysis.NoriDecompoundMode.Mixed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NoriDecompoundMode"))

    type NormalizerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.Normalizer>()

        override _.Write(writer, value, options) =
            match value with
            | TypesAnalysis.Normalizer.LowercaseNormalizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.Normalizer.CustomNormalizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "lowercasenormalizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LowercaseNormalizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Normalizer.LowercaseNormalizer v
            | "customnormalizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CustomNormalizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.Normalizer.CustomNormalizer v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for Normalizer"))

    type PhoneticEncoderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.PhoneticEncoder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.PhoneticEncoder.Metaphone -> "metaphone"
                | TypesAnalysis.PhoneticEncoder.DoubleMetaphone -> "double_metaphone"
                | TypesAnalysis.PhoneticEncoder.Soundex -> "soundex"
                | TypesAnalysis.PhoneticEncoder.RefinedSoundex -> "refined_soundex"
                | TypesAnalysis.PhoneticEncoder.Caverphone1 -> "caverphone1"
                | TypesAnalysis.PhoneticEncoder.Caverphone2 -> "caverphone2"
                | TypesAnalysis.PhoneticEncoder.Cologne -> "cologne"
                | TypesAnalysis.PhoneticEncoder.Nysiis -> "nysiis"
                | TypesAnalysis.PhoneticEncoder.Koelnerphonetik -> "koelnerphonetik"
                | TypesAnalysis.PhoneticEncoder.Haasephonetik -> "haasephonetik"
                | TypesAnalysis.PhoneticEncoder.BeiderMorse -> "beider_morse"
                | TypesAnalysis.PhoneticEncoder.DaitchMokotoff -> "daitch_mokotoff"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "metaphone" -> TypesAnalysis.PhoneticEncoder.Metaphone
            | "double_metaphone" -> TypesAnalysis.PhoneticEncoder.DoubleMetaphone
            | "soundex" -> TypesAnalysis.PhoneticEncoder.Soundex
            | "refined_soundex" -> TypesAnalysis.PhoneticEncoder.RefinedSoundex
            | "caverphone1" -> TypesAnalysis.PhoneticEncoder.Caverphone1
            | "caverphone2" -> TypesAnalysis.PhoneticEncoder.Caverphone2
            | "cologne" -> TypesAnalysis.PhoneticEncoder.Cologne
            | "nysiis" -> TypesAnalysis.PhoneticEncoder.Nysiis
            | "koelnerphonetik" -> TypesAnalysis.PhoneticEncoder.Koelnerphonetik
            | "haasephonetik" -> TypesAnalysis.PhoneticEncoder.Haasephonetik
            | "beider_morse" -> TypesAnalysis.PhoneticEncoder.BeiderMorse
            | "daitch_mokotoff" -> TypesAnalysis.PhoneticEncoder.DaitchMokotoff
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticEncoder"))

    type PhoneticLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.PhoneticLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.PhoneticLanguage.Any -> "any"
                | TypesAnalysis.PhoneticLanguage.Common -> "common"
                | TypesAnalysis.PhoneticLanguage.Cyrillic -> "cyrillic"
                | TypesAnalysis.PhoneticLanguage.English -> "english"
                | TypesAnalysis.PhoneticLanguage.French -> "french"
                | TypesAnalysis.PhoneticLanguage.German -> "german"
                | TypesAnalysis.PhoneticLanguage.Hebrew -> "hebrew"
                | TypesAnalysis.PhoneticLanguage.Hungarian -> "hungarian"
                | TypesAnalysis.PhoneticLanguage.Polish -> "polish"
                | TypesAnalysis.PhoneticLanguage.Romanian -> "romanian"
                | TypesAnalysis.PhoneticLanguage.Russian -> "russian"
                | TypesAnalysis.PhoneticLanguage.Spanish -> "spanish"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "any" -> TypesAnalysis.PhoneticLanguage.Any
            | "common" -> TypesAnalysis.PhoneticLanguage.Common
            | "cyrillic" -> TypesAnalysis.PhoneticLanguage.Cyrillic
            | "english" -> TypesAnalysis.PhoneticLanguage.English
            | "french" -> TypesAnalysis.PhoneticLanguage.French
            | "german" -> TypesAnalysis.PhoneticLanguage.German
            | "hebrew" -> TypesAnalysis.PhoneticLanguage.Hebrew
            | "hungarian" -> TypesAnalysis.PhoneticLanguage.Hungarian
            | "polish" -> TypesAnalysis.PhoneticLanguage.Polish
            | "romanian" -> TypesAnalysis.PhoneticLanguage.Romanian
            | "russian" -> TypesAnalysis.PhoneticLanguage.Russian
            | "spanish" -> TypesAnalysis.PhoneticLanguage.Spanish
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticLanguage"))

    type PhoneticNameTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.PhoneticNameType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.PhoneticNameType.Generic -> "generic"
                | TypesAnalysis.PhoneticNameType.Ashkenazi -> "ashkenazi"
                | TypesAnalysis.PhoneticNameType.Sephardic -> "sephardic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "generic" -> TypesAnalysis.PhoneticNameType.Generic
            | "ashkenazi" -> TypesAnalysis.PhoneticNameType.Ashkenazi
            | "sephardic" -> TypesAnalysis.PhoneticNameType.Sephardic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticNameType"))

    type PhoneticRuleTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.PhoneticRuleType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.PhoneticRuleType.Approx -> "approx"
                | TypesAnalysis.PhoneticRuleType.Exact -> "exact"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "approx" -> TypesAnalysis.PhoneticRuleType.Approx
            | "exact" -> TypesAnalysis.PhoneticRuleType.Exact
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PhoneticRuleType"))

    type SnowballLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.SnowballLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.SnowballLanguage.Arabic -> "Arabic"
                | TypesAnalysis.SnowballLanguage.Armenian -> "Armenian"
                | TypesAnalysis.SnowballLanguage.Basque -> "Basque"
                | TypesAnalysis.SnowballLanguage.Catalan -> "Catalan"
                | TypesAnalysis.SnowballLanguage.Danish -> "Danish"
                | TypesAnalysis.SnowballLanguage.Dutch -> "Dutch"
                | TypesAnalysis.SnowballLanguage.English -> "English"
                | TypesAnalysis.SnowballLanguage.Estonian -> "Estonian"
                | TypesAnalysis.SnowballLanguage.Finnish -> "Finnish"
                | TypesAnalysis.SnowballLanguage.French -> "French"
                | TypesAnalysis.SnowballLanguage.German -> "German"
                | TypesAnalysis.SnowballLanguage.German2 -> "German2"
                | TypesAnalysis.SnowballLanguage.Hungarian -> "Hungarian"
                | TypesAnalysis.SnowballLanguage.Italian -> "Italian"
                | TypesAnalysis.SnowballLanguage.Irish -> "Irish"
                | TypesAnalysis.SnowballLanguage.Kp -> "Kp"
                | TypesAnalysis.SnowballLanguage.Lithuanian -> "Lithuanian"
                | TypesAnalysis.SnowballLanguage.Lovins -> "Lovins"
                | TypesAnalysis.SnowballLanguage.Norwegian -> "Norwegian"
                | TypesAnalysis.SnowballLanguage.Porter -> "Porter"
                | TypesAnalysis.SnowballLanguage.Portuguese -> "Portuguese"
                | TypesAnalysis.SnowballLanguage.Romanian -> "Romanian"
                | TypesAnalysis.SnowballLanguage.Russian -> "Russian"
                | TypesAnalysis.SnowballLanguage.Serbian -> "Serbian"
                | TypesAnalysis.SnowballLanguage.Spanish -> "Spanish"
                | TypesAnalysis.SnowballLanguage.Swedish -> "Swedish"
                | TypesAnalysis.SnowballLanguage.Turkish -> "Turkish"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "Arabic" -> TypesAnalysis.SnowballLanguage.Arabic
            | "Armenian" -> TypesAnalysis.SnowballLanguage.Armenian
            | "Basque" -> TypesAnalysis.SnowballLanguage.Basque
            | "Catalan" -> TypesAnalysis.SnowballLanguage.Catalan
            | "Danish" -> TypesAnalysis.SnowballLanguage.Danish
            | "Dutch" -> TypesAnalysis.SnowballLanguage.Dutch
            | "English" -> TypesAnalysis.SnowballLanguage.English
            | "Estonian" -> TypesAnalysis.SnowballLanguage.Estonian
            | "Finnish" -> TypesAnalysis.SnowballLanguage.Finnish
            | "French" -> TypesAnalysis.SnowballLanguage.French
            | "German" -> TypesAnalysis.SnowballLanguage.German
            | "German2" -> TypesAnalysis.SnowballLanguage.German2
            | "Hungarian" -> TypesAnalysis.SnowballLanguage.Hungarian
            | "Italian" -> TypesAnalysis.SnowballLanguage.Italian
            | "Irish" -> TypesAnalysis.SnowballLanguage.Irish
            | "Kp" -> TypesAnalysis.SnowballLanguage.Kp
            | "Lithuanian" -> TypesAnalysis.SnowballLanguage.Lithuanian
            | "Lovins" -> TypesAnalysis.SnowballLanguage.Lovins
            | "Norwegian" -> TypesAnalysis.SnowballLanguage.Norwegian
            | "Porter" -> TypesAnalysis.SnowballLanguage.Porter
            | "Portuguese" -> TypesAnalysis.SnowballLanguage.Portuguese
            | "Romanian" -> TypesAnalysis.SnowballLanguage.Romanian
            | "Russian" -> TypesAnalysis.SnowballLanguage.Russian
            | "Serbian" -> TypesAnalysis.SnowballLanguage.Serbian
            | "Spanish" -> TypesAnalysis.SnowballLanguage.Spanish
            | "Swedish" -> TypesAnalysis.SnowballLanguage.Swedish
            | "Turkish" -> TypesAnalysis.SnowballLanguage.Turkish
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnowballLanguage"))

    type StopWordLanguageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.StopWordLanguage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.StopWordLanguage.Arabic -> "_arabic_"
                | TypesAnalysis.StopWordLanguage.Armenian -> "_armenian_"
                | TypesAnalysis.StopWordLanguage.Basque -> "_basque_"
                | TypesAnalysis.StopWordLanguage.Bengali -> "_bengali_"
                | TypesAnalysis.StopWordLanguage.Brazilian -> "_brazilian_"
                | TypesAnalysis.StopWordLanguage.Bulgarian -> "_bulgarian_"
                | TypesAnalysis.StopWordLanguage.Catalan -> "_catalan_"
                | TypesAnalysis.StopWordLanguage.Cjk -> "_cjk_"
                | TypesAnalysis.StopWordLanguage.Czech -> "_czech_"
                | TypesAnalysis.StopWordLanguage.Danish -> "_danish_"
                | TypesAnalysis.StopWordLanguage.Dutch -> "_dutch_"
                | TypesAnalysis.StopWordLanguage.English -> "_english_"
                | TypesAnalysis.StopWordLanguage.Estonian -> "_estonian_"
                | TypesAnalysis.StopWordLanguage.Finnish -> "_finnish_"
                | TypesAnalysis.StopWordLanguage.French -> "_french_"
                | TypesAnalysis.StopWordLanguage.Galician -> "_galician_"
                | TypesAnalysis.StopWordLanguage.German -> "_german_"
                | TypesAnalysis.StopWordLanguage.Greek -> "_greek_"
                | TypesAnalysis.StopWordLanguage.Hindi -> "_hindi_"
                | TypesAnalysis.StopWordLanguage.Hungarian -> "_hungarian_"
                | TypesAnalysis.StopWordLanguage.Indonesian -> "_indonesian_"
                | TypesAnalysis.StopWordLanguage.Irish -> "_irish_"
                | TypesAnalysis.StopWordLanguage.Italian -> "_italian_"
                | TypesAnalysis.StopWordLanguage.Latvian -> "_latvian_"
                | TypesAnalysis.StopWordLanguage.Lithuanian -> "_lithuanian_"
                | TypesAnalysis.StopWordLanguage.Norwegian -> "_norwegian_"
                | TypesAnalysis.StopWordLanguage.Persian -> "_persian_"
                | TypesAnalysis.StopWordLanguage.Portuguese -> "_portuguese_"
                | TypesAnalysis.StopWordLanguage.Romanian -> "_romanian_"
                | TypesAnalysis.StopWordLanguage.Russian -> "_russian_"
                | TypesAnalysis.StopWordLanguage.Serbian -> "_serbian_"
                | TypesAnalysis.StopWordLanguage.Sorani -> "_sorani_"
                | TypesAnalysis.StopWordLanguage.Spanish -> "_spanish_"
                | TypesAnalysis.StopWordLanguage.Swedish -> "_swedish_"
                | TypesAnalysis.StopWordLanguage.Thai -> "_thai_"
                | TypesAnalysis.StopWordLanguage.Turkish -> "_turkish_"
                | TypesAnalysis.StopWordLanguage.None -> "_none_"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_arabic_" -> TypesAnalysis.StopWordLanguage.Arabic
            | "_armenian_" -> TypesAnalysis.StopWordLanguage.Armenian
            | "_basque_" -> TypesAnalysis.StopWordLanguage.Basque
            | "_bengali_" -> TypesAnalysis.StopWordLanguage.Bengali
            | "_brazilian_" -> TypesAnalysis.StopWordLanguage.Brazilian
            | "_bulgarian_" -> TypesAnalysis.StopWordLanguage.Bulgarian
            | "_catalan_" -> TypesAnalysis.StopWordLanguage.Catalan
            | "_cjk_" -> TypesAnalysis.StopWordLanguage.Cjk
            | "_czech_" -> TypesAnalysis.StopWordLanguage.Czech
            | "_danish_" -> TypesAnalysis.StopWordLanguage.Danish
            | "_dutch_" -> TypesAnalysis.StopWordLanguage.Dutch
            | "_english_" -> TypesAnalysis.StopWordLanguage.English
            | "_estonian_" -> TypesAnalysis.StopWordLanguage.Estonian
            | "_finnish_" -> TypesAnalysis.StopWordLanguage.Finnish
            | "_french_" -> TypesAnalysis.StopWordLanguage.French
            | "_galician_" -> TypesAnalysis.StopWordLanguage.Galician
            | "_german_" -> TypesAnalysis.StopWordLanguage.German
            | "_greek_" -> TypesAnalysis.StopWordLanguage.Greek
            | "_hindi_" -> TypesAnalysis.StopWordLanguage.Hindi
            | "_hungarian_" -> TypesAnalysis.StopWordLanguage.Hungarian
            | "_indonesian_" -> TypesAnalysis.StopWordLanguage.Indonesian
            | "_irish_" -> TypesAnalysis.StopWordLanguage.Irish
            | "_italian_" -> TypesAnalysis.StopWordLanguage.Italian
            | "_latvian_" -> TypesAnalysis.StopWordLanguage.Latvian
            | "_lithuanian_" -> TypesAnalysis.StopWordLanguage.Lithuanian
            | "_norwegian_" -> TypesAnalysis.StopWordLanguage.Norwegian
            | "_persian_" -> TypesAnalysis.StopWordLanguage.Persian
            | "_portuguese_" -> TypesAnalysis.StopWordLanguage.Portuguese
            | "_romanian_" -> TypesAnalysis.StopWordLanguage.Romanian
            | "_russian_" -> TypesAnalysis.StopWordLanguage.Russian
            | "_serbian_" -> TypesAnalysis.StopWordLanguage.Serbian
            | "_sorani_" -> TypesAnalysis.StopWordLanguage.Sorani
            | "_spanish_" -> TypesAnalysis.StopWordLanguage.Spanish
            | "_swedish_" -> TypesAnalysis.StopWordLanguage.Swedish
            | "_thai_" -> TypesAnalysis.StopWordLanguage.Thai
            | "_turkish_" -> TypesAnalysis.StopWordLanguage.Turkish
            | "_none_" -> TypesAnalysis.StopWordLanguage.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StopWordLanguage"))

    type SynonymFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.SynonymFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.SynonymFormat.Solr -> "solr"
                | TypesAnalysis.SynonymFormat.Wordnet -> "wordnet"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "solr" -> TypesAnalysis.SynonymFormat.Solr
            | "wordnet" -> TypesAnalysis.SynonymFormat.Wordnet
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SynonymFormat"))

    type TokenCharConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.TokenChar>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesAnalysis.TokenChar.Letter -> "letter"
                | TypesAnalysis.TokenChar.Digit -> "digit"
                | TypesAnalysis.TokenChar.Whitespace -> "whitespace"
                | TypesAnalysis.TokenChar.Punctuation -> "punctuation"
                | TypesAnalysis.TokenChar.Symbol -> "symbol"
                | TypesAnalysis.TokenChar.Custom -> "custom"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "letter" -> TypesAnalysis.TokenChar.Letter
            | "digit" -> TypesAnalysis.TokenChar.Digit
            | "whitespace" -> TypesAnalysis.TokenChar.Whitespace
            | "punctuation" -> TypesAnalysis.TokenChar.Punctuation
            | "symbol" -> TypesAnalysis.TokenChar.Symbol
            | "custom" -> TypesAnalysis.TokenChar.Custom
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TokenChar"))

    type TokenFilterDefinitionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.TokenFilterDefinition>()

        override _.Write(writer, value, options) =
            match value with
            | TypesAnalysis.TokenFilterDefinition.ApostropheTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ArabicStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ArabicNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.AsciiFoldingTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.BengaliNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.BrazilianStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.CjkBigramTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.CjkWidthTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ClassicTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.CommonGramsTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ConditionTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.CzechStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.DecimalDigitTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.DelimitedPayloadTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.DutchStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.EdgeNGramTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ElisionTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.FingerprintTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.FlattenGraphTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.FrenchStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.GermanNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.GermanStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.HindiNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.HunspellTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.HyphenationDecompounderTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.IndicNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KeepTypesTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KeepWordsTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KeywordMarkerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KeywordRepeatTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.LengthTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.LimitTokenCountTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.LowercaseTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.MinHashTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.MultiplexerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.NGramTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.NoriPartOfSpeechTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.PatternCaptureTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.PatternReplaceTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.PersianNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.PersianStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.PorterStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.PredicateTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.RemoveDuplicatesTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ReverseTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.RussianStemTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ScandinavianFoldingTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ScandinavianNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.SerbianNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.ShingleTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.SnowballTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.SoraniNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.StemmerOverrideTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.StemmerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.StopTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.SynonymGraphTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.SynonymTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.TrimTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.TruncateTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.UniqueTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.UppercaseTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.WordDelimiterGraphTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.WordDelimiterTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.JaStopTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KuromojiStemmerTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KuromojiReadingFormTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.KuromojiPartOfSpeechTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.IcuCollationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.IcuFoldingTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.IcuNormalizationTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.IcuTransformTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.PhoneticTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.DictionaryDecompounderTokenFilter v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenFilterDefinition.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "apostrophetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ApostropheTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ApostropheTokenFilter v
            | "arabicstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ArabicStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ArabicStemTokenFilter v
            | "arabicnormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ArabicNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ArabicNormalizationTokenFilter v
            | "asciifoldingtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.AsciiFoldingTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.AsciiFoldingTokenFilter v
            | "bengalinormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.BengaliNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.BengaliNormalizationTokenFilter v
            | "brazilianstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.BrazilianStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.BrazilianStemTokenFilter v
            | "cjkbigramtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CjkBigramTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.CjkBigramTokenFilter v
            | "cjkwidthtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CjkWidthTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.CjkWidthTokenFilter v
            | "classictokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ClassicTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ClassicTokenFilter v
            | "commongramstokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CommonGramsTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.CommonGramsTokenFilter v
            | "conditiontokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ConditionTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ConditionTokenFilter v
            | "czechstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CzechStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.CzechStemTokenFilter v
            | "decimaldigittokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.DecimalDigitTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.DecimalDigitTokenFilter v
            | "delimitedpayloadtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.DelimitedPayloadTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.DelimitedPayloadTokenFilter v
            | "dutchstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.DutchStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.DutchStemTokenFilter v
            | "edgengramtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.EdgeNGramTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.EdgeNGramTokenFilter v
            | "elisiontokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ElisionTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ElisionTokenFilter v
            | "fingerprinttokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.FingerprintTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.FingerprintTokenFilter v
            | "flattengraphtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.FlattenGraphTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.FlattenGraphTokenFilter v
            | "frenchstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.FrenchStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.FrenchStemTokenFilter v
            | "germannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.GermanNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.GermanNormalizationTokenFilter v
            | "germanstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.GermanStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.GermanStemTokenFilter v
            | "hindinormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.HindiNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.HindiNormalizationTokenFilter v
            | "hunspelltokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.HunspellTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.HunspellTokenFilter v
            | "hyphenationdecompoundertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.HyphenationDecompounderTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.HyphenationDecompounderTokenFilter v
            | "indicnormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IndicNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.IndicNormalizationTokenFilter v
            | "keeptypestokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KeepTypesTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KeepTypesTokenFilter v
            | "keepwordstokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KeepWordsTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KeepWordsTokenFilter v
            | "keywordmarkertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KeywordMarkerTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KeywordMarkerTokenFilter v
            | "keywordrepeattokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KeywordRepeatTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KeywordRepeatTokenFilter v
            | "kstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KStemTokenFilter v
            | "lengthtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LengthTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.LengthTokenFilter v
            | "limittokencounttokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LimitTokenCountTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.LimitTokenCountTokenFilter v
            | "lowercasetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LowercaseTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.LowercaseTokenFilter v
            | "minhashtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.MinHashTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.MinHashTokenFilter v
            | "multiplexertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.MultiplexerTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.MultiplexerTokenFilter v
            | "ngramtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.NGramTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.NGramTokenFilter v
            | "noripartofspeechtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.NoriPartOfSpeechTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.NoriPartOfSpeechTokenFilter v
            | "patterncapturetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PatternCaptureTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.PatternCaptureTokenFilter v
            | "patternreplacetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PatternReplaceTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.PatternReplaceTokenFilter v
            | "persiannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PersianNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.PersianNormalizationTokenFilter v
            | "persianstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PersianStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.PersianStemTokenFilter v
            | "porterstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PorterStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.PorterStemTokenFilter v
            | "predicatetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PredicateTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.PredicateTokenFilter v
            | "removeduplicatestokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.RemoveDuplicatesTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.RemoveDuplicatesTokenFilter v
            | "reversetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ReverseTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ReverseTokenFilter v
            | "russianstemtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.RussianStemTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.RussianStemTokenFilter v
            | "scandinavianfoldingtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ScandinavianFoldingTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ScandinavianFoldingTokenFilter v
            | "scandinaviannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ScandinavianNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ScandinavianNormalizationTokenFilter v
            | "serbiannormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SerbianNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.SerbianNormalizationTokenFilter v
            | "shingletokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ShingleTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.ShingleTokenFilter v
            | "snowballtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SnowballTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.SnowballTokenFilter v
            | "soraninormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SoraniNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.SoraniNormalizationTokenFilter v
            | "stemmeroverridetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.StemmerOverrideTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.StemmerOverrideTokenFilter v
            | "stemmertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.StemmerTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.StemmerTokenFilter v
            | "stoptokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.StopTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.StopTokenFilter v
            | "synonymgraphtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SynonymGraphTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.SynonymGraphTokenFilter v
            | "synonymtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SynonymTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.SynonymTokenFilter v
            | "trimtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.TrimTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.TrimTokenFilter v
            | "truncatetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.TruncateTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.TruncateTokenFilter v
            | "uniquetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.UniqueTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.UniqueTokenFilter v
            | "uppercasetokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.UppercaseTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.UppercaseTokenFilter v
            | "worddelimitergraphtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.WordDelimiterGraphTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.WordDelimiterGraphTokenFilter v
            | "worddelimitertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.WordDelimiterTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.WordDelimiterTokenFilter v
            | "jastoptokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.JaStopTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.JaStopTokenFilter v
            | "kuromojistemmertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KuromojiStemmerTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KuromojiStemmerTokenFilter v
            | "kuromojireadingformtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KuromojiReadingFormTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KuromojiReadingFormTokenFilter v
            | "kuromojipartofspeechtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KuromojiPartOfSpeechTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.KuromojiPartOfSpeechTokenFilter v
            | "icucollationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IcuCollationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.IcuCollationTokenFilter v
            | "icufoldingtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IcuFoldingTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.IcuFoldingTokenFilter v
            | "icunormalizationtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IcuNormalizationTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.IcuNormalizationTokenFilter v
            | "icutransformtokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IcuTransformTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.IcuTransformTokenFilter v
            | "phonetictokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PhoneticTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.PhoneticTokenFilter v
            | "dictionarydecompoundertokenfilter" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.DictionaryDecompounderTokenFilter>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenFilterDefinition.DictionaryDecompounderTokenFilter v
            | _ -> TypesAnalysis.TokenFilterDefinition.Unknown (tagValue, doc.RootElement.Clone())

    type TokenizerDefinitionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesAnalysis.TokenizerDefinition>()

        override _.Write(writer, value, options) =
            match value with
            | TypesAnalysis.TokenizerDefinition.CharGroupTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.ClassicTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.EdgeNGramTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.KeywordTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.LetterTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.LowercaseTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.NGramTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.PathHierarchyTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.PatternTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.SimplePatternTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.SimplePatternSplitTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.StandardTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.ThaiTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.UaxEmailUrlTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.WhitespaceTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.IcuTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.KuromojiTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.NoriTokenizer v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesAnalysis.TokenizerDefinition.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "chargrouptokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.CharGroupTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.CharGroupTokenizer v
            | "classictokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ClassicTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.ClassicTokenizer v
            | "edgengramtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.EdgeNGramTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.EdgeNGramTokenizer v
            | "keywordtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KeywordTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.KeywordTokenizer v
            | "lettertokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LetterTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.LetterTokenizer v
            | "lowercasetokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.LowercaseTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.LowercaseTokenizer v
            | "ngramtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.NGramTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.NGramTokenizer v
            | "pathhierarchytokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PathHierarchyTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.PathHierarchyTokenizer v
            | "patterntokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.PatternTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.PatternTokenizer v
            | "simplepatterntokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SimplePatternTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.SimplePatternTokenizer v
            | "simplepatternsplittokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.SimplePatternSplitTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.SimplePatternSplitTokenizer v
            | "standardtokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.StandardTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.StandardTokenizer v
            | "thaitokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.ThaiTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.ThaiTokenizer v
            | "uaxemailurltokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.UaxEmailUrlTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.UaxEmailUrlTokenizer v
            | "whitespacetokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.WhitespaceTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.WhitespaceTokenizer v
            | "icutokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.IcuTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.IcuTokenizer v
            | "kuromojitokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.KuromojiTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.KuromojiTokenizer v
            | "noritokenizer" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesAnalysis.NoriTokenizer>(doc.RootElement.GetRawText(), options)
                TypesAnalysis.TokenizerDefinition.NoriTokenizer v
            | _ -> TypesAnalysis.TokenizerDefinition.Unknown (tagValue, doc.RootElement.Clone())

    type DenseVectorElementTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.DenseVectorElementType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.DenseVectorElementType.Bit -> "bit"
                | TypesMapping.DenseVectorElementType.Byte -> "byte"
                | TypesMapping.DenseVectorElementType.Float -> "float"
                | TypesMapping.DenseVectorElementType.Bfloat16 -> "bfloat16"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "bit" -> TypesMapping.DenseVectorElementType.Bit
            | "byte" -> TypesMapping.DenseVectorElementType.Byte
            | "float" -> TypesMapping.DenseVectorElementType.Float
            | "bfloat16" -> TypesMapping.DenseVectorElementType.Bfloat16
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DenseVectorElementType"))

    type DenseVectorIndexOptionsTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.DenseVectorIndexOptionsType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.DenseVectorIndexOptionsType.BbqFlat -> "bbq_flat"
                | TypesMapping.DenseVectorIndexOptionsType.BbqHnsw -> "bbq_hnsw"
                | TypesMapping.DenseVectorIndexOptionsType.BbqDisk -> "bbq_disk"
                | TypesMapping.DenseVectorIndexOptionsType.Flat -> "flat"
                | TypesMapping.DenseVectorIndexOptionsType.Hnsw -> "hnsw"
                | TypesMapping.DenseVectorIndexOptionsType.Int4Flat -> "int4_flat"
                | TypesMapping.DenseVectorIndexOptionsType.Int4Hnsw -> "int4_hnsw"
                | TypesMapping.DenseVectorIndexOptionsType.Int8Flat -> "int8_flat"
                | TypesMapping.DenseVectorIndexOptionsType.Int8Hnsw -> "int8_hnsw"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "bbq_flat" -> TypesMapping.DenseVectorIndexOptionsType.BbqFlat
            | "bbq_hnsw" -> TypesMapping.DenseVectorIndexOptionsType.BbqHnsw
            | "bbq_disk" -> TypesMapping.DenseVectorIndexOptionsType.BbqDisk
            | "flat" -> TypesMapping.DenseVectorIndexOptionsType.Flat
            | "hnsw" -> TypesMapping.DenseVectorIndexOptionsType.Hnsw
            | "int4_flat" -> TypesMapping.DenseVectorIndexOptionsType.Int4Flat
            | "int4_hnsw" -> TypesMapping.DenseVectorIndexOptionsType.Int4Hnsw
            | "int8_flat" -> TypesMapping.DenseVectorIndexOptionsType.Int8Flat
            | "int8_hnsw" -> TypesMapping.DenseVectorIndexOptionsType.Int8Hnsw
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DenseVectorIndexOptionsType"))

    type DenseVectorSimilarityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.DenseVectorSimilarity>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.DenseVectorSimilarity.Cosine -> "cosine"
                | TypesMapping.DenseVectorSimilarity.DotProduct -> "dot_product"
                | TypesMapping.DenseVectorSimilarity.L2Norm -> "l2_norm"
                | TypesMapping.DenseVectorSimilarity.MaxInnerProduct -> "max_inner_product"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> TypesMapping.DenseVectorSimilarity.Cosine
            | "dot_product" -> TypesMapping.DenseVectorSimilarity.DotProduct
            | "l2_norm" -> TypesMapping.DenseVectorSimilarity.L2Norm
            | "max_inner_product" -> TypesMapping.DenseVectorSimilarity.MaxInnerProduct
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DenseVectorSimilarity"))

    type DynamicMappingConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.DynamicMapping>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.DynamicMapping.Strict -> "strict"
                | TypesMapping.DynamicMapping.Runtime -> "runtime"
                | TypesMapping.DynamicMapping.True -> "true"
                | TypesMapping.DynamicMapping.False -> "false"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "strict" -> TypesMapping.DynamicMapping.Strict
            | "runtime" -> TypesMapping.DynamicMapping.Runtime
            | "true" -> TypesMapping.DynamicMapping.True
            | "false" -> TypesMapping.DynamicMapping.False
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DynamicMapping"))

    type DynamicTemplateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.DynamicTemplate>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesMapping.DynamicTemplate.Mapping v ->
                writer.WritePropertyName("mapping")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.DynamicTemplate.Runtime v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.Property>(ref reader, options)
                    TypesMapping.DynamicTemplate.Mapping v
                | "runtime" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.RuntimeField>(ref reader, options)
                    TypesMapping.DynamicTemplate.Runtime v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DynamicTemplate"))
            reader.Read() |> ignore // EndObject
            result

    type FieldTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.FieldType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.FieldType.None -> "none"
                | TypesMapping.FieldType.GeoPoint -> "geo_point"
                | TypesMapping.FieldType.GeoShape -> "geo_shape"
                | TypesMapping.FieldType.Ip -> "ip"
                | TypesMapping.FieldType.Binary -> "binary"
                | TypesMapping.FieldType.Keyword -> "keyword"
                | TypesMapping.FieldType.Text -> "text"
                | TypesMapping.FieldType.SearchAsYouType -> "search_as_you_type"
                | TypesMapping.FieldType.Date -> "date"
                | TypesMapping.FieldType.DateNanos -> "date_nanos"
                | TypesMapping.FieldType.Boolean -> "boolean"
                | TypesMapping.FieldType.Completion -> "completion"
                | TypesMapping.FieldType.Nested -> "nested"
                | TypesMapping.FieldType.Object -> "object"
                | TypesMapping.FieldType.Passthrough -> "passthrough"
                | TypesMapping.FieldType.Version -> "version"
                | TypesMapping.FieldType.Murmur3 -> "murmur3"
                | TypesMapping.FieldType.TokenCount -> "token_count"
                | TypesMapping.FieldType.Percolator -> "percolator"
                | TypesMapping.FieldType.Integer -> "integer"
                | TypesMapping.FieldType.Long -> "long"
                | TypesMapping.FieldType.Short -> "short"
                | TypesMapping.FieldType.Byte -> "byte"
                | TypesMapping.FieldType.Float -> "float"
                | TypesMapping.FieldType.HalfFloat -> "half_float"
                | TypesMapping.FieldType.ScaledFloat -> "scaled_float"
                | TypesMapping.FieldType.Double -> "double"
                | TypesMapping.FieldType.IntegerRange -> "integer_range"
                | TypesMapping.FieldType.FloatRange -> "float_range"
                | TypesMapping.FieldType.LongRange -> "long_range"
                | TypesMapping.FieldType.DoubleRange -> "double_range"
                | TypesMapping.FieldType.DateRange -> "date_range"
                | TypesMapping.FieldType.IpRange -> "ip_range"
                | TypesMapping.FieldType.Alias -> "alias"
                | TypesMapping.FieldType.Join -> "join"
                | TypesMapping.FieldType.RankFeature -> "rank_feature"
                | TypesMapping.FieldType.RankFeatures -> "rank_features"
                | TypesMapping.FieldType.Flattened -> "flattened"
                | TypesMapping.FieldType.Shape -> "shape"
                | TypesMapping.FieldType.Histogram -> "histogram"
                | TypesMapping.FieldType.ConstantKeyword -> "constant_keyword"
                | TypesMapping.FieldType.CountedKeyword -> "counted_keyword"
                | TypesMapping.FieldType.AggregateMetricDouble -> "aggregate_metric_double"
                | TypesMapping.FieldType.DenseVector -> "dense_vector"
                | TypesMapping.FieldType.SemanticText -> "semantic_text"
                | TypesMapping.FieldType.SparseVector -> "sparse_vector"
                | TypesMapping.FieldType.MatchOnlyText -> "match_only_text"
                | TypesMapping.FieldType.IcuCollationKeyword -> "icu_collation_keyword"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> TypesMapping.FieldType.None
            | "geo_point" -> TypesMapping.FieldType.GeoPoint
            | "geo_shape" -> TypesMapping.FieldType.GeoShape
            | "ip" -> TypesMapping.FieldType.Ip
            | "binary" -> TypesMapping.FieldType.Binary
            | "keyword" -> TypesMapping.FieldType.Keyword
            | "text" -> TypesMapping.FieldType.Text
            | "search_as_you_type" -> TypesMapping.FieldType.SearchAsYouType
            | "date" -> TypesMapping.FieldType.Date
            | "date_nanos" -> TypesMapping.FieldType.DateNanos
            | "boolean" -> TypesMapping.FieldType.Boolean
            | "completion" -> TypesMapping.FieldType.Completion
            | "nested" -> TypesMapping.FieldType.Nested
            | "object" -> TypesMapping.FieldType.Object
            | "passthrough" -> TypesMapping.FieldType.Passthrough
            | "version" -> TypesMapping.FieldType.Version
            | "murmur3" -> TypesMapping.FieldType.Murmur3
            | "token_count" -> TypesMapping.FieldType.TokenCount
            | "percolator" -> TypesMapping.FieldType.Percolator
            | "integer" -> TypesMapping.FieldType.Integer
            | "long" -> TypesMapping.FieldType.Long
            | "short" -> TypesMapping.FieldType.Short
            | "byte" -> TypesMapping.FieldType.Byte
            | "float" -> TypesMapping.FieldType.Float
            | "half_float" -> TypesMapping.FieldType.HalfFloat
            | "scaled_float" -> TypesMapping.FieldType.ScaledFloat
            | "double" -> TypesMapping.FieldType.Double
            | "integer_range" -> TypesMapping.FieldType.IntegerRange
            | "float_range" -> TypesMapping.FieldType.FloatRange
            | "long_range" -> TypesMapping.FieldType.LongRange
            | "double_range" -> TypesMapping.FieldType.DoubleRange
            | "date_range" -> TypesMapping.FieldType.DateRange
            | "ip_range" -> TypesMapping.FieldType.IpRange
            | "alias" -> TypesMapping.FieldType.Alias
            | "join" -> TypesMapping.FieldType.Join
            | "rank_feature" -> TypesMapping.FieldType.RankFeature
            | "rank_features" -> TypesMapping.FieldType.RankFeatures
            | "flattened" -> TypesMapping.FieldType.Flattened
            | "shape" -> TypesMapping.FieldType.Shape
            | "histogram" -> TypesMapping.FieldType.Histogram
            | "constant_keyword" -> TypesMapping.FieldType.ConstantKeyword
            | "counted_keyword" -> TypesMapping.FieldType.CountedKeyword
            | "aggregate_metric_double" -> TypesMapping.FieldType.AggregateMetricDouble
            | "dense_vector" -> TypesMapping.FieldType.DenseVector
            | "semantic_text" -> TypesMapping.FieldType.SemanticText
            | "sparse_vector" -> TypesMapping.FieldType.SparseVector
            | "match_only_text" -> TypesMapping.FieldType.MatchOnlyText
            | "icu_collation_keyword" -> TypesMapping.FieldType.IcuCollationKeyword
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldType"))

    type GeoOrientationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.GeoOrientation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.GeoOrientation.Right -> "right"
                | TypesMapping.GeoOrientation.Left -> "left"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "right" -> TypesMapping.GeoOrientation.Right
            | "left" -> TypesMapping.GeoOrientation.Left
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoOrientation"))

    type GeoPointMetricTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.GeoPointMetricType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.GeoPointMetricType.Gauge -> "gauge"
                | TypesMapping.GeoPointMetricType.Counter -> "counter"
                | TypesMapping.GeoPointMetricType.Position -> "position"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "gauge" -> TypesMapping.GeoPointMetricType.Gauge
            | "counter" -> TypesMapping.GeoPointMetricType.Counter
            | "position" -> TypesMapping.GeoPointMetricType.Position
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoPointMetricType"))

    type GeoStrategyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.GeoStrategy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.GeoStrategy.Recursive -> "recursive"
                | TypesMapping.GeoStrategy.Term -> "term"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "recursive" -> TypesMapping.GeoStrategy.Recursive
            | "term" -> TypesMapping.GeoStrategy.Term
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoStrategy"))

    type IndexOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.IndexOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.IndexOptions.Docs -> "docs"
                | TypesMapping.IndexOptions.Freqs -> "freqs"
                | TypesMapping.IndexOptions.Positions -> "positions"
                | TypesMapping.IndexOptions.Offsets -> "offsets"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "docs" -> TypesMapping.IndexOptions.Docs
            | "freqs" -> TypesMapping.IndexOptions.Freqs
            | "positions" -> TypesMapping.IndexOptions.Positions
            | "offsets" -> TypesMapping.IndexOptions.Offsets
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexOptions"))

    type MatchTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.MatchType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.MatchType.Simple -> "simple"
                | TypesMapping.MatchType.Regex -> "regex"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "simple" -> TypesMapping.MatchType.Simple
            | "regex" -> TypesMapping.MatchType.Regex
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MatchType"))

    type OnScriptErrorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.OnScriptError>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.OnScriptError.Fail -> "fail"
                | TypesMapping.OnScriptError.Continue -> "continue"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "fail" -> TypesMapping.OnScriptError.Fail
            | "continue" -> TypesMapping.OnScriptError.Continue
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OnScriptError"))

    type PropertyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.Property>()

        override _.Write(writer, value, options) =
            match value with
            | TypesMapping.Property.BinaryProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.BooleanProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.DynamicProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.JoinProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.KeywordProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.MatchOnlyTextProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.PercolatorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.RankFeatureProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.RankFeaturesProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.SearchAsYouTypeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.TextProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.VersionProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.WildcardProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.DateNanosProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.DateProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.AggregateMetricDoubleProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.DenseVectorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.FlattenedProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.NestedProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.ObjectProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.PassthroughObjectProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.RankVectorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.SemanticTextProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.SparseVectorProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.CompletionProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.ConstantKeywordProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.CountedKeywordProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.FieldAliasProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.HistogramProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.ExponentialHistogramProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.IpProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.Murmur3HashProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.TokenCountProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.GeoPointProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.GeoShapeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.PointProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.ShapeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.ByteNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.DoubleNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.FloatNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.HalfFloatNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.IntegerNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.LongNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.ScaledFloatNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.ShortNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.UnsignedLongNumberProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.DateRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.DoubleRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.FloatRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.IntegerRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.IpRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.LongRangeProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.IcuCollationProperty v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesMapping.Property.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "binary" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.BinaryProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.BinaryProperty v
            | "boolean" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.BooleanProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.BooleanProperty v
            | "dynamic" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.DynamicProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.DynamicProperty v
            | "join" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.JoinProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.JoinProperty v
            | "keyword" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.KeywordProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.KeywordProperty v
            | "matchonlytext" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.MatchOnlyTextProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.MatchOnlyTextProperty v
            | "percolator" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.PercolatorProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.PercolatorProperty v
            | "rankfeature" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.RankFeatureProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.RankFeatureProperty v
            | "rankfeatures" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.RankFeaturesProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.RankFeaturesProperty v
            | "searchasyoutype" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.SearchAsYouTypeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.SearchAsYouTypeProperty v
            | "text" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.TextProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.TextProperty v
            | "version" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.VersionProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.VersionProperty v
            | "wildcard" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.WildcardProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.WildcardProperty v
            | "datenanos" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.DateNanosProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.DateNanosProperty v
            | "date" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.DateProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.DateProperty v
            | "aggregatemetricdouble" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.AggregateMetricDoubleProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.AggregateMetricDoubleProperty v
            | "densevector" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.DenseVectorProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.DenseVectorProperty v
            | "flattened" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.FlattenedProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.FlattenedProperty v
            | "nested" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.NestedProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.NestedProperty v
            | "object" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.ObjectProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.ObjectProperty v
            | "passthroughobject" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.PassthroughObjectProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.PassthroughObjectProperty v
            | "rankvector" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.RankVectorProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.RankVectorProperty v
            | "semantictext" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.SemanticTextProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.SemanticTextProperty v
            | "sparsevector" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.SparseVectorProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.SparseVectorProperty v
            | "completion" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.CompletionProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.CompletionProperty v
            | "constantkeyword" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.ConstantKeywordProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.ConstantKeywordProperty v
            | "countedkeyword" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.CountedKeywordProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.CountedKeywordProperty v
            | "fieldalias" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.FieldAliasProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.FieldAliasProperty v
            | "histogram" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.HistogramProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.HistogramProperty v
            | "exponentialhistogram" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.ExponentialHistogramProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.ExponentialHistogramProperty v
            | "ip" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.IpProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.IpProperty v
            | "murmur3hash" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.Murmur3HashProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.Murmur3HashProperty v
            | "tokencount" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.TokenCountProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.TokenCountProperty v
            | "geopoint" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.GeoPointProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.GeoPointProperty v
            | "geoshape" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.GeoShapeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.GeoShapeProperty v
            | "point" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.PointProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.PointProperty v
            | "shape" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.ShapeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.ShapeProperty v
            | "bytenumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.ByteNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.ByteNumberProperty v
            | "doublenumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.DoubleNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.DoubleNumberProperty v
            | "floatnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.FloatNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.FloatNumberProperty v
            | "halffloatnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.HalfFloatNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.HalfFloatNumberProperty v
            | "integernumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.IntegerNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.IntegerNumberProperty v
            | "longnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.LongNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.LongNumberProperty v
            | "scaledfloatnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.ScaledFloatNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.ScaledFloatNumberProperty v
            | "shortnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.ShortNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.ShortNumberProperty v
            | "unsignedlongnumber" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.UnsignedLongNumberProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.UnsignedLongNumberProperty v
            | "daterange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.DateRangeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.DateRangeProperty v
            | "doublerange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.DoubleRangeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.DoubleRangeProperty v
            | "floatrange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.FloatRangeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.FloatRangeProperty v
            | "integerrange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.IntegerRangeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.IntegerRangeProperty v
            | "iprange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.IpRangeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.IpRangeProperty v
            | "longrange" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.LongRangeProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.LongRangeProperty v
            | "icucollation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<TypesMapping.IcuCollationProperty>(doc.RootElement.GetRawText(), options)
                TypesMapping.Property.IcuCollationProperty v
            | _ -> TypesMapping.Property.Unknown (tagValue, doc.RootElement.Clone())

    type RankVectorElementTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.RankVectorElementType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.RankVectorElementType.Byte -> "byte"
                | TypesMapping.RankVectorElementType.Float -> "float"
                | TypesMapping.RankVectorElementType.Bit -> "bit"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "byte" -> TypesMapping.RankVectorElementType.Byte
            | "float" -> TypesMapping.RankVectorElementType.Float
            | "bit" -> TypesMapping.RankVectorElementType.Bit
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RankVectorElementType"))

    type RuntimeFieldTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.RuntimeFieldType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.RuntimeFieldType.Boolean -> "boolean"
                | TypesMapping.RuntimeFieldType.Composite -> "composite"
                | TypesMapping.RuntimeFieldType.Date -> "date"
                | TypesMapping.RuntimeFieldType.Double -> "double"
                | TypesMapping.RuntimeFieldType.GeoPoint -> "geo_point"
                | TypesMapping.RuntimeFieldType.GeoShape -> "geo_shape"
                | TypesMapping.RuntimeFieldType.Ip -> "ip"
                | TypesMapping.RuntimeFieldType.Keyword -> "keyword"
                | TypesMapping.RuntimeFieldType.Long -> "long"
                | TypesMapping.RuntimeFieldType.Lookup -> "lookup"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "boolean" -> TypesMapping.RuntimeFieldType.Boolean
            | "composite" -> TypesMapping.RuntimeFieldType.Composite
            | "date" -> TypesMapping.RuntimeFieldType.Date
            | "double" -> TypesMapping.RuntimeFieldType.Double
            | "geo_point" -> TypesMapping.RuntimeFieldType.GeoPoint
            | "geo_shape" -> TypesMapping.RuntimeFieldType.GeoShape
            | "ip" -> TypesMapping.RuntimeFieldType.Ip
            | "keyword" -> TypesMapping.RuntimeFieldType.Keyword
            | "long" -> TypesMapping.RuntimeFieldType.Long
            | "lookup" -> TypesMapping.RuntimeFieldType.Lookup
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RuntimeFieldType"))

    type SourceFieldModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.SourceFieldMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.SourceFieldMode.Disabled -> "disabled"
                | TypesMapping.SourceFieldMode.Stored -> "stored"
                | TypesMapping.SourceFieldMode.Synthetic -> "synthetic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "disabled" -> TypesMapping.SourceFieldMode.Disabled
            | "stored" -> TypesMapping.SourceFieldMode.Stored
            | "synthetic" -> TypesMapping.SourceFieldMode.Synthetic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SourceFieldMode"))

    type SubobjectsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.Subobjects>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.Subobjects.True -> "true"
                | TypesMapping.Subobjects.False -> "false"
                | TypesMapping.Subobjects.Auto -> "auto"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "true" -> TypesMapping.Subobjects.True
            | "false" -> TypesMapping.Subobjects.False
            | "auto" -> TypesMapping.Subobjects.Auto
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Subobjects"))

    type SyntheticSourceKeepEnumConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.SyntheticSourceKeepEnum>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.SyntheticSourceKeepEnum.None -> "none"
                | TypesMapping.SyntheticSourceKeepEnum.Arrays -> "arrays"
                | TypesMapping.SyntheticSourceKeepEnum.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> TypesMapping.SyntheticSourceKeepEnum.None
            | "arrays" -> TypesMapping.SyntheticSourceKeepEnum.Arrays
            | "all" -> TypesMapping.SyntheticSourceKeepEnum.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyntheticSourceKeepEnum"))

    type TermVectorOptionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.TermVectorOption>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.TermVectorOption.No -> "no"
                | TypesMapping.TermVectorOption.Yes -> "yes"
                | TypesMapping.TermVectorOption.WithOffsets -> "with_offsets"
                | TypesMapping.TermVectorOption.WithPositions -> "with_positions"
                | TypesMapping.TermVectorOption.WithPositionsOffsets -> "with_positions_offsets"
                | TypesMapping.TermVectorOption.WithPositionsOffsetsPayloads -> "with_positions_offsets_payloads"
                | TypesMapping.TermVectorOption.WithPositionsPayloads -> "with_positions_payloads"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "no" -> TypesMapping.TermVectorOption.No
            | "yes" -> TypesMapping.TermVectorOption.Yes
            | "with_offsets" -> TypesMapping.TermVectorOption.WithOffsets
            | "with_positions" -> TypesMapping.TermVectorOption.WithPositions
            | "with_positions_offsets" -> TypesMapping.TermVectorOption.WithPositionsOffsets
            | "with_positions_offsets_payloads" -> TypesMapping.TermVectorOption.WithPositionsOffsetsPayloads
            | "with_positions_payloads" -> TypesMapping.TermVectorOption.WithPositionsPayloads
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TermVectorOption"))

    type TimeSeriesMetricTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesMapping.TimeSeriesMetricType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesMapping.TimeSeriesMetricType.Gauge -> "gauge"
                | TypesMapping.TimeSeriesMetricType.Counter -> "counter"
                | TypesMapping.TimeSeriesMetricType.Summary -> "summary"
                | TypesMapping.TimeSeriesMetricType.Histogram -> "histogram"
                | TypesMapping.TimeSeriesMetricType.Position -> "position"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "gauge" -> TypesMapping.TimeSeriesMetricType.Gauge
            | "counter" -> TypesMapping.TimeSeriesMetricType.Counter
            | "summary" -> TypesMapping.TimeSeriesMetricType.Summary
            | "histogram" -> TypesMapping.TimeSeriesMetricType.Histogram
            | "position" -> TypesMapping.TimeSeriesMetricType.Position
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TimeSeriesMetricType"))

    type ChildScoreModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.ChildScoreMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.ChildScoreMode.None -> "none"
                | TypesQueryDsl.ChildScoreMode.Avg -> "avg"
                | TypesQueryDsl.ChildScoreMode.Sum -> "sum"
                | TypesQueryDsl.ChildScoreMode.Max -> "max"
                | TypesQueryDsl.ChildScoreMode.Min -> "min"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> TypesQueryDsl.ChildScoreMode.None
            | "avg" -> TypesQueryDsl.ChildScoreMode.Avg
            | "sum" -> TypesQueryDsl.ChildScoreMode.Sum
            | "max" -> TypesQueryDsl.ChildScoreMode.Max
            | "min" -> TypesQueryDsl.ChildScoreMode.Min
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ChildScoreMode"))

    type CombinedFieldsOperatorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.CombinedFieldsOperator>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.CombinedFieldsOperator.Or -> "or"
                | TypesQueryDsl.CombinedFieldsOperator.And -> "and"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "or" -> TypesQueryDsl.CombinedFieldsOperator.Or
            | "and" -> TypesQueryDsl.CombinedFieldsOperator.And
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CombinedFieldsOperator"))

    type CombinedFieldsZeroTermsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.CombinedFieldsZeroTerms>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.CombinedFieldsZeroTerms.None -> "none"
                | TypesQueryDsl.CombinedFieldsZeroTerms.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> TypesQueryDsl.CombinedFieldsZeroTerms.None
            | "all" -> TypesQueryDsl.CombinedFieldsZeroTerms.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CombinedFieldsZeroTerms"))

    type FieldValueFactorModifierConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.FieldValueFactorModifier>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.FieldValueFactorModifier.None -> "none"
                | TypesQueryDsl.FieldValueFactorModifier.Log -> "log"
                | TypesQueryDsl.FieldValueFactorModifier.Log1p -> "log1p"
                | TypesQueryDsl.FieldValueFactorModifier.Log2p -> "log2p"
                | TypesQueryDsl.FieldValueFactorModifier.Ln -> "ln"
                | TypesQueryDsl.FieldValueFactorModifier.Ln1p -> "ln1p"
                | TypesQueryDsl.FieldValueFactorModifier.Ln2p -> "ln2p"
                | TypesQueryDsl.FieldValueFactorModifier.Square -> "square"
                | TypesQueryDsl.FieldValueFactorModifier.Sqrt -> "sqrt"
                | TypesQueryDsl.FieldValueFactorModifier.Reciprocal -> "reciprocal"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> TypesQueryDsl.FieldValueFactorModifier.None
            | "log" -> TypesQueryDsl.FieldValueFactorModifier.Log
            | "log1p" -> TypesQueryDsl.FieldValueFactorModifier.Log1p
            | "log2p" -> TypesQueryDsl.FieldValueFactorModifier.Log2p
            | "ln" -> TypesQueryDsl.FieldValueFactorModifier.Ln
            | "ln1p" -> TypesQueryDsl.FieldValueFactorModifier.Ln1p
            | "ln2p" -> TypesQueryDsl.FieldValueFactorModifier.Ln2p
            | "square" -> TypesQueryDsl.FieldValueFactorModifier.Square
            | "sqrt" -> TypesQueryDsl.FieldValueFactorModifier.Sqrt
            | "reciprocal" -> TypesQueryDsl.FieldValueFactorModifier.Reciprocal
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldValueFactorModifier"))

    type FunctionBoostModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.FunctionBoostMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.FunctionBoostMode.Multiply -> "multiply"
                | TypesQueryDsl.FunctionBoostMode.Replace -> "replace"
                | TypesQueryDsl.FunctionBoostMode.Sum -> "sum"
                | TypesQueryDsl.FunctionBoostMode.Avg -> "avg"
                | TypesQueryDsl.FunctionBoostMode.Max -> "max"
                | TypesQueryDsl.FunctionBoostMode.Min -> "min"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "multiply" -> TypesQueryDsl.FunctionBoostMode.Multiply
            | "replace" -> TypesQueryDsl.FunctionBoostMode.Replace
            | "sum" -> TypesQueryDsl.FunctionBoostMode.Sum
            | "avg" -> TypesQueryDsl.FunctionBoostMode.Avg
            | "max" -> TypesQueryDsl.FunctionBoostMode.Max
            | "min" -> TypesQueryDsl.FunctionBoostMode.Min
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FunctionBoostMode"))

    type FunctionScoreContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.FunctionScoreContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.FunctionScoreContainer.Exp v ->
                writer.WritePropertyName("exp")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.FunctionScoreContainer.Gauss v ->
                writer.WritePropertyName("gauss")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.FunctionScoreContainer.Linear v ->
                writer.WritePropertyName("linear")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.FunctionScoreContainer.FieldValueFactor v ->
                writer.WritePropertyName("field_value_factor")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.FunctionScoreContainer.RandomScore v ->
                writer.WritePropertyName("random_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.FunctionScoreContainer.ScriptScore v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.DecayFunction>(ref reader, options)
                    TypesQueryDsl.FunctionScoreContainer.Exp v
                | "gauss" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.DecayFunction>(ref reader, options)
                    TypesQueryDsl.FunctionScoreContainer.Gauss v
                | "linear" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.DecayFunction>(ref reader, options)
                    TypesQueryDsl.FunctionScoreContainer.Linear v
                | "field_value_factor" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.FieldValueFactorScoreFunction>(ref reader, options)
                    TypesQueryDsl.FunctionScoreContainer.FieldValueFactor v
                | "random_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RandomScoreFunction>(ref reader, options)
                    TypesQueryDsl.FunctionScoreContainer.RandomScore v
                | "script_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ScriptScoreFunction>(ref reader, options)
                    TypesQueryDsl.FunctionScoreContainer.ScriptScore v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for FunctionScoreContainer"))
            reader.Read() |> ignore // EndObject
            result

    type FunctionScoreModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.FunctionScoreMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.FunctionScoreMode.Multiply -> "multiply"
                | TypesQueryDsl.FunctionScoreMode.Sum -> "sum"
                | TypesQueryDsl.FunctionScoreMode.Avg -> "avg"
                | TypesQueryDsl.FunctionScoreMode.First -> "first"
                | TypesQueryDsl.FunctionScoreMode.Max -> "max"
                | TypesQueryDsl.FunctionScoreMode.Min -> "min"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "multiply" -> TypesQueryDsl.FunctionScoreMode.Multiply
            | "sum" -> TypesQueryDsl.FunctionScoreMode.Sum
            | "avg" -> TypesQueryDsl.FunctionScoreMode.Avg
            | "first" -> TypesQueryDsl.FunctionScoreMode.First
            | "max" -> TypesQueryDsl.FunctionScoreMode.Max
            | "min" -> TypesQueryDsl.FunctionScoreMode.Min
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FunctionScoreMode"))

    type GeoExecutionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.GeoExecution>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.GeoExecution.Memory -> "memory"
                | TypesQueryDsl.GeoExecution.Indexed -> "indexed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "memory" -> TypesQueryDsl.GeoExecution.Memory
            | "indexed" -> TypesQueryDsl.GeoExecution.Indexed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoExecution"))

    type GeoGridQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.GeoGridQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.GeoGridQuery.Geotile v ->
                writer.WritePropertyName("geotile")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.GeoGridQuery.Geohash v ->
                writer.WritePropertyName("geohash")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.GeoGridQuery.Geohex v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoTile>(ref reader, options)
                    TypesQueryDsl.GeoGridQuery.Geotile v
                | "geohash" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoHash>(ref reader, options)
                    TypesQueryDsl.GeoGridQuery.Geohash v
                | "geohex" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.GeoHexCell>(ref reader, options)
                    TypesQueryDsl.GeoGridQuery.Geohex v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for GeoGridQuery"))
            reader.Read() |> ignore // EndObject
            result

    type GeoValidationMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.GeoValidationMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.GeoValidationMethod.Coerce -> "coerce"
                | TypesQueryDsl.GeoValidationMethod.IgnoreMalformed -> "ignore_malformed"
                | TypesQueryDsl.GeoValidationMethod.Strict -> "strict"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "coerce" -> TypesQueryDsl.GeoValidationMethod.Coerce
            | "ignore_malformed" -> TypesQueryDsl.GeoValidationMethod.IgnoreMalformed
            | "strict" -> TypesQueryDsl.GeoValidationMethod.Strict
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoValidationMethod"))

    type IntervalsContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.IntervalsContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.IntervalsContainer.AllOf v ->
                writer.WritePropertyName("all_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsContainer.AnyOf v ->
                writer.WritePropertyName("any_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsContainer.Fuzzy v ->
                writer.WritePropertyName("fuzzy")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsContainer.Match v ->
                writer.WritePropertyName("match")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsContainer.Prefix v ->
                writer.WritePropertyName("prefix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsContainer.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsContainer.Regexp v ->
                writer.WritePropertyName("regexp")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsContainer.Wildcard v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsAllOf>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.AllOf v
                | "any_of" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsAnyOf>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.AnyOf v
                | "fuzzy" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsFuzzy>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.Fuzzy v
                | "match" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsMatch>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.Match v
                | "prefix" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsPrefix>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.Prefix v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsRange>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.Range v
                | "regexp" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsRegexp>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.Regexp v
                | "wildcard" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsWildcard>(ref reader, options)
                    TypesQueryDsl.IntervalsContainer.Wildcard v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IntervalsContainer"))
            reader.Read() |> ignore // EndObject
            result

    type IntervalsFilterConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.IntervalsFilter>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.IntervalsFilter.After v ->
                writer.WritePropertyName("after")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.Before v ->
                writer.WritePropertyName("before")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.ContainedBy v ->
                writer.WritePropertyName("contained_by")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.Containing v ->
                writer.WritePropertyName("containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.NotContainedBy v ->
                writer.WritePropertyName("not_contained_by")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.NotContaining v ->
                writer.WritePropertyName("not_containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.NotOverlapping v ->
                writer.WritePropertyName("not_overlapping")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.Overlapping v ->
                writer.WritePropertyName("overlapping")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsFilter.Script v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.After v
                | "before" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.Before v
                | "contained_by" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.ContainedBy v
                | "containing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.Containing v
                | "not_contained_by" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.NotContainedBy v
                | "not_containing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.NotContaining v
                | "not_overlapping" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.NotOverlapping v
                | "overlapping" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsContainer>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.Overlapping v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Script>(ref reader, options)
                    TypesQueryDsl.IntervalsFilter.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IntervalsFilter"))
            reader.Read() |> ignore // EndObject
            result

    type IntervalsQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.IntervalsQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.IntervalsQuery.AllOf v ->
                writer.WritePropertyName("all_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsQuery.AnyOf v ->
                writer.WritePropertyName("any_of")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsQuery.Fuzzy v ->
                writer.WritePropertyName("fuzzy")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsQuery.Match v ->
                writer.WritePropertyName("match")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsQuery.Prefix v ->
                writer.WritePropertyName("prefix")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsQuery.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsQuery.Regexp v ->
                writer.WritePropertyName("regexp")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.IntervalsQuery.Wildcard v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsAllOf>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.AllOf v
                | "any_of" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsAnyOf>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.AnyOf v
                | "fuzzy" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsFuzzy>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.Fuzzy v
                | "match" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsMatch>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.Match v
                | "prefix" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsPrefix>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.Prefix v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsRange>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.Range v
                | "regexp" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsRegexp>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.Regexp v
                | "wildcard" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsWildcard>(ref reader, options)
                    TypesQueryDsl.IntervalsQuery.Wildcard v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for IntervalsQuery"))
            reader.Read() |> ignore // EndObject
            result

    type MultiValueModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.MultiValueMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.MultiValueMode.Min -> "min"
                | TypesQueryDsl.MultiValueMode.Max -> "max"
                | TypesQueryDsl.MultiValueMode.Avg -> "avg"
                | TypesQueryDsl.MultiValueMode.Sum -> "sum"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> TypesQueryDsl.MultiValueMode.Min
            | "max" -> TypesQueryDsl.MultiValueMode.Max
            | "avg" -> TypesQueryDsl.MultiValueMode.Avg
            | "sum" -> TypesQueryDsl.MultiValueMode.Sum
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MultiValueMode"))

    type OperatorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.Operator>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.Operator.And -> "and"
                | TypesQueryDsl.Operator.Or -> "or"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "and" -> TypesQueryDsl.Operator.And
            | "or" -> TypesQueryDsl.Operator.Or
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Operator"))

    type PinnedQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.PinnedQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.PinnedQuery.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.PinnedQuery.Docs v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Id list>(ref reader, options)
                    TypesQueryDsl.PinnedQuery.Ids v
                | "docs" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.PinnedDoc list>(ref reader, options)
                    TypesQueryDsl.PinnedQuery.Docs v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for PinnedQuery"))
            reader.Read() |> ignore // EndObject
            result

    type QueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.QueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.QueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Boosting v ->
                writer.WritePropertyName("boosting")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Common (field, v) ->
                writer.WritePropertyName("common")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.CombinedFields v ->
                writer.WritePropertyName("combined_fields")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.ConstantScore v ->
                writer.WritePropertyName("constant_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.DisMax v ->
                writer.WritePropertyName("dis_max")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.DistanceFeature v ->
                writer.WritePropertyName("distance_feature")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.FunctionScore v ->
                writer.WritePropertyName("function_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Fuzzy (field, v) ->
                writer.WritePropertyName("fuzzy")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.GeoBoundingBox v ->
                writer.WritePropertyName("geo_bounding_box")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.GeoDistance v ->
                writer.WritePropertyName("geo_distance")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.GeoGrid (field, v) ->
                writer.WritePropertyName("geo_grid")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.GeoPolygon v ->
                writer.WritePropertyName("geo_polygon")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.GeoShape v ->
                writer.WritePropertyName("geo_shape")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.HasChild v ->
                writer.WritePropertyName("has_child")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.HasParent v ->
                writer.WritePropertyName("has_parent")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Intervals (field, v) ->
                writer.WritePropertyName("intervals")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.Knn v ->
                writer.WritePropertyName("knn")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.MatchBoolPrefix (field, v) ->
                writer.WritePropertyName("match_bool_prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.MatchNone v ->
                writer.WritePropertyName("match_none")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.MatchPhrase (field, v) ->
                writer.WritePropertyName("match_phrase")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.MatchPhrasePrefix (field, v) ->
                writer.WritePropertyName("match_phrase_prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.MoreLikeThis v ->
                writer.WritePropertyName("more_like_this")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.MultiMatch v ->
                writer.WritePropertyName("multi_match")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Nested v ->
                writer.WritePropertyName("nested")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.ParentId v ->
                writer.WritePropertyName("parent_id")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Percolate v ->
                writer.WritePropertyName("percolate")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Pinned v ->
                writer.WritePropertyName("pinned")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.QueryString v ->
                writer.WritePropertyName("query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.RankFeature v ->
                writer.WritePropertyName("rank_feature")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Regexp (field, v) ->
                writer.WritePropertyName("regexp")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.Rule v ->
                writer.WritePropertyName("rule")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.ScriptScore v ->
                writer.WritePropertyName("script_score")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Semantic v ->
                writer.WritePropertyName("semantic")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Shape v ->
                writer.WritePropertyName("shape")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanContaining v ->
                writer.WritePropertyName("span_containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanFieldMasking v ->
                writer.WritePropertyName("span_field_masking")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanFirst v ->
                writer.WritePropertyName("span_first")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanMulti v ->
                writer.WritePropertyName("span_multi")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanNear v ->
                writer.WritePropertyName("span_near")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanNot v ->
                writer.WritePropertyName("span_not")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanOr v ->
                writer.WritePropertyName("span_or")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SpanTerm (field, v) ->
                writer.WritePropertyName("span_term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.SpanWithin v ->
                writer.WritePropertyName("span_within")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.SparseVector v ->
                writer.WritePropertyName("sparse_vector")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.TermsSet (field, v) ->
                writer.WritePropertyName("terms_set")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.TextExpansion (field, v) ->
                writer.WritePropertyName("text_expansion")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.WeightedTokens (field, v) ->
                writer.WritePropertyName("weighted_tokens")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.QueryContainer.Wrapper v ->
                writer.WritePropertyName("wrapper")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Type v ->
                writer.WritePropertyName("type")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.QueryContainer.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.BoolQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Bool v
                | "boosting" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.BoostingQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Boosting v
                | "common" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.CommonTermsQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Common (field, v)
                | "combined_fields" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.CombinedFieldsQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.CombinedFields v
                | "constant_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ConstantScoreQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.ConstantScore v
                | "dis_max" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.DisMaxQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.DisMax v
                | "distance_feature" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.DistanceFeatureQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.DistanceFeature v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ExistsQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Exists v
                | "function_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.FunctionScoreQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.FunctionScore v
                | "fuzzy" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.FuzzyQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Fuzzy (field, v)
                | "geo_bounding_box" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.GeoBoundingBoxQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.GeoBoundingBox v
                | "geo_distance" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.GeoDistanceQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.GeoDistance v
                | "geo_grid" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.GeoGridQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.GeoGrid (field, v)
                | "geo_polygon" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.GeoPolygonQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.GeoPolygon v
                | "geo_shape" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.GeoShapeQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.GeoShape v
                | "has_child" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.HasChildQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.HasChild v
                | "has_parent" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.HasParentQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.HasParent v
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IdsQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Ids v
                | "intervals" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IntervalsQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Intervals (field, v)
                | "knn" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.KnnQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Knn v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchAllQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.MatchAll v
                | "match_bool_prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchBoolPrefixQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.MatchBoolPrefix (field, v)
                | "match_none" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchNoneQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.MatchNone v
                | "match_phrase" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchPhraseQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.MatchPhrase (field, v)
                | "match_phrase_prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchPhrasePrefixQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.MatchPhrasePrefix (field, v)
                | "more_like_this" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MoreLikeThisQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.MoreLikeThis v
                | "multi_match" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MultiMatchQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.MultiMatch v
                | "nested" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.NestedQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Nested v
                | "parent_id" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ParentIdQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.ParentId v
                | "percolate" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.PercolateQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Percolate v
                | "pinned" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.PinnedQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Pinned v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.PrefixQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Prefix (field, v)
                | "query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.QueryStringQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.QueryString v
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RangeQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Range (field, v)
                | "rank_feature" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RankFeatureQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.RankFeature v
                | "regexp" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RegexpQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Regexp (field, v)
                | "rule" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RuleQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Rule v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ScriptQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Script v
                | "script_score" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ScriptScoreQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.ScriptScore v
                | "semantic" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SemanticQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Semantic v
                | "shape" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ShapeQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Shape v
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SimpleQueryStringQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SimpleQueryString v
                | "span_containing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanContainingQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanContaining v
                | "span_field_masking" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanFieldMaskingQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanFieldMasking v
                | "span_first" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanFirstQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanFirst v
                | "span_multi" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanMultiTermQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanMulti v
                | "span_near" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanNearQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanNear v
                | "span_not" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanNotQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanNot v
                | "span_or" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanOrQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanOr v
                | "span_term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanTermQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.SpanTerm (field, v)
                | "span_within" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanWithinQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SpanWithin v
                | "sparse_vector" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SparseVectorQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.SparseVector v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermsQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Terms v
                | "terms_set" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermsSetQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.TermsSet (field, v)
                | "text_expansion" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TextExpansionQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.TextExpansion (field, v)
                | "weighted_tokens" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.WeightedTokensQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.WeightedTokens (field, v)
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.WildcardQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.QueryContainer.Wildcard (field, v)
                | "wrapper" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.WrapperQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Wrapper v
                | "type" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TypeQuery>(ref reader, options)
                    TypesQueryDsl.QueryContainer.Type v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    TypesQueryDsl.QueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type RangeRelationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.RangeRelation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.RangeRelation.Within -> "within"
                | TypesQueryDsl.RangeRelation.Contains -> "contains"
                | TypesQueryDsl.RangeRelation.Intersects -> "intersects"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "within" -> TypesQueryDsl.RangeRelation.Within
            | "contains" -> TypesQueryDsl.RangeRelation.Contains
            | "intersects" -> TypesQueryDsl.RangeRelation.Intersects
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RangeRelation"))

    type SimpleQueryStringFlagConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.SimpleQueryStringFlag>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.SimpleQueryStringFlag.NONE -> "NONE"
                | TypesQueryDsl.SimpleQueryStringFlag.AND -> "AND"
                | TypesQueryDsl.SimpleQueryStringFlag.NOT -> "NOT"
                | TypesQueryDsl.SimpleQueryStringFlag.OR -> "OR"
                | TypesQueryDsl.SimpleQueryStringFlag.PREFIX -> "PREFIX"
                | TypesQueryDsl.SimpleQueryStringFlag.PHRASE -> "PHRASE"
                | TypesQueryDsl.SimpleQueryStringFlag.PRECEDENCE -> "PRECEDENCE"
                | TypesQueryDsl.SimpleQueryStringFlag.ESCAPE -> "ESCAPE"
                | TypesQueryDsl.SimpleQueryStringFlag.WHITESPACE -> "WHITESPACE"
                | TypesQueryDsl.SimpleQueryStringFlag.FUZZY -> "FUZZY"
                | TypesQueryDsl.SimpleQueryStringFlag.NEAR -> "NEAR"
                | TypesQueryDsl.SimpleQueryStringFlag.SLOP -> "SLOP"
                | TypesQueryDsl.SimpleQueryStringFlag.ALL -> "ALL"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "NONE" -> TypesQueryDsl.SimpleQueryStringFlag.NONE
            | "AND" -> TypesQueryDsl.SimpleQueryStringFlag.AND
            | "NOT" -> TypesQueryDsl.SimpleQueryStringFlag.NOT
            | "OR" -> TypesQueryDsl.SimpleQueryStringFlag.OR
            | "PREFIX" -> TypesQueryDsl.SimpleQueryStringFlag.PREFIX
            | "PHRASE" -> TypesQueryDsl.SimpleQueryStringFlag.PHRASE
            | "PRECEDENCE" -> TypesQueryDsl.SimpleQueryStringFlag.PRECEDENCE
            | "ESCAPE" -> TypesQueryDsl.SimpleQueryStringFlag.ESCAPE
            | "WHITESPACE" -> TypesQueryDsl.SimpleQueryStringFlag.WHITESPACE
            | "FUZZY" -> TypesQueryDsl.SimpleQueryStringFlag.FUZZY
            | "NEAR" -> TypesQueryDsl.SimpleQueryStringFlag.NEAR
            | "SLOP" -> TypesQueryDsl.SimpleQueryStringFlag.SLOP
            | "ALL" -> TypesQueryDsl.SimpleQueryStringFlag.ALL
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SimpleQueryStringFlag"))

    type SpanQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.SpanQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.SpanQuery.SpanContaining v ->
                writer.WritePropertyName("span_containing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanFieldMasking v ->
                writer.WritePropertyName("span_field_masking")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanFirst v ->
                writer.WritePropertyName("span_first")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanGap v ->
                writer.WritePropertyName("span_gap")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanMulti v ->
                writer.WritePropertyName("span_multi")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanNear v ->
                writer.WritePropertyName("span_near")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanNot v ->
                writer.WritePropertyName("span_not")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanOr v ->
                writer.WritePropertyName("span_or")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.SpanTerm (field, v) ->
                writer.WritePropertyName("span_term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | TypesQueryDsl.SpanQuery.SpanWithin v ->
                writer.WritePropertyName("span_within")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SpanQuery.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanContainingQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanContaining v
                | "span_field_masking" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanFieldMaskingQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanFieldMasking v
                | "span_first" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanFirstQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanFirst v
                | "span_gap" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanGapQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanGap v
                | "span_multi" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanMultiTermQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanMulti v
                | "span_near" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanNearQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanNear v
                | "span_not" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanNotQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanNot v
                | "span_or" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanOrQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanOr v
                | "span_term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanTermQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    TypesQueryDsl.SpanQuery.SpanTerm (field, v)
                | "span_within" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SpanWithinQuery>(ref reader, options)
                    TypesQueryDsl.SpanQuery.SpanWithin v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    TypesQueryDsl.SpanQuery.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type SparseVectorQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.SparseVectorQuery>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TypesQueryDsl.SparseVectorQuery.QueryVector v ->
                writer.WritePropertyName("query_vector")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TypesQueryDsl.SparseVectorQuery.InferenceId v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<Map<string, Types.Float>>(ref reader, options)
                    TypesQueryDsl.SparseVectorQuery.QueryVector v
                | "inference_id" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Id>(ref reader, options)
                    TypesQueryDsl.SparseVectorQuery.InferenceId v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SparseVectorQuery"))
            reader.Read() |> ignore // EndObject
            result

    type TextQueryTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.TextQueryType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.TextQueryType.BestFields -> "best_fields"
                | TypesQueryDsl.TextQueryType.MostFields -> "most_fields"
                | TypesQueryDsl.TextQueryType.CrossFields -> "cross_fields"
                | TypesQueryDsl.TextQueryType.Phrase -> "phrase"
                | TypesQueryDsl.TextQueryType.PhrasePrefix -> "phrase_prefix"
                | TypesQueryDsl.TextQueryType.BoolPrefix -> "bool_prefix"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "best_fields" -> TypesQueryDsl.TextQueryType.BestFields
            | "most_fields" -> TypesQueryDsl.TextQueryType.MostFields
            | "cross_fields" -> TypesQueryDsl.TextQueryType.CrossFields
            | "phrase" -> TypesQueryDsl.TextQueryType.Phrase
            | "phrase_prefix" -> TypesQueryDsl.TextQueryType.PhrasePrefix
            | "bool_prefix" -> TypesQueryDsl.TextQueryType.BoolPrefix
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TextQueryType"))

    type ZeroTermsQueryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TypesQueryDsl.ZeroTermsQuery>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TypesQueryDsl.ZeroTermsQuery.All -> "all"
                | TypesQueryDsl.ZeroTermsQuery.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> TypesQueryDsl.ZeroTermsQuery.All
            | "none" -> TypesQueryDsl.ZeroTermsQuery.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ZeroTermsQuery"))

    type CatAliasesColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatAliasesColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatAliasesColumn.Alias -> "alias"
                | CatTypes.CatAliasesColumn.Index -> "index"
                | CatTypes.CatAliasesColumn.Filter -> "filter"
                | CatTypes.CatAliasesColumn.RoutingIndex -> "routing.index"
                | CatTypes.CatAliasesColumn.RoutingSearch -> "routing.search"
                | CatTypes.CatAliasesColumn.IsWriteIndex -> "is_write_index"
                | CatTypes.CatAliasesColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "alias" -> CatTypes.CatAliasesColumn.Alias
            | "index" -> CatTypes.CatAliasesColumn.Index
            | "filter" -> CatTypes.CatAliasesColumn.Filter
            | "routing.index" -> CatTypes.CatAliasesColumn.RoutingIndex
            | "routing.search" -> CatTypes.CatAliasesColumn.RoutingSearch
            | "is_write_index" -> CatTypes.CatAliasesColumn.IsWriteIndex
            | other -> CatTypes.CatAliasesColumn.Custom other

    type CatAllocationColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatAllocationColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatAllocationColumn.Shards -> "shards"
                | CatTypes.CatAllocationColumn.ShardsUndesired -> "shards.undesired"
                | CatTypes.CatAllocationColumn.WriteLoadForecast -> "write_load.forecast"
                | CatTypes.CatAllocationColumn.DiskIndicesForecast -> "disk.indices.forecast"
                | CatTypes.CatAllocationColumn.DiskIndices -> "disk.indices"
                | CatTypes.CatAllocationColumn.DiskUsed -> "disk.used"
                | CatTypes.CatAllocationColumn.DiskAvail -> "disk.avail"
                | CatTypes.CatAllocationColumn.DiskTotal -> "disk.total"
                | CatTypes.CatAllocationColumn.DiskPercent -> "disk.percent"
                | CatTypes.CatAllocationColumn.Host -> "host"
                | CatTypes.CatAllocationColumn.Ip -> "ip"
                | CatTypes.CatAllocationColumn.Node -> "node"
                | CatTypes.CatAllocationColumn.NodeRole -> "node.role"
                | CatTypes.CatAllocationColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "shards" -> CatTypes.CatAllocationColumn.Shards
            | "shards.undesired" -> CatTypes.CatAllocationColumn.ShardsUndesired
            | "write_load.forecast" -> CatTypes.CatAllocationColumn.WriteLoadForecast
            | "disk.indices.forecast" -> CatTypes.CatAllocationColumn.DiskIndicesForecast
            | "disk.indices" -> CatTypes.CatAllocationColumn.DiskIndices
            | "disk.used" -> CatTypes.CatAllocationColumn.DiskUsed
            | "disk.avail" -> CatTypes.CatAllocationColumn.DiskAvail
            | "disk.total" -> CatTypes.CatAllocationColumn.DiskTotal
            | "disk.percent" -> CatTypes.CatAllocationColumn.DiskPercent
            | "host" -> CatTypes.CatAllocationColumn.Host
            | "ip" -> CatTypes.CatAllocationColumn.Ip
            | "node" -> CatTypes.CatAllocationColumn.Node
            | "node.role" -> CatTypes.CatAllocationColumn.NodeRole
            | other -> CatTypes.CatAllocationColumn.Custom other

    type CatAnomalyDetectorColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatAnomalyDetectorColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatAnomalyDetectorColumn.AssignmentExplanation -> "assignment_explanation"
                | CatTypes.CatAnomalyDetectorColumn.BucketsCount -> "buckets.count"
                | CatTypes.CatAnomalyDetectorColumn.BucketsTimeExpAvg -> "buckets.time.exp_avg"
                | CatTypes.CatAnomalyDetectorColumn.BucketsTimeExpAvgHour -> "buckets.time.exp_avg_hour"
                | CatTypes.CatAnomalyDetectorColumn.BucketsTimeMax -> "buckets.time.max"
                | CatTypes.CatAnomalyDetectorColumn.BucketsTimeMin -> "buckets.time.min"
                | CatTypes.CatAnomalyDetectorColumn.BucketsTimeTotal -> "buckets.time.total"
                | CatTypes.CatAnomalyDetectorColumn.DataBuckets -> "data.buckets"
                | CatTypes.CatAnomalyDetectorColumn.DataEarliestRecord -> "data.earliest_record"
                | CatTypes.CatAnomalyDetectorColumn.DataEmptyBuckets -> "data.empty_buckets"
                | CatTypes.CatAnomalyDetectorColumn.DataInputBytes -> "data.input_bytes"
                | CatTypes.CatAnomalyDetectorColumn.DataInputFields -> "data.input_fields"
                | CatTypes.CatAnomalyDetectorColumn.DataInputRecords -> "data.input_records"
                | CatTypes.CatAnomalyDetectorColumn.DataInvalidDates -> "data.invalid_dates"
                | CatTypes.CatAnomalyDetectorColumn.DataLast -> "data.last"
                | CatTypes.CatAnomalyDetectorColumn.DataLastEmptyBucket -> "data.last_empty_bucket"
                | CatTypes.CatAnomalyDetectorColumn.DataLastSparseBucket -> "data.last_sparse_bucket"
                | CatTypes.CatAnomalyDetectorColumn.DataLatestRecord -> "data.latest_record"
                | CatTypes.CatAnomalyDetectorColumn.DataMissingFields -> "data.missing_fields"
                | CatTypes.CatAnomalyDetectorColumn.DataOutOfOrderTimestamps -> "data.out_of_order_timestamps"
                | CatTypes.CatAnomalyDetectorColumn.DataProcessedFields -> "data.processed_fields"
                | CatTypes.CatAnomalyDetectorColumn.DataProcessedRecords -> "data.processed_records"
                | CatTypes.CatAnomalyDetectorColumn.DataSparseBuckets -> "data.sparse_buckets"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryAvg -> "forecasts.memory.avg"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryMax -> "forecasts.memory.max"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryMin -> "forecasts.memory.min"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryTotal -> "forecasts.memory.total"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsAvg -> "forecasts.records.avg"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsMax -> "forecasts.records.max"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsMin -> "forecasts.records.min"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsTotal -> "forecasts.records.total"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsTimeAvg -> "forecasts.time.avg"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsTimeMax -> "forecasts.time.max"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsTimeMin -> "forecasts.time.min"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsTimeTotal -> "forecasts.time.total"
                | CatTypes.CatAnomalyDetectorColumn.ForecastsTotal -> "forecasts.total"
                | CatTypes.CatAnomalyDetectorColumn.Id -> "id"
                | CatTypes.CatAnomalyDetectorColumn.ModelBucketAllocationFailures -> "model.bucket_allocation_failures"
                | CatTypes.CatAnomalyDetectorColumn.ModelByFields -> "model.by_fields"
                | CatTypes.CatAnomalyDetectorColumn.ModelBytes -> "model.bytes"
                | CatTypes.CatAnomalyDetectorColumn.ModelBytesExceeded -> "model.bytes_exceeded"
                | CatTypes.CatAnomalyDetectorColumn.ModelCategorizationStatus -> "model.categorization_status"
                | CatTypes.CatAnomalyDetectorColumn.ModelCategorizedDocCount -> "model.categorized_doc_count"
                | CatTypes.CatAnomalyDetectorColumn.ModelDeadCategoryCount -> "model.dead_category_count"
                | CatTypes.CatAnomalyDetectorColumn.ModelFailedCategoryCount -> "model.failed_category_count"
                | CatTypes.CatAnomalyDetectorColumn.ModelFrequentCategoryCount -> "model.frequent_category_count"
                | CatTypes.CatAnomalyDetectorColumn.ModelLogTime -> "model.log_time"
                | CatTypes.CatAnomalyDetectorColumn.ModelMemoryLimit -> "model.memory_limit"
                | CatTypes.CatAnomalyDetectorColumn.ModelMemoryStatus -> "model.memory_status"
                | CatTypes.CatAnomalyDetectorColumn.ModelOverFields -> "model.over_fields"
                | CatTypes.CatAnomalyDetectorColumn.ModelPartitionFields -> "model.partition_fields"
                | CatTypes.CatAnomalyDetectorColumn.ModelRareCategoryCount -> "model.rare_category_count"
                | CatTypes.CatAnomalyDetectorColumn.ModelTimestamp -> "model.timestamp"
                | CatTypes.CatAnomalyDetectorColumn.ModelTotalCategoryCount -> "model.total_category_count"
                | CatTypes.CatAnomalyDetectorColumn.NodeAddress -> "node.address"
                | CatTypes.CatAnomalyDetectorColumn.NodeEphemeralId -> "node.ephemeral_id"
                | CatTypes.CatAnomalyDetectorColumn.NodeId -> "node.id"
                | CatTypes.CatAnomalyDetectorColumn.NodeName -> "node.name"
                | CatTypes.CatAnomalyDetectorColumn.OpenedTime -> "opened_time"
                | CatTypes.CatAnomalyDetectorColumn.State -> "state"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "assignment_explanation" -> CatTypes.CatAnomalyDetectorColumn.AssignmentExplanation
            | "buckets.count" -> CatTypes.CatAnomalyDetectorColumn.BucketsCount
            | "buckets.time.exp_avg" -> CatTypes.CatAnomalyDetectorColumn.BucketsTimeExpAvg
            | "buckets.time.exp_avg_hour" -> CatTypes.CatAnomalyDetectorColumn.BucketsTimeExpAvgHour
            | "buckets.time.max" -> CatTypes.CatAnomalyDetectorColumn.BucketsTimeMax
            | "buckets.time.min" -> CatTypes.CatAnomalyDetectorColumn.BucketsTimeMin
            | "buckets.time.total" -> CatTypes.CatAnomalyDetectorColumn.BucketsTimeTotal
            | "data.buckets" -> CatTypes.CatAnomalyDetectorColumn.DataBuckets
            | "data.earliest_record" -> CatTypes.CatAnomalyDetectorColumn.DataEarliestRecord
            | "data.empty_buckets" -> CatTypes.CatAnomalyDetectorColumn.DataEmptyBuckets
            | "data.input_bytes" -> CatTypes.CatAnomalyDetectorColumn.DataInputBytes
            | "data.input_fields" -> CatTypes.CatAnomalyDetectorColumn.DataInputFields
            | "data.input_records" -> CatTypes.CatAnomalyDetectorColumn.DataInputRecords
            | "data.invalid_dates" -> CatTypes.CatAnomalyDetectorColumn.DataInvalidDates
            | "data.last" -> CatTypes.CatAnomalyDetectorColumn.DataLast
            | "data.last_empty_bucket" -> CatTypes.CatAnomalyDetectorColumn.DataLastEmptyBucket
            | "data.last_sparse_bucket" -> CatTypes.CatAnomalyDetectorColumn.DataLastSparseBucket
            | "data.latest_record" -> CatTypes.CatAnomalyDetectorColumn.DataLatestRecord
            | "data.missing_fields" -> CatTypes.CatAnomalyDetectorColumn.DataMissingFields
            | "data.out_of_order_timestamps" -> CatTypes.CatAnomalyDetectorColumn.DataOutOfOrderTimestamps
            | "data.processed_fields" -> CatTypes.CatAnomalyDetectorColumn.DataProcessedFields
            | "data.processed_records" -> CatTypes.CatAnomalyDetectorColumn.DataProcessedRecords
            | "data.sparse_buckets" -> CatTypes.CatAnomalyDetectorColumn.DataSparseBuckets
            | "forecasts.memory.avg" -> CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryAvg
            | "forecasts.memory.max" -> CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryMax
            | "forecasts.memory.min" -> CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryMin
            | "forecasts.memory.total" -> CatTypes.CatAnomalyDetectorColumn.ForecastsMemoryTotal
            | "forecasts.records.avg" -> CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsAvg
            | "forecasts.records.max" -> CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsMax
            | "forecasts.records.min" -> CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsMin
            | "forecasts.records.total" -> CatTypes.CatAnomalyDetectorColumn.ForecastsRecordsTotal
            | "forecasts.time.avg" -> CatTypes.CatAnomalyDetectorColumn.ForecastsTimeAvg
            | "forecasts.time.max" -> CatTypes.CatAnomalyDetectorColumn.ForecastsTimeMax
            | "forecasts.time.min" -> CatTypes.CatAnomalyDetectorColumn.ForecastsTimeMin
            | "forecasts.time.total" -> CatTypes.CatAnomalyDetectorColumn.ForecastsTimeTotal
            | "forecasts.total" -> CatTypes.CatAnomalyDetectorColumn.ForecastsTotal
            | "id" -> CatTypes.CatAnomalyDetectorColumn.Id
            | "model.bucket_allocation_failures" -> CatTypes.CatAnomalyDetectorColumn.ModelBucketAllocationFailures
            | "model.by_fields" -> CatTypes.CatAnomalyDetectorColumn.ModelByFields
            | "model.bytes" -> CatTypes.CatAnomalyDetectorColumn.ModelBytes
            | "model.bytes_exceeded" -> CatTypes.CatAnomalyDetectorColumn.ModelBytesExceeded
            | "model.categorization_status" -> CatTypes.CatAnomalyDetectorColumn.ModelCategorizationStatus
            | "model.categorized_doc_count" -> CatTypes.CatAnomalyDetectorColumn.ModelCategorizedDocCount
            | "model.dead_category_count" -> CatTypes.CatAnomalyDetectorColumn.ModelDeadCategoryCount
            | "model.failed_category_count" -> CatTypes.CatAnomalyDetectorColumn.ModelFailedCategoryCount
            | "model.frequent_category_count" -> CatTypes.CatAnomalyDetectorColumn.ModelFrequentCategoryCount
            | "model.log_time" -> CatTypes.CatAnomalyDetectorColumn.ModelLogTime
            | "model.memory_limit" -> CatTypes.CatAnomalyDetectorColumn.ModelMemoryLimit
            | "model.memory_status" -> CatTypes.CatAnomalyDetectorColumn.ModelMemoryStatus
            | "model.over_fields" -> CatTypes.CatAnomalyDetectorColumn.ModelOverFields
            | "model.partition_fields" -> CatTypes.CatAnomalyDetectorColumn.ModelPartitionFields
            | "model.rare_category_count" -> CatTypes.CatAnomalyDetectorColumn.ModelRareCategoryCount
            | "model.timestamp" -> CatTypes.CatAnomalyDetectorColumn.ModelTimestamp
            | "model.total_category_count" -> CatTypes.CatAnomalyDetectorColumn.ModelTotalCategoryCount
            | "node.address" -> CatTypes.CatAnomalyDetectorColumn.NodeAddress
            | "node.ephemeral_id" -> CatTypes.CatAnomalyDetectorColumn.NodeEphemeralId
            | "node.id" -> CatTypes.CatAnomalyDetectorColumn.NodeId
            | "node.name" -> CatTypes.CatAnomalyDetectorColumn.NodeName
            | "opened_time" -> CatTypes.CatAnomalyDetectorColumn.OpenedTime
            | "state" -> CatTypes.CatAnomalyDetectorColumn.State
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatAnomalyDetectorColumn"))

    type CatCircuitBreakerColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatCircuitBreakerColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatCircuitBreakerColumn.NodeId -> "node_id"
                | CatTypes.CatCircuitBreakerColumn.NodeName -> "node_name"
                | CatTypes.CatCircuitBreakerColumn.Breaker -> "breaker"
                | CatTypes.CatCircuitBreakerColumn.Limit -> "limit"
                | CatTypes.CatCircuitBreakerColumn.LimitBytes -> "limit_bytes"
                | CatTypes.CatCircuitBreakerColumn.Estimated -> "estimated"
                | CatTypes.CatCircuitBreakerColumn.EstimatedBytes -> "estimated_bytes"
                | CatTypes.CatCircuitBreakerColumn.Tripped -> "tripped"
                | CatTypes.CatCircuitBreakerColumn.Overhead -> "overhead"
                | CatTypes.CatCircuitBreakerColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "node_id" -> CatTypes.CatCircuitBreakerColumn.NodeId
            | "node_name" -> CatTypes.CatCircuitBreakerColumn.NodeName
            | "breaker" -> CatTypes.CatCircuitBreakerColumn.Breaker
            | "limit" -> CatTypes.CatCircuitBreakerColumn.Limit
            | "limit_bytes" -> CatTypes.CatCircuitBreakerColumn.LimitBytes
            | "estimated" -> CatTypes.CatCircuitBreakerColumn.Estimated
            | "estimated_bytes" -> CatTypes.CatCircuitBreakerColumn.EstimatedBytes
            | "tripped" -> CatTypes.CatCircuitBreakerColumn.Tripped
            | "overhead" -> CatTypes.CatCircuitBreakerColumn.Overhead
            | other -> CatTypes.CatCircuitBreakerColumn.Custom other

    type CatComponentColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatComponentColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatComponentColumn.Name -> "name"
                | CatTypes.CatComponentColumn.Version -> "version"
                | CatTypes.CatComponentColumn.AliasCount -> "alias_count"
                | CatTypes.CatComponentColumn.MappingCount -> "mapping_count"
                | CatTypes.CatComponentColumn.SettingsCount -> "settings_count"
                | CatTypes.CatComponentColumn.MetadataCount -> "metadata_count"
                | CatTypes.CatComponentColumn.IncludedIn -> "included_in"
                | CatTypes.CatComponentColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "name" -> CatTypes.CatComponentColumn.Name
            | "version" -> CatTypes.CatComponentColumn.Version
            | "alias_count" -> CatTypes.CatComponentColumn.AliasCount
            | "mapping_count" -> CatTypes.CatComponentColumn.MappingCount
            | "settings_count" -> CatTypes.CatComponentColumn.SettingsCount
            | "metadata_count" -> CatTypes.CatComponentColumn.MetadataCount
            | "included_in" -> CatTypes.CatComponentColumn.IncludedIn
            | other -> CatTypes.CatComponentColumn.Custom other

    type CatCountColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatCountColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatCountColumn.Epoch -> "epoch"
                | CatTypes.CatCountColumn.Timestamp -> "timestamp"
                | CatTypes.CatCountColumn.Count -> "count"
                | CatTypes.CatCountColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "epoch" -> CatTypes.CatCountColumn.Epoch
            | "timestamp" -> CatTypes.CatCountColumn.Timestamp
            | "count" -> CatTypes.CatCountColumn.Count
            | other -> CatTypes.CatCountColumn.Custom other

    type CatDatafeedColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatDatafeedColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatDatafeedColumn.Ae -> "ae"
                | CatTypes.CatDatafeedColumn.Bc -> "bc"
                | CatTypes.CatDatafeedColumn.Id -> "id"
                | CatTypes.CatDatafeedColumn.Na -> "na"
                | CatTypes.CatDatafeedColumn.Ne -> "ne"
                | CatTypes.CatDatafeedColumn.Ni -> "ni"
                | CatTypes.CatDatafeedColumn.Nn -> "nn"
                | CatTypes.CatDatafeedColumn.Sba -> "sba"
                | CatTypes.CatDatafeedColumn.Sc -> "sc"
                | CatTypes.CatDatafeedColumn.Seah -> "seah"
                | CatTypes.CatDatafeedColumn.St -> "st"
                | CatTypes.CatDatafeedColumn.S -> "s"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ae" -> CatTypes.CatDatafeedColumn.Ae
            | "bc" -> CatTypes.CatDatafeedColumn.Bc
            | "id" -> CatTypes.CatDatafeedColumn.Id
            | "na" -> CatTypes.CatDatafeedColumn.Na
            | "ne" -> CatTypes.CatDatafeedColumn.Ne
            | "ni" -> CatTypes.CatDatafeedColumn.Ni
            | "nn" -> CatTypes.CatDatafeedColumn.Nn
            | "sba" -> CatTypes.CatDatafeedColumn.Sba
            | "sc" -> CatTypes.CatDatafeedColumn.Sc
            | "seah" -> CatTypes.CatDatafeedColumn.Seah
            | "st" -> CatTypes.CatDatafeedColumn.St
            | "s" -> CatTypes.CatDatafeedColumn.S
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatDatafeedColumn"))

    type CatDfaColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatDfaColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatDfaColumn.AssignmentExplanation -> "assignment_explanation"
                | CatTypes.CatDfaColumn.CreateTime -> "create_time"
                | CatTypes.CatDfaColumn.Description -> "description"
                | CatTypes.CatDfaColumn.DestIndex -> "dest_index"
                | CatTypes.CatDfaColumn.FailureReason -> "failure_reason"
                | CatTypes.CatDfaColumn.Id -> "id"
                | CatTypes.CatDfaColumn.ModelMemoryLimit -> "model_memory_limit"
                | CatTypes.CatDfaColumn.NodeAddress -> "node.address"
                | CatTypes.CatDfaColumn.NodeEphemeralId -> "node.ephemeral_id"
                | CatTypes.CatDfaColumn.NodeId -> "node.id"
                | CatTypes.CatDfaColumn.NodeName -> "node.name"
                | CatTypes.CatDfaColumn.Progress -> "progress"
                | CatTypes.CatDfaColumn.SourceIndex -> "source_index"
                | CatTypes.CatDfaColumn.State -> "state"
                | CatTypes.CatDfaColumn.Type -> "type"
                | CatTypes.CatDfaColumn.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "assignment_explanation" -> CatTypes.CatDfaColumn.AssignmentExplanation
            | "create_time" -> CatTypes.CatDfaColumn.CreateTime
            | "description" -> CatTypes.CatDfaColumn.Description
            | "dest_index" -> CatTypes.CatDfaColumn.DestIndex
            | "failure_reason" -> CatTypes.CatDfaColumn.FailureReason
            | "id" -> CatTypes.CatDfaColumn.Id
            | "model_memory_limit" -> CatTypes.CatDfaColumn.ModelMemoryLimit
            | "node.address" -> CatTypes.CatDfaColumn.NodeAddress
            | "node.ephemeral_id" -> CatTypes.CatDfaColumn.NodeEphemeralId
            | "node.id" -> CatTypes.CatDfaColumn.NodeId
            | "node.name" -> CatTypes.CatDfaColumn.NodeName
            | "progress" -> CatTypes.CatDfaColumn.Progress
            | "source_index" -> CatTypes.CatDfaColumn.SourceIndex
            | "state" -> CatTypes.CatDfaColumn.State
            | "type" -> CatTypes.CatDfaColumn.Type
            | "version" -> CatTypes.CatDfaColumn.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatDfaColumn"))

    type CatFieldDataColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatFieldDataColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatFieldDataColumn.Id -> "id"
                | CatTypes.CatFieldDataColumn.Host -> "host"
                | CatTypes.CatFieldDataColumn.Ip -> "ip"
                | CatTypes.CatFieldDataColumn.Node -> "node"
                | CatTypes.CatFieldDataColumn.Field -> "field"
                | CatTypes.CatFieldDataColumn.Size -> "size"
                | CatTypes.CatFieldDataColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatTypes.CatFieldDataColumn.Id
            | "host" -> CatTypes.CatFieldDataColumn.Host
            | "ip" -> CatTypes.CatFieldDataColumn.Ip
            | "node" -> CatTypes.CatFieldDataColumn.Node
            | "field" -> CatTypes.CatFieldDataColumn.Field
            | "size" -> CatTypes.CatFieldDataColumn.Size
            | other -> CatTypes.CatFieldDataColumn.Custom other

    type CatHealthColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatHealthColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatHealthColumn.Epoch -> "epoch"
                | CatTypes.CatHealthColumn.Timestamp -> "timestamp"
                | CatTypes.CatHealthColumn.Cluster -> "cluster"
                | CatTypes.CatHealthColumn.Status -> "status"
                | CatTypes.CatHealthColumn.NodeTotal -> "node.total"
                | CatTypes.CatHealthColumn.NodeData -> "node.data"
                | CatTypes.CatHealthColumn.Shards -> "shards"
                | CatTypes.CatHealthColumn.Pri -> "pri"
                | CatTypes.CatHealthColumn.Relo -> "relo"
                | CatTypes.CatHealthColumn.Init -> "init"
                | CatTypes.CatHealthColumn.Unassign -> "unassign"
                | CatTypes.CatHealthColumn.UnassignPri -> "unassign.pri"
                | CatTypes.CatHealthColumn.PendingTasks -> "pending_tasks"
                | CatTypes.CatHealthColumn.MaxTaskWaitTime -> "max_task_wait_time"
                | CatTypes.CatHealthColumn.ActiveShardsPercent -> "active_shards_percent"
                | CatTypes.CatHealthColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "epoch" -> CatTypes.CatHealthColumn.Epoch
            | "timestamp" -> CatTypes.CatHealthColumn.Timestamp
            | "cluster" -> CatTypes.CatHealthColumn.Cluster
            | "status" -> CatTypes.CatHealthColumn.Status
            | "node.total" -> CatTypes.CatHealthColumn.NodeTotal
            | "node.data" -> CatTypes.CatHealthColumn.NodeData
            | "shards" -> CatTypes.CatHealthColumn.Shards
            | "pri" -> CatTypes.CatHealthColumn.Pri
            | "relo" -> CatTypes.CatHealthColumn.Relo
            | "init" -> CatTypes.CatHealthColumn.Init
            | "unassign" -> CatTypes.CatHealthColumn.Unassign
            | "unassign.pri" -> CatTypes.CatHealthColumn.UnassignPri
            | "pending_tasks" -> CatTypes.CatHealthColumn.PendingTasks
            | "max_task_wait_time" -> CatTypes.CatHealthColumn.MaxTaskWaitTime
            | "active_shards_percent" -> CatTypes.CatHealthColumn.ActiveShardsPercent
            | other -> CatTypes.CatHealthColumn.Custom other

    type CatIndicesColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatIndicesColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatIndicesColumn.Health -> "health"
                | CatTypes.CatIndicesColumn.Status -> "status"
                | CatTypes.CatIndicesColumn.Index -> "index"
                | CatTypes.CatIndicesColumn.Uuid -> "uuid"
                | CatTypes.CatIndicesColumn.Pri -> "pri"
                | CatTypes.CatIndicesColumn.Rep -> "rep"
                | CatTypes.CatIndicesColumn.DocsCount -> "docs.count"
                | CatTypes.CatIndicesColumn.DocsDeleted -> "docs.deleted"
                | CatTypes.CatIndicesColumn.CreationDate -> "creation.date"
                | CatTypes.CatIndicesColumn.CreationDateString -> "creation.date.string"
                | CatTypes.CatIndicesColumn.StoreSize -> "store.size"
                | CatTypes.CatIndicesColumn.PriStoreSize -> "pri.store.size"
                | CatTypes.CatIndicesColumn.DatasetSize -> "dataset.size"
                | CatTypes.CatIndicesColumn.CompletionSize -> "completion.size"
                | CatTypes.CatIndicesColumn.PriCompletionSize -> "pri.completion.size"
                | CatTypes.CatIndicesColumn.FielddataMemorySize -> "fielddata.memory_size"
                | CatTypes.CatIndicesColumn.PriFielddataMemorySize -> "pri.fielddata.memory_size"
                | CatTypes.CatIndicesColumn.FielddataEvictions -> "fielddata.evictions"
                | CatTypes.CatIndicesColumn.PriFielddataEvictions -> "pri.fielddata.evictions"
                | CatTypes.CatIndicesColumn.QueryCacheMemorySize -> "query_cache.memory_size"
                | CatTypes.CatIndicesColumn.PriQueryCacheMemorySize -> "pri.query_cache.memory_size"
                | CatTypes.CatIndicesColumn.QueryCacheEvictions -> "query_cache.evictions"
                | CatTypes.CatIndicesColumn.PriQueryCacheEvictions -> "pri.query_cache.evictions"
                | CatTypes.CatIndicesColumn.RequestCacheMemorySize -> "request_cache.memory_size"
                | CatTypes.CatIndicesColumn.PriRequestCacheMemorySize -> "pri.request_cache.memory_size"
                | CatTypes.CatIndicesColumn.RequestCacheEvictions -> "request_cache.evictions"
                | CatTypes.CatIndicesColumn.PriRequestCacheEvictions -> "pri.request_cache.evictions"
                | CatTypes.CatIndicesColumn.RequestCacheHitCount -> "request_cache.hit_count"
                | CatTypes.CatIndicesColumn.PriRequestCacheHitCount -> "pri.request_cache.hit_count"
                | CatTypes.CatIndicesColumn.RequestCacheMissCount -> "request_cache.miss_count"
                | CatTypes.CatIndicesColumn.PriRequestCacheMissCount -> "pri.request_cache.miss_count"
                | CatTypes.CatIndicesColumn.FlushTotal -> "flush.total"
                | CatTypes.CatIndicesColumn.PriFlushTotal -> "pri.flush.total"
                | CatTypes.CatIndicesColumn.FlushTotalTime -> "flush.total_time"
                | CatTypes.CatIndicesColumn.PriFlushTotalTime -> "pri.flush.total_time"
                | CatTypes.CatIndicesColumn.GetCurrent -> "get.current"
                | CatTypes.CatIndicesColumn.PriGetCurrent -> "pri.get.current"
                | CatTypes.CatIndicesColumn.GetTime -> "get.time"
                | CatTypes.CatIndicesColumn.PriGetTime -> "pri.get.time"
                | CatTypes.CatIndicesColumn.GetTotal -> "get.total"
                | CatTypes.CatIndicesColumn.PriGetTotal -> "pri.get.total"
                | CatTypes.CatIndicesColumn.GetExistsTime -> "get.exists_time"
                | CatTypes.CatIndicesColumn.PriGetExistsTime -> "pri.get.exists_time"
                | CatTypes.CatIndicesColumn.GetExistsTotal -> "get.exists_total"
                | CatTypes.CatIndicesColumn.PriGetExistsTotal -> "pri.get.exists_total"
                | CatTypes.CatIndicesColumn.GetMissingTime -> "get.missing_time"
                | CatTypes.CatIndicesColumn.PriGetMissingTime -> "pri.get.missing_time"
                | CatTypes.CatIndicesColumn.GetMissingTotal -> "get.missing_total"
                | CatTypes.CatIndicesColumn.PriGetMissingTotal -> "pri.get.missing_total"
                | CatTypes.CatIndicesColumn.IndexingDeleteCurrent -> "indexing.delete_current"
                | CatTypes.CatIndicesColumn.PriIndexingDeleteCurrent -> "pri.indexing.delete_current"
                | CatTypes.CatIndicesColumn.IndexingDeleteTime -> "indexing.delete_time"
                | CatTypes.CatIndicesColumn.PriIndexingDeleteTime -> "pri.indexing.delete_time"
                | CatTypes.CatIndicesColumn.IndexingDeleteTotal -> "indexing.delete_total"
                | CatTypes.CatIndicesColumn.PriIndexingDeleteTotal -> "pri.indexing.delete_total"
                | CatTypes.CatIndicesColumn.IndexingIndexCurrent -> "indexing.index_current"
                | CatTypes.CatIndicesColumn.PriIndexingIndexCurrent -> "pri.indexing.index_current"
                | CatTypes.CatIndicesColumn.IndexingIndexTime -> "indexing.index_time"
                | CatTypes.CatIndicesColumn.PriIndexingIndexTime -> "pri.indexing.index_time"
                | CatTypes.CatIndicesColumn.IndexingIndexTotal -> "indexing.index_total"
                | CatTypes.CatIndicesColumn.PriIndexingIndexTotal -> "pri.indexing.index_total"
                | CatTypes.CatIndicesColumn.IndexingIndexFailed -> "indexing.index_failed"
                | CatTypes.CatIndicesColumn.PriIndexingIndexFailed -> "pri.indexing.index_failed"
                | CatTypes.CatIndicesColumn.IndexingIndexFailedDueToVersionConflict -> "indexing.index_failed_due_to_version_conflict"
                | CatTypes.CatIndicesColumn.PriIndexingIndexFailedDueToVersionConflict -> "pri.indexing.index_failed_due_to_version_conflict"
                | CatTypes.CatIndicesColumn.MergesCurrent -> "merges.current"
                | CatTypes.CatIndicesColumn.PriMergesCurrent -> "pri.merges.current"
                | CatTypes.CatIndicesColumn.MergesCurrentDocs -> "merges.current_docs"
                | CatTypes.CatIndicesColumn.PriMergesCurrentDocs -> "pri.merges.current_docs"
                | CatTypes.CatIndicesColumn.MergesCurrentSize -> "merges.current_size"
                | CatTypes.CatIndicesColumn.PriMergesCurrentSize -> "pri.merges.current_size"
                | CatTypes.CatIndicesColumn.MergesTotal -> "merges.total"
                | CatTypes.CatIndicesColumn.PriMergesTotal -> "pri.merges.total"
                | CatTypes.CatIndicesColumn.MergesTotalDocs -> "merges.total_docs"
                | CatTypes.CatIndicesColumn.PriMergesTotalDocs -> "pri.merges.total_docs"
                | CatTypes.CatIndicesColumn.MergesTotalSize -> "merges.total_size"
                | CatTypes.CatIndicesColumn.PriMergesTotalSize -> "pri.merges.total_size"
                | CatTypes.CatIndicesColumn.MergesTotalTime -> "merges.total_time"
                | CatTypes.CatIndicesColumn.PriMergesTotalTime -> "pri.merges.total_time"
                | CatTypes.CatIndicesColumn.RefreshTotal -> "refresh.total"
                | CatTypes.CatIndicesColumn.PriRefreshTotal -> "pri.refresh.total"
                | CatTypes.CatIndicesColumn.RefreshTime -> "refresh.time"
                | CatTypes.CatIndicesColumn.PriRefreshTime -> "pri.refresh.time"
                | CatTypes.CatIndicesColumn.RefreshExternalTotal -> "refresh.external_total"
                | CatTypes.CatIndicesColumn.PriRefreshExternalTotal -> "pri.refresh.external_total"
                | CatTypes.CatIndicesColumn.RefreshExternalTime -> "refresh.external_time"
                | CatTypes.CatIndicesColumn.PriRefreshExternalTime -> "pri.refresh.external_time"
                | CatTypes.CatIndicesColumn.RefreshListeners -> "refresh.listeners"
                | CatTypes.CatIndicesColumn.PriRefreshListeners -> "pri.refresh.listeners"
                | CatTypes.CatIndicesColumn.SearchFetchCurrent -> "search.fetch_current"
                | CatTypes.CatIndicesColumn.PriSearchFetchCurrent -> "pri.search.fetch_current"
                | CatTypes.CatIndicesColumn.SearchFetchTime -> "search.fetch_time"
                | CatTypes.CatIndicesColumn.PriSearchFetchTime -> "pri.search.fetch_time"
                | CatTypes.CatIndicesColumn.SearchFetchTotal -> "search.fetch_total"
                | CatTypes.CatIndicesColumn.PriSearchFetchTotal -> "pri.search.fetch_total"
                | CatTypes.CatIndicesColumn.SearchOpenContexts -> "search.open_contexts"
                | CatTypes.CatIndicesColumn.PriSearchOpenContexts -> "pri.search.open_contexts"
                | CatTypes.CatIndicesColumn.SearchQueryCurrent -> "search.query_current"
                | CatTypes.CatIndicesColumn.PriSearchQueryCurrent -> "pri.search.query_current"
                | CatTypes.CatIndicesColumn.SearchQueryTime -> "search.query_time"
                | CatTypes.CatIndicesColumn.PriSearchQueryTime -> "pri.search.query_time"
                | CatTypes.CatIndicesColumn.SearchQueryTotal -> "search.query_total"
                | CatTypes.CatIndicesColumn.PriSearchQueryTotal -> "pri.search.query_total"
                | CatTypes.CatIndicesColumn.SearchScrollCurrent -> "search.scroll_current"
                | CatTypes.CatIndicesColumn.PriSearchScrollCurrent -> "pri.search.scroll_current"
                | CatTypes.CatIndicesColumn.SearchScrollTime -> "search.scroll_time"
                | CatTypes.CatIndicesColumn.PriSearchScrollTime -> "pri.search.scroll_time"
                | CatTypes.CatIndicesColumn.SearchScrollTotal -> "search.scroll_total"
                | CatTypes.CatIndicesColumn.PriSearchScrollTotal -> "pri.search.scroll_total"
                | CatTypes.CatIndicesColumn.SegmentsCount -> "segments.count"
                | CatTypes.CatIndicesColumn.PriSegmentsCount -> "pri.segments.count"
                | CatTypes.CatIndicesColumn.SegmentsMemory -> "segments.memory"
                | CatTypes.CatIndicesColumn.PriSegmentsMemory -> "pri.segments.memory"
                | CatTypes.CatIndicesColumn.SegmentsIndexWriterMemory -> "segments.index_writer_memory"
                | CatTypes.CatIndicesColumn.PriSegmentsIndexWriterMemory -> "pri.segments.index_writer_memory"
                | CatTypes.CatIndicesColumn.SegmentsVersionMapMemory -> "segments.version_map_memory"
                | CatTypes.CatIndicesColumn.PriSegmentsVersionMapMemory -> "pri.segments.version_map_memory"
                | CatTypes.CatIndicesColumn.SegmentsFixedBitsetMemory -> "segments.fixed_bitset_memory"
                | CatTypes.CatIndicesColumn.PriSegmentsFixedBitsetMemory -> "pri.segments.fixed_bitset_memory"
                | CatTypes.CatIndicesColumn.WarmerCurrent -> "warmer.current"
                | CatTypes.CatIndicesColumn.PriWarmerCurrent -> "pri.warmer.current"
                | CatTypes.CatIndicesColumn.WarmerTotal -> "warmer.total"
                | CatTypes.CatIndicesColumn.PriWarmerTotal -> "pri.warmer.total"
                | CatTypes.CatIndicesColumn.WarmerTotalTime -> "warmer.total_time"
                | CatTypes.CatIndicesColumn.PriWarmerTotalTime -> "pri.warmer.total_time"
                | CatTypes.CatIndicesColumn.SuggestCurrent -> "suggest.current"
                | CatTypes.CatIndicesColumn.PriSuggestCurrent -> "pri.suggest.current"
                | CatTypes.CatIndicesColumn.SuggestTime -> "suggest.time"
                | CatTypes.CatIndicesColumn.PriSuggestTime -> "pri.suggest.time"
                | CatTypes.CatIndicesColumn.SuggestTotal -> "suggest.total"
                | CatTypes.CatIndicesColumn.PriSuggestTotal -> "pri.suggest.total"
                | CatTypes.CatIndicesColumn.MemoryTotal -> "memory.total"
                | CatTypes.CatIndicesColumn.PriMemoryTotal -> "pri.memory.total"
                | CatTypes.CatIndicesColumn.BulkTotalOperations -> "bulk.total_operations"
                | CatTypes.CatIndicesColumn.PriBulkTotalOperations -> "pri.bulk.total_operations"
                | CatTypes.CatIndicesColumn.BulkTotalTime -> "bulk.total_time"
                | CatTypes.CatIndicesColumn.PriBulkTotalTime -> "pri.bulk.total_time"
                | CatTypes.CatIndicesColumn.BulkTotalSizeInBytes -> "bulk.total_size_in_bytes"
                | CatTypes.CatIndicesColumn.PriBulkTotalSizeInBytes -> "pri.bulk.total_size_in_bytes"
                | CatTypes.CatIndicesColumn.BulkAvgTime -> "bulk.avg_time"
                | CatTypes.CatIndicesColumn.PriBulkAvgTime -> "pri.bulk.avg_time"
                | CatTypes.CatIndicesColumn.BulkAvgSizeInBytes -> "bulk.avg_size_in_bytes"
                | CatTypes.CatIndicesColumn.PriBulkAvgSizeInBytes -> "pri.bulk.avg_size_in_bytes"
                | CatTypes.CatIndicesColumn.DenseVectorValueCount -> "dense_vector.value_count"
                | CatTypes.CatIndicesColumn.PriDenseVectorValueCount -> "pri.dense_vector.value_count"
                | CatTypes.CatIndicesColumn.SparseVectorValueCount -> "sparse_vector.value_count"
                | CatTypes.CatIndicesColumn.PriSparseVectorValueCount -> "pri.sparse_vector.value_count"
                | CatTypes.CatIndicesColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "health" -> CatTypes.CatIndicesColumn.Health
            | "status" -> CatTypes.CatIndicesColumn.Status
            | "index" -> CatTypes.CatIndicesColumn.Index
            | "uuid" -> CatTypes.CatIndicesColumn.Uuid
            | "pri" -> CatTypes.CatIndicesColumn.Pri
            | "rep" -> CatTypes.CatIndicesColumn.Rep
            | "docs.count" -> CatTypes.CatIndicesColumn.DocsCount
            | "docs.deleted" -> CatTypes.CatIndicesColumn.DocsDeleted
            | "creation.date" -> CatTypes.CatIndicesColumn.CreationDate
            | "creation.date.string" -> CatTypes.CatIndicesColumn.CreationDateString
            | "store.size" -> CatTypes.CatIndicesColumn.StoreSize
            | "pri.store.size" -> CatTypes.CatIndicesColumn.PriStoreSize
            | "dataset.size" -> CatTypes.CatIndicesColumn.DatasetSize
            | "completion.size" -> CatTypes.CatIndicesColumn.CompletionSize
            | "pri.completion.size" -> CatTypes.CatIndicesColumn.PriCompletionSize
            | "fielddata.memory_size" -> CatTypes.CatIndicesColumn.FielddataMemorySize
            | "pri.fielddata.memory_size" -> CatTypes.CatIndicesColumn.PriFielddataMemorySize
            | "fielddata.evictions" -> CatTypes.CatIndicesColumn.FielddataEvictions
            | "pri.fielddata.evictions" -> CatTypes.CatIndicesColumn.PriFielddataEvictions
            | "query_cache.memory_size" -> CatTypes.CatIndicesColumn.QueryCacheMemorySize
            | "pri.query_cache.memory_size" -> CatTypes.CatIndicesColumn.PriQueryCacheMemorySize
            | "query_cache.evictions" -> CatTypes.CatIndicesColumn.QueryCacheEvictions
            | "pri.query_cache.evictions" -> CatTypes.CatIndicesColumn.PriQueryCacheEvictions
            | "request_cache.memory_size" -> CatTypes.CatIndicesColumn.RequestCacheMemorySize
            | "pri.request_cache.memory_size" -> CatTypes.CatIndicesColumn.PriRequestCacheMemorySize
            | "request_cache.evictions" -> CatTypes.CatIndicesColumn.RequestCacheEvictions
            | "pri.request_cache.evictions" -> CatTypes.CatIndicesColumn.PriRequestCacheEvictions
            | "request_cache.hit_count" -> CatTypes.CatIndicesColumn.RequestCacheHitCount
            | "pri.request_cache.hit_count" -> CatTypes.CatIndicesColumn.PriRequestCacheHitCount
            | "request_cache.miss_count" -> CatTypes.CatIndicesColumn.RequestCacheMissCount
            | "pri.request_cache.miss_count" -> CatTypes.CatIndicesColumn.PriRequestCacheMissCount
            | "flush.total" -> CatTypes.CatIndicesColumn.FlushTotal
            | "pri.flush.total" -> CatTypes.CatIndicesColumn.PriFlushTotal
            | "flush.total_time" -> CatTypes.CatIndicesColumn.FlushTotalTime
            | "pri.flush.total_time" -> CatTypes.CatIndicesColumn.PriFlushTotalTime
            | "get.current" -> CatTypes.CatIndicesColumn.GetCurrent
            | "pri.get.current" -> CatTypes.CatIndicesColumn.PriGetCurrent
            | "get.time" -> CatTypes.CatIndicesColumn.GetTime
            | "pri.get.time" -> CatTypes.CatIndicesColumn.PriGetTime
            | "get.total" -> CatTypes.CatIndicesColumn.GetTotal
            | "pri.get.total" -> CatTypes.CatIndicesColumn.PriGetTotal
            | "get.exists_time" -> CatTypes.CatIndicesColumn.GetExistsTime
            | "pri.get.exists_time" -> CatTypes.CatIndicesColumn.PriGetExistsTime
            | "get.exists_total" -> CatTypes.CatIndicesColumn.GetExistsTotal
            | "pri.get.exists_total" -> CatTypes.CatIndicesColumn.PriGetExistsTotal
            | "get.missing_time" -> CatTypes.CatIndicesColumn.GetMissingTime
            | "pri.get.missing_time" -> CatTypes.CatIndicesColumn.PriGetMissingTime
            | "get.missing_total" -> CatTypes.CatIndicesColumn.GetMissingTotal
            | "pri.get.missing_total" -> CatTypes.CatIndicesColumn.PriGetMissingTotal
            | "indexing.delete_current" -> CatTypes.CatIndicesColumn.IndexingDeleteCurrent
            | "pri.indexing.delete_current" -> CatTypes.CatIndicesColumn.PriIndexingDeleteCurrent
            | "indexing.delete_time" -> CatTypes.CatIndicesColumn.IndexingDeleteTime
            | "pri.indexing.delete_time" -> CatTypes.CatIndicesColumn.PriIndexingDeleteTime
            | "indexing.delete_total" -> CatTypes.CatIndicesColumn.IndexingDeleteTotal
            | "pri.indexing.delete_total" -> CatTypes.CatIndicesColumn.PriIndexingDeleteTotal
            | "indexing.index_current" -> CatTypes.CatIndicesColumn.IndexingIndexCurrent
            | "pri.indexing.index_current" -> CatTypes.CatIndicesColumn.PriIndexingIndexCurrent
            | "indexing.index_time" -> CatTypes.CatIndicesColumn.IndexingIndexTime
            | "pri.indexing.index_time" -> CatTypes.CatIndicesColumn.PriIndexingIndexTime
            | "indexing.index_total" -> CatTypes.CatIndicesColumn.IndexingIndexTotal
            | "pri.indexing.index_total" -> CatTypes.CatIndicesColumn.PriIndexingIndexTotal
            | "indexing.index_failed" -> CatTypes.CatIndicesColumn.IndexingIndexFailed
            | "pri.indexing.index_failed" -> CatTypes.CatIndicesColumn.PriIndexingIndexFailed
            | "indexing.index_failed_due_to_version_conflict" -> CatTypes.CatIndicesColumn.IndexingIndexFailedDueToVersionConflict
            | "pri.indexing.index_failed_due_to_version_conflict" -> CatTypes.CatIndicesColumn.PriIndexingIndexFailedDueToVersionConflict
            | "merges.current" -> CatTypes.CatIndicesColumn.MergesCurrent
            | "pri.merges.current" -> CatTypes.CatIndicesColumn.PriMergesCurrent
            | "merges.current_docs" -> CatTypes.CatIndicesColumn.MergesCurrentDocs
            | "pri.merges.current_docs" -> CatTypes.CatIndicesColumn.PriMergesCurrentDocs
            | "merges.current_size" -> CatTypes.CatIndicesColumn.MergesCurrentSize
            | "pri.merges.current_size" -> CatTypes.CatIndicesColumn.PriMergesCurrentSize
            | "merges.total" -> CatTypes.CatIndicesColumn.MergesTotal
            | "pri.merges.total" -> CatTypes.CatIndicesColumn.PriMergesTotal
            | "merges.total_docs" -> CatTypes.CatIndicesColumn.MergesTotalDocs
            | "pri.merges.total_docs" -> CatTypes.CatIndicesColumn.PriMergesTotalDocs
            | "merges.total_size" -> CatTypes.CatIndicesColumn.MergesTotalSize
            | "pri.merges.total_size" -> CatTypes.CatIndicesColumn.PriMergesTotalSize
            | "merges.total_time" -> CatTypes.CatIndicesColumn.MergesTotalTime
            | "pri.merges.total_time" -> CatTypes.CatIndicesColumn.PriMergesTotalTime
            | "refresh.total" -> CatTypes.CatIndicesColumn.RefreshTotal
            | "pri.refresh.total" -> CatTypes.CatIndicesColumn.PriRefreshTotal
            | "refresh.time" -> CatTypes.CatIndicesColumn.RefreshTime
            | "pri.refresh.time" -> CatTypes.CatIndicesColumn.PriRefreshTime
            | "refresh.external_total" -> CatTypes.CatIndicesColumn.RefreshExternalTotal
            | "pri.refresh.external_total" -> CatTypes.CatIndicesColumn.PriRefreshExternalTotal
            | "refresh.external_time" -> CatTypes.CatIndicesColumn.RefreshExternalTime
            | "pri.refresh.external_time" -> CatTypes.CatIndicesColumn.PriRefreshExternalTime
            | "refresh.listeners" -> CatTypes.CatIndicesColumn.RefreshListeners
            | "pri.refresh.listeners" -> CatTypes.CatIndicesColumn.PriRefreshListeners
            | "search.fetch_current" -> CatTypes.CatIndicesColumn.SearchFetchCurrent
            | "pri.search.fetch_current" -> CatTypes.CatIndicesColumn.PriSearchFetchCurrent
            | "search.fetch_time" -> CatTypes.CatIndicesColumn.SearchFetchTime
            | "pri.search.fetch_time" -> CatTypes.CatIndicesColumn.PriSearchFetchTime
            | "search.fetch_total" -> CatTypes.CatIndicesColumn.SearchFetchTotal
            | "pri.search.fetch_total" -> CatTypes.CatIndicesColumn.PriSearchFetchTotal
            | "search.open_contexts" -> CatTypes.CatIndicesColumn.SearchOpenContexts
            | "pri.search.open_contexts" -> CatTypes.CatIndicesColumn.PriSearchOpenContexts
            | "search.query_current" -> CatTypes.CatIndicesColumn.SearchQueryCurrent
            | "pri.search.query_current" -> CatTypes.CatIndicesColumn.PriSearchQueryCurrent
            | "search.query_time" -> CatTypes.CatIndicesColumn.SearchQueryTime
            | "pri.search.query_time" -> CatTypes.CatIndicesColumn.PriSearchQueryTime
            | "search.query_total" -> CatTypes.CatIndicesColumn.SearchQueryTotal
            | "pri.search.query_total" -> CatTypes.CatIndicesColumn.PriSearchQueryTotal
            | "search.scroll_current" -> CatTypes.CatIndicesColumn.SearchScrollCurrent
            | "pri.search.scroll_current" -> CatTypes.CatIndicesColumn.PriSearchScrollCurrent
            | "search.scroll_time" -> CatTypes.CatIndicesColumn.SearchScrollTime
            | "pri.search.scroll_time" -> CatTypes.CatIndicesColumn.PriSearchScrollTime
            | "search.scroll_total" -> CatTypes.CatIndicesColumn.SearchScrollTotal
            | "pri.search.scroll_total" -> CatTypes.CatIndicesColumn.PriSearchScrollTotal
            | "segments.count" -> CatTypes.CatIndicesColumn.SegmentsCount
            | "pri.segments.count" -> CatTypes.CatIndicesColumn.PriSegmentsCount
            | "segments.memory" -> CatTypes.CatIndicesColumn.SegmentsMemory
            | "pri.segments.memory" -> CatTypes.CatIndicesColumn.PriSegmentsMemory
            | "segments.index_writer_memory" -> CatTypes.CatIndicesColumn.SegmentsIndexWriterMemory
            | "pri.segments.index_writer_memory" -> CatTypes.CatIndicesColumn.PriSegmentsIndexWriterMemory
            | "segments.version_map_memory" -> CatTypes.CatIndicesColumn.SegmentsVersionMapMemory
            | "pri.segments.version_map_memory" -> CatTypes.CatIndicesColumn.PriSegmentsVersionMapMemory
            | "segments.fixed_bitset_memory" -> CatTypes.CatIndicesColumn.SegmentsFixedBitsetMemory
            | "pri.segments.fixed_bitset_memory" -> CatTypes.CatIndicesColumn.PriSegmentsFixedBitsetMemory
            | "warmer.current" -> CatTypes.CatIndicesColumn.WarmerCurrent
            | "pri.warmer.current" -> CatTypes.CatIndicesColumn.PriWarmerCurrent
            | "warmer.total" -> CatTypes.CatIndicesColumn.WarmerTotal
            | "pri.warmer.total" -> CatTypes.CatIndicesColumn.PriWarmerTotal
            | "warmer.total_time" -> CatTypes.CatIndicesColumn.WarmerTotalTime
            | "pri.warmer.total_time" -> CatTypes.CatIndicesColumn.PriWarmerTotalTime
            | "suggest.current" -> CatTypes.CatIndicesColumn.SuggestCurrent
            | "pri.suggest.current" -> CatTypes.CatIndicesColumn.PriSuggestCurrent
            | "suggest.time" -> CatTypes.CatIndicesColumn.SuggestTime
            | "pri.suggest.time" -> CatTypes.CatIndicesColumn.PriSuggestTime
            | "suggest.total" -> CatTypes.CatIndicesColumn.SuggestTotal
            | "pri.suggest.total" -> CatTypes.CatIndicesColumn.PriSuggestTotal
            | "memory.total" -> CatTypes.CatIndicesColumn.MemoryTotal
            | "pri.memory.total" -> CatTypes.CatIndicesColumn.PriMemoryTotal
            | "bulk.total_operations" -> CatTypes.CatIndicesColumn.BulkTotalOperations
            | "pri.bulk.total_operations" -> CatTypes.CatIndicesColumn.PriBulkTotalOperations
            | "bulk.total_time" -> CatTypes.CatIndicesColumn.BulkTotalTime
            | "pri.bulk.total_time" -> CatTypes.CatIndicesColumn.PriBulkTotalTime
            | "bulk.total_size_in_bytes" -> CatTypes.CatIndicesColumn.BulkTotalSizeInBytes
            | "pri.bulk.total_size_in_bytes" -> CatTypes.CatIndicesColumn.PriBulkTotalSizeInBytes
            | "bulk.avg_time" -> CatTypes.CatIndicesColumn.BulkAvgTime
            | "pri.bulk.avg_time" -> CatTypes.CatIndicesColumn.PriBulkAvgTime
            | "bulk.avg_size_in_bytes" -> CatTypes.CatIndicesColumn.BulkAvgSizeInBytes
            | "pri.bulk.avg_size_in_bytes" -> CatTypes.CatIndicesColumn.PriBulkAvgSizeInBytes
            | "dense_vector.value_count" -> CatTypes.CatIndicesColumn.DenseVectorValueCount
            | "pri.dense_vector.value_count" -> CatTypes.CatIndicesColumn.PriDenseVectorValueCount
            | "sparse_vector.value_count" -> CatTypes.CatIndicesColumn.SparseVectorValueCount
            | "pri.sparse_vector.value_count" -> CatTypes.CatIndicesColumn.PriSparseVectorValueCount
            | other -> CatTypes.CatIndicesColumn.Custom other

    type CatMasterColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatMasterColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatMasterColumn.Id -> "id"
                | CatTypes.CatMasterColumn.Host -> "host"
                | CatTypes.CatMasterColumn.Ip -> "ip"
                | CatTypes.CatMasterColumn.Node -> "node"
                | CatTypes.CatMasterColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatTypes.CatMasterColumn.Id
            | "host" -> CatTypes.CatMasterColumn.Host
            | "ip" -> CatTypes.CatMasterColumn.Ip
            | "node" -> CatTypes.CatMasterColumn.Node
            | other -> CatTypes.CatMasterColumn.Custom other

    type CatNodeColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatNodeColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatNodeColumn.Build -> "build"
                | CatTypes.CatNodeColumn.CompletionSize -> "completion.size"
                | CatTypes.CatNodeColumn.Cpu -> "cpu"
                | CatTypes.CatNodeColumn.DiskAvail -> "disk.avail"
                | CatTypes.CatNodeColumn.DiskTotal -> "disk.total"
                | CatTypes.CatNodeColumn.DiskUsed -> "disk.used"
                | CatTypes.CatNodeColumn.DiskUsedPercent -> "disk.used_percent"
                | CatTypes.CatNodeColumn.FielddataEvictions -> "fielddata.evictions"
                | CatTypes.CatNodeColumn.FielddataMemorySize -> "fielddata.memory_size"
                | CatTypes.CatNodeColumn.FileDescCurrent -> "file_desc.current"
                | CatTypes.CatNodeColumn.FileDescMax -> "file_desc.max"
                | CatTypes.CatNodeColumn.FileDescPercent -> "file_desc.percent"
                | CatTypes.CatNodeColumn.FlushTotal -> "flush.total"
                | CatTypes.CatNodeColumn.FlushTotalTime -> "flush.total_time"
                | CatTypes.CatNodeColumn.GetCurrent -> "get.current"
                | CatTypes.CatNodeColumn.GetExistsTime -> "get.exists_time"
                | CatTypes.CatNodeColumn.GetExistsTotal -> "get.exists_total"
                | CatTypes.CatNodeColumn.GetMissingTime -> "get.missing_time"
                | CatTypes.CatNodeColumn.GetMissingTotal -> "get.missing_total"
                | CatTypes.CatNodeColumn.GetTime -> "get.time"
                | CatTypes.CatNodeColumn.GetTotal -> "get.total"
                | CatTypes.CatNodeColumn.HeapCurrent -> "heap.current"
                | CatTypes.CatNodeColumn.HeapMax -> "heap.max"
                | CatTypes.CatNodeColumn.HeapPercent -> "heap.percent"
                | CatTypes.CatNodeColumn.HttpAddress -> "http_address"
                | CatTypes.CatNodeColumn.Id -> "id"
                | CatTypes.CatNodeColumn.IndexingDeleteCurrent -> "indexing.delete_current"
                | CatTypes.CatNodeColumn.IndexingDeleteTime -> "indexing.delete_time"
                | CatTypes.CatNodeColumn.IndexingDeleteTotal -> "indexing.delete_total"
                | CatTypes.CatNodeColumn.IndexingIndexCurrent -> "indexing.index_current"
                | CatTypes.CatNodeColumn.IndexingIndexFailed -> "indexing.index_failed"
                | CatTypes.CatNodeColumn.IndexingIndexFailedDueToVersionConflict -> "indexing.index_failed_due_to_version_conflict"
                | CatTypes.CatNodeColumn.IndexingIndexTime -> "indexing.index_time"
                | CatTypes.CatNodeColumn.IndexingIndexTotal -> "indexing.index_total"
                | CatTypes.CatNodeColumn.Ip -> "ip"
                | CatTypes.CatNodeColumn.Jdk -> "jdk"
                | CatTypes.CatNodeColumn.Load1m -> "load_1m"
                | CatTypes.CatNodeColumn.Load5m -> "load_5m"
                | CatTypes.CatNodeColumn.Load15m -> "load_15m"
                | CatTypes.CatNodeColumn.AvailableProcessors -> "available_processors"
                | CatTypes.CatNodeColumn.MappingsTotalCount -> "mappings.total_count"
                | CatTypes.CatNodeColumn.MappingsTotalEstimatedOverheadInBytes -> "mappings.total_estimated_overhead_in_bytes"
                | CatTypes.CatNodeColumn.Master -> "master"
                | CatTypes.CatNodeColumn.MergesCurrent -> "merges.current"
                | CatTypes.CatNodeColumn.MergesCurrentDocs -> "merges.current_docs"
                | CatTypes.CatNodeColumn.MergesCurrentSize -> "merges.current_size"
                | CatTypes.CatNodeColumn.MergesTotal -> "merges.total"
                | CatTypes.CatNodeColumn.MergesTotalDocs -> "merges.total_docs"
                | CatTypes.CatNodeColumn.MergesTotalSize -> "merges.total_size"
                | CatTypes.CatNodeColumn.MergesTotalTime -> "merges.total_time"
                | CatTypes.CatNodeColumn.Name -> "name"
                | CatTypes.CatNodeColumn.NodeRole -> "node.role"
                | CatTypes.CatNodeColumn.Pid -> "pid"
                | CatTypes.CatNodeColumn.Port -> "port"
                | CatTypes.CatNodeColumn.QueryCacheMemorySize -> "query_cache.memory_size"
                | CatTypes.CatNodeColumn.QueryCacheEvictions -> "query_cache.evictions"
                | CatTypes.CatNodeColumn.QueryCacheHitCount -> "query_cache.hit_count"
                | CatTypes.CatNodeColumn.QueryCacheMissCount -> "query_cache.miss_count"
                | CatTypes.CatNodeColumn.RamCurrent -> "ram.current"
                | CatTypes.CatNodeColumn.RamMax -> "ram.max"
                | CatTypes.CatNodeColumn.RamPercent -> "ram.percent"
                | CatTypes.CatNodeColumn.RefreshTotal -> "refresh.total"
                | CatTypes.CatNodeColumn.RefreshTime -> "refresh.time"
                | CatTypes.CatNodeColumn.RequestCacheMemorySize -> "request_cache.memory_size"
                | CatTypes.CatNodeColumn.RequestCacheEvictions -> "request_cache.evictions"
                | CatTypes.CatNodeColumn.RequestCacheHitCount -> "request_cache.hit_count"
                | CatTypes.CatNodeColumn.RequestCacheMissCount -> "request_cache.miss_count"
                | CatTypes.CatNodeColumn.ScriptCompilations -> "script.compilations"
                | CatTypes.CatNodeColumn.ScriptCacheEvictions -> "script.cache_evictions"
                | CatTypes.CatNodeColumn.SearchFetchCurrent -> "search.fetch_current"
                | CatTypes.CatNodeColumn.SearchFetchTime -> "search.fetch_time"
                | CatTypes.CatNodeColumn.SearchFetchTotal -> "search.fetch_total"
                | CatTypes.CatNodeColumn.SearchOpenContexts -> "search.open_contexts"
                | CatTypes.CatNodeColumn.SearchQueryCurrent -> "search.query_current"
                | CatTypes.CatNodeColumn.SearchQueryTime -> "search.query_time"
                | CatTypes.CatNodeColumn.SearchQueryTotal -> "search.query_total"
                | CatTypes.CatNodeColumn.SearchScrollCurrent -> "search.scroll_current"
                | CatTypes.CatNodeColumn.SearchScrollTime -> "search.scroll_time"
                | CatTypes.CatNodeColumn.SearchScrollTotal -> "search.scroll_total"
                | CatTypes.CatNodeColumn.SegmentsCount -> "segments.count"
                | CatTypes.CatNodeColumn.SegmentsFixedBitsetMemory -> "segments.fixed_bitset_memory"
                | CatTypes.CatNodeColumn.SegmentsIndexWriterMemory -> "segments.index_writer_memory"
                | CatTypes.CatNodeColumn.SegmentsMemory -> "segments.memory"
                | CatTypes.CatNodeColumn.SegmentsVersionMapMemory -> "segments.version_map_memory"
                | CatTypes.CatNodeColumn.ShardStatsTotalCount -> "shard_stats.total_count"
                | CatTypes.CatNodeColumn.SuggestCurrent -> "suggest.current"
                | CatTypes.CatNodeColumn.SuggestTime -> "suggest.time"
                | CatTypes.CatNodeColumn.SuggestTotal -> "suggest.total"
                | CatTypes.CatNodeColumn.Uptime -> "uptime"
                | CatTypes.CatNodeColumn.Version -> "version"
                | CatTypes.CatNodeColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "build" -> CatTypes.CatNodeColumn.Build
            | "completion.size" -> CatTypes.CatNodeColumn.CompletionSize
            | "cpu" -> CatTypes.CatNodeColumn.Cpu
            | "disk.avail" -> CatTypes.CatNodeColumn.DiskAvail
            | "disk.total" -> CatTypes.CatNodeColumn.DiskTotal
            | "disk.used" -> CatTypes.CatNodeColumn.DiskUsed
            | "disk.used_percent" -> CatTypes.CatNodeColumn.DiskUsedPercent
            | "fielddata.evictions" -> CatTypes.CatNodeColumn.FielddataEvictions
            | "fielddata.memory_size" -> CatTypes.CatNodeColumn.FielddataMemorySize
            | "file_desc.current" -> CatTypes.CatNodeColumn.FileDescCurrent
            | "file_desc.max" -> CatTypes.CatNodeColumn.FileDescMax
            | "file_desc.percent" -> CatTypes.CatNodeColumn.FileDescPercent
            | "flush.total" -> CatTypes.CatNodeColumn.FlushTotal
            | "flush.total_time" -> CatTypes.CatNodeColumn.FlushTotalTime
            | "get.current" -> CatTypes.CatNodeColumn.GetCurrent
            | "get.exists_time" -> CatTypes.CatNodeColumn.GetExistsTime
            | "get.exists_total" -> CatTypes.CatNodeColumn.GetExistsTotal
            | "get.missing_time" -> CatTypes.CatNodeColumn.GetMissingTime
            | "get.missing_total" -> CatTypes.CatNodeColumn.GetMissingTotal
            | "get.time" -> CatTypes.CatNodeColumn.GetTime
            | "get.total" -> CatTypes.CatNodeColumn.GetTotal
            | "heap.current" -> CatTypes.CatNodeColumn.HeapCurrent
            | "heap.max" -> CatTypes.CatNodeColumn.HeapMax
            | "heap.percent" -> CatTypes.CatNodeColumn.HeapPercent
            | "http_address" -> CatTypes.CatNodeColumn.HttpAddress
            | "id" -> CatTypes.CatNodeColumn.Id
            | "indexing.delete_current" -> CatTypes.CatNodeColumn.IndexingDeleteCurrent
            | "indexing.delete_time" -> CatTypes.CatNodeColumn.IndexingDeleteTime
            | "indexing.delete_total" -> CatTypes.CatNodeColumn.IndexingDeleteTotal
            | "indexing.index_current" -> CatTypes.CatNodeColumn.IndexingIndexCurrent
            | "indexing.index_failed" -> CatTypes.CatNodeColumn.IndexingIndexFailed
            | "indexing.index_failed_due_to_version_conflict" -> CatTypes.CatNodeColumn.IndexingIndexFailedDueToVersionConflict
            | "indexing.index_time" -> CatTypes.CatNodeColumn.IndexingIndexTime
            | "indexing.index_total" -> CatTypes.CatNodeColumn.IndexingIndexTotal
            | "ip" -> CatTypes.CatNodeColumn.Ip
            | "jdk" -> CatTypes.CatNodeColumn.Jdk
            | "load_1m" -> CatTypes.CatNodeColumn.Load1m
            | "load_5m" -> CatTypes.CatNodeColumn.Load5m
            | "load_15m" -> CatTypes.CatNodeColumn.Load15m
            | "available_processors" -> CatTypes.CatNodeColumn.AvailableProcessors
            | "mappings.total_count" -> CatTypes.CatNodeColumn.MappingsTotalCount
            | "mappings.total_estimated_overhead_in_bytes" -> CatTypes.CatNodeColumn.MappingsTotalEstimatedOverheadInBytes
            | "master" -> CatTypes.CatNodeColumn.Master
            | "merges.current" -> CatTypes.CatNodeColumn.MergesCurrent
            | "merges.current_docs" -> CatTypes.CatNodeColumn.MergesCurrentDocs
            | "merges.current_size" -> CatTypes.CatNodeColumn.MergesCurrentSize
            | "merges.total" -> CatTypes.CatNodeColumn.MergesTotal
            | "merges.total_docs" -> CatTypes.CatNodeColumn.MergesTotalDocs
            | "merges.total_size" -> CatTypes.CatNodeColumn.MergesTotalSize
            | "merges.total_time" -> CatTypes.CatNodeColumn.MergesTotalTime
            | "name" -> CatTypes.CatNodeColumn.Name
            | "node.role" -> CatTypes.CatNodeColumn.NodeRole
            | "pid" -> CatTypes.CatNodeColumn.Pid
            | "port" -> CatTypes.CatNodeColumn.Port
            | "query_cache.memory_size" -> CatTypes.CatNodeColumn.QueryCacheMemorySize
            | "query_cache.evictions" -> CatTypes.CatNodeColumn.QueryCacheEvictions
            | "query_cache.hit_count" -> CatTypes.CatNodeColumn.QueryCacheHitCount
            | "query_cache.miss_count" -> CatTypes.CatNodeColumn.QueryCacheMissCount
            | "ram.current" -> CatTypes.CatNodeColumn.RamCurrent
            | "ram.max" -> CatTypes.CatNodeColumn.RamMax
            | "ram.percent" -> CatTypes.CatNodeColumn.RamPercent
            | "refresh.total" -> CatTypes.CatNodeColumn.RefreshTotal
            | "refresh.time" -> CatTypes.CatNodeColumn.RefreshTime
            | "request_cache.memory_size" -> CatTypes.CatNodeColumn.RequestCacheMemorySize
            | "request_cache.evictions" -> CatTypes.CatNodeColumn.RequestCacheEvictions
            | "request_cache.hit_count" -> CatTypes.CatNodeColumn.RequestCacheHitCount
            | "request_cache.miss_count" -> CatTypes.CatNodeColumn.RequestCacheMissCount
            | "script.compilations" -> CatTypes.CatNodeColumn.ScriptCompilations
            | "script.cache_evictions" -> CatTypes.CatNodeColumn.ScriptCacheEvictions
            | "search.fetch_current" -> CatTypes.CatNodeColumn.SearchFetchCurrent
            | "search.fetch_time" -> CatTypes.CatNodeColumn.SearchFetchTime
            | "search.fetch_total" -> CatTypes.CatNodeColumn.SearchFetchTotal
            | "search.open_contexts" -> CatTypes.CatNodeColumn.SearchOpenContexts
            | "search.query_current" -> CatTypes.CatNodeColumn.SearchQueryCurrent
            | "search.query_time" -> CatTypes.CatNodeColumn.SearchQueryTime
            | "search.query_total" -> CatTypes.CatNodeColumn.SearchQueryTotal
            | "search.scroll_current" -> CatTypes.CatNodeColumn.SearchScrollCurrent
            | "search.scroll_time" -> CatTypes.CatNodeColumn.SearchScrollTime
            | "search.scroll_total" -> CatTypes.CatNodeColumn.SearchScrollTotal
            | "segments.count" -> CatTypes.CatNodeColumn.SegmentsCount
            | "segments.fixed_bitset_memory" -> CatTypes.CatNodeColumn.SegmentsFixedBitsetMemory
            | "segments.index_writer_memory" -> CatTypes.CatNodeColumn.SegmentsIndexWriterMemory
            | "segments.memory" -> CatTypes.CatNodeColumn.SegmentsMemory
            | "segments.version_map_memory" -> CatTypes.CatNodeColumn.SegmentsVersionMapMemory
            | "shard_stats.total_count" -> CatTypes.CatNodeColumn.ShardStatsTotalCount
            | "suggest.current" -> CatTypes.CatNodeColumn.SuggestCurrent
            | "suggest.time" -> CatTypes.CatNodeColumn.SuggestTime
            | "suggest.total" -> CatTypes.CatNodeColumn.SuggestTotal
            | "uptime" -> CatTypes.CatNodeColumn.Uptime
            | "version" -> CatTypes.CatNodeColumn.Version
            | other -> CatTypes.CatNodeColumn.Custom other

    type CatNodeattrsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatNodeattrsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatNodeattrsColumn.Node -> "node"
                | CatTypes.CatNodeattrsColumn.Id -> "id"
                | CatTypes.CatNodeattrsColumn.Pid -> "pid"
                | CatTypes.CatNodeattrsColumn.Host -> "host"
                | CatTypes.CatNodeattrsColumn.Ip -> "ip"
                | CatTypes.CatNodeattrsColumn.Port -> "port"
                | CatTypes.CatNodeattrsColumn.Attr -> "attr"
                | CatTypes.CatNodeattrsColumn.Value -> "value"
                | CatTypes.CatNodeattrsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "node" -> CatTypes.CatNodeattrsColumn.Node
            | "id" -> CatTypes.CatNodeattrsColumn.Id
            | "pid" -> CatTypes.CatNodeattrsColumn.Pid
            | "host" -> CatTypes.CatNodeattrsColumn.Host
            | "ip" -> CatTypes.CatNodeattrsColumn.Ip
            | "port" -> CatTypes.CatNodeattrsColumn.Port
            | "attr" -> CatTypes.CatNodeattrsColumn.Attr
            | "value" -> CatTypes.CatNodeattrsColumn.Value
            | other -> CatTypes.CatNodeattrsColumn.Custom other

    type CatPendingTasksColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatPendingTasksColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatPendingTasksColumn.InsertOrder -> "insertOrder"
                | CatTypes.CatPendingTasksColumn.TimeInQueue -> "timeInQueue"
                | CatTypes.CatPendingTasksColumn.Priority -> "priority"
                | CatTypes.CatPendingTasksColumn.Source -> "source"
                | CatTypes.CatPendingTasksColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "insertOrder" -> CatTypes.CatPendingTasksColumn.InsertOrder
            | "timeInQueue" -> CatTypes.CatPendingTasksColumn.TimeInQueue
            | "priority" -> CatTypes.CatPendingTasksColumn.Priority
            | "source" -> CatTypes.CatPendingTasksColumn.Source
            | other -> CatTypes.CatPendingTasksColumn.Custom other

    type CatPluginsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatPluginsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatPluginsColumn.Id -> "id"
                | CatTypes.CatPluginsColumn.Name -> "name"
                | CatTypes.CatPluginsColumn.Component -> "component"
                | CatTypes.CatPluginsColumn.Version -> "version"
                | CatTypes.CatPluginsColumn.Description -> "description"
                | CatTypes.CatPluginsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatTypes.CatPluginsColumn.Id
            | "name" -> CatTypes.CatPluginsColumn.Name
            | "component" -> CatTypes.CatPluginsColumn.Component
            | "version" -> CatTypes.CatPluginsColumn.Version
            | "description" -> CatTypes.CatPluginsColumn.Description
            | other -> CatTypes.CatPluginsColumn.Custom other

    type CatRecoveryColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatRecoveryColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatRecoveryColumn.Index -> "index"
                | CatTypes.CatRecoveryColumn.Shard -> "shard"
                | CatTypes.CatRecoveryColumn.StartTime -> "start_time"
                | CatTypes.CatRecoveryColumn.StartTimeMillis -> "start_time_millis"
                | CatTypes.CatRecoveryColumn.StopTime -> "stop_time"
                | CatTypes.CatRecoveryColumn.StopTimeMillis -> "stop_time_millis"
                | CatTypes.CatRecoveryColumn.Time -> "time"
                | CatTypes.CatRecoveryColumn.Type -> "type"
                | CatTypes.CatRecoveryColumn.Stage -> "stage"
                | CatTypes.CatRecoveryColumn.SourceHost -> "source_host"
                | CatTypes.CatRecoveryColumn.SourceNode -> "source_node"
                | CatTypes.CatRecoveryColumn.TargetHost -> "target_host"
                | CatTypes.CatRecoveryColumn.TargetNode -> "target_node"
                | CatTypes.CatRecoveryColumn.Repository -> "repository"
                | CatTypes.CatRecoveryColumn.Snapshot -> "snapshot"
                | CatTypes.CatRecoveryColumn.Files -> "files"
                | CatTypes.CatRecoveryColumn.FilesRecovered -> "files_recovered"
                | CatTypes.CatRecoveryColumn.FilesPercent -> "files_percent"
                | CatTypes.CatRecoveryColumn.FilesTotal -> "files_total"
                | CatTypes.CatRecoveryColumn.Bytes -> "bytes"
                | CatTypes.CatRecoveryColumn.BytesRecovered -> "bytes_recovered"
                | CatTypes.CatRecoveryColumn.BytesPercent -> "bytes_percent"
                | CatTypes.CatRecoveryColumn.BytesTotal -> "bytes_total"
                | CatTypes.CatRecoveryColumn.TranslogOps -> "translog_ops"
                | CatTypes.CatRecoveryColumn.TranslogOpsRecovered -> "translog_ops_recovered"
                | CatTypes.CatRecoveryColumn.TranslogOpsPercent -> "translog_ops_percent"
                | CatTypes.CatRecoveryColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> CatTypes.CatRecoveryColumn.Index
            | "shard" -> CatTypes.CatRecoveryColumn.Shard
            | "start_time" -> CatTypes.CatRecoveryColumn.StartTime
            | "start_time_millis" -> CatTypes.CatRecoveryColumn.StartTimeMillis
            | "stop_time" -> CatTypes.CatRecoveryColumn.StopTime
            | "stop_time_millis" -> CatTypes.CatRecoveryColumn.StopTimeMillis
            | "time" -> CatTypes.CatRecoveryColumn.Time
            | "type" -> CatTypes.CatRecoveryColumn.Type
            | "stage" -> CatTypes.CatRecoveryColumn.Stage
            | "source_host" -> CatTypes.CatRecoveryColumn.SourceHost
            | "source_node" -> CatTypes.CatRecoveryColumn.SourceNode
            | "target_host" -> CatTypes.CatRecoveryColumn.TargetHost
            | "target_node" -> CatTypes.CatRecoveryColumn.TargetNode
            | "repository" -> CatTypes.CatRecoveryColumn.Repository
            | "snapshot" -> CatTypes.CatRecoveryColumn.Snapshot
            | "files" -> CatTypes.CatRecoveryColumn.Files
            | "files_recovered" -> CatTypes.CatRecoveryColumn.FilesRecovered
            | "files_percent" -> CatTypes.CatRecoveryColumn.FilesPercent
            | "files_total" -> CatTypes.CatRecoveryColumn.FilesTotal
            | "bytes" -> CatTypes.CatRecoveryColumn.Bytes
            | "bytes_recovered" -> CatTypes.CatRecoveryColumn.BytesRecovered
            | "bytes_percent" -> CatTypes.CatRecoveryColumn.BytesPercent
            | "bytes_total" -> CatTypes.CatRecoveryColumn.BytesTotal
            | "translog_ops" -> CatTypes.CatRecoveryColumn.TranslogOps
            | "translog_ops_recovered" -> CatTypes.CatRecoveryColumn.TranslogOpsRecovered
            | "translog_ops_percent" -> CatTypes.CatRecoveryColumn.TranslogOpsPercent
            | other -> CatTypes.CatRecoveryColumn.Custom other

    type CatSegmentsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatSegmentsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatSegmentsColumn.Index -> "index"
                | CatTypes.CatSegmentsColumn.Shard -> "shard"
                | CatTypes.CatSegmentsColumn.Prirep -> "prirep"
                | CatTypes.CatSegmentsColumn.Ip -> "ip"
                | CatTypes.CatSegmentsColumn.Segment -> "segment"
                | CatTypes.CatSegmentsColumn.Generation -> "generation"
                | CatTypes.CatSegmentsColumn.DocsCount -> "docs.count"
                | CatTypes.CatSegmentsColumn.DocsDeleted -> "docs.deleted"
                | CatTypes.CatSegmentsColumn.Size -> "size"
                | CatTypes.CatSegmentsColumn.SizeMemory -> "size.memory"
                | CatTypes.CatSegmentsColumn.Committed -> "committed"
                | CatTypes.CatSegmentsColumn.Searchable -> "searchable"
                | CatTypes.CatSegmentsColumn.Version -> "version"
                | CatTypes.CatSegmentsColumn.Compound -> "compound"
                | CatTypes.CatSegmentsColumn.Id -> "id"
                | CatTypes.CatSegmentsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> CatTypes.CatSegmentsColumn.Index
            | "shard" -> CatTypes.CatSegmentsColumn.Shard
            | "prirep" -> CatTypes.CatSegmentsColumn.Prirep
            | "ip" -> CatTypes.CatSegmentsColumn.Ip
            | "segment" -> CatTypes.CatSegmentsColumn.Segment
            | "generation" -> CatTypes.CatSegmentsColumn.Generation
            | "docs.count" -> CatTypes.CatSegmentsColumn.DocsCount
            | "docs.deleted" -> CatTypes.CatSegmentsColumn.DocsDeleted
            | "size" -> CatTypes.CatSegmentsColumn.Size
            | "size.memory" -> CatTypes.CatSegmentsColumn.SizeMemory
            | "committed" -> CatTypes.CatSegmentsColumn.Committed
            | "searchable" -> CatTypes.CatSegmentsColumn.Searchable
            | "version" -> CatTypes.CatSegmentsColumn.Version
            | "compound" -> CatTypes.CatSegmentsColumn.Compound
            | "id" -> CatTypes.CatSegmentsColumn.Id
            | other -> CatTypes.CatSegmentsColumn.Custom other

    type CatShardColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatShardColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatShardColumn.CompletionSize -> "completion.size"
                | CatTypes.CatShardColumn.DatasetSize -> "dataset.size"
                | CatTypes.CatShardColumn.DenseVectorValueCount -> "dense_vector.value_count"
                | CatTypes.CatShardColumn.Docs -> "docs"
                | CatTypes.CatShardColumn.FielddataEvictions -> "fielddata.evictions"
                | CatTypes.CatShardColumn.FielddataMemorySize -> "fielddata.memory_size"
                | CatTypes.CatShardColumn.FlushTotal -> "flush.total"
                | CatTypes.CatShardColumn.FlushTotalTime -> "flush.total_time"
                | CatTypes.CatShardColumn.GetCurrent -> "get.current"
                | CatTypes.CatShardColumn.GetExistsTime -> "get.exists_time"
                | CatTypes.CatShardColumn.GetExistsTotal -> "get.exists_total"
                | CatTypes.CatShardColumn.GetMissingTime -> "get.missing_time"
                | CatTypes.CatShardColumn.GetMissingTotal -> "get.missing_total"
                | CatTypes.CatShardColumn.GetTime -> "get.time"
                | CatTypes.CatShardColumn.GetTotal -> "get.total"
                | CatTypes.CatShardColumn.Id -> "id"
                | CatTypes.CatShardColumn.Index -> "index"
                | CatTypes.CatShardColumn.IndexingDeleteCurrent -> "indexing.delete_current"
                | CatTypes.CatShardColumn.IndexingDeleteTime -> "indexing.delete_time"
                | CatTypes.CatShardColumn.IndexingDeleteTotal -> "indexing.delete_total"
                | CatTypes.CatShardColumn.IndexingIndexCurrent -> "indexing.index_current"
                | CatTypes.CatShardColumn.IndexingIndexFailedDueToVersionConflict -> "indexing.index_failed_due_to_version_conflict"
                | CatTypes.CatShardColumn.IndexingIndexFailed -> "indexing.index_failed"
                | CatTypes.CatShardColumn.IndexingIndexTime -> "indexing.index_time"
                | CatTypes.CatShardColumn.IndexingIndexTotal -> "indexing.index_total"
                | CatTypes.CatShardColumn.Ip -> "ip"
                | CatTypes.CatShardColumn.MergesCurrent -> "merges.current"
                | CatTypes.CatShardColumn.MergesCurrentDocs -> "merges.current_docs"
                | CatTypes.CatShardColumn.MergesCurrentSize -> "merges.current_size"
                | CatTypes.CatShardColumn.MergesTotal -> "merges.total"
                | CatTypes.CatShardColumn.MergesTotalDocs -> "merges.total_docs"
                | CatTypes.CatShardColumn.MergesTotalSize -> "merges.total_size"
                | CatTypes.CatShardColumn.MergesTotalTime -> "merges.total_time"
                | CatTypes.CatShardColumn.Node -> "node"
                | CatTypes.CatShardColumn.Prirep -> "prirep"
                | CatTypes.CatShardColumn.QueryCacheEvictions -> "query_cache.evictions"
                | CatTypes.CatShardColumn.QueryCacheMemorySize -> "query_cache.memory_size"
                | CatTypes.CatShardColumn.RecoverysourceType -> "recoverysource.type"
                | CatTypes.CatShardColumn.RefreshTime -> "refresh.time"
                | CatTypes.CatShardColumn.RefreshTotal -> "refresh.total"
                | CatTypes.CatShardColumn.SearchFetchCurrent -> "search.fetch_current"
                | CatTypes.CatShardColumn.SearchFetchTime -> "search.fetch_time"
                | CatTypes.CatShardColumn.SearchFetchTotal -> "search.fetch_total"
                | CatTypes.CatShardColumn.SearchOpenContexts -> "search.open_contexts"
                | CatTypes.CatShardColumn.SearchQueryCurrent -> "search.query_current"
                | CatTypes.CatShardColumn.SearchQueryTime -> "search.query_time"
                | CatTypes.CatShardColumn.SearchQueryTotal -> "search.query_total"
                | CatTypes.CatShardColumn.SearchScrollCurrent -> "search.scroll_current"
                | CatTypes.CatShardColumn.SearchScrollTime -> "search.scroll_time"
                | CatTypes.CatShardColumn.SearchScrollTotal -> "search.scroll_total"
                | CatTypes.CatShardColumn.SegmentsCount -> "segments.count"
                | CatTypes.CatShardColumn.SegmentsFixedBitsetMemory -> "segments.fixed_bitset_memory"
                | CatTypes.CatShardColumn.SegmentsIndexWriterMemory -> "segments.index_writer_memory"
                | CatTypes.CatShardColumn.SegmentsMemory -> "segments.memory"
                | CatTypes.CatShardColumn.SegmentsVersionMapMemory -> "segments.version_map_memory"
                | CatTypes.CatShardColumn.SeqNoGlobalCheckpoint -> "seq_no.global_checkpoint"
                | CatTypes.CatShardColumn.SeqNoLocalCheckpoint -> "seq_no.local_checkpoint"
                | CatTypes.CatShardColumn.SeqNoMax -> "seq_no.max"
                | CatTypes.CatShardColumn.Shard -> "shard"
                | CatTypes.CatShardColumn.DsparseVectorValueCount -> "dsparse_vector.value_count"
                | CatTypes.CatShardColumn.State -> "state"
                | CatTypes.CatShardColumn.Store -> "store"
                | CatTypes.CatShardColumn.SuggestCurrent -> "suggest.current"
                | CatTypes.CatShardColumn.SuggestTime -> "suggest.time"
                | CatTypes.CatShardColumn.SuggestTotal -> "suggest.total"
                | CatTypes.CatShardColumn.SyncId -> "sync_id"
                | CatTypes.CatShardColumn.UnassignedAt -> "unassigned.at"
                | CatTypes.CatShardColumn.UnassignedDetails -> "unassigned.details"
                | CatTypes.CatShardColumn.UnassignedFor -> "unassigned.for"
                | CatTypes.CatShardColumn.UnassignedReason -> "unassigned.reason"
                | CatTypes.CatShardColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion.size" -> CatTypes.CatShardColumn.CompletionSize
            | "dataset.size" -> CatTypes.CatShardColumn.DatasetSize
            | "dense_vector.value_count" -> CatTypes.CatShardColumn.DenseVectorValueCount
            | "docs" -> CatTypes.CatShardColumn.Docs
            | "fielddata.evictions" -> CatTypes.CatShardColumn.FielddataEvictions
            | "fielddata.memory_size" -> CatTypes.CatShardColumn.FielddataMemorySize
            | "flush.total" -> CatTypes.CatShardColumn.FlushTotal
            | "flush.total_time" -> CatTypes.CatShardColumn.FlushTotalTime
            | "get.current" -> CatTypes.CatShardColumn.GetCurrent
            | "get.exists_time" -> CatTypes.CatShardColumn.GetExistsTime
            | "get.exists_total" -> CatTypes.CatShardColumn.GetExistsTotal
            | "get.missing_time" -> CatTypes.CatShardColumn.GetMissingTime
            | "get.missing_total" -> CatTypes.CatShardColumn.GetMissingTotal
            | "get.time" -> CatTypes.CatShardColumn.GetTime
            | "get.total" -> CatTypes.CatShardColumn.GetTotal
            | "id" -> CatTypes.CatShardColumn.Id
            | "index" -> CatTypes.CatShardColumn.Index
            | "indexing.delete_current" -> CatTypes.CatShardColumn.IndexingDeleteCurrent
            | "indexing.delete_time" -> CatTypes.CatShardColumn.IndexingDeleteTime
            | "indexing.delete_total" -> CatTypes.CatShardColumn.IndexingDeleteTotal
            | "indexing.index_current" -> CatTypes.CatShardColumn.IndexingIndexCurrent
            | "indexing.index_failed_due_to_version_conflict" -> CatTypes.CatShardColumn.IndexingIndexFailedDueToVersionConflict
            | "indexing.index_failed" -> CatTypes.CatShardColumn.IndexingIndexFailed
            | "indexing.index_time" -> CatTypes.CatShardColumn.IndexingIndexTime
            | "indexing.index_total" -> CatTypes.CatShardColumn.IndexingIndexTotal
            | "ip" -> CatTypes.CatShardColumn.Ip
            | "merges.current" -> CatTypes.CatShardColumn.MergesCurrent
            | "merges.current_docs" -> CatTypes.CatShardColumn.MergesCurrentDocs
            | "merges.current_size" -> CatTypes.CatShardColumn.MergesCurrentSize
            | "merges.total" -> CatTypes.CatShardColumn.MergesTotal
            | "merges.total_docs" -> CatTypes.CatShardColumn.MergesTotalDocs
            | "merges.total_size" -> CatTypes.CatShardColumn.MergesTotalSize
            | "merges.total_time" -> CatTypes.CatShardColumn.MergesTotalTime
            | "node" -> CatTypes.CatShardColumn.Node
            | "prirep" -> CatTypes.CatShardColumn.Prirep
            | "query_cache.evictions" -> CatTypes.CatShardColumn.QueryCacheEvictions
            | "query_cache.memory_size" -> CatTypes.CatShardColumn.QueryCacheMemorySize
            | "recoverysource.type" -> CatTypes.CatShardColumn.RecoverysourceType
            | "refresh.time" -> CatTypes.CatShardColumn.RefreshTime
            | "refresh.total" -> CatTypes.CatShardColumn.RefreshTotal
            | "search.fetch_current" -> CatTypes.CatShardColumn.SearchFetchCurrent
            | "search.fetch_time" -> CatTypes.CatShardColumn.SearchFetchTime
            | "search.fetch_total" -> CatTypes.CatShardColumn.SearchFetchTotal
            | "search.open_contexts" -> CatTypes.CatShardColumn.SearchOpenContexts
            | "search.query_current" -> CatTypes.CatShardColumn.SearchQueryCurrent
            | "search.query_time" -> CatTypes.CatShardColumn.SearchQueryTime
            | "search.query_total" -> CatTypes.CatShardColumn.SearchQueryTotal
            | "search.scroll_current" -> CatTypes.CatShardColumn.SearchScrollCurrent
            | "search.scroll_time" -> CatTypes.CatShardColumn.SearchScrollTime
            | "search.scroll_total" -> CatTypes.CatShardColumn.SearchScrollTotal
            | "segments.count" -> CatTypes.CatShardColumn.SegmentsCount
            | "segments.fixed_bitset_memory" -> CatTypes.CatShardColumn.SegmentsFixedBitsetMemory
            | "segments.index_writer_memory" -> CatTypes.CatShardColumn.SegmentsIndexWriterMemory
            | "segments.memory" -> CatTypes.CatShardColumn.SegmentsMemory
            | "segments.version_map_memory" -> CatTypes.CatShardColumn.SegmentsVersionMapMemory
            | "seq_no.global_checkpoint" -> CatTypes.CatShardColumn.SeqNoGlobalCheckpoint
            | "seq_no.local_checkpoint" -> CatTypes.CatShardColumn.SeqNoLocalCheckpoint
            | "seq_no.max" -> CatTypes.CatShardColumn.SeqNoMax
            | "shard" -> CatTypes.CatShardColumn.Shard
            | "dsparse_vector.value_count" -> CatTypes.CatShardColumn.DsparseVectorValueCount
            | "state" -> CatTypes.CatShardColumn.State
            | "store" -> CatTypes.CatShardColumn.Store
            | "suggest.current" -> CatTypes.CatShardColumn.SuggestCurrent
            | "suggest.time" -> CatTypes.CatShardColumn.SuggestTime
            | "suggest.total" -> CatTypes.CatShardColumn.SuggestTotal
            | "sync_id" -> CatTypes.CatShardColumn.SyncId
            | "unassigned.at" -> CatTypes.CatShardColumn.UnassignedAt
            | "unassigned.details" -> CatTypes.CatShardColumn.UnassignedDetails
            | "unassigned.for" -> CatTypes.CatShardColumn.UnassignedFor
            | "unassigned.reason" -> CatTypes.CatShardColumn.UnassignedReason
            | other -> CatTypes.CatShardColumn.Custom other

    type CatSnapshotsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatSnapshotsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatSnapshotsColumn.Id -> "id"
                | CatTypes.CatSnapshotsColumn.Repository -> "repository"
                | CatTypes.CatSnapshotsColumn.Status -> "status"
                | CatTypes.CatSnapshotsColumn.StartEpoch -> "start_epoch"
                | CatTypes.CatSnapshotsColumn.StartTime -> "start_time"
                | CatTypes.CatSnapshotsColumn.EndEpoch -> "end_epoch"
                | CatTypes.CatSnapshotsColumn.EndTime -> "end_time"
                | CatTypes.CatSnapshotsColumn.Duration -> "duration"
                | CatTypes.CatSnapshotsColumn.Indices -> "indices"
                | CatTypes.CatSnapshotsColumn.SuccessfulShards -> "successful_shards"
                | CatTypes.CatSnapshotsColumn.FailedShards -> "failed_shards"
                | CatTypes.CatSnapshotsColumn.TotalShards -> "total_shards"
                | CatTypes.CatSnapshotsColumn.Reason -> "reason"
                | CatTypes.CatSnapshotsColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatTypes.CatSnapshotsColumn.Id
            | "repository" -> CatTypes.CatSnapshotsColumn.Repository
            | "status" -> CatTypes.CatSnapshotsColumn.Status
            | "start_epoch" -> CatTypes.CatSnapshotsColumn.StartEpoch
            | "start_time" -> CatTypes.CatSnapshotsColumn.StartTime
            | "end_epoch" -> CatTypes.CatSnapshotsColumn.EndEpoch
            | "end_time" -> CatTypes.CatSnapshotsColumn.EndTime
            | "duration" -> CatTypes.CatSnapshotsColumn.Duration
            | "indices" -> CatTypes.CatSnapshotsColumn.Indices
            | "successful_shards" -> CatTypes.CatSnapshotsColumn.SuccessfulShards
            | "failed_shards" -> CatTypes.CatSnapshotsColumn.FailedShards
            | "total_shards" -> CatTypes.CatSnapshotsColumn.TotalShards
            | "reason" -> CatTypes.CatSnapshotsColumn.Reason
            | other -> CatTypes.CatSnapshotsColumn.Custom other

    type CatTasksColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatTasksColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatTasksColumn.Id -> "id"
                | CatTypes.CatTasksColumn.Action -> "action"
                | CatTypes.CatTasksColumn.TaskId -> "task_id"
                | CatTypes.CatTasksColumn.ParentTaskId -> "parent_task_id"
                | CatTypes.CatTasksColumn.Type -> "type"
                | CatTypes.CatTasksColumn.StartTime -> "start_time"
                | CatTypes.CatTasksColumn.Timestamp -> "timestamp"
                | CatTypes.CatTasksColumn.RunningTimeNs -> "running_time_ns"
                | CatTypes.CatTasksColumn.RunningTime -> "running_time"
                | CatTypes.CatTasksColumn.NodeId -> "node_id"
                | CatTypes.CatTasksColumn.Ip -> "ip"
                | CatTypes.CatTasksColumn.Port -> "port"
                | CatTypes.CatTasksColumn.Node -> "node"
                | CatTypes.CatTasksColumn.Version -> "version"
                | CatTypes.CatTasksColumn.XOpaqueId -> "x_opaque_id"
                | CatTypes.CatTasksColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "id" -> CatTypes.CatTasksColumn.Id
            | "action" -> CatTypes.CatTasksColumn.Action
            | "task_id" -> CatTypes.CatTasksColumn.TaskId
            | "parent_task_id" -> CatTypes.CatTasksColumn.ParentTaskId
            | "type" -> CatTypes.CatTasksColumn.Type
            | "start_time" -> CatTypes.CatTasksColumn.StartTime
            | "timestamp" -> CatTypes.CatTasksColumn.Timestamp
            | "running_time_ns" -> CatTypes.CatTasksColumn.RunningTimeNs
            | "running_time" -> CatTypes.CatTasksColumn.RunningTime
            | "node_id" -> CatTypes.CatTasksColumn.NodeId
            | "ip" -> CatTypes.CatTasksColumn.Ip
            | "port" -> CatTypes.CatTasksColumn.Port
            | "node" -> CatTypes.CatTasksColumn.Node
            | "version" -> CatTypes.CatTasksColumn.Version
            | "x_opaque_id" -> CatTypes.CatTasksColumn.XOpaqueId
            | other -> CatTypes.CatTasksColumn.Custom other

    type CatTemplatesColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatTemplatesColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatTemplatesColumn.Name -> "name"
                | CatTypes.CatTemplatesColumn.IndexPatterns -> "index_patterns"
                | CatTypes.CatTemplatesColumn.Order -> "order"
                | CatTypes.CatTemplatesColumn.Version -> "version"
                | CatTypes.CatTemplatesColumn.ComposedOf -> "composed_of"
                | CatTypes.CatTemplatesColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "name" -> CatTypes.CatTemplatesColumn.Name
            | "index_patterns" -> CatTypes.CatTemplatesColumn.IndexPatterns
            | "order" -> CatTypes.CatTemplatesColumn.Order
            | "version" -> CatTypes.CatTemplatesColumn.Version
            | "composed_of" -> CatTypes.CatTemplatesColumn.ComposedOf
            | other -> CatTypes.CatTemplatesColumn.Custom other

    type CatThreadPoolColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatThreadPoolColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatThreadPoolColumn.Active -> "active"
                | CatTypes.CatThreadPoolColumn.Completed -> "completed"
                | CatTypes.CatThreadPoolColumn.Core -> "core"
                | CatTypes.CatThreadPoolColumn.EphemeralId -> "ephemeral_id"
                | CatTypes.CatThreadPoolColumn.Host -> "host"
                | CatTypes.CatThreadPoolColumn.Ip -> "ip"
                | CatTypes.CatThreadPoolColumn.KeepAlive -> "keep_alive"
                | CatTypes.CatThreadPoolColumn.Largest -> "largest"
                | CatTypes.CatThreadPoolColumn.Max -> "max"
                | CatTypes.CatThreadPoolColumn.Name -> "name"
                | CatTypes.CatThreadPoolColumn.NodeId -> "node_id"
                | CatTypes.CatThreadPoolColumn.NodeName -> "node_name"
                | CatTypes.CatThreadPoolColumn.Pid -> "pid"
                | CatTypes.CatThreadPoolColumn.PoolSize -> "pool_size"
                | CatTypes.CatThreadPoolColumn.Port -> "port"
                | CatTypes.CatThreadPoolColumn.Queue -> "queue"
                | CatTypes.CatThreadPoolColumn.QueueSize -> "queue_size"
                | CatTypes.CatThreadPoolColumn.Rejected -> "rejected"
                | CatTypes.CatThreadPoolColumn.Size -> "size"
                | CatTypes.CatThreadPoolColumn.Type -> "type"
                | CatTypes.CatThreadPoolColumn.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "active" -> CatTypes.CatThreadPoolColumn.Active
            | "completed" -> CatTypes.CatThreadPoolColumn.Completed
            | "core" -> CatTypes.CatThreadPoolColumn.Core
            | "ephemeral_id" -> CatTypes.CatThreadPoolColumn.EphemeralId
            | "host" -> CatTypes.CatThreadPoolColumn.Host
            | "ip" -> CatTypes.CatThreadPoolColumn.Ip
            | "keep_alive" -> CatTypes.CatThreadPoolColumn.KeepAlive
            | "largest" -> CatTypes.CatThreadPoolColumn.Largest
            | "max" -> CatTypes.CatThreadPoolColumn.Max
            | "name" -> CatTypes.CatThreadPoolColumn.Name
            | "node_id" -> CatTypes.CatThreadPoolColumn.NodeId
            | "node_name" -> CatTypes.CatThreadPoolColumn.NodeName
            | "pid" -> CatTypes.CatThreadPoolColumn.Pid
            | "pool_size" -> CatTypes.CatThreadPoolColumn.PoolSize
            | "port" -> CatTypes.CatThreadPoolColumn.Port
            | "queue" -> CatTypes.CatThreadPoolColumn.Queue
            | "queue_size" -> CatTypes.CatThreadPoolColumn.QueueSize
            | "rejected" -> CatTypes.CatThreadPoolColumn.Rejected
            | "size" -> CatTypes.CatThreadPoolColumn.Size
            | "type" -> CatTypes.CatThreadPoolColumn.Type
            | other -> CatTypes.CatThreadPoolColumn.Custom other

    type CatTrainedModelsColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatTrainedModelsColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatTrainedModelsColumn.CreateTime -> "create_time"
                | CatTypes.CatTrainedModelsColumn.CreatedBy -> "created_by"
                | CatTypes.CatTrainedModelsColumn.DataFrameAnalyticsId -> "data_frame_analytics_id"
                | CatTypes.CatTrainedModelsColumn.Description -> "description"
                | CatTypes.CatTrainedModelsColumn.HeapSize -> "heap_size"
                | CatTypes.CatTrainedModelsColumn.Id -> "id"
                | CatTypes.CatTrainedModelsColumn.IngestCount -> "ingest.count"
                | CatTypes.CatTrainedModelsColumn.IngestCurrent -> "ingest.current"
                | CatTypes.CatTrainedModelsColumn.IngestFailed -> "ingest.failed"
                | CatTypes.CatTrainedModelsColumn.IngestPipelines -> "ingest.pipelines"
                | CatTypes.CatTrainedModelsColumn.IngestTime -> "ingest.time"
                | CatTypes.CatTrainedModelsColumn.License -> "license"
                | CatTypes.CatTrainedModelsColumn.Operations -> "operations"
                | CatTypes.CatTrainedModelsColumn.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "create_time" -> CatTypes.CatTrainedModelsColumn.CreateTime
            | "created_by" -> CatTypes.CatTrainedModelsColumn.CreatedBy
            | "data_frame_analytics_id" -> CatTypes.CatTrainedModelsColumn.DataFrameAnalyticsId
            | "description" -> CatTypes.CatTrainedModelsColumn.Description
            | "heap_size" -> CatTypes.CatTrainedModelsColumn.HeapSize
            | "id" -> CatTypes.CatTrainedModelsColumn.Id
            | "ingest.count" -> CatTypes.CatTrainedModelsColumn.IngestCount
            | "ingest.current" -> CatTypes.CatTrainedModelsColumn.IngestCurrent
            | "ingest.failed" -> CatTypes.CatTrainedModelsColumn.IngestFailed
            | "ingest.pipelines" -> CatTypes.CatTrainedModelsColumn.IngestPipelines
            | "ingest.time" -> CatTypes.CatTrainedModelsColumn.IngestTime
            | "license" -> CatTypes.CatTrainedModelsColumn.License
            | "operations" -> CatTypes.CatTrainedModelsColumn.Operations
            | "version" -> CatTypes.CatTrainedModelsColumn.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatTrainedModelsColumn"))

    type CatTransformColumnConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CatTypes.CatTransformColumn>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CatTypes.CatTransformColumn.ChangesLastDetectionTime -> "changes_last_detection_time"
                | CatTypes.CatTransformColumn.Checkpoint -> "checkpoint"
                | CatTypes.CatTransformColumn.CheckpointDurationTimeExpAvg -> "checkpoint_duration_time_exp_avg"
                | CatTypes.CatTransformColumn.CheckpointProgress -> "checkpoint_progress"
                | CatTypes.CatTransformColumn.CreateTime -> "create_time"
                | CatTypes.CatTransformColumn.DeleteTime -> "delete_time"
                | CatTypes.CatTransformColumn.Description -> "description"
                | CatTypes.CatTransformColumn.DestIndex -> "dest_index"
                | CatTypes.CatTransformColumn.DocumentsDeleted -> "documents_deleted"
                | CatTypes.CatTransformColumn.DocumentsIndexed -> "documents_indexed"
                | CatTypes.CatTransformColumn.DocsPerSecond -> "docs_per_second"
                | CatTypes.CatTransformColumn.DocumentsProcessed -> "documents_processed"
                | CatTypes.CatTransformColumn.Frequency -> "frequency"
                | CatTypes.CatTransformColumn.Id -> "id"
                | CatTypes.CatTransformColumn.IndexFailure -> "index_failure"
                | CatTypes.CatTransformColumn.IndexTime -> "index_time"
                | CatTypes.CatTransformColumn.IndexTotal -> "index_total"
                | CatTypes.CatTransformColumn.IndexedDocumentsExpAvg -> "indexed_documents_exp_avg"
                | CatTypes.CatTransformColumn.LastSearchTime -> "last_search_time"
                | CatTypes.CatTransformColumn.MaxPageSearchSize -> "max_page_search_size"
                | CatTypes.CatTransformColumn.PagesProcessed -> "pages_processed"
                | CatTypes.CatTransformColumn.Pipeline -> "pipeline"
                | CatTypes.CatTransformColumn.ProcessedDocumentsExpAvg -> "processed_documents_exp_avg"
                | CatTypes.CatTransformColumn.ProcessingTime -> "processing_time"
                | CatTypes.CatTransformColumn.Reason -> "reason"
                | CatTypes.CatTransformColumn.SearchFailure -> "search_failure"
                | CatTypes.CatTransformColumn.SearchTime -> "search_time"
                | CatTypes.CatTransformColumn.SearchTotal -> "search_total"
                | CatTypes.CatTransformColumn.SourceIndex -> "source_index"
                | CatTypes.CatTransformColumn.State -> "state"
                | CatTypes.CatTransformColumn.TransformType -> "transform_type"
                | CatTypes.CatTransformColumn.TriggerCount -> "trigger_count"
                | CatTypes.CatTransformColumn.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "changes_last_detection_time" -> CatTypes.CatTransformColumn.ChangesLastDetectionTime
            | "checkpoint" -> CatTypes.CatTransformColumn.Checkpoint
            | "checkpoint_duration_time_exp_avg" -> CatTypes.CatTransformColumn.CheckpointDurationTimeExpAvg
            | "checkpoint_progress" -> CatTypes.CatTransformColumn.CheckpointProgress
            | "create_time" -> CatTypes.CatTransformColumn.CreateTime
            | "delete_time" -> CatTypes.CatTransformColumn.DeleteTime
            | "description" -> CatTypes.CatTransformColumn.Description
            | "dest_index" -> CatTypes.CatTransformColumn.DestIndex
            | "documents_deleted" -> CatTypes.CatTransformColumn.DocumentsDeleted
            | "documents_indexed" -> CatTypes.CatTransformColumn.DocumentsIndexed
            | "docs_per_second" -> CatTypes.CatTransformColumn.DocsPerSecond
            | "documents_processed" -> CatTypes.CatTransformColumn.DocumentsProcessed
            | "frequency" -> CatTypes.CatTransformColumn.Frequency
            | "id" -> CatTypes.CatTransformColumn.Id
            | "index_failure" -> CatTypes.CatTransformColumn.IndexFailure
            | "index_time" -> CatTypes.CatTransformColumn.IndexTime
            | "index_total" -> CatTypes.CatTransformColumn.IndexTotal
            | "indexed_documents_exp_avg" -> CatTypes.CatTransformColumn.IndexedDocumentsExpAvg
            | "last_search_time" -> CatTypes.CatTransformColumn.LastSearchTime
            | "max_page_search_size" -> CatTypes.CatTransformColumn.MaxPageSearchSize
            | "pages_processed" -> CatTypes.CatTransformColumn.PagesProcessed
            | "pipeline" -> CatTypes.CatTransformColumn.Pipeline
            | "processed_documents_exp_avg" -> CatTypes.CatTransformColumn.ProcessedDocumentsExpAvg
            | "processing_time" -> CatTypes.CatTransformColumn.ProcessingTime
            | "reason" -> CatTypes.CatTransformColumn.Reason
            | "search_failure" -> CatTypes.CatTransformColumn.SearchFailure
            | "search_time" -> CatTypes.CatTransformColumn.SearchTime
            | "search_total" -> CatTypes.CatTransformColumn.SearchTotal
            | "source_index" -> CatTypes.CatTransformColumn.SourceIndex
            | "state" -> CatTypes.CatTransformColumn.State
            | "transform_type" -> CatTypes.CatTransformColumn.TransformType
            | "trigger_count" -> CatTypes.CatTransformColumn.TriggerCount
            | "version" -> CatTypes.CatTransformColumn.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CatTransformColumn"))

    type FollowerIndexStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<CcrFollowInfo.FollowerIndexStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | CcrFollowInfo.FollowerIndexStatus.Active -> "active"
                | CcrFollowInfo.FollowerIndexStatus.Paused -> "paused"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "active" -> CcrFollowInfo.FollowerIndexStatus.Active
            | "paused" -> CcrFollowInfo.FollowerIndexStatus.Paused
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FollowerIndexStatus"))

    type AllocationExplainDecisionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterAllocationExplain.AllocationExplainDecision>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterAllocationExplain.AllocationExplainDecision.NO -> "NO"
                | ClusterAllocationExplain.AllocationExplainDecision.YES -> "YES"
                | ClusterAllocationExplain.AllocationExplainDecision.THROTTLE -> "THROTTLE"
                | ClusterAllocationExplain.AllocationExplainDecision.ALWAYS -> "ALWAYS"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "NO" -> ClusterAllocationExplain.AllocationExplainDecision.NO
            | "YES" -> ClusterAllocationExplain.AllocationExplainDecision.YES
            | "THROTTLE" -> ClusterAllocationExplain.AllocationExplainDecision.THROTTLE
            | "ALWAYS" -> ClusterAllocationExplain.AllocationExplainDecision.ALWAYS
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AllocationExplainDecision"))

    type DecisionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterAllocationExplain.Decision>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterAllocationExplain.Decision.Yes -> "yes"
                | ClusterAllocationExplain.Decision.No -> "no"
                | ClusterAllocationExplain.Decision.WorseBalance -> "worse_balance"
                | ClusterAllocationExplain.Decision.Throttled -> "throttled"
                | ClusterAllocationExplain.Decision.AwaitingInfo -> "awaiting_info"
                | ClusterAllocationExplain.Decision.AllocationDelayed -> "allocation_delayed"
                | ClusterAllocationExplain.Decision.NoValidShardCopy -> "no_valid_shard_copy"
                | ClusterAllocationExplain.Decision.NoAttempt -> "no_attempt"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "yes" -> ClusterAllocationExplain.Decision.Yes
            | "no" -> ClusterAllocationExplain.Decision.No
            | "worse_balance" -> ClusterAllocationExplain.Decision.WorseBalance
            | "throttled" -> ClusterAllocationExplain.Decision.Throttled
            | "awaiting_info" -> ClusterAllocationExplain.Decision.AwaitingInfo
            | "allocation_delayed" -> ClusterAllocationExplain.Decision.AllocationDelayed
            | "no_valid_shard_copy" -> ClusterAllocationExplain.Decision.NoValidShardCopy
            | "no_attempt" -> ClusterAllocationExplain.Decision.NoAttempt
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Decision"))

    type UnassignedInformationReasonConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterAllocationExplain.UnassignedInformationReason>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterAllocationExplain.UnassignedInformationReason.INDEXCREATED -> "INDEX_CREATED"
                | ClusterAllocationExplain.UnassignedInformationReason.CLUSTERRECOVERED -> "CLUSTER_RECOVERED"
                | ClusterAllocationExplain.UnassignedInformationReason.INDEXREOPENED -> "INDEX_REOPENED"
                | ClusterAllocationExplain.UnassignedInformationReason.DANGLINGINDEXIMPORTED -> "DANGLING_INDEX_IMPORTED"
                | ClusterAllocationExplain.UnassignedInformationReason.NEWINDEXRESTORED -> "NEW_INDEX_RESTORED"
                | ClusterAllocationExplain.UnassignedInformationReason.EXISTINGINDEXRESTORED -> "EXISTING_INDEX_RESTORED"
                | ClusterAllocationExplain.UnassignedInformationReason.REPLICAADDED -> "REPLICA_ADDED"
                | ClusterAllocationExplain.UnassignedInformationReason.ALLOCATIONFAILED -> "ALLOCATION_FAILED"
                | ClusterAllocationExplain.UnassignedInformationReason.NODELEFT -> "NODE_LEFT"
                | ClusterAllocationExplain.UnassignedInformationReason.REROUTECANCELLED -> "REROUTE_CANCELLED"
                | ClusterAllocationExplain.UnassignedInformationReason.REINITIALIZED -> "REINITIALIZED"
                | ClusterAllocationExplain.UnassignedInformationReason.REALLOCATEDREPLICA -> "REALLOCATED_REPLICA"
                | ClusterAllocationExplain.UnassignedInformationReason.PRIMARYFAILED -> "PRIMARY_FAILED"
                | ClusterAllocationExplain.UnassignedInformationReason.FORCEDEMPTYPRIMARY -> "FORCED_EMPTY_PRIMARY"
                | ClusterAllocationExplain.UnassignedInformationReason.MANUALALLOCATION -> "MANUAL_ALLOCATION"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "INDEX_CREATED" -> ClusterAllocationExplain.UnassignedInformationReason.INDEXCREATED
            | "CLUSTER_RECOVERED" -> ClusterAllocationExplain.UnassignedInformationReason.CLUSTERRECOVERED
            | "INDEX_REOPENED" -> ClusterAllocationExplain.UnassignedInformationReason.INDEXREOPENED
            | "DANGLING_INDEX_IMPORTED" -> ClusterAllocationExplain.UnassignedInformationReason.DANGLINGINDEXIMPORTED
            | "NEW_INDEX_RESTORED" -> ClusterAllocationExplain.UnassignedInformationReason.NEWINDEXRESTORED
            | "EXISTING_INDEX_RESTORED" -> ClusterAllocationExplain.UnassignedInformationReason.EXISTINGINDEXRESTORED
            | "REPLICA_ADDED" -> ClusterAllocationExplain.UnassignedInformationReason.REPLICAADDED
            | "ALLOCATION_FAILED" -> ClusterAllocationExplain.UnassignedInformationReason.ALLOCATIONFAILED
            | "NODE_LEFT" -> ClusterAllocationExplain.UnassignedInformationReason.NODELEFT
            | "REROUTE_CANCELLED" -> ClusterAllocationExplain.UnassignedInformationReason.REROUTECANCELLED
            | "REINITIALIZED" -> ClusterAllocationExplain.UnassignedInformationReason.REINITIALIZED
            | "REALLOCATED_REPLICA" -> ClusterAllocationExplain.UnassignedInformationReason.REALLOCATEDREPLICA
            | "PRIMARY_FAILED" -> ClusterAllocationExplain.UnassignedInformationReason.PRIMARYFAILED
            | "FORCED_EMPTY_PRIMARY" -> ClusterAllocationExplain.UnassignedInformationReason.FORCEDEMPTYPRIMARY
            | "MANUAL_ALLOCATION" -> ClusterAllocationExplain.UnassignedInformationReason.MANUALALLOCATION
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for UnassignedInformationReason"))

    type ClusterRemoteInfoConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterRemoteInfo.ClusterRemoteInfo>()

        override _.Write(writer, value, options) =
            match value with
            | ClusterRemoteInfo.ClusterRemoteInfo.ClusterRemoteSniffInfo v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ClusterRemoteInfo.ClusterRemoteInfo.ClusterRemoteProxyInfo v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("mode") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "clusterremotesniffinfo" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<ClusterRemoteInfo.ClusterRemoteSniffInfo>(doc.RootElement.GetRawText(), options)
                ClusterRemoteInfo.ClusterRemoteInfo.ClusterRemoteSniffInfo v
            | "clusterremoteproxyinfo" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<ClusterRemoteInfo.ClusterRemoteProxyInfo>(doc.RootElement.GetRawText(), options)
                ClusterRemoteInfo.ClusterRemoteInfo.ClusterRemoteProxyInfo v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for ClusterRemoteInfo"))

    type ClusterStateMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterState.ClusterStateMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterState.ClusterStateMetric.All -> "_all"
                | ClusterState.ClusterStateMetric.Version -> "version"
                | ClusterState.ClusterStateMetric.MasterNode -> "master_node"
                | ClusterState.ClusterStateMetric.Blocks -> "blocks"
                | ClusterState.ClusterStateMetric.Nodes -> "nodes"
                | ClusterState.ClusterStateMetric.Metadata -> "metadata"
                | ClusterState.ClusterStateMetric.RoutingTable -> "routing_table"
                | ClusterState.ClusterStateMetric.RoutingNodes -> "routing_nodes"
                | ClusterState.ClusterStateMetric.Customs -> "customs"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> ClusterState.ClusterStateMetric.All
            | "version" -> ClusterState.ClusterStateMetric.Version
            | "master_node" -> ClusterState.ClusterStateMetric.MasterNode
            | "blocks" -> ClusterState.ClusterStateMetric.Blocks
            | "nodes" -> ClusterState.ClusterStateMetric.Nodes
            | "metadata" -> ClusterState.ClusterStateMetric.Metadata
            | "routing_table" -> ClusterState.ClusterStateMetric.RoutingTable
            | "routing_nodes" -> ClusterState.ClusterStateMetric.RoutingNodes
            | "customs" -> ClusterState.ClusterStateMetric.Customs
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ClusterStateMetric"))

    type ShardStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterStats.ShardState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterStats.ShardState.INIT -> "INIT"
                | ClusterStats.ShardState.SUCCESS -> "SUCCESS"
                | ClusterStats.ShardState.FAILED -> "FAILED"
                | ClusterStats.ShardState.ABORTED -> "ABORTED"
                | ClusterStats.ShardState.MISSING -> "MISSING"
                | ClusterStats.ShardState.WAITING -> "WAITING"
                | ClusterStats.ShardState.QUEUED -> "QUEUED"
                | ClusterStats.ShardState.PAUSEDFORNODEREMOVAL -> "PAUSED_FOR_NODE_REMOVAL"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "INIT" -> ClusterStats.ShardState.INIT
            | "SUCCESS" -> ClusterStats.ShardState.SUCCESS
            | "FAILED" -> ClusterStats.ShardState.FAILED
            | "ABORTED" -> ClusterStats.ShardState.ABORTED
            | "MISSING" -> ClusterStats.ShardState.MISSING
            | "WAITING" -> ClusterStats.ShardState.WAITING
            | "QUEUED" -> ClusterStats.ShardState.QUEUED
            | "PAUSED_FOR_NODE_REMOVAL" -> ClusterStats.ShardState.PAUSEDFORNODEREMOVAL
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardState"))

    type SortTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ClusterStats.SortType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ClusterStats.SortType.Doc -> "_doc"
                | ClusterStats.SortType.GeoDistance -> "_geo_distance"
                | ClusterStats.SortType.Score -> "_score"
                | ClusterStats.SortType.Script -> "_script"
                | ClusterStats.SortType.FieldSort -> "field_sort"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_doc" -> ClusterStats.SortType.Doc
            | "_geo_distance" -> ClusterStats.SortType.GeoDistance
            | "_score" -> ClusterStats.SortType.Score
            | "_script" -> ClusterStats.SortType.Script
            | "field_sort" -> ClusterStats.SortType.FieldSort
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SortType"))

    type ConnectorFieldTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.ConnectorFieldType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.ConnectorFieldType.Str -> "str"
                | ConnectorTypes.ConnectorFieldType.Int -> "int"
                | ConnectorTypes.ConnectorFieldType.List -> "list"
                | ConnectorTypes.ConnectorFieldType.Bool -> "bool"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "str" -> ConnectorTypes.ConnectorFieldType.Str
            | "int" -> ConnectorTypes.ConnectorFieldType.Int
            | "list" -> ConnectorTypes.ConnectorFieldType.List
            | "bool" -> ConnectorTypes.ConnectorFieldType.Bool
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConnectorFieldType"))

    type ConnectorStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.ConnectorStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.ConnectorStatus.Created -> "created"
                | ConnectorTypes.ConnectorStatus.NeedsConfiguration -> "needs_configuration"
                | ConnectorTypes.ConnectorStatus.Configured -> "configured"
                | ConnectorTypes.ConnectorStatus.Connected -> "connected"
                | ConnectorTypes.ConnectorStatus.Error -> "error"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "created" -> ConnectorTypes.ConnectorStatus.Created
            | "needs_configuration" -> ConnectorTypes.ConnectorStatus.NeedsConfiguration
            | "configured" -> ConnectorTypes.ConnectorStatus.Configured
            | "connected" -> ConnectorTypes.ConnectorStatus.Connected
            | "error" -> ConnectorTypes.ConnectorStatus.Error
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConnectorStatus"))

    type DisplayTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.DisplayType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.DisplayType.Textbox -> "textbox"
                | ConnectorTypes.DisplayType.Textarea -> "textarea"
                | ConnectorTypes.DisplayType.Numeric -> "numeric"
                | ConnectorTypes.DisplayType.Toggle -> "toggle"
                | ConnectorTypes.DisplayType.Dropdown -> "dropdown"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "textbox" -> ConnectorTypes.DisplayType.Textbox
            | "textarea" -> ConnectorTypes.DisplayType.Textarea
            | "numeric" -> ConnectorTypes.DisplayType.Numeric
            | "toggle" -> ConnectorTypes.DisplayType.Toggle
            | "dropdown" -> ConnectorTypes.DisplayType.Dropdown
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DisplayType"))

    type FilteringPolicyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.FilteringPolicy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.FilteringPolicy.Exclude -> "exclude"
                | ConnectorTypes.FilteringPolicy.Include -> "include"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "exclude" -> ConnectorTypes.FilteringPolicy.Exclude
            | "include" -> ConnectorTypes.FilteringPolicy.Include
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilteringPolicy"))

    type FilteringRuleRuleConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.FilteringRuleRule>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.FilteringRuleRule.Contains -> "contains"
                | ConnectorTypes.FilteringRuleRule.EndsWith -> "ends_with"
                | ConnectorTypes.FilteringRuleRule.Equals -> "equals"
                | ConnectorTypes.FilteringRuleRule.Regex -> "regex"
                | ConnectorTypes.FilteringRuleRule.StartsWith -> "starts_with"
                | ConnectorTypes.FilteringRuleRule.Gt -> ">"
                | ConnectorTypes.FilteringRuleRule.Lt -> "<"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "contains" -> ConnectorTypes.FilteringRuleRule.Contains
            | "ends_with" -> ConnectorTypes.FilteringRuleRule.EndsWith
            | "equals" -> ConnectorTypes.FilteringRuleRule.Equals
            | "regex" -> ConnectorTypes.FilteringRuleRule.Regex
            | "starts_with" -> ConnectorTypes.FilteringRuleRule.StartsWith
            | ">" -> ConnectorTypes.FilteringRuleRule.Gt
            | "<" -> ConnectorTypes.FilteringRuleRule.Lt
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilteringRuleRule"))

    type FilteringValidationStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.FilteringValidationState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.FilteringValidationState.Edited -> "edited"
                | ConnectorTypes.FilteringValidationState.Invalid -> "invalid"
                | ConnectorTypes.FilteringValidationState.Valid -> "valid"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "edited" -> ConnectorTypes.FilteringValidationState.Edited
            | "invalid" -> ConnectorTypes.FilteringValidationState.Invalid
            | "valid" -> ConnectorTypes.FilteringValidationState.Valid
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilteringValidationState"))

    type SyncJobTriggerMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.SyncJobTriggerMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.SyncJobTriggerMethod.OnDemand -> "on_demand"
                | ConnectorTypes.SyncJobTriggerMethod.Scheduled -> "scheduled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "on_demand" -> ConnectorTypes.SyncJobTriggerMethod.OnDemand
            | "scheduled" -> ConnectorTypes.SyncJobTriggerMethod.Scheduled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyncJobTriggerMethod"))

    type SyncJobTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.SyncJobType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.SyncJobType.Full -> "full"
                | ConnectorTypes.SyncJobType.Incremental -> "incremental"
                | ConnectorTypes.SyncJobType.AccessControl -> "access_control"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "full" -> ConnectorTypes.SyncJobType.Full
            | "incremental" -> ConnectorTypes.SyncJobType.Incremental
            | "access_control" -> ConnectorTypes.SyncJobType.AccessControl
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyncJobType"))

    type SyncStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.SyncStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ConnectorTypes.SyncStatus.Canceling -> "canceling"
                | ConnectorTypes.SyncStatus.Canceled -> "canceled"
                | ConnectorTypes.SyncStatus.Completed -> "completed"
                | ConnectorTypes.SyncStatus.Error -> "error"
                | ConnectorTypes.SyncStatus.InProgress -> "in_progress"
                | ConnectorTypes.SyncStatus.Pending -> "pending"
                | ConnectorTypes.SyncStatus.Suspended -> "suspended"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "canceling" -> ConnectorTypes.SyncStatus.Canceling
            | "canceled" -> ConnectorTypes.SyncStatus.Canceled
            | "completed" -> ConnectorTypes.SyncStatus.Completed
            | "error" -> ConnectorTypes.SyncStatus.Error
            | "in_progress" -> ConnectorTypes.SyncStatus.InProgress
            | "pending" -> ConnectorTypes.SyncStatus.Pending
            | "suspended" -> ConnectorTypes.SyncStatus.Suspended
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SyncStatus"))

    type ValidationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ConnectorTypes.Validation>()

        override _.Write(writer, value, options) =
            match value with
            | ConnectorTypes.Validation.LessThanValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ConnectorTypes.Validation.GreaterThanValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ConnectorTypes.Validation.ListTypeValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ConnectorTypes.Validation.IncludedInValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | ConnectorTypes.Validation.RegexValidation v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "lessthanvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<ConnectorTypes.LessThanValidation>(doc.RootElement.GetRawText(), options)
                ConnectorTypes.Validation.LessThanValidation v
            | "greaterthanvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<ConnectorTypes.GreaterThanValidation>(doc.RootElement.GetRawText(), options)
                ConnectorTypes.Validation.GreaterThanValidation v
            | "listtypevalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<ConnectorTypes.ListTypeValidation>(doc.RootElement.GetRawText(), options)
                ConnectorTypes.Validation.ListTypeValidation v
            | "includedinvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<ConnectorTypes.IncludedInValidation>(doc.RootElement.GetRawText(), options)
                ConnectorTypes.Validation.IncludedInValidation v
            | "regexvalidation" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<ConnectorTypes.RegexValidation>(doc.RootElement.GetRawText(), options)
                ConnectorTypes.Validation.RegexValidation v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for Validation"))

    type PolicyTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EnrichTypes.PolicyType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EnrichTypes.PolicyType.GeoMatch -> "geo_match"
                | EnrichTypes.PolicyType.Match -> "match"
                | EnrichTypes.PolicyType.Range -> "range"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geo_match" -> EnrichTypes.PolicyType.GeoMatch
            | "match" -> EnrichTypes.PolicyType.Match
            | "range" -> EnrichTypes.PolicyType.Range
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PolicyType"))

    type EnrichPolicyPhaseConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EnrichExecutePolicy.EnrichPolicyPhase>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EnrichExecutePolicy.EnrichPolicyPhase.SCHEDULED -> "SCHEDULED"
                | EnrichExecutePolicy.EnrichPolicyPhase.RUNNING -> "RUNNING"
                | EnrichExecutePolicy.EnrichPolicyPhase.COMPLETE -> "COMPLETE"
                | EnrichExecutePolicy.EnrichPolicyPhase.FAILED -> "FAILED"
                | EnrichExecutePolicy.EnrichPolicyPhase.CANCELLED -> "CANCELLED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "SCHEDULED" -> EnrichExecutePolicy.EnrichPolicyPhase.SCHEDULED
            | "RUNNING" -> EnrichExecutePolicy.EnrichPolicyPhase.RUNNING
            | "COMPLETE" -> EnrichExecutePolicy.EnrichPolicyPhase.COMPLETE
            | "FAILED" -> EnrichExecutePolicy.EnrichPolicyPhase.FAILED
            | "CANCELLED" -> EnrichExecutePolicy.EnrichPolicyPhase.CANCELLED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EnrichPolicyPhase"))

    type ResultPositionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EqlSearch.ResultPosition>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EqlSearch.ResultPosition.Tail -> "tail"
                | EqlSearch.ResultPosition.Head -> "head"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "tail" -> EqlSearch.ResultPosition.Tail
            | "head" -> EqlSearch.ResultPosition.Head
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ResultPosition"))

    type EsqlClusterStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EsqlTypes.EsqlClusterStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EsqlTypes.EsqlClusterStatus.Running -> "running"
                | EsqlTypes.EsqlClusterStatus.Successful -> "successful"
                | EsqlTypes.EsqlClusterStatus.Partial -> "partial"
                | EsqlTypes.EsqlClusterStatus.Skipped -> "skipped"
                | EsqlTypes.EsqlClusterStatus.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "running" -> EsqlTypes.EsqlClusterStatus.Running
            | "successful" -> EsqlTypes.EsqlClusterStatus.Successful
            | "partial" -> EsqlTypes.EsqlClusterStatus.Partial
            | "skipped" -> EsqlTypes.EsqlClusterStatus.Skipped
            | "failed" -> EsqlTypes.EsqlClusterStatus.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EsqlClusterStatus"))

    type EsqlFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EsqlTypes.EsqlFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | EsqlTypes.EsqlFormat.Csv -> "csv"
                | EsqlTypes.EsqlFormat.Json -> "json"
                | EsqlTypes.EsqlFormat.Tsv -> "tsv"
                | EsqlTypes.EsqlFormat.Txt -> "txt"
                | EsqlTypes.EsqlFormat.Yaml -> "yaml"
                | EsqlTypes.EsqlFormat.Cbor -> "cbor"
                | EsqlTypes.EsqlFormat.Smile -> "smile"
                | EsqlTypes.EsqlFormat.Arrow -> "arrow"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "csv" -> EsqlTypes.EsqlFormat.Csv
            | "json" -> EsqlTypes.EsqlFormat.Json
            | "tsv" -> EsqlTypes.EsqlFormat.Tsv
            | "txt" -> EsqlTypes.EsqlFormat.Txt
            | "yaml" -> EsqlTypes.EsqlFormat.Yaml
            | "cbor" -> EsqlTypes.EsqlFormat.Cbor
            | "smile" -> EsqlTypes.EsqlFormat.Smile
            | "arrow" -> EsqlTypes.EsqlFormat.Arrow
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EsqlFormat"))

    type TableValuesContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<EsqlTypes.TableValuesContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | EsqlTypes.TableValuesContainer.Integer v ->
                writer.WritePropertyName("integer")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | EsqlTypes.TableValuesContainer.Keyword v ->
                writer.WritePropertyName("keyword")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | EsqlTypes.TableValuesContainer.Long v ->
                writer.WritePropertyName("long")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | EsqlTypes.TableValuesContainer.Double v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<EsqlTypes.TableValuesIntegerValue list>(ref reader, options)
                    EsqlTypes.TableValuesContainer.Integer v
                | "keyword" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<EsqlTypes.TableValuesKeywordValue list>(ref reader, options)
                    EsqlTypes.TableValuesContainer.Keyword v
                | "long" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<EsqlTypes.TableValuesLongValue list>(ref reader, options)
                    EsqlTypes.TableValuesContainer.Long v
                | "double" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<EsqlTypes.TableValuesLongDouble list>(ref reader, options)
                    EsqlTypes.TableValuesContainer.Double v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TableValuesContainer"))
            reader.Read() |> ignore // EndObject
            result

    type LifecycleExplainConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IlmExplainLifecycle.LifecycleExplain>()

        override _.Write(writer, value, options) =
            match value with
            | IlmExplainLifecycle.LifecycleExplain.LifecycleExplainManaged v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IlmExplainLifecycle.LifecycleExplain.LifecycleExplainUnmanaged v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("managed") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "lifecycleexplainmanaged" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IlmExplainLifecycle.LifecycleExplainManaged>(doc.RootElement.GetRawText(), options)
                IlmExplainLifecycle.LifecycleExplain.LifecycleExplainManaged v
            | "lifecycleexplainunmanaged" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IlmExplainLifecycle.LifecycleExplainUnmanaged>(doc.RootElement.GetRawText(), options)
                IlmExplainLifecycle.LifecycleExplain.LifecycleExplainUnmanaged v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for LifecycleExplain"))

    type IndexCheckOnStartupConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.IndexCheckOnStartup>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.IndexCheckOnStartup.True -> "true"
                | IndicesTypes.IndexCheckOnStartup.False -> "false"
                | IndicesTypes.IndexCheckOnStartup.Checksum -> "checksum"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "true" -> IndicesTypes.IndexCheckOnStartup.True
            | "false" -> IndicesTypes.IndexCheckOnStartup.False
            | "checksum" -> IndicesTypes.IndexCheckOnStartup.Checksum
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexCheckOnStartup"))

    type IndexModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.IndexMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.IndexMode.Standard -> "standard"
                | IndicesTypes.IndexMode.TimeSeries -> "time_series"
                | IndicesTypes.IndexMode.Logsdb -> "logsdb"
                | IndicesTypes.IndexMode.Lookup -> "lookup"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "standard" -> IndicesTypes.IndexMode.Standard
            | "time_series" -> IndicesTypes.IndexMode.TimeSeries
            | "logsdb" -> IndicesTypes.IndexMode.Logsdb
            | "lookup" -> IndicesTypes.IndexMode.Lookup
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexMode"))

    type IndexRoutingAllocationOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.IndexRoutingAllocationOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.IndexRoutingAllocationOptions.All -> "all"
                | IndicesTypes.IndexRoutingAllocationOptions.Primaries -> "primaries"
                | IndicesTypes.IndexRoutingAllocationOptions.NewPrimaries -> "new_primaries"
                | IndicesTypes.IndexRoutingAllocationOptions.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> IndicesTypes.IndexRoutingAllocationOptions.All
            | "primaries" -> IndicesTypes.IndexRoutingAllocationOptions.Primaries
            | "new_primaries" -> IndicesTypes.IndexRoutingAllocationOptions.NewPrimaries
            | "none" -> IndicesTypes.IndexRoutingAllocationOptions.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexRoutingAllocationOptions"))

    type IndexRoutingRebalanceOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.IndexRoutingRebalanceOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.IndexRoutingRebalanceOptions.All -> "all"
                | IndicesTypes.IndexRoutingRebalanceOptions.Primaries -> "primaries"
                | IndicesTypes.IndexRoutingRebalanceOptions.Replicas -> "replicas"
                | IndicesTypes.IndexRoutingRebalanceOptions.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> IndicesTypes.IndexRoutingRebalanceOptions.All
            | "primaries" -> IndicesTypes.IndexRoutingRebalanceOptions.Primaries
            | "replicas" -> IndicesTypes.IndexRoutingRebalanceOptions.Replicas
            | "none" -> IndicesTypes.IndexRoutingRebalanceOptions.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexRoutingRebalanceOptions"))

    type IndicesBlockOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.IndicesBlockOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.IndicesBlockOptions.Metadata -> "metadata"
                | IndicesTypes.IndicesBlockOptions.Read -> "read"
                | IndicesTypes.IndicesBlockOptions.ReadOnly -> "read_only"
                | IndicesTypes.IndicesBlockOptions.Write -> "write"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "metadata" -> IndicesTypes.IndicesBlockOptions.Metadata
            | "read" -> IndicesTypes.IndicesBlockOptions.Read
            | "read_only" -> IndicesTypes.IndicesBlockOptions.ReadOnly
            | "write" -> IndicesTypes.IndicesBlockOptions.Write
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndicesBlockOptions"))

    type ManagedByConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.ManagedBy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.ManagedBy.IndexLifecycleManagement -> "Index Lifecycle Management"
                | IndicesTypes.ManagedBy.DataStreamLifecycle -> "Data stream lifecycle"
                | IndicesTypes.ManagedBy.Unmanaged -> "Unmanaged"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "Index Lifecycle Management" -> IndicesTypes.ManagedBy.IndexLifecycleManagement
            | "Data stream lifecycle" -> IndicesTypes.ManagedBy.DataStreamLifecycle
            | "Unmanaged" -> IndicesTypes.ManagedBy.Unmanaged
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ManagedBy"))

    type NumericFielddataFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.NumericFielddataFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.NumericFielddataFormat.Array -> "array"
                | IndicesTypes.NumericFielddataFormat.Disabled -> "disabled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "array" -> IndicesTypes.NumericFielddataFormat.Array
            | "disabled" -> IndicesTypes.NumericFielddataFormat.Disabled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NumericFielddataFormat"))

    type SamplingMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.SamplingMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.SamplingMethod.Aggregate -> "aggregate"
                | IndicesTypes.SamplingMethod.LastValue -> "last_value"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "aggregate" -> IndicesTypes.SamplingMethod.Aggregate
            | "last_value" -> IndicesTypes.SamplingMethod.LastValue
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SamplingMethod"))

    type SegmentSortMissingConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.SegmentSortMissing>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.SegmentSortMissing.Last -> "_last"
                | IndicesTypes.SegmentSortMissing.First -> "_first"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_last" -> IndicesTypes.SegmentSortMissing.Last
            | "_first" -> IndicesTypes.SegmentSortMissing.First
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SegmentSortMissing"))

    type SegmentSortModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.SegmentSortMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.SegmentSortMode.Min -> "min"
                | IndicesTypes.SegmentSortMode.Max -> "max"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> IndicesTypes.SegmentSortMode.Min
            | "max" -> IndicesTypes.SegmentSortMode.Max
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SegmentSortMode"))

    type SegmentSortOrderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.SegmentSortOrder>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.SegmentSortOrder.Asc -> "asc"
                | IndicesTypes.SegmentSortOrder.Desc -> "desc"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "asc" -> IndicesTypes.SegmentSortOrder.Asc
            | "desc" -> IndicesTypes.SegmentSortOrder.Desc
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SegmentSortOrder"))

    type SettingsSimilarityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.SettingsSimilarity>()

        override _.Write(writer, value, options) =
            match value with
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityBm25 v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityBoolean v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityDfi v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityDfr v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityIb v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityLmd v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityLmj v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.SettingsSimilarityScripted v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesTypes.SettingsSimilarity.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "settingssimilaritybm25" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityBm25>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityBm25 v
            | "settingssimilarityboolean" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityBoolean>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityBoolean v
            | "settingssimilaritydfi" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityDfi>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityDfi v
            | "settingssimilaritydfr" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityDfr>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityDfr v
            | "settingssimilarityib" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityIb>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityIb v
            | "settingssimilaritylmd" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityLmd>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityLmd v
            | "settingssimilaritylmj" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityLmj>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityLmj v
            | "settingssimilarityscripted" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<IndicesTypes.SettingsSimilarityScripted>(doc.RootElement.GetRawText(), options)
                IndicesTypes.SettingsSimilarity.SettingsSimilarityScripted v
            | _ -> IndicesTypes.SettingsSimilarity.Unknown (tagValue, doc.RootElement.Clone())

    type SourceModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.SourceMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.SourceMode.Disabled -> "disabled"
                | IndicesTypes.SourceMode.Stored -> "stored"
                | IndicesTypes.SourceMode.Synthetic -> "synthetic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "disabled" -> IndicesTypes.SourceMode.Disabled
            | "stored" -> IndicesTypes.SourceMode.Stored
            | "synthetic" -> IndicesTypes.SourceMode.Synthetic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SourceMode"))

    type StorageTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.StorageType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.StorageType.Fs -> "fs"
                | IndicesTypes.StorageType.Niofs -> "niofs"
                | IndicesTypes.StorageType.Mmapfs -> "mmapfs"
                | IndicesTypes.StorageType.Hybridfs -> "hybridfs"
                | IndicesTypes.StorageType.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "fs" -> IndicesTypes.StorageType.Fs
            | "niofs" -> IndicesTypes.StorageType.Niofs
            | "mmapfs" -> IndicesTypes.StorageType.Mmapfs
            | "hybridfs" -> IndicesTypes.StorageType.Hybridfs
            | other -> IndicesTypes.StorageType.Custom other

    type TranslogDurabilityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesTypes.TranslogDurability>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesTypes.TranslogDurability.Request -> "request"
                | IndicesTypes.TranslogDurability.Async -> "async"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "request" -> IndicesTypes.TranslogDurability.Request
            | "async" -> IndicesTypes.TranslogDurability.Async
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TranslogDurability"))

    type FeatureConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesGet.Feature>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesGet.Feature.Aliases -> "aliases"
                | IndicesGet.Feature.Mappings -> "mappings"
                | IndicesGet.Feature.Settings -> "settings"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "aliases" -> IndicesGet.Feature.Aliases
            | "mappings" -> IndicesGet.Feature.Mappings
            | "settings" -> IndicesGet.Feature.Settings
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Feature"))

    type ModeEnumConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesMigrateReindex.ModeEnum>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesMigrateReindex.ModeEnum.Upgrade -> "upgrade"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "upgrade" -> IndicesMigrateReindex.ModeEnum.Upgrade
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ModeEnum"))

    type ActionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesModifyDataStream.Action>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IndicesModifyDataStream.Action.AddBackingIndex v ->
                writer.WritePropertyName("add_backing_index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesModifyDataStream.Action.RemoveBackingIndex v ->
                writer.WritePropertyName("remove_backing_index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for Action"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for Action"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "add_backing_index" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IndicesModifyDataStream.IndexAndDataStreamAction>(ref reader, options)
                    IndicesModifyDataStream.Action.AddBackingIndex v
                | "remove_backing_index" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IndicesModifyDataStream.IndexAndDataStreamAction>(ref reader, options)
                    IndicesModifyDataStream.Action.RemoveBackingIndex v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for Action"))
            reader.Read() |> ignore // EndObject
            result

    type RecoveryStageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesRecovery.RecoveryStage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesRecovery.RecoveryStage.INIT -> "INIT"
                | IndicesRecovery.RecoveryStage.INDEX -> "INDEX"
                | IndicesRecovery.RecoveryStage.VERIFYINDEX -> "VERIFY_INDEX"
                | IndicesRecovery.RecoveryStage.TRANSLOG -> "TRANSLOG"
                | IndicesRecovery.RecoveryStage.FINALIZE -> "FINALIZE"
                | IndicesRecovery.RecoveryStage.DONE -> "DONE"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "INIT" -> IndicesRecovery.RecoveryStage.INIT
            | "INDEX" -> IndicesRecovery.RecoveryStage.INDEX
            | "VERIFY_INDEX" -> IndicesRecovery.RecoveryStage.VERIFYINDEX
            | "TRANSLOG" -> IndicesRecovery.RecoveryStage.TRANSLOG
            | "FINALIZE" -> IndicesRecovery.RecoveryStage.FINALIZE
            | "DONE" -> IndicesRecovery.RecoveryStage.DONE
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RecoveryStage"))

    type RecoveryTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesRecovery.RecoveryType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesRecovery.RecoveryType.EMPTYSTORE -> "EMPTY_STORE"
                | IndicesRecovery.RecoveryType.EXISTINGSTORE -> "EXISTING_STORE"
                | IndicesRecovery.RecoveryType.LOCALSHARDS -> "LOCAL_SHARDS"
                | IndicesRecovery.RecoveryType.PEER -> "PEER"
                | IndicesRecovery.RecoveryType.SNAPSHOT -> "SNAPSHOT"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "EMPTY_STORE" -> IndicesRecovery.RecoveryType.EMPTYSTORE
            | "EXISTING_STORE" -> IndicesRecovery.RecoveryType.EXISTINGSTORE
            | "LOCAL_SHARDS" -> IndicesRecovery.RecoveryType.LOCALSHARDS
            | "PEER" -> IndicesRecovery.RecoveryType.PEER
            | "SNAPSHOT" -> IndicesRecovery.RecoveryType.SNAPSHOT
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RecoveryType"))

    type ShardStoreAllocationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesShardStores.ShardStoreAllocation>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesShardStores.ShardStoreAllocation.Primary -> "primary"
                | IndicesShardStores.ShardStoreAllocation.Replica -> "replica"
                | IndicesShardStores.ShardStoreAllocation.Unused -> "unused"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "primary" -> IndicesShardStores.ShardStoreAllocation.Primary
            | "replica" -> IndicesShardStores.ShardStoreAllocation.Replica
            | "unused" -> IndicesShardStores.ShardStoreAllocation.Unused
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardStoreAllocation"))

    type ShardStoreStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesShardStores.ShardStoreStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesShardStores.ShardStoreStatus.Green -> "green"
                | IndicesShardStores.ShardStoreStatus.Yellow -> "yellow"
                | IndicesShardStores.ShardStoreStatus.Red -> "red"
                | IndicesShardStores.ShardStoreStatus.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "green" -> IndicesShardStores.ShardStoreStatus.Green
            | "yellow" -> IndicesShardStores.ShardStoreStatus.Yellow
            | "red" -> IndicesShardStores.ShardStoreStatus.Red
            | "all" -> IndicesShardStores.ShardStoreStatus.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardStoreStatus"))

    type IndexMetadataStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesStats.IndexMetadataState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesStats.IndexMetadataState.Open -> "open"
                | IndicesStats.IndexMetadataState.Close -> "close"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "open" -> IndicesStats.IndexMetadataState.Open
            | "close" -> IndicesStats.IndexMetadataState.Close
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexMetadataState"))

    type ShardRoutingStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesStats.ShardRoutingState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IndicesStats.ShardRoutingState.UNASSIGNED -> "UNASSIGNED"
                | IndicesStats.ShardRoutingState.INITIALIZING -> "INITIALIZING"
                | IndicesStats.ShardRoutingState.STARTED -> "STARTED"
                | IndicesStats.ShardRoutingState.RELOCATING -> "RELOCATING"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "UNASSIGNED" -> IndicesStats.ShardRoutingState.UNASSIGNED
            | "INITIALIZING" -> IndicesStats.ShardRoutingState.INITIALIZING
            | "STARTED" -> IndicesStats.ShardRoutingState.STARTED
            | "RELOCATING" -> IndicesStats.ShardRoutingState.RELOCATING
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardRoutingState"))

    type ActionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IndicesUpdateAliases.Action>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IndicesUpdateAliases.Action.Add v ->
                writer.WritePropertyName("add")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesUpdateAliases.Action.Remove v ->
                writer.WritePropertyName("remove")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IndicesUpdateAliases.Action.RemoveIndex v ->
                writer.WritePropertyName("remove_index")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            writer.WriteEndObject()

        override _.Read(reader, _typeToConvert, options) =
            if reader.TokenType <> System.Text.Json.JsonTokenType.StartObject then
                raise (System.Text.Json.JsonException("Expected StartObject for Action"))
            reader.Read() |> ignore
            if reader.TokenType <> System.Text.Json.JsonTokenType.PropertyName then
                raise (System.Text.Json.JsonException("Expected PropertyName for Action"))
            let propName = reader.GetString()
            reader.Read() |> ignore
            let result =
                match propName with
                | "add" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IndicesUpdateAliases.AddAction>(ref reader, options)
                    IndicesUpdateAliases.Action.Add v
                | "remove" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IndicesUpdateAliases.RemoveAction>(ref reader, options)
                    IndicesUpdateAliases.Action.Remove v
                | "remove_index" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IndicesUpdateAliases.RemoveIndexAction>(ref reader, options)
                    IndicesUpdateAliases.Action.RemoveIndex v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for Action"))
            reader.Read() |> ignore // EndObject
            result

    type Ai21ServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.Ai21ServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.Ai21ServiceType.Ai21 -> "ai21"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ai21" -> InferenceTypes.Ai21ServiceType.Ai21
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Ai21ServiceType"))

    type Ai21TaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.Ai21TaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.Ai21TaskType.Completion -> "completion"
                | InferenceTypes.Ai21TaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.Ai21TaskType.Completion
            | "chat_completion" -> InferenceTypes.Ai21TaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Ai21TaskType"))

    type AlibabaCloudServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AlibabaCloudServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AlibabaCloudServiceType.AlibabacloudAiSearch -> "alibabacloud-ai-search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "alibabacloud-ai-search" -> InferenceTypes.AlibabaCloudServiceType.AlibabacloudAiSearch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AlibabaCloudServiceType"))

    type AlibabaCloudTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AlibabaCloudTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AlibabaCloudTaskType.Completion -> "completion"
                | InferenceTypes.AlibabaCloudTaskType.Rerank -> "rerank"
                | InferenceTypes.AlibabaCloudTaskType.SparseEmbedding -> "sparse_embedding"
                | InferenceTypes.AlibabaCloudTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.AlibabaCloudTaskType.Completion
            | "rerank" -> InferenceTypes.AlibabaCloudTaskType.Rerank
            | "sparse_embedding" -> InferenceTypes.AlibabaCloudTaskType.SparseEmbedding
            | "text_embedding" -> InferenceTypes.AlibabaCloudTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AlibabaCloudTaskType"))

    type AmazonBedrockServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AmazonBedrockServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AmazonBedrockServiceType.Amazonbedrock -> "amazonbedrock"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "amazonbedrock" -> InferenceTypes.AmazonBedrockServiceType.Amazonbedrock
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonBedrockServiceType"))

    type AmazonBedrockTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AmazonBedrockTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AmazonBedrockTaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.AmazonBedrockTaskType.Completion -> "completion"
                | InferenceTypes.AmazonBedrockTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.AmazonBedrockTaskType.ChatCompletion
            | "completion" -> InferenceTypes.AmazonBedrockTaskType.Completion
            | "text_embedding" -> InferenceTypes.AmazonBedrockTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonBedrockTaskType"))

    type AmazonSageMakerApiConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AmazonSageMakerApi>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AmazonSageMakerApi.Openai -> "openai"
                | InferenceTypes.AmazonSageMakerApi.Elastic -> "elastic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "openai" -> InferenceTypes.AmazonSageMakerApi.Openai
            | "elastic" -> InferenceTypes.AmazonSageMakerApi.Elastic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonSageMakerApi"))

    type AmazonSageMakerServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AmazonSageMakerServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AmazonSageMakerServiceType.AmazonSagemaker -> "amazon_sagemaker"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "amazon_sagemaker" -> InferenceTypes.AmazonSageMakerServiceType.AmazonSagemaker
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AmazonSageMakerServiceType"))

    type AnthropicServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AnthropicServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AnthropicServiceType.Anthropic -> "anthropic"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "anthropic" -> InferenceTypes.AnthropicServiceType.Anthropic
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AnthropicServiceType"))

    type AnthropicTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AnthropicTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AnthropicTaskType.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.AnthropicTaskType.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AnthropicTaskType"))

    type AzureAiStudioServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AzureAiStudioServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AzureAiStudioServiceType.Azureaistudio -> "azureaistudio"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "azureaistudio" -> InferenceTypes.AzureAiStudioServiceType.Azureaistudio
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureAiStudioServiceType"))

    type AzureAiStudioTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AzureAiStudioTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AzureAiStudioTaskType.Completion -> "completion"
                | InferenceTypes.AzureAiStudioTaskType.Rerank -> "rerank"
                | InferenceTypes.AzureAiStudioTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.AzureAiStudioTaskType.Completion
            | "rerank" -> InferenceTypes.AzureAiStudioTaskType.Rerank
            | "text_embedding" -> InferenceTypes.AzureAiStudioTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureAiStudioTaskType"))

    type AzureOpenAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AzureOpenAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AzureOpenAIServiceType.Azureopenai -> "azureopenai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "azureopenai" -> InferenceTypes.AzureOpenAIServiceType.Azureopenai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureOpenAIServiceType"))

    type AzureOpenAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.AzureOpenAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.AzureOpenAITaskType.Completion -> "completion"
                | InferenceTypes.AzureOpenAITaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.AzureOpenAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.AzureOpenAITaskType.Completion
            | "chat_completion" -> InferenceTypes.AzureOpenAITaskType.ChatCompletion
            | "text_embedding" -> InferenceTypes.AzureOpenAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AzureOpenAITaskType"))

    type CohereEmbeddingTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CohereEmbeddingType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CohereEmbeddingType.Binary -> "binary"
                | InferenceTypes.CohereEmbeddingType.Bit -> "bit"
                | InferenceTypes.CohereEmbeddingType.Byte -> "byte"
                | InferenceTypes.CohereEmbeddingType.Float -> "float"
                | InferenceTypes.CohereEmbeddingType.Int8 -> "int8"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "binary" -> InferenceTypes.CohereEmbeddingType.Binary
            | "bit" -> InferenceTypes.CohereEmbeddingType.Bit
            | "byte" -> InferenceTypes.CohereEmbeddingType.Byte
            | "float" -> InferenceTypes.CohereEmbeddingType.Float
            | "int8" -> InferenceTypes.CohereEmbeddingType.Int8
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereEmbeddingType"))

    type CohereInputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CohereInputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CohereInputType.Classification -> "classification"
                | InferenceTypes.CohereInputType.Clustering -> "clustering"
                | InferenceTypes.CohereInputType.Ingest -> "ingest"
                | InferenceTypes.CohereInputType.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classification" -> InferenceTypes.CohereInputType.Classification
            | "clustering" -> InferenceTypes.CohereInputType.Clustering
            | "ingest" -> InferenceTypes.CohereInputType.Ingest
            | "search" -> InferenceTypes.CohereInputType.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereInputType"))

    type CohereServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CohereServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CohereServiceType.Cohere -> "cohere"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cohere" -> InferenceTypes.CohereServiceType.Cohere
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereServiceType"))

    type CohereSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CohereSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CohereSimilarityType.Cosine -> "cosine"
                | InferenceTypes.CohereSimilarityType.DotProduct -> "dot_product"
                | InferenceTypes.CohereSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> InferenceTypes.CohereSimilarityType.Cosine
            | "dot_product" -> InferenceTypes.CohereSimilarityType.DotProduct
            | "l2_norm" -> InferenceTypes.CohereSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereSimilarityType"))

    type CohereTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CohereTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CohereTaskType.Completion -> "completion"
                | InferenceTypes.CohereTaskType.Rerank -> "rerank"
                | InferenceTypes.CohereTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.CohereTaskType.Completion
            | "rerank" -> InferenceTypes.CohereTaskType.Rerank
            | "text_embedding" -> InferenceTypes.CohereTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereTaskType"))

    type CohereTruncateTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CohereTruncateType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CohereTruncateType.END -> "END"
                | InferenceTypes.CohereTruncateType.NONE -> "NONE"
                | InferenceTypes.CohereTruncateType.START -> "START"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "END" -> InferenceTypes.CohereTruncateType.END
            | "NONE" -> InferenceTypes.CohereTruncateType.NONE
            | "START" -> InferenceTypes.CohereTruncateType.START
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CohereTruncateType"))

    type ContentTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ContentType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ContentType.Text -> "text"
                | InferenceTypes.ContentType.ImageUrl -> "image_url"
                | InferenceTypes.ContentType.File -> "file"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text" -> InferenceTypes.ContentType.Text
            | "image_url" -> InferenceTypes.ContentType.ImageUrl
            | "file" -> InferenceTypes.ContentType.File
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ContentType"))

    type ContextualAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ContextualAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ContextualAIServiceType.Contextualai -> "contextualai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "contextualai" -> InferenceTypes.ContextualAIServiceType.Contextualai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ContextualAIServiceType"))

    type CustomServiceInputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CustomServiceInputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CustomServiceInputType.Classification -> "classification"
                | InferenceTypes.CustomServiceInputType.Clustering -> "clustering"
                | InferenceTypes.CustomServiceInputType.Ingest -> "ingest"
                | InferenceTypes.CustomServiceInputType.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classification" -> InferenceTypes.CustomServiceInputType.Classification
            | "clustering" -> InferenceTypes.CustomServiceInputType.Clustering
            | "ingest" -> InferenceTypes.CustomServiceInputType.Ingest
            | "search" -> InferenceTypes.CustomServiceInputType.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CustomServiceInputType"))

    type CustomServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CustomServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CustomServiceType.Custom -> "custom"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "custom" -> InferenceTypes.CustomServiceType.Custom
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CustomServiceType"))

    type CustomTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.CustomTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.CustomTaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.CustomTaskType.SparseEmbedding -> "sparse_embedding"
                | InferenceTypes.CustomTaskType.Rerank -> "rerank"
                | InferenceTypes.CustomTaskType.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.CustomTaskType.TextEmbedding
            | "sparse_embedding" -> InferenceTypes.CustomTaskType.SparseEmbedding
            | "rerank" -> InferenceTypes.CustomTaskType.Rerank
            | "completion" -> InferenceTypes.CustomTaskType.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CustomTaskType"))

    type DeepSeekServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.DeepSeekServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.DeepSeekServiceType.Deepseek -> "deepseek"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "deepseek" -> InferenceTypes.DeepSeekServiceType.Deepseek
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeepSeekServiceType"))

    type ElasticsearchServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ElasticsearchServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ElasticsearchServiceType.Elasticsearch -> "elasticsearch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "elasticsearch" -> InferenceTypes.ElasticsearchServiceType.Elasticsearch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElasticsearchServiceType"))

    type ElasticsearchTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ElasticsearchTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ElasticsearchTaskType.Rerank -> "rerank"
                | InferenceTypes.ElasticsearchTaskType.SparseEmbedding -> "sparse_embedding"
                | InferenceTypes.ElasticsearchTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rerank" -> InferenceTypes.ElasticsearchTaskType.Rerank
            | "sparse_embedding" -> InferenceTypes.ElasticsearchTaskType.SparseEmbedding
            | "text_embedding" -> InferenceTypes.ElasticsearchTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElasticsearchTaskType"))

    type ElserServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ElserServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ElserServiceType.Elser -> "elser"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "elser" -> InferenceTypes.ElserServiceType.Elser
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElserServiceType"))

    type ElserTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ElserTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ElserTaskType.SparseEmbedding -> "sparse_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> InferenceTypes.ElserTaskType.SparseEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ElserTaskType"))

    type EmbeddingContentFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.EmbeddingContentFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.EmbeddingContentFormat.Text -> "text"
                | InferenceTypes.EmbeddingContentFormat.Base64 -> "base64"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text" -> InferenceTypes.EmbeddingContentFormat.Text
            | "base64" -> InferenceTypes.EmbeddingContentFormat.Base64
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EmbeddingContentFormat"))

    type EmbeddingContentTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.EmbeddingContentType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.EmbeddingContentType.Text -> "text"
                | InferenceTypes.EmbeddingContentType.Image -> "image"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text" -> InferenceTypes.EmbeddingContentType.Text
            | "image" -> InferenceTypes.EmbeddingContentType.Image
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EmbeddingContentType"))

    type EmbeddingInferenceResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.EmbeddingInferenceResult>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceTypes.EmbeddingInferenceResult.EmbeddingsBytes v ->
                writer.WritePropertyName("embeddings_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.EmbeddingInferenceResult.EmbeddingsBits v ->
                writer.WritePropertyName("embeddings_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.EmbeddingInferenceResult.Embeddings v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.EmbeddingInferenceResult.EmbeddingsBytes v
                | "embeddings_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.EmbeddingInferenceResult.EmbeddingsBits v
                | "embeddings" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingResult list>(ref reader, options)
                    InferenceTypes.EmbeddingInferenceResult.Embeddings v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for EmbeddingInferenceResult"))
            reader.Read() |> ignore // EndObject
            result

    type FireworksAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.FireworksAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.FireworksAIServiceType.Fireworksai -> "fireworksai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "fireworksai" -> InferenceTypes.FireworksAIServiceType.Fireworksai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FireworksAIServiceType"))

    type FireworksAISimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.FireworksAISimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.FireworksAISimilarityType.Cosine -> "cosine"
                | InferenceTypes.FireworksAISimilarityType.DotProduct -> "dot_product"
                | InferenceTypes.FireworksAISimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> InferenceTypes.FireworksAISimilarityType.Cosine
            | "dot_product" -> InferenceTypes.FireworksAISimilarityType.DotProduct
            | "l2_norm" -> InferenceTypes.FireworksAISimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FireworksAISimilarityType"))

    type FireworksAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.FireworksAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.FireworksAITaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.FireworksAITaskType.Completion -> "completion"
                | InferenceTypes.FireworksAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.FireworksAITaskType.ChatCompletion
            | "completion" -> InferenceTypes.FireworksAITaskType.Completion
            | "text_embedding" -> InferenceTypes.FireworksAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FireworksAITaskType"))

    type GoogleAiServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.GoogleAiServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.GoogleAiServiceType.Googleaistudio -> "googleaistudio"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "googleaistudio" -> InferenceTypes.GoogleAiServiceType.Googleaistudio
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleAiServiceType"))

    type GoogleAiStudioTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.GoogleAiStudioTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.GoogleAiStudioTaskType.Completion -> "completion"
                | InferenceTypes.GoogleAiStudioTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.GoogleAiStudioTaskType.Completion
            | "text_embedding" -> InferenceTypes.GoogleAiStudioTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleAiStudioTaskType"))

    type GoogleModelGardenProviderConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.GoogleModelGardenProvider>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.GoogleModelGardenProvider.Google -> "google"
                | InferenceTypes.GoogleModelGardenProvider.Anthropic -> "anthropic"
                | InferenceTypes.GoogleModelGardenProvider.Meta -> "meta"
                | InferenceTypes.GoogleModelGardenProvider.HuggingFace -> "hugging_face"
                | InferenceTypes.GoogleModelGardenProvider.Mistral -> "mistral"
                | InferenceTypes.GoogleModelGardenProvider.Ai21 -> "ai21"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "google" -> InferenceTypes.GoogleModelGardenProvider.Google
            | "anthropic" -> InferenceTypes.GoogleModelGardenProvider.Anthropic
            | "meta" -> InferenceTypes.GoogleModelGardenProvider.Meta
            | "hugging_face" -> InferenceTypes.GoogleModelGardenProvider.HuggingFace
            | "mistral" -> InferenceTypes.GoogleModelGardenProvider.Mistral
            | "ai21" -> InferenceTypes.GoogleModelGardenProvider.Ai21
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleModelGardenProvider"))

    type GoogleVertexAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.GoogleVertexAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.GoogleVertexAIServiceType.Googlevertexai -> "googlevertexai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "googlevertexai" -> InferenceTypes.GoogleVertexAIServiceType.Googlevertexai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleVertexAIServiceType"))

    type GoogleVertexAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.GoogleVertexAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.GoogleVertexAITaskType.Rerank -> "rerank"
                | InferenceTypes.GoogleVertexAITaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.GoogleVertexAITaskType.Completion -> "completion"
                | InferenceTypes.GoogleVertexAITaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rerank" -> InferenceTypes.GoogleVertexAITaskType.Rerank
            | "text_embedding" -> InferenceTypes.GoogleVertexAITaskType.TextEmbedding
            | "completion" -> InferenceTypes.GoogleVertexAITaskType.Completion
            | "chat_completion" -> InferenceTypes.GoogleVertexAITaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GoogleVertexAITaskType"))

    type GroqServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.GroqServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.GroqServiceType.Groq -> "groq"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "groq" -> InferenceTypes.GroqServiceType.Groq
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GroqServiceType"))

    type GroqTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.GroqTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.GroqTaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.GroqTaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GroqTaskType"))

    type HuggingFaceServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.HuggingFaceServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.HuggingFaceServiceType.HuggingFace -> "hugging_face"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "hugging_face" -> InferenceTypes.HuggingFaceServiceType.HuggingFace
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HuggingFaceServiceType"))

    type HuggingFaceTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.HuggingFaceTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.HuggingFaceTaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.HuggingFaceTaskType.Completion -> "completion"
                | InferenceTypes.HuggingFaceTaskType.Rerank -> "rerank"
                | InferenceTypes.HuggingFaceTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.HuggingFaceTaskType.ChatCompletion
            | "completion" -> InferenceTypes.HuggingFaceTaskType.Completion
            | "rerank" -> InferenceTypes.HuggingFaceTaskType.Rerank
            | "text_embedding" -> InferenceTypes.HuggingFaceTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HuggingFaceTaskType"))

    type ImageUrlDetailConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ImageUrlDetail>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ImageUrlDetail.Auto -> "auto"
                | InferenceTypes.ImageUrlDetail.Low -> "low"
                | InferenceTypes.ImageUrlDetail.High -> "high"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> InferenceTypes.ImageUrlDetail.Auto
            | "low" -> InferenceTypes.ImageUrlDetail.Low
            | "high" -> InferenceTypes.ImageUrlDetail.High
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ImageUrlDetail"))

    type InferenceResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.InferenceResult>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceTypes.InferenceResult.EmbeddingsBytes v ->
                writer.WritePropertyName("embeddings_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.EmbeddingsBits v ->
                writer.WritePropertyName("embeddings_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.Embeddings v ->
                writer.WritePropertyName("embeddings")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.TextEmbeddingBytes v ->
                writer.WritePropertyName("text_embedding_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.TextEmbeddingBits v ->
                writer.WritePropertyName("text_embedding_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.SparseEmbedding v ->
                writer.WritePropertyName("sparse_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.Completion v ->
                writer.WritePropertyName("completion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.InferenceResult.Rerank v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.EmbeddingsBytes v
                | "embeddings_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.EmbeddingsBits v
                | "embeddings" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.Embeddings v
                | "text_embedding_bytes" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.TextEmbeddingBytes v
                | "text_embedding_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.TextEmbeddingBits v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.TextEmbedding v
                | "sparse_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.SparseEmbeddingResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.SparseEmbedding v
                | "completion" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.CompletionResult list>(ref reader, options)
                    InferenceTypes.InferenceResult.Completion v
                | "rerank" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.RankedDocument list>(ref reader, options)
                    InferenceTypes.InferenceResult.Rerank v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceResult"))
            reader.Read() |> ignore // EndObject
            result

    type JinaAIElementTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.JinaAIElementType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.JinaAIElementType.Binary -> "binary"
                | InferenceTypes.JinaAIElementType.Bit -> "bit"
                | InferenceTypes.JinaAIElementType.Float -> "float"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "binary" -> InferenceTypes.JinaAIElementType.Binary
            | "bit" -> InferenceTypes.JinaAIElementType.Bit
            | "float" -> InferenceTypes.JinaAIElementType.Float
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAIElementType"))

    type JinaAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.JinaAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.JinaAIServiceType.Jinaai -> "jinaai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "jinaai" -> InferenceTypes.JinaAIServiceType.Jinaai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAIServiceType"))

    type JinaAISimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.JinaAISimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.JinaAISimilarityType.Cosine -> "cosine"
                | InferenceTypes.JinaAISimilarityType.DotProduct -> "dot_product"
                | InferenceTypes.JinaAISimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> InferenceTypes.JinaAISimilarityType.Cosine
            | "dot_product" -> InferenceTypes.JinaAISimilarityType.DotProduct
            | "l2_norm" -> InferenceTypes.JinaAISimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAISimilarityType"))

    type JinaAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.JinaAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.JinaAITaskType.Embedding -> "embedding"
                | InferenceTypes.JinaAITaskType.Rerank -> "rerank"
                | InferenceTypes.JinaAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "embedding" -> InferenceTypes.JinaAITaskType.Embedding
            | "rerank" -> InferenceTypes.JinaAITaskType.Rerank
            | "text_embedding" -> InferenceTypes.JinaAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAITaskType"))

    type JinaAITextEmbeddingTaskConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.JinaAITextEmbeddingTask>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.JinaAITextEmbeddingTask.Classification -> "classification"
                | InferenceTypes.JinaAITextEmbeddingTask.Clustering -> "clustering"
                | InferenceTypes.JinaAITextEmbeddingTask.Ingest -> "ingest"
                | InferenceTypes.JinaAITextEmbeddingTask.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classification" -> InferenceTypes.JinaAITextEmbeddingTask.Classification
            | "clustering" -> InferenceTypes.JinaAITextEmbeddingTask.Clustering
            | "ingest" -> InferenceTypes.JinaAITextEmbeddingTask.Ingest
            | "search" -> InferenceTypes.JinaAITextEmbeddingTask.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JinaAITextEmbeddingTask"))

    type LlamaServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.LlamaServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.LlamaServiceType.Llama -> "llama"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "llama" -> InferenceTypes.LlamaServiceType.Llama
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LlamaServiceType"))

    type LlamaSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.LlamaSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.LlamaSimilarityType.Cosine -> "cosine"
                | InferenceTypes.LlamaSimilarityType.DotProduct -> "dot_product"
                | InferenceTypes.LlamaSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> InferenceTypes.LlamaSimilarityType.Cosine
            | "dot_product" -> InferenceTypes.LlamaSimilarityType.DotProduct
            | "l2_norm" -> InferenceTypes.LlamaSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LlamaSimilarityType"))

    type LlamaTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.LlamaTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.LlamaTaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.LlamaTaskType.Completion -> "completion"
                | InferenceTypes.LlamaTaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.LlamaTaskType.TextEmbedding
            | "completion" -> InferenceTypes.LlamaTaskType.Completion
            | "chat_completion" -> InferenceTypes.LlamaTaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LlamaTaskType"))

    type MistralServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.MistralServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.MistralServiceType.Mistral -> "mistral"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "mistral" -> InferenceTypes.MistralServiceType.Mistral
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MistralServiceType"))

    type MistralTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.MistralTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.MistralTaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.MistralTaskType.Completion -> "completion"
                | InferenceTypes.MistralTaskType.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.MistralTaskType.TextEmbedding
            | "completion" -> InferenceTypes.MistralTaskType.Completion
            | "chat_completion" -> InferenceTypes.MistralTaskType.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MistralTaskType"))

    type NvidiaInputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.NvidiaInputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.NvidiaInputType.Ingest -> "ingest"
                | InferenceTypes.NvidiaInputType.Search -> "search"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ingest" -> InferenceTypes.NvidiaInputType.Ingest
            | "search" -> InferenceTypes.NvidiaInputType.Search
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaInputType"))

    type NvidiaServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.NvidiaServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.NvidiaServiceType.Nvidia -> "nvidia"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nvidia" -> InferenceTypes.NvidiaServiceType.Nvidia
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaServiceType"))

    type NvidiaSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.NvidiaSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.NvidiaSimilarityType.Cosine -> "cosine"
                | InferenceTypes.NvidiaSimilarityType.DotProduct -> "dot_product"
                | InferenceTypes.NvidiaSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> InferenceTypes.NvidiaSimilarityType.Cosine
            | "dot_product" -> InferenceTypes.NvidiaSimilarityType.DotProduct
            | "l2_norm" -> InferenceTypes.NvidiaSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaSimilarityType"))

    type NvidiaTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.NvidiaTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.NvidiaTaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.NvidiaTaskType.Completion -> "completion"
                | InferenceTypes.NvidiaTaskType.Rerank -> "rerank"
                | InferenceTypes.NvidiaTaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.NvidiaTaskType.ChatCompletion
            | "completion" -> InferenceTypes.NvidiaTaskType.Completion
            | "rerank" -> InferenceTypes.NvidiaTaskType.Rerank
            | "text_embedding" -> InferenceTypes.NvidiaTaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NvidiaTaskType"))

    type OpenAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.OpenAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.OpenAIServiceType.Openai -> "openai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "openai" -> InferenceTypes.OpenAIServiceType.Openai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenAIServiceType"))

    type OpenAISimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.OpenAISimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.OpenAISimilarityType.Cosine -> "cosine"
                | InferenceTypes.OpenAISimilarityType.DotProduct -> "dot_product"
                | InferenceTypes.OpenAISimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> InferenceTypes.OpenAISimilarityType.Cosine
            | "dot_product" -> InferenceTypes.OpenAISimilarityType.DotProduct
            | "l2_norm" -> InferenceTypes.OpenAISimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenAISimilarityType"))

    type OpenAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.OpenAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.OpenAITaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.OpenAITaskType.Completion -> "completion"
                | InferenceTypes.OpenAITaskType.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.OpenAITaskType.ChatCompletion
            | "completion" -> InferenceTypes.OpenAITaskType.Completion
            | "text_embedding" -> InferenceTypes.OpenAITaskType.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenAITaskType"))

    type OpenShiftAiServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.OpenShiftAiServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.OpenShiftAiServiceType.OpenshiftAi -> "openshift_ai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "openshift_ai" -> InferenceTypes.OpenShiftAiServiceType.OpenshiftAi
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenShiftAiServiceType"))

    type OpenShiftAiSimilarityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.OpenShiftAiSimilarityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.OpenShiftAiSimilarityType.Cosine -> "cosine"
                | InferenceTypes.OpenShiftAiSimilarityType.DotProduct -> "dot_product"
                | InferenceTypes.OpenShiftAiSimilarityType.L2Norm -> "l2_norm"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cosine" -> InferenceTypes.OpenShiftAiSimilarityType.Cosine
            | "dot_product" -> InferenceTypes.OpenShiftAiSimilarityType.DotProduct
            | "l2_norm" -> InferenceTypes.OpenShiftAiSimilarityType.L2Norm
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenShiftAiSimilarityType"))

    type OpenShiftAiTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.OpenShiftAiTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.OpenShiftAiTaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.OpenShiftAiTaskType.Completion -> "completion"
                | InferenceTypes.OpenShiftAiTaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.OpenShiftAiTaskType.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.OpenShiftAiTaskType.TextEmbedding
            | "completion" -> InferenceTypes.OpenShiftAiTaskType.Completion
            | "chat_completion" -> InferenceTypes.OpenShiftAiTaskType.ChatCompletion
            | "rerank" -> InferenceTypes.OpenShiftAiTaskType.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for OpenShiftAiTaskType"))

    type ReasoningDetailConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ReasoningDetail>()

        override _.Write(writer, value, options) =
            match value with
            | InferenceTypes.ReasoningDetail.EncryptedReasoningDetail v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.ReasoningDetail.SummaryReasoningDetail v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.ReasoningDetail.TextReasoningDetail v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "encryptedreasoningdetail" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.EncryptedReasoningDetail>(doc.RootElement.GetRawText(), options)
                InferenceTypes.ReasoningDetail.EncryptedReasoningDetail v
            | "summaryreasoningdetail" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.SummaryReasoningDetail>(doc.RootElement.GetRawText(), options)
                InferenceTypes.ReasoningDetail.SummaryReasoningDetail v
            | "textreasoningdetail" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.TextReasoningDetail>(doc.RootElement.GetRawText(), options)
                InferenceTypes.ReasoningDetail.TextReasoningDetail v
            | other -> raise (System.Text.Json.JsonException($"Unknown tag value '{other}' for ReasoningDetail"))

    type ReasoningEffortConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ReasoningEffort>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ReasoningEffort.Xhigh -> "xhigh"
                | InferenceTypes.ReasoningEffort.High -> "high"
                | InferenceTypes.ReasoningEffort.Medium -> "medium"
                | InferenceTypes.ReasoningEffort.Low -> "low"
                | InferenceTypes.ReasoningEffort.Minimal -> "minimal"
                | InferenceTypes.ReasoningEffort.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "xhigh" -> InferenceTypes.ReasoningEffort.Xhigh
            | "high" -> InferenceTypes.ReasoningEffort.High
            | "medium" -> InferenceTypes.ReasoningEffort.Medium
            | "low" -> InferenceTypes.ReasoningEffort.Low
            | "minimal" -> InferenceTypes.ReasoningEffort.Minimal
            | "none" -> InferenceTypes.ReasoningEffort.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ReasoningEffort"))

    type ReasoningSummaryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.ReasoningSummary>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.ReasoningSummary.Auto -> "auto"
                | InferenceTypes.ReasoningSummary.Concise -> "concise"
                | InferenceTypes.ReasoningSummary.Detailed -> "detailed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> InferenceTypes.ReasoningSummary.Auto
            | "concise" -> InferenceTypes.ReasoningSummary.Concise
            | "detailed" -> InferenceTypes.ReasoningSummary.Detailed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ReasoningSummary"))

    type TaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskType.SparseEmbedding -> "sparse_embedding"
                | InferenceTypes.TaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskType.Rerank -> "rerank"
                | InferenceTypes.TaskType.Completion -> "completion"
                | InferenceTypes.TaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskType.Embedding -> "embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> InferenceTypes.TaskType.SparseEmbedding
            | "text_embedding" -> InferenceTypes.TaskType.TextEmbedding
            | "rerank" -> InferenceTypes.TaskType.Rerank
            | "completion" -> InferenceTypes.TaskType.Completion
            | "chat_completion" -> InferenceTypes.TaskType.ChatCompletion
            | "embedding" -> InferenceTypes.TaskType.Embedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskType"))

    type TaskTypeAi21Converter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeAi21>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeAi21.Completion -> "completion"
                | InferenceTypes.TaskTypeAi21.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.TaskTypeAi21.Completion
            | "chat_completion" -> InferenceTypes.TaskTypeAi21.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAi21"))

    type TaskTypeAlibabaCloudAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeAlibabaCloudAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeAlibabaCloudAI.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeAlibabaCloudAI.Rerank -> "rerank"
                | InferenceTypes.TaskTypeAlibabaCloudAI.Completion -> "completion"
                | InferenceTypes.TaskTypeAlibabaCloudAI.SparseEmbedding -> "sparse_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeAlibabaCloudAI.TextEmbedding
            | "rerank" -> InferenceTypes.TaskTypeAlibabaCloudAI.Rerank
            | "completion" -> InferenceTypes.TaskTypeAlibabaCloudAI.Completion
            | "sparse_embedding" -> InferenceTypes.TaskTypeAlibabaCloudAI.SparseEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAlibabaCloudAI"))

    type TaskTypeAmazonBedrockConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeAmazonBedrock>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeAmazonBedrock.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeAmazonBedrock.Completion -> "completion"
                | InferenceTypes.TaskTypeAmazonBedrock.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.TaskTypeAmazonBedrock.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeAmazonBedrock.Completion
            | "text_embedding" -> InferenceTypes.TaskTypeAmazonBedrock.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAmazonBedrock"))

    type TaskTypeAmazonSageMakerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeAmazonSageMaker>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeAmazonSageMaker.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeAmazonSageMaker.Completion -> "completion"
                | InferenceTypes.TaskTypeAmazonSageMaker.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeAmazonSageMaker.SparseEmbedding -> "sparse_embedding"
                | InferenceTypes.TaskTypeAmazonSageMaker.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeAmazonSageMaker.TextEmbedding
            | "completion" -> InferenceTypes.TaskTypeAmazonSageMaker.Completion
            | "chat_completion" -> InferenceTypes.TaskTypeAmazonSageMaker.ChatCompletion
            | "sparse_embedding" -> InferenceTypes.TaskTypeAmazonSageMaker.SparseEmbedding
            | "rerank" -> InferenceTypes.TaskTypeAmazonSageMaker.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAmazonSageMaker"))

    type TaskTypeAnthropicConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeAnthropic>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeAnthropic.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.TaskTypeAnthropic.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAnthropic"))

    type TaskTypeAzureAIStudioConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeAzureAIStudio>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeAzureAIStudio.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeAzureAIStudio.Completion -> "completion"
                | InferenceTypes.TaskTypeAzureAIStudio.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeAzureAIStudio.TextEmbedding
            | "completion" -> InferenceTypes.TaskTypeAzureAIStudio.Completion
            | "rerank" -> InferenceTypes.TaskTypeAzureAIStudio.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAzureAIStudio"))

    type TaskTypeAzureOpenAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeAzureOpenAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeAzureOpenAI.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeAzureOpenAI.Completion -> "completion"
                | InferenceTypes.TaskTypeAzureOpenAI.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeAzureOpenAI.TextEmbedding
            | "completion" -> InferenceTypes.TaskTypeAzureOpenAI.Completion
            | "chat_completion" -> InferenceTypes.TaskTypeAzureOpenAI.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeAzureOpenAI"))

    type TaskTypeCohereConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeCohere>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeCohere.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeCohere.Rerank -> "rerank"
                | InferenceTypes.TaskTypeCohere.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeCohere.TextEmbedding
            | "rerank" -> InferenceTypes.TaskTypeCohere.Rerank
            | "completion" -> InferenceTypes.TaskTypeCohere.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeCohere"))

    type TaskTypeContextualAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeContextualAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeContextualAI.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rerank" -> InferenceTypes.TaskTypeContextualAI.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeContextualAI"))

    type TaskTypeCustomConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeCustom>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeCustom.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeCustom.SparseEmbedding -> "sparse_embedding"
                | InferenceTypes.TaskTypeCustom.Rerank -> "rerank"
                | InferenceTypes.TaskTypeCustom.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeCustom.TextEmbedding
            | "sparse_embedding" -> InferenceTypes.TaskTypeCustom.SparseEmbedding
            | "rerank" -> InferenceTypes.TaskTypeCustom.Rerank
            | "completion" -> InferenceTypes.TaskTypeCustom.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeCustom"))

    type TaskTypeDeepSeekConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeDeepSeek>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeDeepSeek.Completion -> "completion"
                | InferenceTypes.TaskTypeDeepSeek.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "completion" -> InferenceTypes.TaskTypeDeepSeek.Completion
            | "chat_completion" -> InferenceTypes.TaskTypeDeepSeek.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeDeepSeek"))

    type TaskTypeELSERConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeELSER>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeELSER.SparseEmbedding -> "sparse_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> InferenceTypes.TaskTypeELSER.SparseEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeELSER"))

    type TaskTypeElasticsearchConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeElasticsearch>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeElasticsearch.SparseEmbedding -> "sparse_embedding"
                | InferenceTypes.TaskTypeElasticsearch.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeElasticsearch.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sparse_embedding" -> InferenceTypes.TaskTypeElasticsearch.SparseEmbedding
            | "text_embedding" -> InferenceTypes.TaskTypeElasticsearch.TextEmbedding
            | "rerank" -> InferenceTypes.TaskTypeElasticsearch.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeElasticsearch"))

    type TaskTypeFireworksAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeFireworksAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeFireworksAI.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeFireworksAI.Completion -> "completion"
                | InferenceTypes.TaskTypeFireworksAI.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.TaskTypeFireworksAI.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeFireworksAI.Completion
            | "text_embedding" -> InferenceTypes.TaskTypeFireworksAI.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeFireworksAI"))

    type TaskTypeGoogleAIStudioConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeGoogleAIStudio>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeGoogleAIStudio.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeGoogleAIStudio.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeGoogleAIStudio.TextEmbedding
            | "completion" -> InferenceTypes.TaskTypeGoogleAIStudio.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeGoogleAIStudio"))

    type TaskTypeGoogleVertexAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeGoogleVertexAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeGoogleVertexAI.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeGoogleVertexAI.Completion -> "completion"
                | InferenceTypes.TaskTypeGoogleVertexAI.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeGoogleVertexAI.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.TaskTypeGoogleVertexAI.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeGoogleVertexAI.Completion
            | "text_embedding" -> InferenceTypes.TaskTypeGoogleVertexAI.TextEmbedding
            | "rerank" -> InferenceTypes.TaskTypeGoogleVertexAI.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeGoogleVertexAI"))

    type TaskTypeGroqConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeGroq>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeGroq.ChatCompletion -> "chat_completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.TaskTypeGroq.ChatCompletion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeGroq"))

    type TaskTypeHuggingFaceConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeHuggingFace>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeHuggingFace.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeHuggingFace.Completion -> "completion"
                | InferenceTypes.TaskTypeHuggingFace.Rerank -> "rerank"
                | InferenceTypes.TaskTypeHuggingFace.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.TaskTypeHuggingFace.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeHuggingFace.Completion
            | "rerank" -> InferenceTypes.TaskTypeHuggingFace.Rerank
            | "text_embedding" -> InferenceTypes.TaskTypeHuggingFace.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeHuggingFace"))

    type TaskTypeJinaAiConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeJinaAi>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeJinaAi.Embedding -> "embedding"
                | InferenceTypes.TaskTypeJinaAi.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeJinaAi.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "embedding" -> InferenceTypes.TaskTypeJinaAi.Embedding
            | "text_embedding" -> InferenceTypes.TaskTypeJinaAi.TextEmbedding
            | "rerank" -> InferenceTypes.TaskTypeJinaAi.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeJinaAi"))

    type TaskTypeLlamaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeLlama>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeLlama.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeLlama.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeLlama.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeLlama.TextEmbedding
            | "chat_completion" -> InferenceTypes.TaskTypeLlama.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeLlama.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeLlama"))

    type TaskTypeMistralConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeMistral>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeMistral.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeMistral.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeMistral.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeMistral.TextEmbedding
            | "chat_completion" -> InferenceTypes.TaskTypeMistral.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeMistral.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeMistral"))

    type TaskTypeNvidiaConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeNvidia>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeNvidia.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeNvidia.Completion -> "completion"
                | InferenceTypes.TaskTypeNvidia.Rerank -> "rerank"
                | InferenceTypes.TaskTypeNvidia.TextEmbedding -> "text_embedding"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "chat_completion" -> InferenceTypes.TaskTypeNvidia.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeNvidia.Completion
            | "rerank" -> InferenceTypes.TaskTypeNvidia.Rerank
            | "text_embedding" -> InferenceTypes.TaskTypeNvidia.TextEmbedding
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeNvidia"))

    type TaskTypeOpenAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeOpenAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeOpenAI.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeOpenAI.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeOpenAI.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeOpenAI.TextEmbedding
            | "chat_completion" -> InferenceTypes.TaskTypeOpenAI.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeOpenAI.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeOpenAI"))

    type TaskTypeOpenShiftAiConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeOpenShiftAi>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeOpenShiftAi.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeOpenShiftAi.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeOpenShiftAi.Completion -> "completion"
                | InferenceTypes.TaskTypeOpenShiftAi.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeOpenShiftAi.TextEmbedding
            | "chat_completion" -> InferenceTypes.TaskTypeOpenShiftAi.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeOpenShiftAi.Completion
            | "rerank" -> InferenceTypes.TaskTypeOpenShiftAi.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeOpenShiftAi"))

    type TaskTypeVoyageAIConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeVoyageAI>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeVoyageAI.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeVoyageAI.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeVoyageAI.TextEmbedding
            | "rerank" -> InferenceTypes.TaskTypeVoyageAI.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeVoyageAI"))

    type TaskTypeWatsonxConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TaskTypeWatsonx>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.TaskTypeWatsonx.TextEmbedding -> "text_embedding"
                | InferenceTypes.TaskTypeWatsonx.ChatCompletion -> "chat_completion"
                | InferenceTypes.TaskTypeWatsonx.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.TaskTypeWatsonx.TextEmbedding
            | "chat_completion" -> InferenceTypes.TaskTypeWatsonx.ChatCompletion
            | "completion" -> InferenceTypes.TaskTypeWatsonx.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TaskTypeWatsonx"))

    type TextEmbeddingInferenceResultConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.TextEmbeddingInferenceResult>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | InferenceTypes.TextEmbeddingInferenceResult.TextEmbeddingBytes v ->
                writer.WritePropertyName("text_embedding_bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.TextEmbeddingInferenceResult.TextEmbeddingBits v ->
                writer.WritePropertyName("text_embedding_bits")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | InferenceTypes.TextEmbeddingInferenceResult.TextEmbedding v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.TextEmbeddingInferenceResult.TextEmbeddingBytes v
                | "text_embedding_bits" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingByteResult list>(ref reader, options)
                    InferenceTypes.TextEmbeddingInferenceResult.TextEmbeddingBits v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<InferenceTypes.DenseEmbeddingResult list>(ref reader, options)
                    InferenceTypes.TextEmbeddingInferenceResult.TextEmbedding v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TextEmbeddingInferenceResult"))
            reader.Read() |> ignore // EndObject
            result

    type VoyageAIServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.VoyageAIServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.VoyageAIServiceType.Voyageai -> "voyageai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "voyageai" -> InferenceTypes.VoyageAIServiceType.Voyageai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for VoyageAIServiceType"))

    type VoyageAITaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.VoyageAITaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.VoyageAITaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.VoyageAITaskType.Rerank -> "rerank"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.VoyageAITaskType.TextEmbedding
            | "rerank" -> InferenceTypes.VoyageAITaskType.Rerank
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for VoyageAITaskType"))

    type WatsonxServiceTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.WatsonxServiceType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.WatsonxServiceType.Watsonxai -> "watsonxai"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "watsonxai" -> InferenceTypes.WatsonxServiceType.Watsonxai
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatsonxServiceType"))

    type WatsonxTaskTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<InferenceTypes.WatsonxTaskType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | InferenceTypes.WatsonxTaskType.TextEmbedding -> "text_embedding"
                | InferenceTypes.WatsonxTaskType.Rerank -> "rerank"
                | InferenceTypes.WatsonxTaskType.ChatCompletion -> "chat_completion"
                | InferenceTypes.WatsonxTaskType.Completion -> "completion"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "text_embedding" -> InferenceTypes.WatsonxTaskType.TextEmbedding
            | "rerank" -> InferenceTypes.WatsonxTaskType.Rerank
            | "chat_completion" -> InferenceTypes.WatsonxTaskType.ChatCompletion
            | "completion" -> InferenceTypes.WatsonxTaskType.Completion
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatsonxTaskType"))

    type ConvertTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.ConvertType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.ConvertType.Integer -> "integer"
                | IngestTypes.ConvertType.Long -> "long"
                | IngestTypes.ConvertType.Double -> "double"
                | IngestTypes.ConvertType.Float -> "float"
                | IngestTypes.ConvertType.Boolean -> "boolean"
                | IngestTypes.ConvertType.Ip -> "ip"
                | IngestTypes.ConvertType.String -> "string"
                | IngestTypes.ConvertType.Auto -> "auto"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "integer" -> IngestTypes.ConvertType.Integer
            | "long" -> IngestTypes.ConvertType.Long
            | "double" -> IngestTypes.ConvertType.Double
            | "float" -> IngestTypes.ConvertType.Float
            | "boolean" -> IngestTypes.ConvertType.Boolean
            | "ip" -> IngestTypes.ConvertType.Ip
            | "string" -> IngestTypes.ConvertType.String
            | "auto" -> IngestTypes.ConvertType.Auto
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConvertType"))

    type DatabaseConfigurationConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.DatabaseConfiguration>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IngestTypes.DatabaseConfiguration.Maxmind v ->
                writer.WritePropertyName("maxmind")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.DatabaseConfiguration.Ipinfo v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.Maxmind>(ref reader, options)
                    IngestTypes.DatabaseConfiguration.Maxmind v
                | "ipinfo" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.Ipinfo>(ref reader, options)
                    IngestTypes.DatabaseConfiguration.Ipinfo v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DatabaseConfiguration"))
            reader.Read() |> ignore // EndObject
            result

    type DatabaseConfigurationFullConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.DatabaseConfigurationFull>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IngestTypes.DatabaseConfigurationFull.Web v ->
                writer.WritePropertyName("web")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.DatabaseConfigurationFull.Local v ->
                writer.WritePropertyName("local")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.DatabaseConfigurationFull.Maxmind v ->
                writer.WritePropertyName("maxmind")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.DatabaseConfigurationFull.Ipinfo v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.Web>(ref reader, options)
                    IngestTypes.DatabaseConfigurationFull.Web v
                | "local" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.Local>(ref reader, options)
                    IngestTypes.DatabaseConfigurationFull.Local v
                | "maxmind" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.Maxmind>(ref reader, options)
                    IngestTypes.DatabaseConfigurationFull.Maxmind v
                | "ipinfo" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.Ipinfo>(ref reader, options)
                    IngestTypes.DatabaseConfigurationFull.Ipinfo v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DatabaseConfigurationFull"))
            reader.Read() |> ignore // EndObject
            result

    type FieldAccessPatternConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.FieldAccessPattern>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.FieldAccessPattern.Classic -> "classic"
                | IngestTypes.FieldAccessPattern.Flexible -> "flexible"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "classic" -> IngestTypes.FieldAccessPattern.Classic
            | "flexible" -> IngestTypes.FieldAccessPattern.Flexible
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FieldAccessPattern"))

    type FingerprintDigestConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.FingerprintDigest>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.FingerprintDigest.MD5 -> "MD5"
                | IngestTypes.FingerprintDigest.SHA1 -> "SHA-1"
                | IngestTypes.FingerprintDigest.SHA256 -> "SHA-256"
                | IngestTypes.FingerprintDigest.SHA512 -> "SHA-512"
                | IngestTypes.FingerprintDigest.MurmurHash3 -> "MurmurHash3"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "MD5" -> IngestTypes.FingerprintDigest.MD5
            | "SHA-1" -> IngestTypes.FingerprintDigest.SHA1
            | "SHA-256" -> IngestTypes.FingerprintDigest.SHA256
            | "SHA-512" -> IngestTypes.FingerprintDigest.SHA512
            | "MurmurHash3" -> IngestTypes.FingerprintDigest.MurmurHash3
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FingerprintDigest"))

    type GeoGridTargetFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.GeoGridTargetFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.GeoGridTargetFormat.Geojson -> "geojson"
                | IngestTypes.GeoGridTargetFormat.Wkt -> "wkt"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geojson" -> IngestTypes.GeoGridTargetFormat.Geojson
            | "wkt" -> IngestTypes.GeoGridTargetFormat.Wkt
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoGridTargetFormat"))

    type GeoGridTileTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.GeoGridTileType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.GeoGridTileType.Geotile -> "geotile"
                | IngestTypes.GeoGridTileType.Geohex -> "geohex"
                | IngestTypes.GeoGridTileType.Geohash -> "geohash"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geotile" -> IngestTypes.GeoGridTileType.Geotile
            | "geohex" -> IngestTypes.GeoGridTileType.Geohex
            | "geohash" -> IngestTypes.GeoGridTileType.Geohash
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GeoGridTileType"))

    type InferenceConfigConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.InferenceConfig>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IngestTypes.InferenceConfig.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.InferenceConfig.Classification v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.InferenceConfigRegression>(ref reader, options)
                    IngestTypes.InferenceConfig.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.InferenceConfigClassification>(ref reader, options)
                    IngestTypes.InferenceConfig.Classification v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfig"))
            reader.Read() |> ignore // EndObject
            result

    type JsonProcessorConflictStrategyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.JsonProcessorConflictStrategy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.JsonProcessorConflictStrategy.Replace -> "replace"
                | IngestTypes.JsonProcessorConflictStrategy.Merge -> "merge"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "replace" -> IngestTypes.JsonProcessorConflictStrategy.Replace
            | "merge" -> IngestTypes.JsonProcessorConflictStrategy.Merge
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JsonProcessorConflictStrategy"))

    type PipelineSimulationStatusOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.PipelineSimulationStatusOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.PipelineSimulationStatusOptions.Success -> "success"
                | IngestTypes.PipelineSimulationStatusOptions.Error -> "error"
                | IngestTypes.PipelineSimulationStatusOptions.ErrorIgnored -> "error_ignored"
                | IngestTypes.PipelineSimulationStatusOptions.Skipped -> "skipped"
                | IngestTypes.PipelineSimulationStatusOptions.Dropped -> "dropped"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "success" -> IngestTypes.PipelineSimulationStatusOptions.Success
            | "error" -> IngestTypes.PipelineSimulationStatusOptions.Error
            | "error_ignored" -> IngestTypes.PipelineSimulationStatusOptions.ErrorIgnored
            | "skipped" -> IngestTypes.PipelineSimulationStatusOptions.Skipped
            | "dropped" -> IngestTypes.PipelineSimulationStatusOptions.Dropped
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PipelineSimulationStatusOptions"))

    type ProcessorContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.ProcessorContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | IngestTypes.ProcessorContainer.Append v ->
                writer.WritePropertyName("append")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Attachment v ->
                writer.WritePropertyName("attachment")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Bytes v ->
                writer.WritePropertyName("bytes")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Cef v ->
                writer.WritePropertyName("cef")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Circle v ->
                writer.WritePropertyName("circle")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.CommunityId v ->
                writer.WritePropertyName("community_id")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Convert v ->
                writer.WritePropertyName("convert")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Csv v ->
                writer.WritePropertyName("csv")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Date v ->
                writer.WritePropertyName("date")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.DateIndexName v ->
                writer.WritePropertyName("date_index_name")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Dissect v ->
                writer.WritePropertyName("dissect")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.DotExpander v ->
                writer.WritePropertyName("dot_expander")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Drop v ->
                writer.WritePropertyName("drop")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Enrich v ->
                writer.WritePropertyName("enrich")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Fail v ->
                writer.WritePropertyName("fail")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Fingerprint v ->
                writer.WritePropertyName("fingerprint")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Foreach v ->
                writer.WritePropertyName("foreach")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.IpLocation v ->
                writer.WritePropertyName("ip_location")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.GeoGrid v ->
                writer.WritePropertyName("geo_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Geoip v ->
                writer.WritePropertyName("geoip")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Grok v ->
                writer.WritePropertyName("grok")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Gsub v ->
                writer.WritePropertyName("gsub")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.HtmlStrip v ->
                writer.WritePropertyName("html_strip")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Inference v ->
                writer.WritePropertyName("inference")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Join v ->
                writer.WritePropertyName("join")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Json v ->
                writer.WritePropertyName("json")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Kv v ->
                writer.WritePropertyName("kv")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Lowercase v ->
                writer.WritePropertyName("lowercase")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.NetworkDirection v ->
                writer.WritePropertyName("network_direction")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Pipeline v ->
                writer.WritePropertyName("pipeline")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Redact v ->
                writer.WritePropertyName("redact")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.RegisteredDomain v ->
                writer.WritePropertyName("registered_domain")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Remove v ->
                writer.WritePropertyName("remove")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Rename v ->
                writer.WritePropertyName("rename")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Reroute v ->
                writer.WritePropertyName("reroute")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Script v ->
                writer.WritePropertyName("script")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Set v ->
                writer.WritePropertyName("set")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.SetSecurityUser v ->
                writer.WritePropertyName("set_security_user")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Sort v ->
                writer.WritePropertyName("sort")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Split v ->
                writer.WritePropertyName("split")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Terminate v ->
                writer.WritePropertyName("terminate")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Trim v ->
                writer.WritePropertyName("trim")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Uppercase v ->
                writer.WritePropertyName("uppercase")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Urldecode v ->
                writer.WritePropertyName("urldecode")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.UriParts v ->
                writer.WritePropertyName("uri_parts")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.UserAgent v ->
                writer.WritePropertyName("user_agent")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | IngestTypes.ProcessorContainer.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.AppendProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Append v
                | "attachment" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.AttachmentProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Attachment v
                | "bytes" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.BytesProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Bytes v
                | "cef" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.CefProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Cef v
                | "circle" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.CircleProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Circle v
                | "community_id" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.CommunityIDProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.CommunityId v
                | "convert" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.ConvertProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Convert v
                | "csv" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.CsvProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Csv v
                | "date" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.DateProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Date v
                | "date_index_name" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.DateIndexNameProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.DateIndexName v
                | "dissect" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.DissectProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Dissect v
                | "dot_expander" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.DotExpanderProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.DotExpander v
                | "drop" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.DropProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Drop v
                | "enrich" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.EnrichProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Enrich v
                | "fail" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.FailProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Fail v
                | "fingerprint" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.FingerprintProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Fingerprint v
                | "foreach" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.ForeachProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Foreach v
                | "ip_location" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.IpLocationProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.IpLocation v
                | "geo_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.GeoGridProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.GeoGrid v
                | "geoip" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.GeoIpProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Geoip v
                | "grok" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.GrokProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Grok v
                | "gsub" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.GsubProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Gsub v
                | "html_strip" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.HtmlStripProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.HtmlStrip v
                | "inference" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.InferenceProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Inference v
                | "join" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.JoinProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Join v
                | "json" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.JsonProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Json v
                | "kv" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.KeyValueProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Kv v
                | "lowercase" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.LowercaseProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Lowercase v
                | "network_direction" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.NetworkDirectionProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.NetworkDirection v
                | "pipeline" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.PipelineProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Pipeline v
                | "redact" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.RedactProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Redact v
                | "registered_domain" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.RegisteredDomainProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.RegisteredDomain v
                | "remove" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.RemoveProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Remove v
                | "rename" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.RenameProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Rename v
                | "reroute" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.RerouteProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Reroute v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.ScriptProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Script v
                | "set" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.SetProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Set v
                | "set_security_user" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.SetSecurityUserProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.SetSecurityUser v
                | "sort" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.SortProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Sort v
                | "split" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.SplitProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Split v
                | "terminate" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.TerminateProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Terminate v
                | "trim" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.TrimProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Trim v
                | "uppercase" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.UppercaseProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Uppercase v
                | "urldecode" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.UrlDecodeProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.Urldecode v
                | "uri_parts" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.UriPartsProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.UriParts v
                | "user_agent" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<IngestTypes.UserAgentProcessor>(ref reader, options)
                    IngestTypes.ProcessorContainer.UserAgent v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    IngestTypes.ProcessorContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type ShapeTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.ShapeType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.ShapeType.GeoShape -> "geo_shape"
                | IngestTypes.ShapeType.Shape -> "shape"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "geo_shape" -> IngestTypes.ShapeType.GeoShape
            | "shape" -> IngestTypes.ShapeType.Shape
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShapeType"))

    type UserAgentPropertyConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<IngestTypes.UserAgentProperty>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | IngestTypes.UserAgentProperty.Name -> "name"
                | IngestTypes.UserAgentProperty.Os -> "os"
                | IngestTypes.UserAgentProperty.Device -> "device"
                | IngestTypes.UserAgentProperty.Original -> "original"
                | IngestTypes.UserAgentProperty.Version -> "version"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "name" -> IngestTypes.UserAgentProperty.Name
            | "os" -> IngestTypes.UserAgentProperty.Os
            | "device" -> IngestTypes.UserAgentProperty.Device
            | "original" -> IngestTypes.UserAgentProperty.Original
            | "version" -> IngestTypes.UserAgentProperty.Version
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for UserAgentProperty"))

    type LicenseStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LicenseTypes.LicenseStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LicenseTypes.LicenseStatus.Active -> "active"
                | LicenseTypes.LicenseStatus.Valid -> "valid"
                | LicenseTypes.LicenseStatus.Invalid -> "invalid"
                | LicenseTypes.LicenseStatus.Expired -> "expired"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "active" -> LicenseTypes.LicenseStatus.Active
            | "valid" -> LicenseTypes.LicenseStatus.Valid
            | "invalid" -> LicenseTypes.LicenseStatus.Invalid
            | "expired" -> LicenseTypes.LicenseStatus.Expired
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LicenseStatus"))

    type LicenseTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<LicenseTypes.LicenseType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | LicenseTypes.LicenseType.Missing -> "missing"
                | LicenseTypes.LicenseType.Trial -> "trial"
                | LicenseTypes.LicenseType.Basic -> "basic"
                | LicenseTypes.LicenseType.Standard -> "standard"
                | LicenseTypes.LicenseType.Dev -> "dev"
                | LicenseTypes.LicenseType.Silver -> "silver"
                | LicenseTypes.LicenseType.Gold -> "gold"
                | LicenseTypes.LicenseType.Platinum -> "platinum"
                | LicenseTypes.LicenseType.Enterprise -> "enterprise"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "missing" -> LicenseTypes.LicenseType.Missing
            | "trial" -> LicenseTypes.LicenseType.Trial
            | "basic" -> LicenseTypes.LicenseType.Basic
            | "standard" -> LicenseTypes.LicenseType.Standard
            | "dev" -> LicenseTypes.LicenseType.Dev
            | "silver" -> LicenseTypes.LicenseType.Silver
            | "gold" -> LicenseTypes.LicenseType.Gold
            | "platinum" -> LicenseTypes.LicenseType.Platinum
            | "enterprise" -> LicenseTypes.LicenseType.Enterprise
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for LicenseType"))

    type DeprecationLevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MigrationDeprecations.DeprecationLevel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MigrationDeprecations.DeprecationLevel.None -> "none"
                | MigrationDeprecations.DeprecationLevel.Info -> "info"
                | MigrationDeprecations.DeprecationLevel.Warning -> "warning"
                | MigrationDeprecations.DeprecationLevel.Critical -> "critical"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "none" -> MigrationDeprecations.DeprecationLevel.None
            | "info" -> MigrationDeprecations.DeprecationLevel.Info
            | "warning" -> MigrationDeprecations.DeprecationLevel.Warning
            | "critical" -> MigrationDeprecations.DeprecationLevel.Critical
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeprecationLevel"))

    type MigrationStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MigrationGetFeatureUpgradeStatus.MigrationStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MigrationGetFeatureUpgradeStatus.MigrationStatus.NOMIGRATIONNEEDED -> "NO_MIGRATION_NEEDED"
                | MigrationGetFeatureUpgradeStatus.MigrationStatus.MIGRATIONNEEDED -> "MIGRATION_NEEDED"
                | MigrationGetFeatureUpgradeStatus.MigrationStatus.INPROGRESS -> "IN_PROGRESS"
                | MigrationGetFeatureUpgradeStatus.MigrationStatus.ERROR -> "ERROR"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "NO_MIGRATION_NEEDED" -> MigrationGetFeatureUpgradeStatus.MigrationStatus.NOMIGRATIONNEEDED
            | "MIGRATION_NEEDED" -> MigrationGetFeatureUpgradeStatus.MigrationStatus.MIGRATIONNEEDED
            | "IN_PROGRESS" -> MigrationGetFeatureUpgradeStatus.MigrationStatus.INPROGRESS
            | "ERROR" -> MigrationGetFeatureUpgradeStatus.MigrationStatus.ERROR
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MigrationStatus"))

    type AppliesToConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.AppliesTo>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.AppliesTo.Actual -> "actual"
                | MlTypes.AppliesTo.Typical -> "typical"
                | MlTypes.AppliesTo.DiffFromTypical -> "diff_from_typical"
                | MlTypes.AppliesTo.Time -> "time"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "actual" -> MlTypes.AppliesTo.Actual
            | "typical" -> MlTypes.AppliesTo.Typical
            | "diff_from_typical" -> MlTypes.AppliesTo.DiffFromTypical
            | "time" -> MlTypes.AppliesTo.Time
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AppliesTo"))

    type CategorizationStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.CategorizationStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.CategorizationStatus.Ok -> "ok"
                | MlTypes.CategorizationStatus.Warn -> "warn"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ok" -> MlTypes.CategorizationStatus.Ok
            | "warn" -> MlTypes.CategorizationStatus.Warn
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for CategorizationStatus"))

    type ChunkingModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.ChunkingMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.ChunkingMode.Auto -> "auto"
                | MlTypes.ChunkingMode.Manual -> "manual"
                | MlTypes.ChunkingMode.Off -> "off"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "auto" -> MlTypes.ChunkingMode.Auto
            | "manual" -> MlTypes.ChunkingMode.Manual
            | "off" -> MlTypes.ChunkingMode.Off
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ChunkingMode"))

    type ConditionOperatorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.ConditionOperator>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.ConditionOperator.Gt -> "gt"
                | MlTypes.ConditionOperator.Gte -> "gte"
                | MlTypes.ConditionOperator.Lt -> "lt"
                | MlTypes.ConditionOperator.Lte -> "lte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "gt" -> MlTypes.ConditionOperator.Gt
            | "gte" -> MlTypes.ConditionOperator.Gte
            | "lt" -> MlTypes.ConditionOperator.Lt
            | "lte" -> MlTypes.ConditionOperator.Lte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConditionOperator"))

    type DatafeedStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DatafeedState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.DatafeedState.Started -> "started"
                | MlTypes.DatafeedState.Stopped -> "stopped"
                | MlTypes.DatafeedState.Starting -> "starting"
                | MlTypes.DatafeedState.Stopping -> "stopping"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> MlTypes.DatafeedState.Started
            | "stopped" -> MlTypes.DatafeedState.Stopped
            | "starting" -> MlTypes.DatafeedState.Starting
            | "stopping" -> MlTypes.DatafeedState.Stopping
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DatafeedState"))

    type DataframeAnalysisContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DataframeAnalysisContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlTypes.DataframeAnalysisContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalysisContainer.OutlierDetection v ->
                writer.WritePropertyName("outlier_detection")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalysisContainer.Regression v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisClassification>(ref reader, options)
                    MlTypes.DataframeAnalysisContainer.Classification v
                | "outlier_detection" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisOutlierDetection>(ref reader, options)
                    MlTypes.DataframeAnalysisContainer.OutlierDetection v
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisRegression>(ref reader, options)
                    MlTypes.DataframeAnalysisContainer.Regression v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeAnalysisContainer"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeAnalysisFeatureProcessorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DataframeAnalysisFeatureProcessor>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlTypes.DataframeAnalysisFeatureProcessor.FrequencyEncoding v ->
                writer.WritePropertyName("frequency_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalysisFeatureProcessor.MultiEncoding v ->
                writer.WritePropertyName("multi_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalysisFeatureProcessor.NGramEncoding v ->
                writer.WritePropertyName("n_gram_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalysisFeatureProcessor.OneHotEncoding v ->
                writer.WritePropertyName("one_hot_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalysisFeatureProcessor.TargetMeanEncoding v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisFeatureProcessorFrequencyEncoding>(ref reader, options)
                    MlTypes.DataframeAnalysisFeatureProcessor.FrequencyEncoding v
                | "multi_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisFeatureProcessorMultiEncoding>(ref reader, options)
                    MlTypes.DataframeAnalysisFeatureProcessor.MultiEncoding v
                | "n_gram_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisFeatureProcessorNGramEncoding>(ref reader, options)
                    MlTypes.DataframeAnalysisFeatureProcessor.NGramEncoding v
                | "one_hot_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisFeatureProcessorOneHotEncoding>(ref reader, options)
                    MlTypes.DataframeAnalysisFeatureProcessor.OneHotEncoding v
                | "target_mean_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalysisFeatureProcessorTargetMeanEncoding>(ref reader, options)
                    MlTypes.DataframeAnalysisFeatureProcessor.TargetMeanEncoding v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeAnalysisFeatureProcessor"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeAnalyticsStatsContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DataframeAnalyticsStatsContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlTypes.DataframeAnalyticsStatsContainer.ClassificationStats v ->
                writer.WritePropertyName("classification_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalyticsStatsContainer.OutlierDetectionStats v ->
                writer.WritePropertyName("outlier_detection_stats")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeAnalyticsStatsContainer.RegressionStats v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalyticsStatsHyperparameters>(ref reader, options)
                    MlTypes.DataframeAnalyticsStatsContainer.ClassificationStats v
                | "outlier_detection_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalyticsStatsOutlierDetection>(ref reader, options)
                    MlTypes.DataframeAnalyticsStatsContainer.OutlierDetectionStats v
                | "regression_stats" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeAnalyticsStatsHyperparameters>(ref reader, options)
                    MlTypes.DataframeAnalyticsStatsContainer.RegressionStats v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeAnalyticsStatsContainer"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeEvaluationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DataframeEvaluationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlTypes.DataframeEvaluationContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeEvaluationContainer.OutlierDetection v ->
                writer.WritePropertyName("outlier_detection")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.DataframeEvaluationContainer.Regression v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeEvaluationClassification>(ref reader, options)
                    MlTypes.DataframeEvaluationContainer.Classification v
                | "outlier_detection" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeEvaluationOutlierDetection>(ref reader, options)
                    MlTypes.DataframeEvaluationContainer.OutlierDetection v
                | "regression" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.DataframeEvaluationRegression>(ref reader, options)
                    MlTypes.DataframeEvaluationContainer.Regression v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for DataframeEvaluationContainer"))
            reader.Read() |> ignore // EndObject
            result

    type DataframeStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DataframeState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.DataframeState.Started -> "started"
                | MlTypes.DataframeState.Stopped -> "stopped"
                | MlTypes.DataframeState.Starting -> "starting"
                | MlTypes.DataframeState.Stopping -> "stopping"
                | MlTypes.DataframeState.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> MlTypes.DataframeState.Started
            | "stopped" -> MlTypes.DataframeState.Stopped
            | "starting" -> MlTypes.DataframeState.Starting
            | "stopping" -> MlTypes.DataframeState.Stopping
            | "failed" -> MlTypes.DataframeState.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DataframeState"))

    type DeploymentAllocationStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DeploymentAllocationState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.DeploymentAllocationState.Started -> "started"
                | MlTypes.DeploymentAllocationState.Starting -> "starting"
                | MlTypes.DeploymentAllocationState.FullyAllocated -> "fully_allocated"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> MlTypes.DeploymentAllocationState.Started
            | "starting" -> MlTypes.DeploymentAllocationState.Starting
            | "fully_allocated" -> MlTypes.DeploymentAllocationState.FullyAllocated
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeploymentAllocationState"))

    type DeploymentAssignmentStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.DeploymentAssignmentState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.DeploymentAssignmentState.Started -> "started"
                | MlTypes.DeploymentAssignmentState.Starting -> "starting"
                | MlTypes.DeploymentAssignmentState.Stopping -> "stopping"
                | MlTypes.DeploymentAssignmentState.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> MlTypes.DeploymentAssignmentState.Started
            | "starting" -> MlTypes.DeploymentAssignmentState.Starting
            | "stopping" -> MlTypes.DeploymentAssignmentState.Stopping
            | "failed" -> MlTypes.DeploymentAssignmentState.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DeploymentAssignmentState"))

    type ExcludeFrequentConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.ExcludeFrequent>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.ExcludeFrequent.All -> "all"
                | MlTypes.ExcludeFrequent.None -> "none"
                | MlTypes.ExcludeFrequent.By -> "by"
                | MlTypes.ExcludeFrequent.Over -> "over"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> MlTypes.ExcludeFrequent.All
            | "none" -> MlTypes.ExcludeFrequent.None
            | "by" -> MlTypes.ExcludeFrequent.By
            | "over" -> MlTypes.ExcludeFrequent.Over
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExcludeFrequent"))

    type FilterTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.FilterType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.FilterType.Include -> "include"
                | MlTypes.FilterType.Exclude -> "exclude"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "include" -> MlTypes.FilterType.Include
            | "exclude" -> MlTypes.FilterType.Exclude
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FilterType"))

    type IncludeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.Include>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.Include.Definition -> "definition"
                | MlTypes.Include.FeatureImportanceBaseline -> "feature_importance_baseline"
                | MlTypes.Include.Hyperparameters -> "hyperparameters"
                | MlTypes.Include.TotalFeatureImportance -> "total_feature_importance"
                | MlTypes.Include.DefinitionStatus -> "definition_status"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "definition" -> MlTypes.Include.Definition
            | "feature_importance_baseline" -> MlTypes.Include.FeatureImportanceBaseline
            | "hyperparameters" -> MlTypes.Include.Hyperparameters
            | "total_feature_importance" -> MlTypes.Include.TotalFeatureImportance
            | "definition_status" -> MlTypes.Include.DefinitionStatus
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Include"))

    type InferenceConfigCreateContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.InferenceConfigCreateContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlTypes.InferenceConfigCreateContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.TextClassification v ->
                writer.WritePropertyName("text_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.ZeroShotClassification v ->
                writer.WritePropertyName("zero_shot_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.FillMask v ->
                writer.WritePropertyName("fill_mask")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.LearningToRank v ->
                writer.WritePropertyName("learning_to_rank")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.Ner v ->
                writer.WritePropertyName("ner")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.PassThrough v ->
                writer.WritePropertyName("pass_through")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.TextExpansion v ->
                writer.WritePropertyName("text_expansion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigCreateContainer.QuestionAnswering v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.RegressionInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.ClassificationInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.Classification v
                | "text_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.TextClassificationInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.TextClassification v
                | "zero_shot_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.ZeroShotClassificationInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.ZeroShotClassification v
                | "fill_mask" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.FillMaskInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.FillMask v
                | "learning_to_rank" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.LearningToRankConfig>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.LearningToRank v
                | "ner" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.NerInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.Ner v
                | "pass_through" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.PassThroughInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.PassThrough v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.TextEmbeddingInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.TextEmbedding v
                | "text_expansion" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.TextExpansionInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.TextExpansion v
                | "question_answering" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.QuestionAnsweringInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigCreateContainer.QuestionAnswering v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfigCreateContainer"))
            reader.Read() |> ignore // EndObject
            result

    type InferenceConfigUpdateContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.InferenceConfigUpdateContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlTypes.InferenceConfigUpdateContainer.Regression v ->
                writer.WritePropertyName("regression")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.Classification v ->
                writer.WritePropertyName("classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.TextClassification v ->
                writer.WritePropertyName("text_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.ZeroShotClassification v ->
                writer.WritePropertyName("zero_shot_classification")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.FillMask v ->
                writer.WritePropertyName("fill_mask")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.Ner v ->
                writer.WritePropertyName("ner")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.PassThrough v ->
                writer.WritePropertyName("pass_through")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.TextEmbedding v ->
                writer.WritePropertyName("text_embedding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.TextExpansion v ->
                writer.WritePropertyName("text_expansion")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.InferenceConfigUpdateContainer.QuestionAnswering v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.RegressionInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.Regression v
                | "classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.ClassificationInferenceOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.Classification v
                | "text_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.TextClassificationInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.TextClassification v
                | "zero_shot_classification" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.ZeroShotClassificationInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.ZeroShotClassification v
                | "fill_mask" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.FillMaskInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.FillMask v
                | "ner" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.NerInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.Ner v
                | "pass_through" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.PassThroughInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.PassThrough v
                | "text_embedding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.TextEmbeddingInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.TextEmbedding v
                | "text_expansion" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.TextExpansionInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.TextExpansion v
                | "question_answering" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.QuestionAnsweringInferenceUpdateOptions>(ref reader, options)
                    MlTypes.InferenceConfigUpdateContainer.QuestionAnswering v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InferenceConfigUpdateContainer"))
            reader.Read() |> ignore // EndObject
            result

    type JobBlockedReasonConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.JobBlockedReason>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.JobBlockedReason.Delete -> "delete"
                | MlTypes.JobBlockedReason.Reset -> "reset"
                | MlTypes.JobBlockedReason.Revert -> "revert"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "delete" -> MlTypes.JobBlockedReason.Delete
            | "reset" -> MlTypes.JobBlockedReason.Reset
            | "revert" -> MlTypes.JobBlockedReason.Revert
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JobBlockedReason"))

    type JobStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.JobState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.JobState.Closing -> "closing"
                | MlTypes.JobState.Closed -> "closed"
                | MlTypes.JobState.Opened -> "opened"
                | MlTypes.JobState.Failed -> "failed"
                | MlTypes.JobState.Opening -> "opening"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "closing" -> MlTypes.JobState.Closing
            | "closed" -> MlTypes.JobState.Closed
            | "opened" -> MlTypes.JobState.Opened
            | "failed" -> MlTypes.JobState.Failed
            | "opening" -> MlTypes.JobState.Opening
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for JobState"))

    type MemoryStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.MemoryStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.MemoryStatus.Ok -> "ok"
                | MlTypes.MemoryStatus.SoftLimit -> "soft_limit"
                | MlTypes.MemoryStatus.HardLimit -> "hard_limit"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ok" -> MlTypes.MemoryStatus.Ok
            | "soft_limit" -> MlTypes.MemoryStatus.SoftLimit
            | "hard_limit" -> MlTypes.MemoryStatus.HardLimit
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MemoryStatus"))

    type RoutingStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.RoutingState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.RoutingState.Failed -> "failed"
                | MlTypes.RoutingState.Started -> "started"
                | MlTypes.RoutingState.Starting -> "starting"
                | MlTypes.RoutingState.Stopped -> "stopped"
                | MlTypes.RoutingState.Stopping -> "stopping"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "failed" -> MlTypes.RoutingState.Failed
            | "started" -> MlTypes.RoutingState.Started
            | "starting" -> MlTypes.RoutingState.Starting
            | "stopped" -> MlTypes.RoutingState.Stopped
            | "stopping" -> MlTypes.RoutingState.Stopping
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RoutingState"))

    type RuleActionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.RuleAction>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.RuleAction.SkipResult -> "skip_result"
                | MlTypes.RuleAction.SkipModelUpdate -> "skip_model_update"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "skip_result" -> MlTypes.RuleAction.SkipResult
            | "skip_model_update" -> MlTypes.RuleAction.SkipModelUpdate
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RuleAction"))

    type SnapshotUpgradeStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.SnapshotUpgradeState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.SnapshotUpgradeState.LoadingOldState -> "loading_old_state"
                | MlTypes.SnapshotUpgradeState.SavingNewState -> "saving_new_state"
                | MlTypes.SnapshotUpgradeState.Stopped -> "stopped"
                | MlTypes.SnapshotUpgradeState.Failed -> "failed"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "loading_old_state" -> MlTypes.SnapshotUpgradeState.LoadingOldState
            | "saving_new_state" -> MlTypes.SnapshotUpgradeState.SavingNewState
            | "stopped" -> MlTypes.SnapshotUpgradeState.Stopped
            | "failed" -> MlTypes.SnapshotUpgradeState.Failed
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnapshotUpgradeState"))

    type TokenizationConfigContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.TokenizationConfigContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlTypes.TokenizationConfigContainer.Bert v ->
                writer.WritePropertyName("bert")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.TokenizationConfigContainer.BertJa v ->
                writer.WritePropertyName("bert_ja")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.TokenizationConfigContainer.Mpnet v ->
                writer.WritePropertyName("mpnet")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.TokenizationConfigContainer.Roberta v ->
                writer.WritePropertyName("roberta")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlTypes.TokenizationConfigContainer.XlmRoberta v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.NlpBertTokenizationConfig>(ref reader, options)
                    MlTypes.TokenizationConfigContainer.Bert v
                | "bert_ja" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.NlpBertTokenizationConfig>(ref reader, options)
                    MlTypes.TokenizationConfigContainer.BertJa v
                | "mpnet" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.NlpBertTokenizationConfig>(ref reader, options)
                    MlTypes.TokenizationConfigContainer.Mpnet v
                | "roberta" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.NlpRobertaTokenizationConfig>(ref reader, options)
                    MlTypes.TokenizationConfigContainer.Roberta v
                | "xlm_roberta" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlTypes.XlmRobertaTokenizationConfig>(ref reader, options)
                    MlTypes.TokenizationConfigContainer.XlmRoberta v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TokenizationConfigContainer"))
            reader.Read() |> ignore // EndObject
            result

    type TokenizationTruncateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.TokenizationTruncate>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.TokenizationTruncate.First -> "first"
                | MlTypes.TokenizationTruncate.Second -> "second"
                | MlTypes.TokenizationTruncate.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "first" -> MlTypes.TokenizationTruncate.First
            | "second" -> MlTypes.TokenizationTruncate.Second
            | "none" -> MlTypes.TokenizationTruncate.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TokenizationTruncate"))

    type TrainedModelTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.TrainedModelType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.TrainedModelType.TreeEnsemble -> "tree_ensemble"
                | MlTypes.TrainedModelType.LangIdent -> "lang_ident"
                | MlTypes.TrainedModelType.Pytorch -> "pytorch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "tree_ensemble" -> MlTypes.TrainedModelType.TreeEnsemble
            | "lang_ident" -> MlTypes.TrainedModelType.LangIdent
            | "pytorch" -> MlTypes.TrainedModelType.Pytorch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TrainedModelType"))

    type TrainingPriorityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlTypes.TrainingPriority>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | MlTypes.TrainingPriority.Normal -> "normal"
                | MlTypes.TrainingPriority.Low -> "low"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "normal" -> MlTypes.TrainingPriority.Normal
            | "low" -> MlTypes.TrainingPriority.Low
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TrainingPriority"))

    type PreprocessorConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<MlPutTrainedModel.Preprocessor>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | MlPutTrainedModel.Preprocessor.FrequencyEncoding v ->
                writer.WritePropertyName("frequency_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlPutTrainedModel.Preprocessor.OneHotEncoding v ->
                writer.WritePropertyName("one_hot_encoding")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | MlPutTrainedModel.Preprocessor.TargetMeanEncoding v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlPutTrainedModel.FrequencyEncodingPreprocessor>(ref reader, options)
                    MlPutTrainedModel.Preprocessor.FrequencyEncoding v
                | "one_hot_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlPutTrainedModel.OneHotEncodingPreprocessor>(ref reader, options)
                    MlPutTrainedModel.Preprocessor.OneHotEncoding v
                | "target_mean_encoding" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<MlPutTrainedModel.TargetMeanEncodingPreprocessor>(ref reader, options)
                    MlPutTrainedModel.Preprocessor.TargetMeanEncoding v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for Preprocessor"))
            reader.Read() |> ignore // EndObject
            result

    type NodesInfoMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodesInfo.NodesInfoMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodesInfo.NodesInfoMetric.All -> "_all"
                | NodesInfo.NodesInfoMetric.None -> "_none"
                | NodesInfo.NodesInfoMetric.Settings -> "settings"
                | NodesInfo.NodesInfoMetric.Os -> "os"
                | NodesInfo.NodesInfoMetric.Process -> "process"
                | NodesInfo.NodesInfoMetric.Jvm -> "jvm"
                | NodesInfo.NodesInfoMetric.ThreadPool -> "thread_pool"
                | NodesInfo.NodesInfoMetric.Transport -> "transport"
                | NodesInfo.NodesInfoMetric.Http -> "http"
                | NodesInfo.NodesInfoMetric.RemoteClusterServer -> "remote_cluster_server"
                | NodesInfo.NodesInfoMetric.Plugins -> "plugins"
                | NodesInfo.NodesInfoMetric.Ingest -> "ingest"
                | NodesInfo.NodesInfoMetric.Aggregations -> "aggregations"
                | NodesInfo.NodesInfoMetric.Indices -> "indices"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> NodesInfo.NodesInfoMetric.All
            | "_none" -> NodesInfo.NodesInfoMetric.None
            | "settings" -> NodesInfo.NodesInfoMetric.Settings
            | "os" -> NodesInfo.NodesInfoMetric.Os
            | "process" -> NodesInfo.NodesInfoMetric.Process
            | "jvm" -> NodesInfo.NodesInfoMetric.Jvm
            | "thread_pool" -> NodesInfo.NodesInfoMetric.ThreadPool
            | "transport" -> NodesInfo.NodesInfoMetric.Transport
            | "http" -> NodesInfo.NodesInfoMetric.Http
            | "remote_cluster_server" -> NodesInfo.NodesInfoMetric.RemoteClusterServer
            | "plugins" -> NodesInfo.NodesInfoMetric.Plugins
            | "ingest" -> NodesInfo.NodesInfoMetric.Ingest
            | "aggregations" -> NodesInfo.NodesInfoMetric.Aggregations
            | "indices" -> NodesInfo.NodesInfoMetric.Indices
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodesInfoMetric"))

    type NodeStatsMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodesStats.NodeStatsMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodesStats.NodeStatsMetric.All -> "_all"
                | NodesStats.NodeStatsMetric.None -> "_none"
                | NodesStats.NodeStatsMetric.Indices -> "indices"
                | NodesStats.NodeStatsMetric.Os -> "os"
                | NodesStats.NodeStatsMetric.Process -> "process"
                | NodesStats.NodeStatsMetric.Jvm -> "jvm"
                | NodesStats.NodeStatsMetric.ThreadPool -> "thread_pool"
                | NodesStats.NodeStatsMetric.Fs -> "fs"
                | NodesStats.NodeStatsMetric.Transport -> "transport"
                | NodesStats.NodeStatsMetric.Http -> "http"
                | NodesStats.NodeStatsMetric.Breaker -> "breaker"
                | NodesStats.NodeStatsMetric.Script -> "script"
                | NodesStats.NodeStatsMetric.Discovery -> "discovery"
                | NodesStats.NodeStatsMetric.Ingest -> "ingest"
                | NodesStats.NodeStatsMetric.AdaptiveSelection -> "adaptive_selection"
                | NodesStats.NodeStatsMetric.ScriptCache -> "script_cache"
                | NodesStats.NodeStatsMetric.IndexingPressure -> "indexing_pressure"
                | NodesStats.NodeStatsMetric.Repositories -> "repositories"
                | NodesStats.NodeStatsMetric.Allocations -> "allocations"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> NodesStats.NodeStatsMetric.All
            | "_none" -> NodesStats.NodeStatsMetric.None
            | "indices" -> NodesStats.NodeStatsMetric.Indices
            | "os" -> NodesStats.NodeStatsMetric.Os
            | "process" -> NodesStats.NodeStatsMetric.Process
            | "jvm" -> NodesStats.NodeStatsMetric.Jvm
            | "thread_pool" -> NodesStats.NodeStatsMetric.ThreadPool
            | "fs" -> NodesStats.NodeStatsMetric.Fs
            | "transport" -> NodesStats.NodeStatsMetric.Transport
            | "http" -> NodesStats.NodeStatsMetric.Http
            | "breaker" -> NodesStats.NodeStatsMetric.Breaker
            | "script" -> NodesStats.NodeStatsMetric.Script
            | "discovery" -> NodesStats.NodeStatsMetric.Discovery
            | "ingest" -> NodesStats.NodeStatsMetric.Ingest
            | "adaptive_selection" -> NodesStats.NodeStatsMetric.AdaptiveSelection
            | "script_cache" -> NodesStats.NodeStatsMetric.ScriptCache
            | "indexing_pressure" -> NodesStats.NodeStatsMetric.IndexingPressure
            | "repositories" -> NodesStats.NodeStatsMetric.Repositories
            | "allocations" -> NodesStats.NodeStatsMetric.Allocations
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodeStatsMetric"))

    type NodesUsageMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<NodesUsage.NodesUsageMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | NodesUsage.NodesUsageMetric.All -> "_all"
                | NodesUsage.NodesUsageMetric.RestActions -> "rest_actions"
                | NodesUsage.NodesUsageMetric.Aggregations -> "aggregations"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> NodesUsage.NodesUsageMetric.All
            | "rest_actions" -> NodesUsage.NodesUsageMetric.RestActions
            | "aggregations" -> NodesUsage.NodesUsageMetric.Aggregations
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for NodesUsageMetric"))

    type ProfilingOperationModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ProfilingStatus.ProfilingOperationMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ProfilingStatus.ProfilingOperationMode.RUNNING -> "RUNNING"
                | ProfilingStatus.ProfilingOperationMode.STOPPING -> "STOPPING"
                | ProfilingStatus.ProfilingOperationMode.STOPPED -> "STOPPED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "RUNNING" -> ProfilingStatus.ProfilingOperationMode.RUNNING
            | "STOPPING" -> ProfilingStatus.ProfilingOperationMode.STOPPING
            | "STOPPED" -> ProfilingStatus.ProfilingOperationMode.STOPPED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ProfilingOperationMode"))

    type QueryRuleCriteriaTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<QueryRulesTypes.QueryRuleCriteriaType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | QueryRulesTypes.QueryRuleCriteriaType.Global -> "global"
                | QueryRulesTypes.QueryRuleCriteriaType.Exact -> "exact"
                | QueryRulesTypes.QueryRuleCriteriaType.Fuzzy -> "fuzzy"
                | QueryRulesTypes.QueryRuleCriteriaType.Prefix -> "prefix"
                | QueryRulesTypes.QueryRuleCriteriaType.Suffix -> "suffix"
                | QueryRulesTypes.QueryRuleCriteriaType.Contains -> "contains"
                | QueryRulesTypes.QueryRuleCriteriaType.Lt -> "lt"
                | QueryRulesTypes.QueryRuleCriteriaType.Lte -> "lte"
                | QueryRulesTypes.QueryRuleCriteriaType.Gt -> "gt"
                | QueryRulesTypes.QueryRuleCriteriaType.Gte -> "gte"
                | QueryRulesTypes.QueryRuleCriteriaType.Always -> "always"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "global" -> QueryRulesTypes.QueryRuleCriteriaType.Global
            | "exact" -> QueryRulesTypes.QueryRuleCriteriaType.Exact
            | "fuzzy" -> QueryRulesTypes.QueryRuleCriteriaType.Fuzzy
            | "prefix" -> QueryRulesTypes.QueryRuleCriteriaType.Prefix
            | "suffix" -> QueryRulesTypes.QueryRuleCriteriaType.Suffix
            | "contains" -> QueryRulesTypes.QueryRuleCriteriaType.Contains
            | "lt" -> QueryRulesTypes.QueryRuleCriteriaType.Lt
            | "lte" -> QueryRulesTypes.QueryRuleCriteriaType.Lte
            | "gt" -> QueryRulesTypes.QueryRuleCriteriaType.Gt
            | "gte" -> QueryRulesTypes.QueryRuleCriteriaType.Gte
            | "always" -> QueryRulesTypes.QueryRuleCriteriaType.Always
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for QueryRuleCriteriaType"))

    type QueryRuleTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<QueryRulesTypes.QueryRuleType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | QueryRulesTypes.QueryRuleType.Pinned -> "pinned"
                | QueryRulesTypes.QueryRuleType.Exclude -> "exclude"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "pinned" -> QueryRulesTypes.QueryRuleType.Pinned
            | "exclude" -> QueryRulesTypes.QueryRuleType.Exclude
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for QueryRuleType"))

    type MetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RollupTypes.Metric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RollupTypes.Metric.Min -> "min"
                | RollupTypes.Metric.Max -> "max"
                | RollupTypes.Metric.Sum -> "sum"
                | RollupTypes.Metric.Avg -> "avg"
                | RollupTypes.Metric.ValueCount -> "value_count"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "min" -> RollupTypes.Metric.Min
            | "max" -> RollupTypes.Metric.Max
            | "sum" -> RollupTypes.Metric.Sum
            | "avg" -> RollupTypes.Metric.Avg
            | "value_count" -> RollupTypes.Metric.ValueCount
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Metric"))

    type IndexingJobStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<RollupGetJobs.IndexingJobState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | RollupGetJobs.IndexingJobState.Started -> "started"
                | RollupGetJobs.IndexingJobState.Indexing -> "indexing"
                | RollupGetJobs.IndexingJobState.Stopping -> "stopping"
                | RollupGetJobs.IndexingJobState.Stopped -> "stopped"
                | RollupGetJobs.IndexingJobState.Aborting -> "aborting"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "started" -> RollupGetJobs.IndexingJobState.Started
            | "indexing" -> RollupGetJobs.IndexingJobState.Indexing
            | "stopping" -> RollupGetJobs.IndexingJobState.Stopping
            | "stopped" -> RollupGetJobs.IndexingJobState.Stopped
            | "aborting" -> RollupGetJobs.IndexingJobState.Aborting
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for IndexingJobState"))

    type EventTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SearchApplicationTypes.EventType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SearchApplicationTypes.EventType.PageView -> "page_view"
                | SearchApplicationTypes.EventType.Search -> "search"
                | SearchApplicationTypes.EventType.SearchClick -> "search_click"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "page_view" -> SearchApplicationTypes.EventType.PageView
            | "search" -> SearchApplicationTypes.EventType.Search
            | "search_click" -> SearchApplicationTypes.EventType.SearchClick
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EventType"))

    type StatsLevelConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SearchableSnapshotsTypes.StatsLevel>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SearchableSnapshotsTypes.StatsLevel.Cluster -> "cluster"
                | SearchableSnapshotsTypes.StatsLevel.Indices -> "indices"
                | SearchableSnapshotsTypes.StatsLevel.Shards -> "shards"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cluster" -> SearchableSnapshotsTypes.StatsLevel.Cluster
            | "indices" -> SearchableSnapshotsTypes.StatsLevel.Indices
            | "shards" -> SearchableSnapshotsTypes.StatsLevel.Shards
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StatsLevel"))

    type StorageOptionConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SearchableSnapshotsMount.StorageOption>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SearchableSnapshotsMount.StorageOption.FullCopy -> "full_copy"
                | SearchableSnapshotsMount.StorageOption.SharedCache -> "shared_cache"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "full_copy" -> SearchableSnapshotsMount.StorageOption.FullCopy
            | "shared_cache" -> SearchableSnapshotsMount.StorageOption.SharedCache
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StorageOption"))

    type ApiKeyManagedByConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.ApiKeyManagedBy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.ApiKeyManagedBy.Cloud -> "cloud"
                | SecurityTypes.ApiKeyManagedBy.Elasticsearch -> "elasticsearch"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "cloud" -> SecurityTypes.ApiKeyManagedBy.Cloud
            | "elasticsearch" -> SecurityTypes.ApiKeyManagedBy.Elasticsearch
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ApiKeyManagedBy"))

    type ApiKeyTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.ApiKeyType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.ApiKeyType.Rest -> "rest"
                | SecurityTypes.ApiKeyType.CrossCluster -> "cross_cluster"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "rest" -> SecurityTypes.ApiKeyType.Rest
            | "cross_cluster" -> SecurityTypes.ApiKeyType.CrossCluster
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ApiKeyType"))

    type ClusterPrivilegeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.ClusterPrivilege>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.ClusterPrivilege.All -> "all"
                | SecurityTypes.ClusterPrivilege.CancelTask -> "cancel_task"
                | SecurityTypes.ClusterPrivilege.CreateSnapshot -> "create_snapshot"
                | SecurityTypes.ClusterPrivilege.CrossClusterReplication -> "cross_cluster_replication"
                | SecurityTypes.ClusterPrivilege.CrossClusterSearch -> "cross_cluster_search"
                | SecurityTypes.ClusterPrivilege.DelegatePki -> "delegate_pki"
                | SecurityTypes.ClusterPrivilege.GrantApiKey -> "grant_api_key"
                | SecurityTypes.ClusterPrivilege.Manage -> "manage"
                | SecurityTypes.ClusterPrivilege.ManageApiKey -> "manage_api_key"
                | SecurityTypes.ClusterPrivilege.ManageAutoscaling -> "manage_autoscaling"
                | SecurityTypes.ClusterPrivilege.ManageBehavioralAnalytics -> "manage_behavioral_analytics"
                | SecurityTypes.ClusterPrivilege.ManageCcr -> "manage_ccr"
                | SecurityTypes.ClusterPrivilege.ManageDataFrameTransforms -> "manage_data_frame_transforms"
                | SecurityTypes.ClusterPrivilege.ManageDataStreamGlobalRetention -> "manage_data_stream_global_retention"
                | SecurityTypes.ClusterPrivilege.ManageEnrich -> "manage_enrich"
                | SecurityTypes.ClusterPrivilege.ManageEsql -> "manage_esql"
                | SecurityTypes.ClusterPrivilege.ManageIlm -> "manage_ilm"
                | SecurityTypes.ClusterPrivilege.ManageIndexTemplates -> "manage_index_templates"
                | SecurityTypes.ClusterPrivilege.ManageInference -> "manage_inference"
                | SecurityTypes.ClusterPrivilege.ManageIngestPipelines -> "manage_ingest_pipelines"
                | SecurityTypes.ClusterPrivilege.ManageLogstashPipelines -> "manage_logstash_pipelines"
                | SecurityTypes.ClusterPrivilege.ManageMl -> "manage_ml"
                | SecurityTypes.ClusterPrivilege.ManageOidc -> "manage_oidc"
                | SecurityTypes.ClusterPrivilege.ManageOwnApiKey -> "manage_own_api_key"
                | SecurityTypes.ClusterPrivilege.ManagePipeline -> "manage_pipeline"
                | SecurityTypes.ClusterPrivilege.ManageRollup -> "manage_rollup"
                | SecurityTypes.ClusterPrivilege.ManageSaml -> "manage_saml"
                | SecurityTypes.ClusterPrivilege.ManageSearchApplication -> "manage_search_application"
                | SecurityTypes.ClusterPrivilege.ManageSearchQueryRules -> "manage_search_query_rules"
                | SecurityTypes.ClusterPrivilege.ManageSearchSynonyms -> "manage_search_synonyms"
                | SecurityTypes.ClusterPrivilege.ManageSecurity -> "manage_security"
                | SecurityTypes.ClusterPrivilege.ManageServiceAccount -> "manage_service_account"
                | SecurityTypes.ClusterPrivilege.ManageSlm -> "manage_slm"
                | SecurityTypes.ClusterPrivilege.ManageToken -> "manage_token"
                | SecurityTypes.ClusterPrivilege.ManageTransform -> "manage_transform"
                | SecurityTypes.ClusterPrivilege.ManageUserProfile -> "manage_user_profile"
                | SecurityTypes.ClusterPrivilege.ManageWatcher -> "manage_watcher"
                | SecurityTypes.ClusterPrivilege.Monitor -> "monitor"
                | SecurityTypes.ClusterPrivilege.MonitorDataFrameTransforms -> "monitor_data_frame_transforms"
                | SecurityTypes.ClusterPrivilege.MonitorDataStreamGlobalRetention -> "monitor_data_stream_global_retention"
                | SecurityTypes.ClusterPrivilege.MonitorEnrich -> "monitor_enrich"
                | SecurityTypes.ClusterPrivilege.MonitorEsql -> "monitor_esql"
                | SecurityTypes.ClusterPrivilege.MonitorInference -> "monitor_inference"
                | SecurityTypes.ClusterPrivilege.MonitorMl -> "monitor_ml"
                | SecurityTypes.ClusterPrivilege.MonitorRollup -> "monitor_rollup"
                | SecurityTypes.ClusterPrivilege.MonitorSnapshot -> "monitor_snapshot"
                | SecurityTypes.ClusterPrivilege.MonitorStats -> "monitor_stats"
                | SecurityTypes.ClusterPrivilege.MonitorTextStructure -> "monitor_text_structure"
                | SecurityTypes.ClusterPrivilege.MonitorTransform -> "monitor_transform"
                | SecurityTypes.ClusterPrivilege.MonitorWatcher -> "monitor_watcher"
                | SecurityTypes.ClusterPrivilege.None -> "none"
                | SecurityTypes.ClusterPrivilege.PostBehavioralAnalyticsEvent -> "post_behavioral_analytics_event"
                | SecurityTypes.ClusterPrivilege.ReadCcr -> "read_ccr"
                | SecurityTypes.ClusterPrivilege.ReadFleetSecrets -> "read_fleet_secrets"
                | SecurityTypes.ClusterPrivilege.ReadIlm -> "read_ilm"
                | SecurityTypes.ClusterPrivilege.ReadPipeline -> "read_pipeline"
                | SecurityTypes.ClusterPrivilege.ReadSecurity -> "read_security"
                | SecurityTypes.ClusterPrivilege.ReadSlm -> "read_slm"
                | SecurityTypes.ClusterPrivilege.TransportClient -> "transport_client"
                | SecurityTypes.ClusterPrivilege.WriteConnectorSecrets -> "write_connector_secrets"
                | SecurityTypes.ClusterPrivilege.WriteFleetSecrets -> "write_fleet_secrets"
                | SecurityTypes.ClusterPrivilege.ReadProjectRouting -> "read_project_routing"
                | SecurityTypes.ClusterPrivilege.ManageProjectRouting -> "manage_project_routing"
                | SecurityTypes.ClusterPrivilege.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> SecurityTypes.ClusterPrivilege.All
            | "cancel_task" -> SecurityTypes.ClusterPrivilege.CancelTask
            | "create_snapshot" -> SecurityTypes.ClusterPrivilege.CreateSnapshot
            | "cross_cluster_replication" -> SecurityTypes.ClusterPrivilege.CrossClusterReplication
            | "cross_cluster_search" -> SecurityTypes.ClusterPrivilege.CrossClusterSearch
            | "delegate_pki" -> SecurityTypes.ClusterPrivilege.DelegatePki
            | "grant_api_key" -> SecurityTypes.ClusterPrivilege.GrantApiKey
            | "manage" -> SecurityTypes.ClusterPrivilege.Manage
            | "manage_api_key" -> SecurityTypes.ClusterPrivilege.ManageApiKey
            | "manage_autoscaling" -> SecurityTypes.ClusterPrivilege.ManageAutoscaling
            | "manage_behavioral_analytics" -> SecurityTypes.ClusterPrivilege.ManageBehavioralAnalytics
            | "manage_ccr" -> SecurityTypes.ClusterPrivilege.ManageCcr
            | "manage_data_frame_transforms" -> SecurityTypes.ClusterPrivilege.ManageDataFrameTransforms
            | "manage_data_stream_global_retention" -> SecurityTypes.ClusterPrivilege.ManageDataStreamGlobalRetention
            | "manage_enrich" -> SecurityTypes.ClusterPrivilege.ManageEnrich
            | "manage_esql" -> SecurityTypes.ClusterPrivilege.ManageEsql
            | "manage_ilm" -> SecurityTypes.ClusterPrivilege.ManageIlm
            | "manage_index_templates" -> SecurityTypes.ClusterPrivilege.ManageIndexTemplates
            | "manage_inference" -> SecurityTypes.ClusterPrivilege.ManageInference
            | "manage_ingest_pipelines" -> SecurityTypes.ClusterPrivilege.ManageIngestPipelines
            | "manage_logstash_pipelines" -> SecurityTypes.ClusterPrivilege.ManageLogstashPipelines
            | "manage_ml" -> SecurityTypes.ClusterPrivilege.ManageMl
            | "manage_oidc" -> SecurityTypes.ClusterPrivilege.ManageOidc
            | "manage_own_api_key" -> SecurityTypes.ClusterPrivilege.ManageOwnApiKey
            | "manage_pipeline" -> SecurityTypes.ClusterPrivilege.ManagePipeline
            | "manage_rollup" -> SecurityTypes.ClusterPrivilege.ManageRollup
            | "manage_saml" -> SecurityTypes.ClusterPrivilege.ManageSaml
            | "manage_search_application" -> SecurityTypes.ClusterPrivilege.ManageSearchApplication
            | "manage_search_query_rules" -> SecurityTypes.ClusterPrivilege.ManageSearchQueryRules
            | "manage_search_synonyms" -> SecurityTypes.ClusterPrivilege.ManageSearchSynonyms
            | "manage_security" -> SecurityTypes.ClusterPrivilege.ManageSecurity
            | "manage_service_account" -> SecurityTypes.ClusterPrivilege.ManageServiceAccount
            | "manage_slm" -> SecurityTypes.ClusterPrivilege.ManageSlm
            | "manage_token" -> SecurityTypes.ClusterPrivilege.ManageToken
            | "manage_transform" -> SecurityTypes.ClusterPrivilege.ManageTransform
            | "manage_user_profile" -> SecurityTypes.ClusterPrivilege.ManageUserProfile
            | "manage_watcher" -> SecurityTypes.ClusterPrivilege.ManageWatcher
            | "monitor" -> SecurityTypes.ClusterPrivilege.Monitor
            | "monitor_data_frame_transforms" -> SecurityTypes.ClusterPrivilege.MonitorDataFrameTransforms
            | "monitor_data_stream_global_retention" -> SecurityTypes.ClusterPrivilege.MonitorDataStreamGlobalRetention
            | "monitor_enrich" -> SecurityTypes.ClusterPrivilege.MonitorEnrich
            | "monitor_esql" -> SecurityTypes.ClusterPrivilege.MonitorEsql
            | "monitor_inference" -> SecurityTypes.ClusterPrivilege.MonitorInference
            | "monitor_ml" -> SecurityTypes.ClusterPrivilege.MonitorMl
            | "monitor_rollup" -> SecurityTypes.ClusterPrivilege.MonitorRollup
            | "monitor_snapshot" -> SecurityTypes.ClusterPrivilege.MonitorSnapshot
            | "monitor_stats" -> SecurityTypes.ClusterPrivilege.MonitorStats
            | "monitor_text_structure" -> SecurityTypes.ClusterPrivilege.MonitorTextStructure
            | "monitor_transform" -> SecurityTypes.ClusterPrivilege.MonitorTransform
            | "monitor_watcher" -> SecurityTypes.ClusterPrivilege.MonitorWatcher
            | "none" -> SecurityTypes.ClusterPrivilege.None
            | "post_behavioral_analytics_event" -> SecurityTypes.ClusterPrivilege.PostBehavioralAnalyticsEvent
            | "read_ccr" -> SecurityTypes.ClusterPrivilege.ReadCcr
            | "read_fleet_secrets" -> SecurityTypes.ClusterPrivilege.ReadFleetSecrets
            | "read_ilm" -> SecurityTypes.ClusterPrivilege.ReadIlm
            | "read_pipeline" -> SecurityTypes.ClusterPrivilege.ReadPipeline
            | "read_security" -> SecurityTypes.ClusterPrivilege.ReadSecurity
            | "read_slm" -> SecurityTypes.ClusterPrivilege.ReadSlm
            | "transport_client" -> SecurityTypes.ClusterPrivilege.TransportClient
            | "write_connector_secrets" -> SecurityTypes.ClusterPrivilege.WriteConnectorSecrets
            | "write_fleet_secrets" -> SecurityTypes.ClusterPrivilege.WriteFleetSecrets
            | "read_project_routing" -> SecurityTypes.ClusterPrivilege.ReadProjectRouting
            | "manage_project_routing" -> SecurityTypes.ClusterPrivilege.ManageProjectRouting
            | other -> SecurityTypes.ClusterPrivilege.Custom other

    type GrantTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.GrantType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.GrantType.Password -> "password"
                | SecurityTypes.GrantType.AccessToken -> "access_token"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "password" -> SecurityTypes.GrantType.Password
            | "access_token" -> SecurityTypes.GrantType.AccessToken
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GrantType"))

    type IndexPrivilegeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.IndexPrivilege>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.IndexPrivilege.All -> "all"
                | SecurityTypes.IndexPrivilege.AutoConfigure -> "auto_configure"
                | SecurityTypes.IndexPrivilege.Create -> "create"
                | SecurityTypes.IndexPrivilege.CreateDoc -> "create_doc"
                | SecurityTypes.IndexPrivilege.CreateIndex -> "create_index"
                | SecurityTypes.IndexPrivilege.CreateView -> "create_view"
                | SecurityTypes.IndexPrivilege.CrossClusterReplication -> "cross_cluster_replication"
                | SecurityTypes.IndexPrivilege.CrossClusterReplicationInternal -> "cross_cluster_replication_internal"
                | SecurityTypes.IndexPrivilege.Delete -> "delete"
                | SecurityTypes.IndexPrivilege.DeleteIndex -> "delete_index"
                | SecurityTypes.IndexPrivilege.DeleteView -> "delete_view"
                | SecurityTypes.IndexPrivilege.Index -> "index"
                | SecurityTypes.IndexPrivilege.Maintenance -> "maintenance"
                | SecurityTypes.IndexPrivilege.Manage -> "manage"
                | SecurityTypes.IndexPrivilege.ManageDataStreamLifecycle -> "manage_data_stream_lifecycle"
                | SecurityTypes.IndexPrivilege.ManageFollowIndex -> "manage_follow_index"
                | SecurityTypes.IndexPrivilege.ManageIlm -> "manage_ilm"
                | SecurityTypes.IndexPrivilege.ManageLeaderIndex -> "manage_leader_index"
                | SecurityTypes.IndexPrivilege.ManageView -> "manage_view"
                | SecurityTypes.IndexPrivilege.Monitor -> "monitor"
                | SecurityTypes.IndexPrivilege.None -> "none"
                | SecurityTypes.IndexPrivilege.Read -> "read"
                | SecurityTypes.IndexPrivilege.ReadCrossCluster -> "read_cross_cluster"
                | SecurityTypes.IndexPrivilege.ReadViewMetadata -> "read_view_metadata"
                | SecurityTypes.IndexPrivilege.ViewIndexMetadata -> "view_index_metadata"
                | SecurityTypes.IndexPrivilege.Write -> "write"
                | SecurityTypes.IndexPrivilege.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "all" -> SecurityTypes.IndexPrivilege.All
            | "auto_configure" -> SecurityTypes.IndexPrivilege.AutoConfigure
            | "create" -> SecurityTypes.IndexPrivilege.Create
            | "create_doc" -> SecurityTypes.IndexPrivilege.CreateDoc
            | "create_index" -> SecurityTypes.IndexPrivilege.CreateIndex
            | "create_view" -> SecurityTypes.IndexPrivilege.CreateView
            | "cross_cluster_replication" -> SecurityTypes.IndexPrivilege.CrossClusterReplication
            | "cross_cluster_replication_internal" -> SecurityTypes.IndexPrivilege.CrossClusterReplicationInternal
            | "delete" -> SecurityTypes.IndexPrivilege.Delete
            | "delete_index" -> SecurityTypes.IndexPrivilege.DeleteIndex
            | "delete_view" -> SecurityTypes.IndexPrivilege.DeleteView
            | "index" -> SecurityTypes.IndexPrivilege.Index
            | "maintenance" -> SecurityTypes.IndexPrivilege.Maintenance
            | "manage" -> SecurityTypes.IndexPrivilege.Manage
            | "manage_data_stream_lifecycle" -> SecurityTypes.IndexPrivilege.ManageDataStreamLifecycle
            | "manage_follow_index" -> SecurityTypes.IndexPrivilege.ManageFollowIndex
            | "manage_ilm" -> SecurityTypes.IndexPrivilege.ManageIlm
            | "manage_leader_index" -> SecurityTypes.IndexPrivilege.ManageLeaderIndex
            | "manage_view" -> SecurityTypes.IndexPrivilege.ManageView
            | "monitor" -> SecurityTypes.IndexPrivilege.Monitor
            | "none" -> SecurityTypes.IndexPrivilege.None
            | "read" -> SecurityTypes.IndexPrivilege.Read
            | "read_cross_cluster" -> SecurityTypes.IndexPrivilege.ReadCrossCluster
            | "read_view_metadata" -> SecurityTypes.IndexPrivilege.ReadViewMetadata
            | "view_index_metadata" -> SecurityTypes.IndexPrivilege.ViewIndexMetadata
            | "write" -> SecurityTypes.IndexPrivilege.Write
            | other -> SecurityTypes.IndexPrivilege.Custom other

    type RemoteClusterPrivilegeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.RemoteClusterPrivilege>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.RemoteClusterPrivilege.MonitorEnrich -> "monitor_enrich"
                | SecurityTypes.RemoteClusterPrivilege.MonitorStats -> "monitor_stats"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "monitor_enrich" -> SecurityTypes.RemoteClusterPrivilege.MonitorEnrich
            | "monitor_stats" -> SecurityTypes.RemoteClusterPrivilege.MonitorStats
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for RemoteClusterPrivilege"))

    type RestrictionWorkflowConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.RestrictionWorkflow>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.RestrictionWorkflow.SearchApplicationQuery -> "search_application_query"
                | SecurityTypes.RestrictionWorkflow.Custom v -> v
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "search_application_query" -> SecurityTypes.RestrictionWorkflow.SearchApplicationQuery
            | other -> SecurityTypes.RestrictionWorkflow.Custom other

    type RoleMappingRuleConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.RoleMappingRule>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SecurityTypes.RoleMappingRule.Any v ->
                writer.WritePropertyName("any")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityTypes.RoleMappingRule.All v ->
                writer.WritePropertyName("all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityTypes.RoleMappingRule.Field (field, v) ->
                writer.WritePropertyName("field")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityTypes.RoleMappingRule.Except v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<SecurityTypes.RoleMappingRule list>(ref reader, options)
                    SecurityTypes.RoleMappingRule.Any v
                | "all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<SecurityTypes.RoleMappingRule list>(ref reader, options)
                    SecurityTypes.RoleMappingRule.All v
                | "field" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityTypes.RoleMappingRule.Field (field, v)
                | "except" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<SecurityTypes.RoleMappingRule>(ref reader, options)
                    SecurityTypes.RoleMappingRule.Except v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RoleMappingRule"))
            reader.Read() |> ignore // EndObject
            result

    type TemplateFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityTypes.TemplateFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityTypes.TemplateFormat.String -> "string"
                | SecurityTypes.TemplateFormat.Json -> "json"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "string" -> SecurityTypes.TemplateFormat.String
            | "json" -> SecurityTypes.TemplateFormat.Json
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for TemplateFormat"))

    type AccessTokenGrantTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityGetToken.AccessTokenGrantType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityGetToken.AccessTokenGrantType.Password -> "password"
                | SecurityGetToken.AccessTokenGrantType.ClientCredentials -> "client_credentials"
                | SecurityGetToken.AccessTokenGrantType.Kerberos -> "_kerberos"
                | SecurityGetToken.AccessTokenGrantType.RefreshToken -> "refresh_token"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "password" -> SecurityGetToken.AccessTokenGrantType.Password
            | "client_credentials" -> SecurityGetToken.AccessTokenGrantType.ClientCredentials
            | "_kerberos" -> SecurityGetToken.AccessTokenGrantType.Kerberos
            | "refresh_token" -> SecurityGetToken.AccessTokenGrantType.RefreshToken
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AccessTokenGrantType"))

    type ApiKeyGrantTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityGrantApiKey.ApiKeyGrantType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SecurityGrantApiKey.ApiKeyGrantType.AccessToken -> "access_token"
                | SecurityGrantApiKey.ApiKeyGrantType.Password -> "password"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "access_token" -> SecurityGrantApiKey.ApiKeyGrantType.AccessToken
            | "password" -> SecurityGrantApiKey.ApiKeyGrantType.Password
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ApiKeyGrantType"))

    type ApiKeyAggregationContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityQueryApiKeys.ApiKeyAggregationContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Cardinality v ->
                writer.WritePropertyName("cardinality")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Composite v ->
                writer.WritePropertyName("composite")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.DateRange v ->
                writer.WritePropertyName("date_range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Filter v ->
                writer.WritePropertyName("filter")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Filters v ->
                writer.WritePropertyName("filters")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Missing v ->
                writer.WritePropertyName("missing")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Range v ->
                writer.WritePropertyName("range")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.ValueCount v ->
                writer.WritePropertyName("value_count")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyAggregationContainer.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CardinalityAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Cardinality v
                | "composite" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.CompositeAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Composite v
                | "date_range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.DateRangeAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.DateRange v
                | "filter" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<SecurityQueryApiKeys.ApiKeyQueryContainer>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Filter v
                | "filters" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<SecurityQueryApiKeys.ApiKeyFiltersAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Filters v
                | "missing" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.MissingAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Missing v
                | "range" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.RangeAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Range v
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TermsAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Terms v
                | "value_count" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.ValueCountAggregation>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.ValueCount v
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    SecurityQueryApiKeys.ApiKeyAggregationContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type ApiKeyQueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityQueryApiKeys.ApiKeyQueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryApiKeys.ApiKeyQueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryApiKeys.ApiKeyQueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryApiKeys.ApiKeyQueryContainer.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.BoolQuery>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Bool v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ExistsQuery>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Exists v
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IdsQuery>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Ids v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchAllQuery>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyQueryContainer.MatchAll v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.PrefixQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Prefix (field, v)
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RangeQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Range (field, v)
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SimpleQueryStringQuery>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyQueryContainer.SimpleQueryString v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermsQuery>(ref reader, options)
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Terms v
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.WildcardQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Wildcard (field, v)
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    SecurityQueryApiKeys.ApiKeyQueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type RoleQueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityQueryRole.RoleQueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SecurityQueryRole.RoleQueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryRole.RoleQueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryRole.RoleQueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryRole.RoleQueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryRole.RoleQueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryRole.RoleQueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryRole.RoleQueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryRole.RoleQueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryRole.RoleQueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryRole.RoleQueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryRole.RoleQueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryRole.RoleQueryContainer.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.BoolQuery>(ref reader, options)
                    SecurityQueryRole.RoleQueryContainer.Bool v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ExistsQuery>(ref reader, options)
                    SecurityQueryRole.RoleQueryContainer.Exists v
                | "ids" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IdsQuery>(ref reader, options)
                    SecurityQueryRole.RoleQueryContainer.Ids v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryRole.RoleQueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchAllQuery>(ref reader, options)
                    SecurityQueryRole.RoleQueryContainer.MatchAll v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.PrefixQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryRole.RoleQueryContainer.Prefix (field, v)
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RangeQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryRole.RoleQueryContainer.Range (field, v)
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SimpleQueryStringQuery>(ref reader, options)
                    SecurityQueryRole.RoleQueryContainer.SimpleQueryString v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryRole.RoleQueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermsQuery>(ref reader, options)
                    SecurityQueryRole.RoleQueryContainer.Terms v
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.WildcardQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryRole.RoleQueryContainer.Wildcard (field, v)
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    SecurityQueryRole.RoleQueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type UserQueryContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SecurityQueryUser.UserQueryContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | SecurityQueryUser.UserQueryContainer.Ids v ->
                writer.WritePropertyName("ids")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryUser.UserQueryContainer.Bool v ->
                writer.WritePropertyName("bool")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryUser.UserQueryContainer.Exists v ->
                writer.WritePropertyName("exists")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryUser.UserQueryContainer.Match (field, v) ->
                writer.WritePropertyName("match")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryUser.UserQueryContainer.MatchAll v ->
                writer.WritePropertyName("match_all")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryUser.UserQueryContainer.Prefix (field, v) ->
                writer.WritePropertyName("prefix")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryUser.UserQueryContainer.Range (field, v) ->
                writer.WritePropertyName("range")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryUser.UserQueryContainer.SimpleQueryString v ->
                writer.WritePropertyName("simple_query_string")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryUser.UserQueryContainer.Term (field, v) ->
                writer.WritePropertyName("term")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryUser.UserQueryContainer.Terms v ->
                writer.WritePropertyName("terms")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SecurityQueryUser.UserQueryContainer.Wildcard (field, v) ->
                writer.WritePropertyName("wildcard")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | SecurityQueryUser.UserQueryContainer.Unknown (name, el) ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.IdsQuery>(ref reader, options)
                    SecurityQueryUser.UserQueryContainer.Ids v
                | "bool" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.BoolQuery>(ref reader, options)
                    SecurityQueryUser.UserQueryContainer.Bool v
                | "exists" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.ExistsQuery>(ref reader, options)
                    SecurityQueryUser.UserQueryContainer.Exists v
                | "match" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryUser.UserQueryContainer.Match (field, v)
                | "match_all" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.MatchAllQuery>(ref reader, options)
                    SecurityQueryUser.UserQueryContainer.MatchAll v
                | "prefix" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.PrefixQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryUser.UserQueryContainer.Prefix (field, v)
                | "range" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.RangeQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryUser.UserQueryContainer.Range (field, v)
                | "simple_query_string" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.SimpleQueryStringQuery>(ref reader, options)
                    SecurityQueryUser.UserQueryContainer.SimpleQueryString v
                | "term" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryUser.UserQueryContainer.Term (field, v)
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.TermsQuery>(ref reader, options)
                    SecurityQueryUser.UserQueryContainer.Terms v
                | "wildcard" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesQueryDsl.WildcardQuery>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    SecurityQueryUser.UserQueryContainer.Wildcard (field, v)
                | other ->
                    let el = System.Text.Json.JsonElement.ParseValue(ref reader)
                    SecurityQueryUser.UserQueryContainer.Unknown (other, el)
            reader.Read() |> ignore // EndObject
            result

    type TypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShutdownTypes.Type>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShutdownTypes.Type.Restart -> "restart"
                | ShutdownTypes.Type.Remove -> "remove"
                | ShutdownTypes.Type.Replace -> "replace"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "restart" -> ShutdownTypes.Type.Restart
            | "remove" -> ShutdownTypes.Type.Remove
            | "replace" -> ShutdownTypes.Type.Replace
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Type"))

    type ShutdownStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShutdownGetNode.ShutdownStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShutdownGetNode.ShutdownStatus.NotStarted -> "not_started"
                | ShutdownGetNode.ShutdownStatus.InProgress -> "in_progress"
                | ShutdownGetNode.ShutdownStatus.Stalled -> "stalled"
                | ShutdownGetNode.ShutdownStatus.Complete -> "complete"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "not_started" -> ShutdownGetNode.ShutdownStatus.NotStarted
            | "in_progress" -> ShutdownGetNode.ShutdownStatus.InProgress
            | "stalled" -> ShutdownGetNode.ShutdownStatus.Stalled
            | "complete" -> ShutdownGetNode.ShutdownStatus.Complete
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShutdownStatus"))

    type ShutdownTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<ShutdownGetNode.ShutdownType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | ShutdownGetNode.ShutdownType.Remove -> "remove"
                | ShutdownGetNode.ShutdownType.Restart -> "restart"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "remove" -> ShutdownGetNode.ShutdownType.Remove
            | "restart" -> ShutdownGetNode.ShutdownType.Restart
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShutdownType"))

    type MergeTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SimulateIngest.MergeType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SimulateIngest.MergeType.Index -> "index"
                | SimulateIngest.MergeType.Template -> "template"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "index" -> SimulateIngest.MergeType.Index
            | "template" -> SimulateIngest.MergeType.Template
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for MergeType"))

    type RepositoryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnapshotTypes.Repository>()

        override _.Write(writer, value, options) =
            match value with
            | SnapshotTypes.Repository.AzureRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SnapshotTypes.Repository.GcsRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SnapshotTypes.Repository.S3Repository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SnapshotTypes.Repository.SharedFileSystemRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SnapshotTypes.Repository.ReadOnlyUrlRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SnapshotTypes.Repository.SourceOnlyRepository v ->
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | SnapshotTypes.Repository.Unknown (_, el) -> el.WriteTo(writer)

        override _.Read(reader, _typeToConvert, options) =
            let doc = System.Text.Json.JsonDocument.ParseValue(ref reader)
            let tagValue =
                match doc.RootElement.TryGetProperty("type") with
                | true, v -> v.GetString()
                | _ -> ""
            match tagValue with
            | "azurerepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<SnapshotTypes.AzureRepository>(doc.RootElement.GetRawText(), options)
                SnapshotTypes.Repository.AzureRepository v
            | "gcsrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<SnapshotTypes.GcsRepository>(doc.RootElement.GetRawText(), options)
                SnapshotTypes.Repository.GcsRepository v
            | "s3repository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<SnapshotTypes.S3Repository>(doc.RootElement.GetRawText(), options)
                SnapshotTypes.Repository.S3Repository v
            | "sharedfilesystemrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<SnapshotTypes.SharedFileSystemRepository>(doc.RootElement.GetRawText(), options)
                SnapshotTypes.Repository.SharedFileSystemRepository v
            | "readonlyurlrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<SnapshotTypes.ReadOnlyUrlRepository>(doc.RootElement.GetRawText(), options)
                SnapshotTypes.Repository.ReadOnlyUrlRepository v
            | "sourceonlyrepository" ->
                let v = System.Text.Json.JsonSerializer.Deserialize<SnapshotTypes.SourceOnlyRepository>(doc.RootElement.GetRawText(), options)
                SnapshotTypes.Repository.SourceOnlyRepository v
            | _ -> SnapshotTypes.Repository.Unknown (tagValue, doc.RootElement.Clone())

    type ShardsStatsStageConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnapshotTypes.ShardsStatsStage>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SnapshotTypes.ShardsStatsStage.DONE -> "DONE"
                | SnapshotTypes.ShardsStatsStage.FAILURE -> "FAILURE"
                | SnapshotTypes.ShardsStatsStage.FINALIZE -> "FINALIZE"
                | SnapshotTypes.ShardsStatsStage.INIT -> "INIT"
                | SnapshotTypes.ShardsStatsStage.STARTED -> "STARTED"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "DONE" -> SnapshotTypes.ShardsStatsStage.DONE
            | "FAILURE" -> SnapshotTypes.ShardsStatsStage.FAILURE
            | "FINALIZE" -> SnapshotTypes.ShardsStatsStage.FINALIZE
            | "INIT" -> SnapshotTypes.ShardsStatsStage.INIT
            | "STARTED" -> SnapshotTypes.ShardsStatsStage.STARTED
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ShardsStatsStage"))

    type SnapshotSortConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnapshotTypes.SnapshotSort>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SnapshotTypes.SnapshotSort.StartTime -> "start_time"
                | SnapshotTypes.SnapshotSort.Duration -> "duration"
                | SnapshotTypes.SnapshotSort.Name -> "name"
                | SnapshotTypes.SnapshotSort.IndexCount -> "index_count"
                | SnapshotTypes.SnapshotSort.Repository -> "repository"
                | SnapshotTypes.SnapshotSort.ShardCount -> "shard_count"
                | SnapshotTypes.SnapshotSort.FailedShardCount -> "failed_shard_count"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "start_time" -> SnapshotTypes.SnapshotSort.StartTime
            | "duration" -> SnapshotTypes.SnapshotSort.Duration
            | "name" -> SnapshotTypes.SnapshotSort.Name
            | "index_count" -> SnapshotTypes.SnapshotSort.IndexCount
            | "repository" -> SnapshotTypes.SnapshotSort.Repository
            | "shard_count" -> SnapshotTypes.SnapshotSort.ShardCount
            | "failed_shard_count" -> SnapshotTypes.SnapshotSort.FailedShardCount
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnapshotSort"))

    type SnapshotStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SnapshotTypes.SnapshotState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SnapshotTypes.SnapshotState.INPROGRESS -> "IN_PROGRESS"
                | SnapshotTypes.SnapshotState.SUCCESS -> "SUCCESS"
                | SnapshotTypes.SnapshotState.FAILED -> "FAILED"
                | SnapshotTypes.SnapshotState.PARTIAL -> "PARTIAL"
                | SnapshotTypes.SnapshotState.INCOMPATIBLE -> "INCOMPATIBLE"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "IN_PROGRESS" -> SnapshotTypes.SnapshotState.INPROGRESS
            | "SUCCESS" -> SnapshotTypes.SnapshotState.SUCCESS
            | "FAILED" -> SnapshotTypes.SnapshotState.FAILED
            | "PARTIAL" -> SnapshotTypes.SnapshotState.PARTIAL
            | "INCOMPATIBLE" -> SnapshotTypes.SnapshotState.INCOMPATIBLE
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SnapshotState"))

    type SqlFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<SqlQuery.SqlFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | SqlQuery.SqlFormat.Csv -> "csv"
                | SqlQuery.SqlFormat.Json -> "json"
                | SqlQuery.SqlFormat.Tsv -> "tsv"
                | SqlQuery.SqlFormat.Txt -> "txt"
                | SqlQuery.SqlFormat.Yaml -> "yaml"
                | SqlQuery.SqlFormat.Cbor -> "cbor"
                | SqlQuery.SqlFormat.Smile -> "smile"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "csv" -> SqlQuery.SqlFormat.Csv
            | "json" -> SqlQuery.SqlFormat.Json
            | "tsv" -> SqlQuery.SqlFormat.Tsv
            | "txt" -> SqlQuery.SqlFormat.Txt
            | "yaml" -> SqlQuery.SqlFormat.Yaml
            | "cbor" -> SqlQuery.SqlFormat.Cbor
            | "smile" -> SqlQuery.SqlFormat.Smile
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for SqlFormat"))

    type StreamTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<StreamsTypes.StreamType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | StreamsTypes.StreamType.Logs -> "logs"
                | StreamsTypes.StreamType.LogsOtel -> "logs.otel"
                | StreamsTypes.StreamType.LogsEcs -> "logs.ecs"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "logs" -> StreamsTypes.StreamType.Logs
            | "logs.otel" -> StreamsTypes.StreamType.LogsOtel
            | "logs.ecs" -> StreamsTypes.StreamType.LogsEcs
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for StreamType"))

    type GroupByConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TasksTypes.GroupBy>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TasksTypes.GroupBy.Nodes -> "nodes"
                | TasksTypes.GroupBy.Parents -> "parents"
                | TasksTypes.GroupBy.None -> "none"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "nodes" -> TasksTypes.GroupBy.Nodes
            | "parents" -> TasksTypes.GroupBy.Parents
            | "none" -> TasksTypes.GroupBy.None
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for GroupBy"))

    type EcsCompatibilityTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TextStructureTypes.EcsCompatibilityType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TextStructureTypes.EcsCompatibilityType.Disabled -> "disabled"
                | TextStructureTypes.EcsCompatibilityType.V1 -> "v1"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "disabled" -> TextStructureTypes.EcsCompatibilityType.Disabled
            | "v1" -> TextStructureTypes.EcsCompatibilityType.V1
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EcsCompatibilityType"))

    type FormatTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TextStructureTypes.FormatType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TextStructureTypes.FormatType.Delimited -> "delimited"
                | TextStructureTypes.FormatType.Ndjson -> "ndjson"
                | TextStructureTypes.FormatType.SemiStructuredText -> "semi_structured_text"
                | TextStructureTypes.FormatType.Xml -> "xml"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "delimited" -> TextStructureTypes.FormatType.Delimited
            | "ndjson" -> TextStructureTypes.FormatType.Ndjson
            | "semi_structured_text" -> TextStructureTypes.FormatType.SemiStructuredText
            | "xml" -> TextStructureTypes.FormatType.Xml
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FormatType"))

    type FindStructureFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TextStructureFindStructure.FindStructureFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | TextStructureFindStructure.FindStructureFormat.Ndjson -> "ndjson"
                | TextStructureFindStructure.FindStructureFormat.Xml -> "xml"
                | TextStructureFindStructure.FindStructureFormat.Delimited -> "delimited"
                | TextStructureFindStructure.FindStructureFormat.SemiStructuredText -> "semi_structured_text"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "ndjson" -> TextStructureFindStructure.FindStructureFormat.Ndjson
            | "xml" -> TextStructureFindStructure.FindStructureFormat.Xml
            | "delimited" -> TextStructureFindStructure.FindStructureFormat.Delimited
            | "semi_structured_text" -> TextStructureFindStructure.FindStructureFormat.SemiStructuredText
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for FindStructureFormat"))

    type PivotGroupByContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TransformTypes.PivotGroupByContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TransformTypes.PivotGroupByContainer.DateHistogram v ->
                writer.WritePropertyName("date_histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TransformTypes.PivotGroupByContainer.GeotileGrid v ->
                writer.WritePropertyName("geotile_grid")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TransformTypes.PivotGroupByContainer.Histogram v ->
                writer.WritePropertyName("histogram")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | TransformTypes.PivotGroupByContainer.Terms v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.DateHistogramAggregation>(ref reader, options)
                    TransformTypes.PivotGroupByContainer.DateHistogram v
                | "geotile_grid" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.GeoTileGridAggregation>(ref reader, options)
                    TransformTypes.PivotGroupByContainer.GeotileGrid v
                | "histogram" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.HistogramAggregation>(ref reader, options)
                    TransformTypes.PivotGroupByContainer.Histogram v
                | "terms" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<TypesAggregations.TermsAggregation>(ref reader, options)
                    TransformTypes.PivotGroupByContainer.Terms v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for PivotGroupByContainer"))
            reader.Read() |> ignore // EndObject
            result

    type RetentionPolicyContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TransformTypes.RetentionPolicyContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TransformTypes.RetentionPolicyContainer.Time v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TransformTypes.RetentionPolicy>(ref reader, options)
                    TransformTypes.RetentionPolicyContainer.Time v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for RetentionPolicyContainer"))
            reader.Read() |> ignore // EndObject
            result

    type SyncContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<TransformTypes.SyncContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | TransformTypes.SyncContainer.Time v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<TransformTypes.TimeSync>(ref reader, options)
                    TransformTypes.SyncContainer.Time v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for SyncContainer"))
            reader.Read() |> ignore // EndObject
            result

    type AcknowledgementOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.AcknowledgementOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.AcknowledgementOptions.AwaitsSuccessfulExecution -> "awaits_successful_execution"
                | WatcherTypes.AcknowledgementOptions.Ackable -> "ackable"
                | WatcherTypes.AcknowledgementOptions.Acked -> "acked"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "awaits_successful_execution" -> WatcherTypes.AcknowledgementOptions.AwaitsSuccessfulExecution
            | "ackable" -> WatcherTypes.AcknowledgementOptions.Ackable
            | "acked" -> WatcherTypes.AcknowledgementOptions.Acked
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for AcknowledgementOptions"))

    type ActionExecutionModeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ActionExecutionMode>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ActionExecutionMode.Simulate -> "simulate"
                | WatcherTypes.ActionExecutionMode.ForceSimulate -> "force_simulate"
                | WatcherTypes.ActionExecutionMode.Execute -> "execute"
                | WatcherTypes.ActionExecutionMode.ForceExecute -> "force_execute"
                | WatcherTypes.ActionExecutionMode.Skip -> "skip"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "simulate" -> WatcherTypes.ActionExecutionMode.Simulate
            | "force_simulate" -> WatcherTypes.ActionExecutionMode.ForceSimulate
            | "execute" -> WatcherTypes.ActionExecutionMode.Execute
            | "force_execute" -> WatcherTypes.ActionExecutionMode.ForceExecute
            | "skip" -> WatcherTypes.ActionExecutionMode.Skip
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ActionExecutionMode"))

    type ActionStatusOptionsConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ActionStatusOptions>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ActionStatusOptions.Success -> "success"
                | WatcherTypes.ActionStatusOptions.Failure -> "failure"
                | WatcherTypes.ActionStatusOptions.Simulated -> "simulated"
                | WatcherTypes.ActionStatusOptions.Throttled -> "throttled"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "success" -> WatcherTypes.ActionStatusOptions.Success
            | "failure" -> WatcherTypes.ActionStatusOptions.Failure
            | "simulated" -> WatcherTypes.ActionStatusOptions.Simulated
            | "throttled" -> WatcherTypes.ActionStatusOptions.Throttled
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ActionStatusOptions"))

    type ActionTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ActionType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ActionType.Email -> "email"
                | WatcherTypes.ActionType.Webhook -> "webhook"
                | WatcherTypes.ActionType.Index -> "index"
                | WatcherTypes.ActionType.Logging -> "logging"
                | WatcherTypes.ActionType.Slack -> "slack"
                | WatcherTypes.ActionType.Pagerduty -> "pagerduty"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "email" -> WatcherTypes.ActionType.Email
            | "webhook" -> WatcherTypes.ActionType.Webhook
            | "index" -> WatcherTypes.ActionType.Index
            | "logging" -> WatcherTypes.ActionType.Logging
            | "slack" -> WatcherTypes.ActionType.Slack
            | "pagerduty" -> WatcherTypes.ActionType.Pagerduty
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ActionType"))

    type ConditionContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ConditionContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | WatcherTypes.ConditionContainer.Always v ->
                writer.WritePropertyName("always")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ConditionContainer.ArrayCompare (field, v) ->
                writer.WritePropertyName("array_compare")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | WatcherTypes.ConditionContainer.Compare (field, v) ->
                writer.WritePropertyName("compare")
                writer.WriteStartObject()
                writer.WritePropertyName(field)
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
                writer.WriteEndObject()
            | WatcherTypes.ConditionContainer.Never v ->
                writer.WritePropertyName("never")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ConditionContainer.Script v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.AlwaysCondition>(ref reader, options)
                    WatcherTypes.ConditionContainer.Always v
                | "array_compare" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.ArrayCompareCondition>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    WatcherTypes.ConditionContainer.ArrayCompare (field, v)
                | "compare" ->
                    reader.Read() |> ignore // StartObject
                    let field = reader.GetString()
                    reader.Read() |> ignore
                    let v = System.Text.Json.JsonSerializer.Deserialize<Map<WatcherTypes.ConditionOp, Types.FieldValue>>(ref reader, options)
                    reader.Read() |> ignore // EndObject
                    WatcherTypes.ConditionContainer.Compare (field, v)
                | "never" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.NeverCondition>(ref reader, options)
                    WatcherTypes.ConditionContainer.Never v
                | "script" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.ScriptCondition>(ref reader, options)
                    WatcherTypes.ConditionContainer.Script v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for ConditionContainer"))
            reader.Read() |> ignore // EndObject
            result

    type ConditionOpConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ConditionOp>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ConditionOp.NotEq -> "not_eq"
                | WatcherTypes.ConditionOp.Eq -> "eq"
                | WatcherTypes.ConditionOp.Lt -> "lt"
                | WatcherTypes.ConditionOp.Gt -> "gt"
                | WatcherTypes.ConditionOp.Lte -> "lte"
                | WatcherTypes.ConditionOp.Gte -> "gte"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "not_eq" -> WatcherTypes.ConditionOp.NotEq
            | "eq" -> WatcherTypes.ConditionOp.Eq
            | "lt" -> WatcherTypes.ConditionOp.Lt
            | "gt" -> WatcherTypes.ConditionOp.Gt
            | "lte" -> WatcherTypes.ConditionOp.Lte
            | "gte" -> WatcherTypes.ConditionOp.Gte
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConditionOp"))

    type ConditionTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ConditionType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ConditionType.Always -> "always"
                | WatcherTypes.ConditionType.Never -> "never"
                | WatcherTypes.ConditionType.Script -> "script"
                | WatcherTypes.ConditionType.Compare -> "compare"
                | WatcherTypes.ConditionType.ArrayCompare -> "array_compare"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "always" -> WatcherTypes.ConditionType.Always
            | "never" -> WatcherTypes.ConditionType.Never
            | "script" -> WatcherTypes.ConditionType.Script
            | "compare" -> WatcherTypes.ConditionType.Compare
            | "array_compare" -> WatcherTypes.ConditionType.ArrayCompare
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConditionType"))

    type ConnectionSchemeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ConnectionScheme>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ConnectionScheme.Http -> "http"
                | WatcherTypes.ConnectionScheme.Https -> "https"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "http" -> WatcherTypes.ConnectionScheme.Http
            | "https" -> WatcherTypes.ConnectionScheme.Https
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ConnectionScheme"))

    type DataAttachmentFormatConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.DataAttachmentFormat>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.DataAttachmentFormat.Json -> "json"
                | WatcherTypes.DataAttachmentFormat.Yaml -> "yaml"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "json" -> WatcherTypes.DataAttachmentFormat.Json
            | "yaml" -> WatcherTypes.DataAttachmentFormat.Yaml
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for DataAttachmentFormat"))

    type DayConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.Day>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.Day.Sunday -> "sunday"
                | WatcherTypes.Day.Monday -> "monday"
                | WatcherTypes.Day.Tuesday -> "tuesday"
                | WatcherTypes.Day.Wednesday -> "wednesday"
                | WatcherTypes.Day.Thursday -> "thursday"
                | WatcherTypes.Day.Friday -> "friday"
                | WatcherTypes.Day.Saturday -> "saturday"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "sunday" -> WatcherTypes.Day.Sunday
            | "monday" -> WatcherTypes.Day.Monday
            | "tuesday" -> WatcherTypes.Day.Tuesday
            | "wednesday" -> WatcherTypes.Day.Wednesday
            | "thursday" -> WatcherTypes.Day.Thursday
            | "friday" -> WatcherTypes.Day.Friday
            | "saturday" -> WatcherTypes.Day.Saturday
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Day"))

    type EmailAttachmentContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.EmailAttachmentContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | WatcherTypes.EmailAttachmentContainer.Http v ->
                writer.WritePropertyName("http")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.EmailAttachmentContainer.Reporting v ->
                writer.WritePropertyName("reporting")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.EmailAttachmentContainer.Data v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.HttpEmailAttachment>(ref reader, options)
                    WatcherTypes.EmailAttachmentContainer.Http v
                | "reporting" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.ReportingEmailAttachment>(ref reader, options)
                    WatcherTypes.EmailAttachmentContainer.Reporting v
                | "data" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.DataEmailAttachment>(ref reader, options)
                    WatcherTypes.EmailAttachmentContainer.Data v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for EmailAttachmentContainer"))
            reader.Read() |> ignore // EndObject
            result

    type EmailPriorityConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.EmailPriority>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.EmailPriority.Lowest -> "lowest"
                | WatcherTypes.EmailPriority.Low -> "low"
                | WatcherTypes.EmailPriority.Normal -> "normal"
                | WatcherTypes.EmailPriority.High -> "high"
                | WatcherTypes.EmailPriority.Highest -> "highest"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "lowest" -> WatcherTypes.EmailPriority.Lowest
            | "low" -> WatcherTypes.EmailPriority.Low
            | "normal" -> WatcherTypes.EmailPriority.Normal
            | "high" -> WatcherTypes.EmailPriority.High
            | "highest" -> WatcherTypes.EmailPriority.Highest
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for EmailPriority"))

    type ExecutionPhaseConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ExecutionPhase>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ExecutionPhase.AwaitsExecution -> "awaits_execution"
                | WatcherTypes.ExecutionPhase.Started -> "started"
                | WatcherTypes.ExecutionPhase.Input -> "input"
                | WatcherTypes.ExecutionPhase.Condition -> "condition"
                | WatcherTypes.ExecutionPhase.Actions -> "actions"
                | WatcherTypes.ExecutionPhase.WatchTransform -> "watch_transform"
                | WatcherTypes.ExecutionPhase.Aborted -> "aborted"
                | WatcherTypes.ExecutionPhase.Finished -> "finished"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "awaits_execution" -> WatcherTypes.ExecutionPhase.AwaitsExecution
            | "started" -> WatcherTypes.ExecutionPhase.Started
            | "input" -> WatcherTypes.ExecutionPhase.Input
            | "condition" -> WatcherTypes.ExecutionPhase.Condition
            | "actions" -> WatcherTypes.ExecutionPhase.Actions
            | "watch_transform" -> WatcherTypes.ExecutionPhase.WatchTransform
            | "aborted" -> WatcherTypes.ExecutionPhase.Aborted
            | "finished" -> WatcherTypes.ExecutionPhase.Finished
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExecutionPhase"))

    type ExecutionStatusConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ExecutionStatus>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ExecutionStatus.AwaitsExecution -> "awaits_execution"
                | WatcherTypes.ExecutionStatus.Checking -> "checking"
                | WatcherTypes.ExecutionStatus.ExecutionNotNeeded -> "execution_not_needed"
                | WatcherTypes.ExecutionStatus.Throttled -> "throttled"
                | WatcherTypes.ExecutionStatus.Executed -> "executed"
                | WatcherTypes.ExecutionStatus.Failed -> "failed"
                | WatcherTypes.ExecutionStatus.DeletedWhileQueued -> "deleted_while_queued"
                | WatcherTypes.ExecutionStatus.NotExecutedAlreadyQueued -> "not_executed_already_queued"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "awaits_execution" -> WatcherTypes.ExecutionStatus.AwaitsExecution
            | "checking" -> WatcherTypes.ExecutionStatus.Checking
            | "execution_not_needed" -> WatcherTypes.ExecutionStatus.ExecutionNotNeeded
            | "throttled" -> WatcherTypes.ExecutionStatus.Throttled
            | "executed" -> WatcherTypes.ExecutionStatus.Executed
            | "failed" -> WatcherTypes.ExecutionStatus.Failed
            | "deleted_while_queued" -> WatcherTypes.ExecutionStatus.DeletedWhileQueued
            | "not_executed_already_queued" -> WatcherTypes.ExecutionStatus.NotExecutedAlreadyQueued
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ExecutionStatus"))

    type HttpInputMethodConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.HttpInputMethod>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.HttpInputMethod.Head -> "head"
                | WatcherTypes.HttpInputMethod.Get -> "get"
                | WatcherTypes.HttpInputMethod.Post -> "post"
                | WatcherTypes.HttpInputMethod.Put -> "put"
                | WatcherTypes.HttpInputMethod.Delete -> "delete"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "head" -> WatcherTypes.HttpInputMethod.Head
            | "get" -> WatcherTypes.HttpInputMethod.Get
            | "post" -> WatcherTypes.HttpInputMethod.Post
            | "put" -> WatcherTypes.HttpInputMethod.Put
            | "delete" -> WatcherTypes.HttpInputMethod.Delete
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for HttpInputMethod"))

    type InputContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.InputContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | WatcherTypes.InputContainer.Chain v ->
                writer.WritePropertyName("chain")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.InputContainer.Http v ->
                writer.WritePropertyName("http")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.InputContainer.Search v ->
                writer.WritePropertyName("search")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.InputContainer.Simple v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.ChainInput>(ref reader, options)
                    WatcherTypes.InputContainer.Chain v
                | "http" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.HttpInput>(ref reader, options)
                    WatcherTypes.InputContainer.Http v
                | "search" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.SearchInput>(ref reader, options)
                    WatcherTypes.InputContainer.Search v
                | "simple" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Map<string, System.Text.Json.JsonElement>>(ref reader, options)
                    WatcherTypes.InputContainer.Simple v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for InputContainer"))
            reader.Read() |> ignore // EndObject
            result

    type InputTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.InputType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.InputType.Http -> "http"
                | WatcherTypes.InputType.Search -> "search"
                | WatcherTypes.InputType.Simple -> "simple"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "http" -> WatcherTypes.InputType.Http
            | "search" -> WatcherTypes.InputType.Search
            | "simple" -> WatcherTypes.InputType.Simple
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for InputType"))

    type MonthConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.Month>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.Month.January -> "january"
                | WatcherTypes.Month.February -> "february"
                | WatcherTypes.Month.March -> "march"
                | WatcherTypes.Month.April -> "april"
                | WatcherTypes.Month.May -> "may"
                | WatcherTypes.Month.June -> "june"
                | WatcherTypes.Month.July -> "july"
                | WatcherTypes.Month.August -> "august"
                | WatcherTypes.Month.September -> "september"
                | WatcherTypes.Month.October -> "october"
                | WatcherTypes.Month.November -> "november"
                | WatcherTypes.Month.December -> "december"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "january" -> WatcherTypes.Month.January
            | "february" -> WatcherTypes.Month.February
            | "march" -> WatcherTypes.Month.March
            | "april" -> WatcherTypes.Month.April
            | "may" -> WatcherTypes.Month.May
            | "june" -> WatcherTypes.Month.June
            | "july" -> WatcherTypes.Month.July
            | "august" -> WatcherTypes.Month.August
            | "september" -> WatcherTypes.Month.September
            | "october" -> WatcherTypes.Month.October
            | "november" -> WatcherTypes.Month.November
            | "december" -> WatcherTypes.Month.December
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Month"))

    type PagerDutyContextTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.PagerDutyContextType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.PagerDutyContextType.Link -> "link"
                | WatcherTypes.PagerDutyContextType.Image -> "image"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "link" -> WatcherTypes.PagerDutyContextType.Link
            | "image" -> WatcherTypes.PagerDutyContextType.Image
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PagerDutyContextType"))

    type PagerDutyEventTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.PagerDutyEventType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.PagerDutyEventType.Trigger -> "trigger"
                | WatcherTypes.PagerDutyEventType.Resolve -> "resolve"
                | WatcherTypes.PagerDutyEventType.Acknowledge -> "acknowledge"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "trigger" -> WatcherTypes.PagerDutyEventType.Trigger
            | "resolve" -> WatcherTypes.PagerDutyEventType.Resolve
            | "acknowledge" -> WatcherTypes.PagerDutyEventType.Acknowledge
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for PagerDutyEventType"))

    type QuantifierConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.Quantifier>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.Quantifier.Some -> "some"
                | WatcherTypes.Quantifier.All -> "all"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "some" -> WatcherTypes.Quantifier.Some
            | "all" -> WatcherTypes.Quantifier.All
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for Quantifier"))

    type ResponseContentTypeConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ResponseContentType>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherTypes.ResponseContentType.Json -> "json"
                | WatcherTypes.ResponseContentType.Yaml -> "yaml"
                | WatcherTypes.ResponseContentType.Text -> "text"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "json" -> WatcherTypes.ResponseContentType.Json
            | "yaml" -> WatcherTypes.ResponseContentType.Yaml
            | "text" -> WatcherTypes.ResponseContentType.Text
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for ResponseContentType"))

    type ScheduleContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.ScheduleContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | WatcherTypes.ScheduleContainer.Timezone v ->
                writer.WritePropertyName("timezone")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ScheduleContainer.Cron v ->
                writer.WritePropertyName("cron")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ScheduleContainer.Daily v ->
                writer.WritePropertyName("daily")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ScheduleContainer.Hourly v ->
                writer.WritePropertyName("hourly")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ScheduleContainer.Interval v ->
                writer.WritePropertyName("interval")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ScheduleContainer.Monthly v ->
                writer.WritePropertyName("monthly")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ScheduleContainer.Weekly v ->
                writer.WritePropertyName("weekly")
                System.Text.Json.JsonSerializer.Serialize(writer, v, options)
            | WatcherTypes.ScheduleContainer.Yearly v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<string>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Timezone v
                | "cron" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.CronExpression>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Cron v
                | "daily" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.DailySchedule>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Daily v
                | "hourly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.HourlySchedule>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Hourly v
                | "interval" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<Types.Duration>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Interval v
                | "monthly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Monthly v
                | "weekly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Weekly v
                | "yearly" ->
                    let v = System.Text.Json.JsonSerializer.Deserialize<System.Text.Json.JsonElement>(ref reader, options)
                    WatcherTypes.ScheduleContainer.Yearly v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for ScheduleContainer"))
            reader.Read() |> ignore // EndObject
            result

    type TriggerContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.TriggerContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | WatcherTypes.TriggerContainer.Schedule v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.ScheduleContainer>(ref reader, options)
                    WatcherTypes.TriggerContainer.Schedule v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TriggerContainer"))
            reader.Read() |> ignore // EndObject
            result

    type TriggerEventContainerConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherTypes.TriggerEventContainer>()

        override _.Write(writer, value, options) =
            writer.WriteStartObject()
            match value with
            | WatcherTypes.TriggerEventContainer.Schedule v ->
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
                    let v = System.Text.Json.JsonSerializer.Deserialize<WatcherTypes.ScheduleTriggerEvent>(ref reader, options)
                    WatcherTypes.TriggerEventContainer.Schedule v
                | other -> raise (System.Text.Json.JsonException($"Unknown property '{other}' for TriggerEventContainer"))
            reader.Read() |> ignore // EndObject
            result

    type WatcherMetricConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherStats.WatcherMetric>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherStats.WatcherMetric.All -> "_all"
                | WatcherStats.WatcherMetric.QueuedWatches -> "queued_watches"
                | WatcherStats.WatcherMetric.CurrentWatches -> "current_watches"
                | WatcherStats.WatcherMetric.PendingWatches -> "pending_watches"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "_all" -> WatcherStats.WatcherMetric.All
            | "queued_watches" -> WatcherStats.WatcherMetric.QueuedWatches
            | "current_watches" -> WatcherStats.WatcherMetric.CurrentWatches
            | "pending_watches" -> WatcherStats.WatcherMetric.PendingWatches
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatcherMetric"))

    type WatcherStateConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<WatcherStats.WatcherState>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | WatcherStats.WatcherState.Stopped -> "stopped"
                | WatcherStats.WatcherState.Starting -> "starting"
                | WatcherStats.WatcherState.Started -> "started"
                | WatcherStats.WatcherState.Stopping -> "stopping"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "stopped" -> WatcherStats.WatcherState.Stopped
            | "starting" -> WatcherStats.WatcherState.Starting
            | "started" -> WatcherStats.WatcherState.Started
            | "stopping" -> WatcherStats.WatcherState.Stopping
            | other -> raise (System.Text.Json.JsonException($"Unknown enum value '{other}' for WatcherState"))

    type XPackCategoryConverter() =
        inherit System.Text.Json.Serialization.JsonConverter<XpackInfo.XPackCategory>()

        override _.Write(writer, value, _options) =
            let s =
                match value with
                | XpackInfo.XPackCategory.Build -> "build"
                | XpackInfo.XPackCategory.Features -> "features"
                | XpackInfo.XPackCategory.License -> "license"
            writer.WriteStringValue(s)

        override _.Read(reader, _typeToConvert, _options) =
            let s = reader.GetString()
            match s with
            | "build" -> XpackInfo.XPackCategory.Build
            | "features" -> XpackInfo.XPackCategory.Features
            | "license" -> XpackInfo.XPackCategory.License
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
        options.Converters.Add(FeatureConverter())
        options.Converters.Add(ModeEnumConverter())
        options.Converters.Add(ActionConverter())
        options.Converters.Add(RecoveryStageConverter())
        options.Converters.Add(RecoveryTypeConverter())
        options.Converters.Add(ShardStoreAllocationConverter())
        options.Converters.Add(ShardStoreStatusConverter())
        options.Converters.Add(IndexMetadataStateConverter())
        options.Converters.Add(ShardRoutingStateConverter())
        options.Converters.Add(ActionConverter())
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

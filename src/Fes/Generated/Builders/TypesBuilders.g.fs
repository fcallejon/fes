// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module TypesBuilders =

    type BulkStatsBuilder() =
        member _.Yield(_: unit) : Types.BulkStats =
            {
                TotalOperations = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
                TotalSize = None
                TotalSizeInBytes = Unchecked.defaultof<_>
                AvgTime = None
                AvgTimeInMillis = Unchecked.defaultof<_>
                AvgSize = None
                AvgSizeInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("totalOperations")>]
        member _.TotalOperations(state: Types.BulkStats, value: Types.Long) =
            { state with TotalOperations = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: Types.BulkStats, value: Types.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: Types.BulkStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalTimeInMillis = value }

        [<CustomOperation("totalSize")>]
        member _.TotalSize(state: Types.BulkStats, value: Types.ByteSize) =
            { state with TotalSize = Some value }

        [<CustomOperation("totalSizeInBytes")>]
        member _.TotalSizeInBytes(state: Types.BulkStats, value: Types.Long) =
            { state with TotalSizeInBytes = value }

        [<CustomOperation("avgTime")>]
        member _.AvgTime(state: Types.BulkStats, value: Types.Duration) =
            { state with AvgTime = Some value }

        [<CustomOperation("avgTimeInMillis")>]
        member _.AvgTimeInMillis(state: Types.BulkStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with AvgTimeInMillis = value }

        [<CustomOperation("avgSize")>]
        member _.AvgSize(state: Types.BulkStats, value: Types.ByteSize) =
            { state with AvgSize = Some value }

        [<CustomOperation("avgSizeInBytes")>]
        member _.AvgSizeInBytes(state: Types.BulkStats, value: Types.Long) =
            { state with AvgSizeInBytes = value }

    let bulkStats = BulkStatsBuilder()

    type ChunkRescorerBuilder() =
        member _.Yield(_: unit) : Types.ChunkRescorer =
            {
                Size = None
                ChunkingSettings = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: Types.ChunkRescorer, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: Types.ChunkRescorer, value: Types.ChunkRescorerChunkingSettings) =
            { state with ChunkingSettings = Some value }

    let chunkRescorer = ChunkRescorerBuilder()

    type ClusterDetailsBuilder() =
        member _.Yield(_: unit) : Types.ClusterDetails =
            {
                Status = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                Took = None
                TimedOut = Unchecked.defaultof<_>
                Shards = None
                Failures = None
            }

        [<CustomOperation("status")>]
        member _.Status(state: Types.ClusterDetails, value: Types.ClusterSearchStatus) =
            { state with Status = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.ClusterDetails, value: string) =
            { state with Indices = value }

        [<CustomOperation("took")>]
        member _.Took(state: Types.ClusterDetails, value: Types.DurationValue<Types.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("timedOut")>]
        member _.TimedOut(state: Types.ClusterDetails, value: bool) =
            { state with TimedOut = value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.ClusterDetails, value: Types.ShardStatistics) =
            { state with Shards = Some value }

        [<CustomOperation("failures")>]
        member _.Failures(state: Types.ClusterDetails, value: Types.ShardFailure list) =
            { state with Failures = Some value }

    let clusterDetails = ClusterDetailsBuilder()

    type CompletionStatsBuilder() =
        member _.Yield(_: unit) : Types.CompletionStats =
            {
                SizeInBytes = Unchecked.defaultof<_>
                Size = None
                Fields = None
            }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: Types.CompletionStats, value: Types.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.CompletionStats, value: Types.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.CompletionStats, value: Map<Types.Field, Types.FieldSizeUsage>) =
            { state with Fields = Some value }

    let completionStats = CompletionStatsBuilder()

    type DiversifyRetrieverBuilder() =
        member _.Yield(_: unit) : Types.DiversifyRetriever =
            {
                Type = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                Retriever = Unchecked.defaultof<_>
                Size = None
                RankWindowSize = None
                QueryVector = None
                QueryVectorBuilder = None
                Lambda = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.DiversifyRetriever, value: Types.DiversifyRetrieverTypes) =
            { state with Type = value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.DiversifyRetriever, value: string) =
            { state with Field = value }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: Types.DiversifyRetriever, value: Types.RetrieverContainer) =
            { state with Retriever = value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.DiversifyRetriever, value: Types.Integer) =
            { state with Size = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: Types.DiversifyRetriever, value: Types.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: Types.DiversifyRetriever, value: Types.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: Types.DiversifyRetriever, value: Types.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("lambda")>]
        member _.Lambda(state: Types.DiversifyRetriever, value: Types.Float) =
            { state with Lambda = Some value }

    let diversifyRetriever = DiversifyRetrieverBuilder()

    type DocStatsBuilder() =
        member _.Yield(_: unit) : Types.DocStats =
            {
                Count = Unchecked.defaultof<_>
                Deleted = None
                TotalSizeInBytes = Unchecked.defaultof<_>
                TotalSize = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.DocStats, value: Types.Long) =
            { state with Count = value }

        [<CustomOperation("deleted")>]
        member _.Deleted(state: Types.DocStats, value: Types.Long) =
            { state with Deleted = Some value }

        [<CustomOperation("totalSizeInBytes")>]
        member _.TotalSizeInBytes(state: Types.DocStats, value: Types.Long) =
            { state with TotalSizeInBytes = value }

        [<CustomOperation("totalSize")>]
        member _.TotalSize(state: Types.DocStats, value: Types.ByteSize) =
            { state with TotalSize = Some value }

    let docStats = DocStatsBuilder()

    type ErrorCauseBuilder() =
        member _.Yield(_: unit) : Types.ErrorCause =
            {
                Type = Unchecked.defaultof<_>
                Reason = None
                StackTrace = None
                CausedBy = None
                RootCause = None
                Suppressed = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ErrorCause, value: string) =
            { state with Type = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.ErrorCause, value: string option) =
            { state with Reason = Some value }

        [<CustomOperation("stackTrace")>]
        member _.StackTrace(state: Types.ErrorCause, value: string) =
            { state with StackTrace = Some value }

        [<CustomOperation("causedBy")>]
        member _.CausedBy(state: Types.ErrorCause, value: Types.ErrorCause) =
            { state with CausedBy = Some value }

        [<CustomOperation("rootCause")>]
        member _.RootCause(state: Types.ErrorCause, value: Types.ErrorCause list) =
            { state with RootCause = Some value }

        [<CustomOperation("suppressed")>]
        member _.Suppressed(state: Types.ErrorCause, value: Types.ErrorCause list) =
            { state with Suppressed = Some value }

    let errorCause = ErrorCauseBuilder()

    type FieldSortBuilder() =
        member _.Yield(_: unit) : Types.FieldSort =
            {
                Missing = None
                Mode = None
                Nested = None
                Order = None
                UnmappedType = None
                NumericType = None
                Format = None
            }

        [<CustomOperation("missing")>]
        member _.Missing(state: Types.FieldSort, value: Types.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.FieldSort, value: Types.SortMode) =
            { state with Mode = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: Types.FieldSort, value: Types.NestedSortValue) =
            { state with Nested = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.FieldSort, value: Types.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("unmappedType")>]
        member _.UnmappedType(state: Types.FieldSort, value: Types.FieldType) =
            { state with UnmappedType = Some value }

        [<CustomOperation("numericType")>]
        member _.NumericType(state: Types.FieldSort, value: Types.FieldSortNumericType) =
            { state with NumericType = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: Types.FieldSort, value: string) =
            { state with Format = Some value }

    let fieldSort = FieldSortBuilder()

    let ofOrder (value: Types.SortOrder) : Types.FieldSort =
        {
            Missing = None
            Mode = None
            Nested = None
            Order = value
            UnmappedType = None
            NumericType = None
            Format = None
        }

    type FielddataStatsBuilder() =
        member _.Yield(_: unit) : Types.FielddataStats =
            {
                Evictions = None
                MemorySize = None
                MemorySizeInBytes = Unchecked.defaultof<_>
                Fields = None
                GlobalOrdinals = Unchecked.defaultof<_>
            }

        [<CustomOperation("evictions")>]
        member _.Evictions(state: Types.FielddataStats, value: Types.Long) =
            { state with Evictions = Some value }

        [<CustomOperation("memorySize")>]
        member _.MemorySize(state: Types.FielddataStats, value: Types.ByteSize) =
            { state with MemorySize = Some value }

        [<CustomOperation("memorySizeInBytes")>]
        member _.MemorySizeInBytes(state: Types.FielddataStats, value: Types.Long) =
            { state with MemorySizeInBytes = value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.FielddataStats, value: Map<Types.Field, Types.FieldMemoryUsage>) =
            { state with Fields = Some value }

        [<CustomOperation("globalOrdinals")>]
        member _.GlobalOrdinals(state: Types.FielddataStats, value: Types.GlobalOrdinalsStats) =
            { state with GlobalOrdinals = value }

    let fielddataStats = FielddataStatsBuilder()

    type GeoDistanceSortBuilder() =
        member _.Yield(_: unit) : Types.GeoDistanceSort =
            {
                Mode = None
                DistanceType = None
                IgnoreUnmapped = None
                Order = None
                Unit = None
                Nested = None
            }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.GeoDistanceSort, value: Types.SortMode) =
            { state with Mode = Some value }

        [<CustomOperation("distanceType")>]
        member _.DistanceType(state: Types.GeoDistanceSort, value: Types.GeoDistanceType) =
            { state with DistanceType = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: Types.GeoDistanceSort, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: Types.GeoDistanceSort, value: Types.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("unit")>]
        member _.Unit(state: Types.GeoDistanceSort, value: Types.DistanceUnit) =
            { state with Unit = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: Types.GeoDistanceSort, value: Types.NestedSortValue) =
            { state with Nested = Some value }

    let geoDistanceSort = GeoDistanceSortBuilder()

    type GetStatsBuilder() =
        member _.Yield(_: unit) : Types.GetStats =
            {
                Current = Unchecked.defaultof<_>
                ExistsTime = None
                ExistsTimeInMillis = Unchecked.defaultof<_>
                ExistsTotal = Unchecked.defaultof<_>
                MissingTime = None
                MissingTimeInMillis = Unchecked.defaultof<_>
                MissingTotal = Unchecked.defaultof<_>
                Time = None
                TimeInMillis = Unchecked.defaultof<_>
                Total = Unchecked.defaultof<_>
            }

        [<CustomOperation("current")>]
        member _.Current(state: Types.GetStats, value: Types.Long) =
            { state with Current = value }

        [<CustomOperation("existsTime")>]
        member _.ExistsTime(state: Types.GetStats, value: Types.Duration) =
            { state with ExistsTime = Some value }

        [<CustomOperation("existsTimeInMillis")>]
        member _.ExistsTimeInMillis(state: Types.GetStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ExistsTimeInMillis = value }

        [<CustomOperation("existsTotal")>]
        member _.ExistsTotal(state: Types.GetStats, value: Types.Long) =
            { state with ExistsTotal = value }

        [<CustomOperation("missingTime")>]
        member _.MissingTime(state: Types.GetStats, value: Types.Duration) =
            { state with MissingTime = Some value }

        [<CustomOperation("missingTimeInMillis")>]
        member _.MissingTimeInMillis(state: Types.GetStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with MissingTimeInMillis = value }

        [<CustomOperation("missingTotal")>]
        member _.MissingTotal(state: Types.GetStats, value: Types.Long) =
            { state with MissingTotal = value }

        [<CustomOperation("time")>]
        member _.Time(state: Types.GetStats, value: Types.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInMillis")>]
        member _.TimeInMillis(state: Types.GetStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TimeInMillis = value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.GetStats, value: Types.Long) =
            { state with Total = value }

    let getStats = GetStatsBuilder()

    type GlobalOrdinalsStatsBuilder() =
        member _.Yield(_: unit) : Types.GlobalOrdinalsStats =
            {
                BuildTimeInMillis = Unchecked.defaultof<_>
                BuildTime = None
                Fields = None
            }

        [<CustomOperation("buildTimeInMillis")>]
        member _.BuildTimeInMillis(state: Types.GlobalOrdinalsStats, value: Types.UnitMillis) =
            { state with BuildTimeInMillis = value }

        [<CustomOperation("buildTime")>]
        member _.BuildTime(state: Types.GlobalOrdinalsStats, value: string) =
            { state with BuildTime = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.GlobalOrdinalsStats, value: Map<Types.Name, Types.GlobalOrdinalFieldStats>) =
            { state with Fields = Some value }

    let globalOrdinalsStats = GlobalOrdinalsStatsBuilder()

    type IndexingStatsBuilder() =
        member _.Yield(_: unit) : Types.IndexingStats =
            {
                IndexCurrent = Unchecked.defaultof<_>
                DeleteCurrent = Unchecked.defaultof<_>
                DeleteTime = None
                DeleteTimeInMillis = Unchecked.defaultof<_>
                DeleteTotal = Unchecked.defaultof<_>
                IsThrottled = Unchecked.defaultof<_>
                NoopUpdateTotal = Unchecked.defaultof<_>
                ThrottleTime = None
                ThrottleTimeInMillis = Unchecked.defaultof<_>
                IndexTime = None
                IndexTimeInMillis = Unchecked.defaultof<_>
                IndexTotal = Unchecked.defaultof<_>
                IndexFailed = Unchecked.defaultof<_>
                Types = None
                WriteLoad = None
                RecentWriteLoad = None
                PeakWriteLoad = None
            }

        [<CustomOperation("indexCurrent")>]
        member _.IndexCurrent(state: Types.IndexingStats, value: Types.Long) =
            { state with IndexCurrent = value }

        [<CustomOperation("deleteCurrent")>]
        member _.DeleteCurrent(state: Types.IndexingStats, value: Types.Long) =
            { state with DeleteCurrent = value }

        [<CustomOperation("deleteTime")>]
        member _.DeleteTime(state: Types.IndexingStats, value: Types.Duration) =
            { state with DeleteTime = Some value }

        [<CustomOperation("deleteTimeInMillis")>]
        member _.DeleteTimeInMillis(state: Types.IndexingStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with DeleteTimeInMillis = value }

        [<CustomOperation("deleteTotal")>]
        member _.DeleteTotal(state: Types.IndexingStats, value: Types.Long) =
            { state with DeleteTotal = value }

        [<CustomOperation("isThrottled")>]
        member _.IsThrottled(state: Types.IndexingStats, value: bool) =
            { state with IsThrottled = value }

        [<CustomOperation("noopUpdateTotal")>]
        member _.NoopUpdateTotal(state: Types.IndexingStats, value: Types.Long) =
            { state with NoopUpdateTotal = value }

        [<CustomOperation("throttleTime")>]
        member _.ThrottleTime(state: Types.IndexingStats, value: Types.Duration) =
            { state with ThrottleTime = Some value }

        [<CustomOperation("throttleTimeInMillis")>]
        member _.ThrottleTimeInMillis(state: Types.IndexingStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ThrottleTimeInMillis = value }

        [<CustomOperation("indexTime")>]
        member _.IndexTime(state: Types.IndexingStats, value: Types.Duration) =
            { state with IndexTime = Some value }

        [<CustomOperation("indexTimeInMillis")>]
        member _.IndexTimeInMillis(state: Types.IndexingStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with IndexTimeInMillis = value }

        [<CustomOperation("indexTotal")>]
        member _.IndexTotal(state: Types.IndexingStats, value: Types.Long) =
            { state with IndexTotal = value }

        [<CustomOperation("indexFailed")>]
        member _.IndexFailed(state: Types.IndexingStats, value: Types.Long) =
            { state with IndexFailed = value }

        [<CustomOperation("types")>]
        member _.Types(state: Types.IndexingStats, value: Map<string, Types.IndexingStats>) =
            { state with Types = Some value }

        [<CustomOperation("writeLoad")>]
        member _.WriteLoad(state: Types.IndexingStats, value: Types.Double) =
            { state with WriteLoad = Some value }

        [<CustomOperation("recentWriteLoad")>]
        member _.RecentWriteLoad(state: Types.IndexingStats, value: Types.Double) =
            { state with RecentWriteLoad = Some value }

        [<CustomOperation("peakWriteLoad")>]
        member _.PeakWriteLoad(state: Types.IndexingStats, value: Types.Double) =
            { state with PeakWriteLoad = Some value }

    let indexingStats = IndexingStatsBuilder()

    type IndicesOptionsBuilder() =
        member _.Yield(_: unit) : Types.IndicesOptions =
            {
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                IgnoreThrottled = None
            }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: Types.IndicesOptions, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: Types.IndicesOptions, value: Types.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: Types.IndicesOptions, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: Types.IndicesOptions, value: bool) =
            { state with IgnoreThrottled = Some value }

    let indicesOptions = IndicesOptionsBuilder()

    type KnnQueryBuilder() =
        member _.Yield(_: unit) : Types.KnnQuery =
            {
                Field = Unchecked.defaultof<_>
                QueryVector = None
                QueryVectorBuilder = None
                NumCandidates = None
                VisitPercentage = None
                K = None
                Filter = None
                Similarity = None
                RescoreVector = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.KnnQuery, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: Types.KnnQuery, value: Types.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: Types.KnnQuery, value: Types.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("numCandidates")>]
        member _.NumCandidates(state: Types.KnnQuery, value: Types.Integer) =
            { state with NumCandidates = Some value }

        [<CustomOperation("visitPercentage")>]
        member _.VisitPercentage(state: Types.KnnQuery, value: Types.Float) =
            { state with VisitPercentage = Some value }

        [<CustomOperation("k")>]
        member _.K(state: Types.KnnQuery, value: Types.Integer) =
            { state with K = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.KnnQuery, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.KnnQuery, value: Types.Float) =
            { state with Similarity = Some value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: Types.KnnQuery, value: Types.RescoreVector) =
            { state with RescoreVector = Some value }

    let knnQuery = KnnQueryBuilder()

    type KnnRetrieverBuilder() =
        member _.Yield(_: unit) : Types.KnnRetriever =
            {
                Field = Unchecked.defaultof<_>
                QueryVector = None
                QueryVectorBuilder = None
                K = Unchecked.defaultof<_>
                NumCandidates = Unchecked.defaultof<_>
                VisitPercentage = None
                Similarity = None
                RescoreVector = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.KnnRetriever, value: string) =
            { state with Field = value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: Types.KnnRetriever, value: Types.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: Types.KnnRetriever, value: Types.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("k")>]
        member _.K(state: Types.KnnRetriever, value: Types.Integer) =
            { state with K = value }

        [<CustomOperation("numCandidates")>]
        member _.NumCandidates(state: Types.KnnRetriever, value: Types.Integer) =
            { state with NumCandidates = value }

        [<CustomOperation("visitPercentage")>]
        member _.VisitPercentage(state: Types.KnnRetriever, value: Types.Float) =
            { state with VisitPercentage = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.KnnRetriever, value: Types.Float) =
            { state with Similarity = Some value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: Types.KnnRetriever, value: Types.RescoreVector) =
            { state with RescoreVector = Some value }

    let knnRetriever = KnnRetrieverBuilder()

    type KnnSearchBuilder() =
        member _.Yield(_: unit) : Types.KnnSearch =
            {
                Field = Unchecked.defaultof<_>
                QueryVector = None
                QueryVectorBuilder = None
                K = None
                NumCandidates = None
                VisitPercentage = None
                Boost = None
                Filter = None
                Similarity = None
                InnerHits = None
                RescoreVector = None
                Name = None
            }

        [<CustomOperation("field")>]
        member _.Field(state: Types.KnnSearch, value: Types.Field) =
            { state with Field = value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: Types.KnnSearch, value: Types.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: Types.KnnSearch, value: Types.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("k")>]
        member _.K(state: Types.KnnSearch, value: Types.Integer) =
            { state with K = Some value }

        [<CustomOperation("numCandidates")>]
        member _.NumCandidates(state: Types.KnnSearch, value: Types.Integer) =
            { state with NumCandidates = Some value }

        [<CustomOperation("visitPercentage")>]
        member _.VisitPercentage(state: Types.KnnSearch, value: Types.Float) =
            { state with VisitPercentage = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: Types.KnnSearch, value: Types.Float) =
            { state with Boost = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.KnnSearch, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: Types.KnnSearch, value: Types.Float) =
            { state with Similarity = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: Types.KnnSearch, value: Types.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: Types.KnnSearch, value: Types.RescoreVector) =
            { state with RescoreVector = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.KnnSearch, value: string) =
            { state with Name = Some value }

    let knnSearch = KnnSearchBuilder()

    type LinearRetrieverBuilder() =
        member _.Yield(_: unit) : Types.LinearRetriever =
            {
                Retrievers = None
                RankWindowSize = None
                Query = None
                Fields = None
                Normalizer = None
            }

        [<CustomOperation("retrievers")>]
        member _.Retrievers(state: Types.LinearRetriever, value: Types.InnerRetriever list) =
            { state with Retrievers = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: Types.LinearRetriever, value: Types.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.LinearRetriever, value: string) =
            { state with Query = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.LinearRetriever, value: string list) =
            { state with Fields = Some value }

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: Types.LinearRetriever, value: Types.ScoreNormalizer) =
            { state with Normalizer = Some value }

    let linearRetriever = LinearRetrieverBuilder()

    type MergesStatsBuilder() =
        member _.Yield(_: unit) : Types.MergesStats =
            {
                Current = Unchecked.defaultof<_>
                CurrentDocs = Unchecked.defaultof<_>
                CurrentSize = None
                CurrentSizeInBytes = Unchecked.defaultof<_>
                Total = Unchecked.defaultof<_>
                TotalAutoThrottle = None
                TotalAutoThrottleInBytes = Unchecked.defaultof<_>
                TotalDocs = Unchecked.defaultof<_>
                TotalSize = None
                TotalSizeInBytes = Unchecked.defaultof<_>
                TotalStoppedTime = None
                TotalStoppedTimeInMillis = Unchecked.defaultof<_>
                TotalThrottledTime = None
                TotalThrottledTimeInMillis = Unchecked.defaultof<_>
                TotalTime = None
                TotalTimeInMillis = Unchecked.defaultof<_>
            }

        [<CustomOperation("current")>]
        member _.Current(state: Types.MergesStats, value: Types.Long) =
            { state with Current = value }

        [<CustomOperation("currentDocs")>]
        member _.CurrentDocs(state: Types.MergesStats, value: Types.Long) =
            { state with CurrentDocs = value }

        [<CustomOperation("currentSize")>]
        member _.CurrentSize(state: Types.MergesStats, value: string) =
            { state with CurrentSize = Some value }

        [<CustomOperation("currentSizeInBytes")>]
        member _.CurrentSizeInBytes(state: Types.MergesStats, value: Types.Long) =
            { state with CurrentSizeInBytes = value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.MergesStats, value: Types.Long) =
            { state with Total = value }

        [<CustomOperation("totalAutoThrottle")>]
        member _.TotalAutoThrottle(state: Types.MergesStats, value: string) =
            { state with TotalAutoThrottle = Some value }

        [<CustomOperation("totalAutoThrottleInBytes")>]
        member _.TotalAutoThrottleInBytes(state: Types.MergesStats, value: Types.Long) =
            { state with TotalAutoThrottleInBytes = value }

        [<CustomOperation("totalDocs")>]
        member _.TotalDocs(state: Types.MergesStats, value: Types.Long) =
            { state with TotalDocs = value }

        [<CustomOperation("totalSize")>]
        member _.TotalSize(state: Types.MergesStats, value: string) =
            { state with TotalSize = Some value }

        [<CustomOperation("totalSizeInBytes")>]
        member _.TotalSizeInBytes(state: Types.MergesStats, value: Types.Long) =
            { state with TotalSizeInBytes = value }

        [<CustomOperation("totalStoppedTime")>]
        member _.TotalStoppedTime(state: Types.MergesStats, value: Types.Duration) =
            { state with TotalStoppedTime = Some value }

        [<CustomOperation("totalStoppedTimeInMillis")>]
        member _.TotalStoppedTimeInMillis(state: Types.MergesStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalStoppedTimeInMillis = value }

        [<CustomOperation("totalThrottledTime")>]
        member _.TotalThrottledTime(state: Types.MergesStats, value: Types.Duration) =
            { state with TotalThrottledTime = Some value }

        [<CustomOperation("totalThrottledTimeInMillis")>]
        member _.TotalThrottledTimeInMillis(state: Types.MergesStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalThrottledTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: Types.MergesStats, value: Types.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: Types.MergesStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let mergesStats = MergesStatsBuilder()

    type NestedSortValueBuilder() =
        member _.Yield(_: unit) : Types.NestedSortValue =
            {
                Filter = None
                MaxChildren = None
                Nested = None
                Path = Unchecked.defaultof<_>
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.NestedSortValue, value: Types.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("maxChildren")>]
        member _.MaxChildren(state: Types.NestedSortValue, value: Types.Integer) =
            { state with MaxChildren = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: Types.NestedSortValue, value: Types.NestedSortValue) =
            { state with Nested = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: Types.NestedSortValue, value: Types.Field) =
            { state with Path = value }

    let nestedSortValue = NestedSortValueBuilder()

    type NodeShardBuilder() =
        member _.Yield(_: unit) : Types.NodeShard =
            {
                State = Unchecked.defaultof<_>
                Primary = Unchecked.defaultof<_>
                Node = None
                Shard = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                AllocationId = None
                RecoverySource = None
                UnassignedInfo = None
                RelocatingNode = None
                RelocationFailureInfo = None
            }

        [<CustomOperation("state")>]
        member _.State(state: Types.NodeShard, value: Types.ShardRoutingState) =
            { state with State = value }

        [<CustomOperation("primary")>]
        member _.Primary(state: Types.NodeShard, value: bool) =
            { state with Primary = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.NodeShard, value: Types.NodeName) =
            { state with Node = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: Types.NodeShard, value: Types.Integer) =
            { state with Shard = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.NodeShard, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("allocationId")>]
        member _.AllocationId(state: Types.NodeShard, value: Map<string, Types.Id>) =
            { state with AllocationId = Some value }

        [<CustomOperation("recoverySource")>]
        member _.RecoverySource(state: Types.NodeShard, value: Map<string, Types.Id>) =
            { state with RecoverySource = Some value }

        [<CustomOperation("unassignedInfo")>]
        member _.UnassignedInfo(state: Types.NodeShard, value: Types.UnassignedInformation) =
            { state with UnassignedInfo = Some value }

        [<CustomOperation("relocatingNode")>]
        member _.RelocatingNode(state: Types.NodeShard, value: Types.NodeId option) =
            { state with RelocatingNode = Some value }

        [<CustomOperation("relocationFailureInfo")>]
        member _.RelocationFailureInfo(state: Types.NodeShard, value: Types.RelocationFailureInfo) =
            { state with RelocationFailureInfo = Some value }

    let nodeShard = NodeShardBuilder()

    type PinnedRetrieverBuilder() =
        member _.Yield(_: unit) : Types.PinnedRetriever =
            {
                Retriever = Unchecked.defaultof<_>
                Ids = None
                Docs = None
                RankWindowSize = None
            }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: Types.PinnedRetriever, value: Types.RetrieverContainer) =
            { state with Retriever = value }

        [<CustomOperation("ids")>]
        member _.Ids(state: Types.PinnedRetriever, value: string list) =
            { state with Ids = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: Types.PinnedRetriever, value: Types.SpecifiedDocument list) =
            { state with Docs = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: Types.PinnedRetriever, value: Types.Integer) =
            { state with RankWindowSize = Some value }

    let pinnedRetriever = PinnedRetrieverBuilder()

    module QueryVectorBuilder =

        let textEmbedding (value: Types.TextEmbedding) =
            Types.QueryVectorBuilder.TextEmbedding value

        let lookup (value: Types.LookupQueryVectorBuilder) =
            Types.QueryVectorBuilder.Lookup value

    type RRFRetrieverBuilder() =
        member _.Yield(_: unit) : Types.RRFRetriever =
            {
                Retrievers = Unchecked.defaultof<_>
                RankConstant = None
                RankWindowSize = None
                Query = None
                Fields = None
            }

        [<CustomOperation("retrievers")>]
        member _.Retrievers(state: Types.RRFRetriever, value: Types.RRFRetrieverEntry list) =
            { state with Retrievers = value }

        [<CustomOperation("rankConstant")>]
        member _.RankConstant(state: Types.RRFRetriever, value: Types.Integer) =
            { state with RankConstant = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: Types.RRFRetriever, value: Types.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: Types.RRFRetriever, value: string) =
            { state with Query = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: Types.RRFRetriever, value: string list) =
            { state with Fields = Some value }

    let rRFRetriever = RRFRetrieverBuilder()

    module Rank =

        let rrf (value: Types.RrfRank) =
            Types.RankContainer.Rrf value

    type ReindexStatusBuilder() =
        member _.Yield(_: unit) : Types.ReindexStatus =
            {
                SliceId = None
                Batches = Unchecked.defaultof<_>
                Created = None
                Deleted = Unchecked.defaultof<_>
                Noops = Unchecked.defaultof<_>
                RequestsPerSecond = Unchecked.defaultof<_>
                Retries = Unchecked.defaultof<_>
                Throttled = None
                ThrottledMillis = Unchecked.defaultof<_>
                ThrottledUntil = None
                ThrottledUntilMillis = Unchecked.defaultof<_>
                Total = Unchecked.defaultof<_>
                Updated = None
                VersionConflicts = Unchecked.defaultof<_>
                Cancelled = None
            }

        [<CustomOperation("sliceId")>]
        member _.SliceId(state: Types.ReindexStatus, value: Types.Integer) =
            { state with SliceId = Some value }

        [<CustomOperation("batches")>]
        member _.Batches(state: Types.ReindexStatus, value: Types.Long) =
            { state with Batches = value }

        [<CustomOperation("created")>]
        member _.Created(state: Types.ReindexStatus, value: Types.Long) =
            { state with Created = Some value }

        [<CustomOperation("deleted")>]
        member _.Deleted(state: Types.ReindexStatus, value: Types.Long) =
            { state with Deleted = value }

        [<CustomOperation("noops")>]
        member _.Noops(state: Types.ReindexStatus, value: Types.Long) =
            { state with Noops = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: Types.ReindexStatus, value: Types.Float) =
            { state with RequestsPerSecond = value }

        [<CustomOperation("retries")>]
        member _.Retries(state: Types.ReindexStatus, value: Types.Retries) =
            { state with Retries = value }

        [<CustomOperation("throttled")>]
        member _.Throttled(state: Types.ReindexStatus, value: Types.Duration) =
            { state with Throttled = Some value }

        [<CustomOperation("throttledMillis")>]
        member _.ThrottledMillis(state: Types.ReindexStatus, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ThrottledMillis = value }

        [<CustomOperation("throttledUntil")>]
        member _.ThrottledUntil(state: Types.ReindexStatus, value: Types.Duration) =
            { state with ThrottledUntil = Some value }

        [<CustomOperation("throttledUntilMillis")>]
        member _.ThrottledUntilMillis(state: Types.ReindexStatus, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ThrottledUntilMillis = value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.ReindexStatus, value: Types.Long) =
            { state with Total = value }

        [<CustomOperation("updated")>]
        member _.Updated(state: Types.ReindexStatus, value: Types.Long) =
            { state with Updated = Some value }

        [<CustomOperation("versionConflicts")>]
        member _.VersionConflicts(state: Types.ReindexStatus, value: Types.Long) =
            { state with VersionConflicts = value }

        [<CustomOperation("cancelled")>]
        member _.Cancelled(state: Types.ReindexStatus, value: string) =
            { state with Cancelled = Some value }

    let reindexStatus = ReindexStatusBuilder()

    type RetrieverBaseBuilder() =
        member _.Yield(_: unit) : Types.RetrieverBase =
            {
                Filter = None
                MinScore = None
                Name = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.RetrieverBase, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: Types.RetrieverBase, value: Types.Float) =
            { state with MinScore = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.RetrieverBase, value: string) =
            { state with Name = Some value }

    let retrieverBase = RetrieverBaseBuilder()

    module Retriever =

        let standard (value: Types.StandardRetriever) =
            Types.RetrieverContainer.Standard value

        let knn (value: Types.KnnRetriever) =
            Types.RetrieverContainer.Knn value

        let rrf (value: Types.RRFRetriever) =
            Types.RetrieverContainer.Rrf value

        let textSimilarityReranker (value: Types.TextSimilarityReranker) =
            Types.RetrieverContainer.TextSimilarityReranker value

        let rule (value: Types.RuleRetriever) =
            Types.RetrieverContainer.Rule value

        let rescorer (value: Types.RescorerRetriever) =
            Types.RetrieverContainer.Rescorer value

        let linear (value: Types.LinearRetriever) =
            Types.RetrieverContainer.Linear value

        let pinned (value: Types.PinnedRetriever) =
            Types.RetrieverContainer.Pinned value

        let diversify (value: Types.DiversifyRetriever) =
            Types.RetrieverContainer.Diversify value

    type RrfRankBuilder() =
        member _.Yield(_: unit) : Types.RrfRank =
            {
                RankConstant = None
                RankWindowSize = None
            }

        [<CustomOperation("rankConstant")>]
        member _.RankConstant(state: Types.RrfRank, value: Types.Long) =
            { state with RankConstant = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: Types.RrfRank, value: Types.Long) =
            { state with RankWindowSize = Some value }

    let rrfRank = RrfRankBuilder()

    type ScriptBuilder() =
        member _.Yield(_: unit) : Types.Script =
            {
                Source = None
                Id = None
                Params = None
                Lang = None
                Options = None
            }

        [<CustomOperation("source")>]
        member _.Source(state: Types.Script, value: Types.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.Script, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.Script, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: Types.Script, value: Types.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("options")>]
        member _.Options(state: Types.Script, value: Map<string, string>) =
            { state with Options = Some value }

    let script = ScriptBuilder()

    let ofSource (value: Types.ScriptSource) : Types.Script =
        {
            Source = value
            Id = None
            Params = None
            Lang = None
            Options = None
        }

    type ScriptSortBuilder() =
        member _.Yield(_: unit) : Types.ScriptSort =
            {
                Order = None
                Script = Unchecked.defaultof<_>
                Type = None
                Mode = None
                Nested = None
            }

        [<CustomOperation("order")>]
        member _.Order(state: Types.ScriptSort, value: Types.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: Types.ScriptSort, value: Types.Script) =
            { state with Script = value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.ScriptSort, value: Types.ScriptSortType) =
            { state with Type = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.ScriptSort, value: Types.SortMode) =
            { state with Mode = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: Types.ScriptSort, value: Types.NestedSortValue) =
            { state with Nested = Some value }

    let scriptSort = ScriptSortBuilder()

    type ScriptTransformBuilder() =
        member _.Yield(_: unit) : Types.ScriptTransform =
            {
                Lang = None
                Params = None
                Source = None
                Id = None
            }

        [<CustomOperation("lang")>]
        member _.Lang(state: Types.ScriptTransform, value: string) =
            { state with Lang = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.ScriptTransform, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: Types.ScriptTransform, value: Types.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.ScriptTransform, value: string) =
            { state with Id = Some value }

    let scriptTransform = ScriptTransformBuilder()

    type SearchStatsBuilder() =
        member _.Yield(_: unit) : Types.SearchStats =
            {
                FetchCurrent = Unchecked.defaultof<_>
                FetchTime = None
                FetchTimeInMillis = Unchecked.defaultof<_>
                FetchTotal = Unchecked.defaultof<_>
                OpenContexts = None
                QueryCurrent = Unchecked.defaultof<_>
                QueryTime = None
                QueryTimeInMillis = Unchecked.defaultof<_>
                QueryTotal = Unchecked.defaultof<_>
                ScrollCurrent = Unchecked.defaultof<_>
                ScrollTime = None
                ScrollTimeInMillis = Unchecked.defaultof<_>
                ScrollTotal = Unchecked.defaultof<_>
                SuggestCurrent = Unchecked.defaultof<_>
                SuggestTime = None
                SuggestTimeInMillis = Unchecked.defaultof<_>
                SuggestTotal = Unchecked.defaultof<_>
                RecentSearchLoad = None
                Groups = None
            }

        [<CustomOperation("fetchCurrent")>]
        member _.FetchCurrent(state: Types.SearchStats, value: Types.Long) =
            { state with FetchCurrent = value }

        [<CustomOperation("fetchTime")>]
        member _.FetchTime(state: Types.SearchStats, value: Types.Duration) =
            { state with FetchTime = Some value }

        [<CustomOperation("fetchTimeInMillis")>]
        member _.FetchTimeInMillis(state: Types.SearchStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with FetchTimeInMillis = value }

        [<CustomOperation("fetchTotal")>]
        member _.FetchTotal(state: Types.SearchStats, value: Types.Long) =
            { state with FetchTotal = value }

        [<CustomOperation("openContexts")>]
        member _.OpenContexts(state: Types.SearchStats, value: Types.Long) =
            { state with OpenContexts = Some value }

        [<CustomOperation("queryCurrent")>]
        member _.QueryCurrent(state: Types.SearchStats, value: Types.Long) =
            { state with QueryCurrent = value }

        [<CustomOperation("queryTime")>]
        member _.QueryTime(state: Types.SearchStats, value: Types.Duration) =
            { state with QueryTime = Some value }

        [<CustomOperation("queryTimeInMillis")>]
        member _.QueryTimeInMillis(state: Types.SearchStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with QueryTimeInMillis = value }

        [<CustomOperation("queryTotal")>]
        member _.QueryTotal(state: Types.SearchStats, value: Types.Long) =
            { state with QueryTotal = value }

        [<CustomOperation("scrollCurrent")>]
        member _.ScrollCurrent(state: Types.SearchStats, value: Types.Long) =
            { state with ScrollCurrent = value }

        [<CustomOperation("scrollTime")>]
        member _.ScrollTime(state: Types.SearchStats, value: Types.Duration) =
            { state with ScrollTime = Some value }

        [<CustomOperation("scrollTimeInMillis")>]
        member _.ScrollTimeInMillis(state: Types.SearchStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with ScrollTimeInMillis = value }

        [<CustomOperation("scrollTotal")>]
        member _.ScrollTotal(state: Types.SearchStats, value: Types.Long) =
            { state with ScrollTotal = value }

        [<CustomOperation("suggestCurrent")>]
        member _.SuggestCurrent(state: Types.SearchStats, value: Types.Long) =
            { state with SuggestCurrent = value }

        [<CustomOperation("suggestTime")>]
        member _.SuggestTime(state: Types.SearchStats, value: Types.Duration) =
            { state with SuggestTime = Some value }

        [<CustomOperation("suggestTimeInMillis")>]
        member _.SuggestTimeInMillis(state: Types.SearchStats, value: Types.DurationValue<Types.UnitMillis>) =
            { state with SuggestTimeInMillis = value }

        [<CustomOperation("suggestTotal")>]
        member _.SuggestTotal(state: Types.SearchStats, value: Types.Long) =
            { state with SuggestTotal = value }

        [<CustomOperation("recentSearchLoad")>]
        member _.RecentSearchLoad(state: Types.SearchStats, value: Types.Double) =
            { state with RecentSearchLoad = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: Types.SearchStats, value: Map<string, Types.SearchStats>) =
            { state with Groups = Some value }

    let searchStats = SearchStatsBuilder()

    type SegmentsStatsBuilder() =
        member _.Yield(_: unit) : Types.SegmentsStats =
            {
                Count = Unchecked.defaultof<_>
                DocValuesMemory = None
                DocValuesMemoryInBytes = Unchecked.defaultof<_>
                FileSizes = Unchecked.defaultof<_>
                FixedBitSet = None
                FixedBitSetMemoryInBytes = Unchecked.defaultof<_>
                IndexWriterMemory = None
                IndexWriterMemoryInBytes = Unchecked.defaultof<_>
                MaxUnsafeAutoIdTimestamp = Unchecked.defaultof<_>
                Memory = None
                MemoryInBytes = Unchecked.defaultof<_>
                NormsMemory = None
                NormsMemoryInBytes = Unchecked.defaultof<_>
                PointsMemory = None
                PointsMemoryInBytes = Unchecked.defaultof<_>
                StoredFieldsMemoryInBytes = Unchecked.defaultof<_>
                StoredFieldsMemory = None
                TermsMemoryInBytes = Unchecked.defaultof<_>
                TermsMemory = None
                TermVectorsMemory = None
                TermVectorsMemoryInBytes = Unchecked.defaultof<_>
                VersionMapMemory = None
                VersionMapMemoryInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("count")>]
        member _.Count(state: Types.SegmentsStats, value: Types.Integer) =
            { state with Count = value }

        [<CustomOperation("docValuesMemory")>]
        member _.DocValuesMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with DocValuesMemory = Some value }

        [<CustomOperation("docValuesMemoryInBytes")>]
        member _.DocValuesMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with DocValuesMemoryInBytes = value }

        [<CustomOperation("fileSizes")>]
        member _.FileSizes(state: Types.SegmentsStats, value: Map<string, Types.ShardFileSizeInfo>) =
            { state with FileSizes = value }

        [<CustomOperation("fixedBitSet")>]
        member _.FixedBitSet(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with FixedBitSet = Some value }

        [<CustomOperation("fixedBitSetMemoryInBytes")>]
        member _.FixedBitSetMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with FixedBitSetMemoryInBytes = value }

        [<CustomOperation("indexWriterMemory")>]
        member _.IndexWriterMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with IndexWriterMemory = Some value }

        [<CustomOperation("indexWriterMemoryInBytes")>]
        member _.IndexWriterMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with IndexWriterMemoryInBytes = value }

        [<CustomOperation("maxUnsafeAutoIdTimestamp")>]
        member _.MaxUnsafeAutoIdTimestamp(state: Types.SegmentsStats, value: Types.Long) =
            { state with MaxUnsafeAutoIdTimestamp = value }

        [<CustomOperation("memory")>]
        member _.Memory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with Memory = Some value }

        [<CustomOperation("memoryInBytes")>]
        member _.MemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with MemoryInBytes = value }

        [<CustomOperation("normsMemory")>]
        member _.NormsMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with NormsMemory = Some value }

        [<CustomOperation("normsMemoryInBytes")>]
        member _.NormsMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with NormsMemoryInBytes = value }

        [<CustomOperation("pointsMemory")>]
        member _.PointsMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with PointsMemory = Some value }

        [<CustomOperation("pointsMemoryInBytes")>]
        member _.PointsMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with PointsMemoryInBytes = value }

        [<CustomOperation("storedFieldsMemoryInBytes")>]
        member _.StoredFieldsMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with StoredFieldsMemoryInBytes = value }

        [<CustomOperation("storedFieldsMemory")>]
        member _.StoredFieldsMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with StoredFieldsMemory = Some value }

        [<CustomOperation("termsMemoryInBytes")>]
        member _.TermsMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with TermsMemoryInBytes = value }

        [<CustomOperation("termsMemory")>]
        member _.TermsMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with TermsMemory = Some value }

        [<CustomOperation("termVectorsMemory")>]
        member _.TermVectorsMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with TermVectorsMemory = Some value }

        [<CustomOperation("termVectorsMemoryInBytes")>]
        member _.TermVectorsMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with TermVectorsMemoryInBytes = value }

        [<CustomOperation("versionMapMemory")>]
        member _.VersionMapMemory(state: Types.SegmentsStats, value: Types.ByteSize) =
            { state with VersionMapMemory = Some value }

        [<CustomOperation("versionMapMemoryInBytes")>]
        member _.VersionMapMemoryInBytes(state: Types.SegmentsStats, value: Types.Long) =
            { state with VersionMapMemoryInBytes = value }

    let segmentsStats = SegmentsStatsBuilder()

    type ShardFailureBuilder() =
        member _.Yield(_: unit) : Types.ShardFailure =
            {
                Index = None
                Node = None
                Reason = Unchecked.defaultof<_>
                Shard = None
                Status = None
                Primary = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.ShardFailure, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.ShardFailure, value: string) =
            { state with Node = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.ShardFailure, value: Types.ErrorCause) =
            { state with Reason = value }

        [<CustomOperation("shard")>]
        member _.Shard(state: Types.ShardFailure, value: Types.Integer) =
            { state with Shard = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.ShardFailure, value: string) =
            { state with Status = Some value }

        [<CustomOperation("primary")>]
        member _.Primary(state: Types.ShardFailure, value: bool) =
            { state with Primary = Some value }

    let shardFailure = ShardFailureBuilder()

    type ShardStatisticsBuilder() =
        member _.Yield(_: unit) : Types.ShardStatistics =
            {
                Failed = Unchecked.defaultof<_>
                Successful = Unchecked.defaultof<_>
                Total = Unchecked.defaultof<_>
                Failures = None
                Skipped = None
            }

        [<CustomOperation("failed")>]
        member _.Failed(state: Types.ShardStatistics, value: Types.Uint) =
            { state with Failed = value }

        [<CustomOperation("successful")>]
        member _.Successful(state: Types.ShardStatistics, value: Types.Uint) =
            { state with Successful = value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.ShardStatistics, value: Types.Uint) =
            { state with Total = value }

        [<CustomOperation("failures")>]
        member _.Failures(state: Types.ShardStatistics, value: Types.ShardFailure list) =
            { state with Failures = Some value }

        [<CustomOperation("skipped")>]
        member _.Skipped(state: Types.ShardStatistics, value: Types.Uint) =
            { state with Skipped = Some value }

    let shardStatistics = ShardStatisticsBuilder()

    module SortOptions =

        let score (value: Types.ScoreSort) =
            Types.SortOptions.Score value

        let doc (value: Types.ScoreSort) =
            Types.SortOptions.Doc value

        let geoDistance (value: Types.GeoDistanceSort) =
            Types.SortOptions.GeoDistance value

        let script (value: Types.ScriptSort) =
            Types.SortOptions.Script value

    type StandardRetrieverBuilder() =
        member _.Yield(_: unit) : Types.StandardRetriever =
            {
                Query = None
                SearchAfter = None
                TerminateAfter = None
                Sort = None
                Collapse = None
            }

        [<CustomOperation("query")>]
        member _.Query(state: Types.StandardRetriever, value: Types.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: Types.StandardRetriever, value: Types.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: Types.StandardRetriever, value: Types.Integer) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.StandardRetriever, value: Types.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: Types.StandardRetriever, value: Types.FieldCollapse) =
            { state with Collapse = Some value }

    let standardRetriever = StandardRetrieverBuilder()

    type StoreStatsBuilder() =
        member _.Yield(_: unit) : Types.StoreStats =
            {
                Size = None
                SizeInBytes = Unchecked.defaultof<_>
                Reserved = None
                ReservedInBytes = Unchecked.defaultof<_>
                TotalDataSetSize = None
                TotalDataSetSizeInBytes = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: Types.StoreStats, value: Types.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: Types.StoreStats, value: Types.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("reserved")>]
        member _.Reserved(state: Types.StoreStats, value: Types.ByteSize) =
            { state with Reserved = Some value }

        [<CustomOperation("reservedInBytes")>]
        member _.ReservedInBytes(state: Types.StoreStats, value: Types.Long) =
            { state with ReservedInBytes = value }

        [<CustomOperation("totalDataSetSize")>]
        member _.TotalDataSetSize(state: Types.StoreStats, value: Types.ByteSize) =
            { state with TotalDataSetSize = Some value }

        [<CustomOperation("totalDataSetSizeInBytes")>]
        member _.TotalDataSetSizeInBytes(state: Types.StoreStats, value: Types.Long) =
            { state with TotalDataSetSizeInBytes = Some value }

    let storeStats = StoreStatsBuilder()

    type TextSimilarityRerankerBuilder() =
        member _.Yield(_: unit) : Types.TextSimilarityReranker =
            {
                Retriever = Unchecked.defaultof<_>
                RankWindowSize = None
                InferenceId = None
                InferenceText = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                ChunkRescorer = None
            }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: Types.TextSimilarityReranker, value: Types.RetrieverContainer) =
            { state with Retriever = value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: Types.TextSimilarityReranker, value: Types.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: Types.TextSimilarityReranker, value: string) =
            { state with InferenceId = Some value }

        [<CustomOperation("inferenceText")>]
        member _.InferenceText(state: Types.TextSimilarityReranker, value: string) =
            { state with InferenceText = value }

        [<CustomOperation("field")>]
        member _.Field(state: Types.TextSimilarityReranker, value: string) =
            { state with Field = value }

        [<CustomOperation("chunkRescorer")>]
        member _.ChunkRescorer(state: Types.TextSimilarityReranker, value: Types.ChunkRescorer) =
            { state with ChunkRescorer = Some value }

    let textSimilarityReranker = TextSimilarityRerankerBuilder()

    type TokenPruningConfigBuilder() =
        member _.Yield(_: unit) : Types.TokenPruningConfig =
            {
                TokensFreqRatioThreshold = None
                TokensWeightThreshold = None
                OnlyScorePrunedTokens = None
            }

        [<CustomOperation("tokensFreqRatioThreshold")>]
        member _.TokensFreqRatioThreshold(state: Types.TokenPruningConfig, value: Types.Integer) =
            { state with TokensFreqRatioThreshold = Some value }

        [<CustomOperation("tokensWeightThreshold")>]
        member _.TokensWeightThreshold(state: Types.TokenPruningConfig, value: Types.Float) =
            { state with TokensWeightThreshold = Some value }

        [<CustomOperation("onlyScorePrunedTokens")>]
        member _.OnlyScorePrunedTokens(state: Types.TokenPruningConfig, value: bool) =
            { state with OnlyScorePrunedTokens = Some value }

    let tokenPruningConfig = TokenPruningConfigBuilder()

    module Transform =

        let chain (value: Types.TransformContainer list) =
            Types.TransformContainer.Chain value

        let script (value: Types.ScriptTransform) =
            Types.TransformContainer.Script value

        let search (value: Types.SearchTransform) =
            Types.TransformContainer.Search value

    type TranslogStatsBuilder() =
        member _.Yield(_: unit) : Types.TranslogStats =
            {
                EarliestLastModifiedAge = Unchecked.defaultof<_>
                Operations = Unchecked.defaultof<_>
                Size = None
                SizeInBytes = Unchecked.defaultof<_>
                UncommittedOperations = Unchecked.defaultof<_>
                UncommittedSize = None
                UncommittedSizeInBytes = Unchecked.defaultof<_>
            }

        [<CustomOperation("earliestLastModifiedAge")>]
        member _.EarliestLastModifiedAge(state: Types.TranslogStats, value: Types.Long) =
            { state with EarliestLastModifiedAge = value }

        [<CustomOperation("operations")>]
        member _.Operations(state: Types.TranslogStats, value: Types.Long) =
            { state with Operations = value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.TranslogStats, value: string) =
            { state with Size = Some value }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: Types.TranslogStats, value: Types.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("uncommittedOperations")>]
        member _.UncommittedOperations(state: Types.TranslogStats, value: Types.Integer) =
            { state with UncommittedOperations = value }

        [<CustomOperation("uncommittedSize")>]
        member _.UncommittedSize(state: Types.TranslogStats, value: string) =
            { state with UncommittedSize = Some value }

        [<CustomOperation("uncommittedSizeInBytes")>]
        member _.UncommittedSizeInBytes(state: Types.TranslogStats, value: Types.Long) =
            { state with UncommittedSizeInBytes = value }

    let translogStats = TranslogStatsBuilder()

    type WriteResponseBaseBuilder() =
        member _.Yield(_: unit) : Types.WriteResponseBase =
            {
                Id = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                PrimaryTerm = None
                Result = Unchecked.defaultof<_>
                SeqNo = None
                Shards = Unchecked.defaultof<_>
                Version = Unchecked.defaultof<_>
                FailureStore = None
                ForcedRefresh = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.WriteResponseBase, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.WriteResponseBase, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: Types.WriteResponseBase, value: Types.Long) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("result")>]
        member _.Result(state: Types.WriteResponseBase, value: Types.Result) =
            { state with Result = value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: Types.WriteResponseBase, value: Types.SequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.WriteResponseBase, value: Types.ShardStatistics) =
            { state with Shards = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.WriteResponseBase, value: Types.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: Types.WriteResponseBase, value: Types.FailureStoreStatus) =
            { state with FailureStore = Some value }

        [<CustomOperation("forcedRefresh")>]
        member _.ForcedRefresh(state: Types.WriteResponseBase, value: bool) =
            { state with ForcedRefresh = Some value }

    let writeResponseBase = WriteResponseBaseBuilder()


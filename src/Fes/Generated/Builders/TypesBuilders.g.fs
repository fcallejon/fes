// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module TypesBuilders =

    type BulkStatsBuilder() =
        member _.Yield(_: unit) : BulkStats =
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
        member _.TotalOperations(state: BulkStats, value: CoreTypes.Long) =
            { state with TotalOperations = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: BulkStats, value: CoreTypes.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: BulkStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalTimeInMillis = value }

        [<CustomOperation("totalSize")>]
        member _.TotalSize(state: BulkStats, value: CoreTypes.ByteSize) =
            { state with TotalSize = Some value }

        [<CustomOperation("totalSizeInBytes")>]
        member _.TotalSizeInBytes(state: BulkStats, value: CoreTypes.Long) =
            { state with TotalSizeInBytes = value }

        [<CustomOperation("avgTime")>]
        member _.AvgTime(state: BulkStats, value: CoreTypes.Duration) =
            { state with AvgTime = Some value }

        [<CustomOperation("avgTimeInMillis")>]
        member _.AvgTimeInMillis(state: BulkStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with AvgTimeInMillis = value }

        [<CustomOperation("avgSize")>]
        member _.AvgSize(state: BulkStats, value: CoreTypes.ByteSize) =
            { state with AvgSize = Some value }

        [<CustomOperation("avgSizeInBytes")>]
        member _.AvgSizeInBytes(state: BulkStats, value: CoreTypes.Long) =
            { state with AvgSizeInBytes = value }

    let bulkStats = BulkStatsBuilder()

    type ChunkRescorerBuilder() =
        member _.Yield(_: unit) : ChunkRescorer =
            {
                Size = None
                ChunkingSettings = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: ChunkRescorer, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("chunkingSettings")>]
        member _.ChunkingSettings(state: ChunkRescorer, value: CoreTypes.ChunkRescorerChunkingSettings) =
            { state with ChunkingSettings = Some value }

    let chunkRescorer = ChunkRescorerBuilder()

    type ClusterDetailsBuilder() =
        member _.Yield(_: unit) : ClusterDetails =
            {
                Status = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                Took = None
                TimedOut = Unchecked.defaultof<_>
                Shards = None
                Failures = None
            }

        [<CustomOperation("status")>]
        member _.Status(state: ClusterDetails, value: CoreTypes.ClusterSearchStatus) =
            { state with Status = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: ClusterDetails, value: string) =
            { state with Indices = value }

        [<CustomOperation("took")>]
        member _.Took(state: ClusterDetails, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with Took = Some value }

        [<CustomOperation("timedOut")>]
        member _.TimedOut(state: ClusterDetails, value: bool) =
            { state with TimedOut = value }

        [<CustomOperation("shards")>]
        member _.Shards(state: ClusterDetails, value: CoreTypes.ShardStatistics) =
            { state with Shards = Some value }

        [<CustomOperation("failures")>]
        member _.Failures(state: ClusterDetails, value: CoreTypes.ShardFailure list) =
            { state with Failures = Some value }

    let clusterDetails = ClusterDetailsBuilder()

    type CompletionStatsBuilder() =
        member _.Yield(_: unit) : CompletionStats =
            {
                SizeInBytes = Unchecked.defaultof<_>
                Size = None
                Fields = None
            }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: CompletionStats, value: CoreTypes.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("size")>]
        member _.Size(state: CompletionStats, value: CoreTypes.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: CompletionStats, value: Map<CoreTypes.Field, CoreTypes.FieldSizeUsage>) =
            { state with Fields = Some value }

    let completionStats = CompletionStatsBuilder()

    type DiversifyRetrieverBuilder() =
        member _.Yield(_: unit) : DiversifyRetriever =
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
        member _.Type(state: DiversifyRetriever, value: CoreTypes.DiversifyRetrieverTypes) =
            { state with Type = value }

        [<CustomOperation("field")>]
        member _.Field(state: DiversifyRetriever, value: string) =
            { state with Field = value }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: DiversifyRetriever, value: CoreTypes.RetrieverContainer) =
            { state with Retriever = value }

        [<CustomOperation("size")>]
        member _.Size(state: DiversifyRetriever, value: CoreTypes.Integer) =
            { state with Size = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: DiversifyRetriever, value: CoreTypes.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: DiversifyRetriever, value: CoreTypes.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: DiversifyRetriever, value: CoreTypes.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("lambda")>]
        member _.Lambda(state: DiversifyRetriever, value: CoreTypes.Float) =
            { state with Lambda = Some value }

    let diversifyRetriever = DiversifyRetrieverBuilder()

    type DocStatsBuilder() =
        member _.Yield(_: unit) : DocStats =
            {
                Count = Unchecked.defaultof<_>
                Deleted = None
                TotalSizeInBytes = Unchecked.defaultof<_>
                TotalSize = None
            }

        [<CustomOperation("count")>]
        member _.Count(state: DocStats, value: CoreTypes.Long) =
            { state with Count = value }

        [<CustomOperation("deleted")>]
        member _.Deleted(state: DocStats, value: CoreTypes.Long) =
            { state with Deleted = Some value }

        [<CustomOperation("totalSizeInBytes")>]
        member _.TotalSizeInBytes(state: DocStats, value: CoreTypes.Long) =
            { state with TotalSizeInBytes = value }

        [<CustomOperation("totalSize")>]
        member _.TotalSize(state: DocStats, value: CoreTypes.ByteSize) =
            { state with TotalSize = Some value }

    let docStats = DocStatsBuilder()

    type ErrorCauseBuilder() =
        member _.Yield(_: unit) : ErrorCause =
            {
                Type = Unchecked.defaultof<_>
                Reason = None
                StackTrace = None
                CausedBy = None
                RootCause = None
                Suppressed = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: ErrorCause, value: string) =
            { state with Type = value }

        [<CustomOperation("reason")>]
        member _.Reason(state: ErrorCause, value: string option) =
            { state with Reason = Some value }

        [<CustomOperation("stackTrace")>]
        member _.StackTrace(state: ErrorCause, value: string) =
            { state with StackTrace = Some value }

        [<CustomOperation("causedBy")>]
        member _.CausedBy(state: ErrorCause, value: CoreTypes.ErrorCause) =
            { state with CausedBy = Some value }

        [<CustomOperation("rootCause")>]
        member _.RootCause(state: ErrorCause, value: CoreTypes.ErrorCause list) =
            { state with RootCause = Some value }

        [<CustomOperation("suppressed")>]
        member _.Suppressed(state: ErrorCause, value: CoreTypes.ErrorCause list) =
            { state with Suppressed = Some value }

    let errorCause = ErrorCauseBuilder()

    type FieldSortBuilder() =
        member _.Yield(_: unit) : FieldSort =
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
        member _.Missing(state: FieldSort, value: CoreTypes.Missing) =
            { state with Missing = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: FieldSort, value: CoreTypes.SortMode) =
            { state with Mode = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: FieldSort, value: CoreTypes.NestedSortValue) =
            { state with Nested = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: FieldSort, value: CoreTypes.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("unmappedType")>]
        member _.UnmappedType(state: FieldSort, value: CoreTypes.FieldType) =
            { state with UnmappedType = Some value }

        [<CustomOperation("numericType")>]
        member _.NumericType(state: FieldSort, value: CoreTypes.FieldSortNumericType) =
            { state with NumericType = Some value }

        [<CustomOperation("format")>]
        member _.Format(state: FieldSort, value: string) =
            { state with Format = Some value }

    let fieldSort = FieldSortBuilder()

    let ofOrder (value: CoreTypes.SortOrder) : FieldSort =
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
        member _.Yield(_: unit) : FielddataStats =
            {
                Evictions = None
                MemorySize = None
                MemorySizeInBytes = Unchecked.defaultof<_>
                Fields = None
                GlobalOrdinals = Unchecked.defaultof<_>
            }

        [<CustomOperation("evictions")>]
        member _.Evictions(state: FielddataStats, value: CoreTypes.Long) =
            { state with Evictions = Some value }

        [<CustomOperation("memorySize")>]
        member _.MemorySize(state: FielddataStats, value: CoreTypes.ByteSize) =
            { state with MemorySize = Some value }

        [<CustomOperation("memorySizeInBytes")>]
        member _.MemorySizeInBytes(state: FielddataStats, value: CoreTypes.Long) =
            { state with MemorySizeInBytes = value }

        [<CustomOperation("fields")>]
        member _.Fields(state: FielddataStats, value: Map<CoreTypes.Field, CoreTypes.FieldMemoryUsage>) =
            { state with Fields = Some value }

        [<CustomOperation("globalOrdinals")>]
        member _.GlobalOrdinals(state: FielddataStats, value: CoreTypes.GlobalOrdinalsStats) =
            { state with GlobalOrdinals = value }

    let fielddataStats = FielddataStatsBuilder()

    type GeoDistanceSortBuilder() =
        member _.Yield(_: unit) : GeoDistanceSort =
            {
                Mode = None
                DistanceType = None
                IgnoreUnmapped = None
                Order = None
                Unit = None
                Nested = None
            }

        [<CustomOperation("mode")>]
        member _.Mode(state: GeoDistanceSort, value: CoreTypes.SortMode) =
            { state with Mode = Some value }

        [<CustomOperation("distanceType")>]
        member _.DistanceType(state: GeoDistanceSort, value: CoreTypes.GeoDistanceType) =
            { state with DistanceType = Some value }

        [<CustomOperation("ignoreUnmapped")>]
        member _.IgnoreUnmapped(state: GeoDistanceSort, value: bool) =
            { state with IgnoreUnmapped = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: GeoDistanceSort, value: CoreTypes.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("unit")>]
        member _.Unit(state: GeoDistanceSort, value: CoreTypes.DistanceUnit) =
            { state with Unit = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: GeoDistanceSort, value: CoreTypes.NestedSortValue) =
            { state with Nested = Some value }

    let geoDistanceSort = GeoDistanceSortBuilder()

    type GetStatsBuilder() =
        member _.Yield(_: unit) : GetStats =
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
        member _.Current(state: GetStats, value: CoreTypes.Long) =
            { state with Current = value }

        [<CustomOperation("existsTime")>]
        member _.ExistsTime(state: GetStats, value: CoreTypes.Duration) =
            { state with ExistsTime = Some value }

        [<CustomOperation("existsTimeInMillis")>]
        member _.ExistsTimeInMillis(state: GetStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ExistsTimeInMillis = value }

        [<CustomOperation("existsTotal")>]
        member _.ExistsTotal(state: GetStats, value: CoreTypes.Long) =
            { state with ExistsTotal = value }

        [<CustomOperation("missingTime")>]
        member _.MissingTime(state: GetStats, value: CoreTypes.Duration) =
            { state with MissingTime = Some value }

        [<CustomOperation("missingTimeInMillis")>]
        member _.MissingTimeInMillis(state: GetStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with MissingTimeInMillis = value }

        [<CustomOperation("missingTotal")>]
        member _.MissingTotal(state: GetStats, value: CoreTypes.Long) =
            { state with MissingTotal = value }

        [<CustomOperation("time")>]
        member _.Time(state: GetStats, value: CoreTypes.Duration) =
            { state with Time = Some value }

        [<CustomOperation("timeInMillis")>]
        member _.TimeInMillis(state: GetStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TimeInMillis = value }

        [<CustomOperation("total")>]
        member _.Total(state: GetStats, value: CoreTypes.Long) =
            { state with Total = value }

    let getStats = GetStatsBuilder()

    type GlobalOrdinalsStatsBuilder() =
        member _.Yield(_: unit) : GlobalOrdinalsStats =
            {
                BuildTimeInMillis = Unchecked.defaultof<_>
                BuildTime = None
                Fields = None
            }

        [<CustomOperation("buildTimeInMillis")>]
        member _.BuildTimeInMillis(state: GlobalOrdinalsStats, value: CoreTypes.UnitMillis) =
            { state with BuildTimeInMillis = value }

        [<CustomOperation("buildTime")>]
        member _.BuildTime(state: GlobalOrdinalsStats, value: string) =
            { state with BuildTime = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: GlobalOrdinalsStats, value: Map<CoreTypes.Name, CoreTypes.GlobalOrdinalFieldStats>) =
            { state with Fields = Some value }

    let globalOrdinalsStats = GlobalOrdinalsStatsBuilder()

    type IndexingStatsBuilder() =
        member _.Yield(_: unit) : IndexingStats =
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
        member _.IndexCurrent(state: IndexingStats, value: CoreTypes.Long) =
            { state with IndexCurrent = value }

        [<CustomOperation("deleteCurrent")>]
        member _.DeleteCurrent(state: IndexingStats, value: CoreTypes.Long) =
            { state with DeleteCurrent = value }

        [<CustomOperation("deleteTime")>]
        member _.DeleteTime(state: IndexingStats, value: CoreTypes.Duration) =
            { state with DeleteTime = Some value }

        [<CustomOperation("deleteTimeInMillis")>]
        member _.DeleteTimeInMillis(state: IndexingStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with DeleteTimeInMillis = value }

        [<CustomOperation("deleteTotal")>]
        member _.DeleteTotal(state: IndexingStats, value: CoreTypes.Long) =
            { state with DeleteTotal = value }

        [<CustomOperation("isThrottled")>]
        member _.IsThrottled(state: IndexingStats, value: bool) =
            { state with IsThrottled = value }

        [<CustomOperation("noopUpdateTotal")>]
        member _.NoopUpdateTotal(state: IndexingStats, value: CoreTypes.Long) =
            { state with NoopUpdateTotal = value }

        [<CustomOperation("throttleTime")>]
        member _.ThrottleTime(state: IndexingStats, value: CoreTypes.Duration) =
            { state with ThrottleTime = Some value }

        [<CustomOperation("throttleTimeInMillis")>]
        member _.ThrottleTimeInMillis(state: IndexingStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ThrottleTimeInMillis = value }

        [<CustomOperation("indexTime")>]
        member _.IndexTime(state: IndexingStats, value: CoreTypes.Duration) =
            { state with IndexTime = Some value }

        [<CustomOperation("indexTimeInMillis")>]
        member _.IndexTimeInMillis(state: IndexingStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with IndexTimeInMillis = value }

        [<CustomOperation("indexTotal")>]
        member _.IndexTotal(state: IndexingStats, value: CoreTypes.Long) =
            { state with IndexTotal = value }

        [<CustomOperation("indexFailed")>]
        member _.IndexFailed(state: IndexingStats, value: CoreTypes.Long) =
            { state with IndexFailed = value }

        [<CustomOperation("types")>]
        member _.Types(state: IndexingStats, value: Map<string, CoreTypes.IndexingStats>) =
            { state with Types = Some value }

        [<CustomOperation("writeLoad")>]
        member _.WriteLoad(state: IndexingStats, value: CoreTypes.Double) =
            { state with WriteLoad = Some value }

        [<CustomOperation("recentWriteLoad")>]
        member _.RecentWriteLoad(state: IndexingStats, value: CoreTypes.Double) =
            { state with RecentWriteLoad = Some value }

        [<CustomOperation("peakWriteLoad")>]
        member _.PeakWriteLoad(state: IndexingStats, value: CoreTypes.Double) =
            { state with PeakWriteLoad = Some value }

    let indexingStats = IndexingStatsBuilder()

    type IndicesOptionsBuilder() =
        member _.Yield(_: unit) : IndicesOptions =
            {
                AllowNoIndices = None
                ExpandWildcards = None
                IgnoreUnavailable = None
                IgnoreThrottled = None
            }

        [<CustomOperation("allowNoIndices")>]
        member _.AllowNoIndices(state: IndicesOptions, value: bool) =
            { state with AllowNoIndices = Some value }

        [<CustomOperation("expandWildcards")>]
        member _.ExpandWildcards(state: IndicesOptions, value: CoreTypes.ExpandWildcards) =
            { state with ExpandWildcards = Some value }

        [<CustomOperation("ignoreUnavailable")>]
        member _.IgnoreUnavailable(state: IndicesOptions, value: bool) =
            { state with IgnoreUnavailable = Some value }

        [<CustomOperation("ignoreThrottled")>]
        member _.IgnoreThrottled(state: IndicesOptions, value: bool) =
            { state with IgnoreThrottled = Some value }

    let indicesOptions = IndicesOptionsBuilder()

    type InlineGetBuilder() =
        member _.Yield(_: unit) : InlineGet =
            {
                Fields = None
                Found = Unchecked.defaultof<_>
                SeqNo = None
                PrimaryTerm = None
                Routing = None
                Source = None
            }

        [<CustomOperation("fields")>]
        member _.Fields(state: InlineGet, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Fields = Some value }

        [<CustomOperation("found")>]
        member _.Found(state: InlineGet, value: bool) =
            { state with Found = value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: InlineGet, value: CoreTypes.SequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: InlineGet, value: CoreTypes.Long) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: InlineGet, value: CoreTypes.Routing) =
            { state with Routing = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: InlineGet, value: 'tDocument) =
            { state with Source = Some value }

    let inlineGet = InlineGetBuilder()

    type KnnQueryBuilder() =
        member _.Yield(_: unit) : KnnQuery =
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
        member _.Field(state: KnnQuery, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: KnnQuery, value: CoreTypes.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: KnnQuery, value: CoreTypes.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("numCandidates")>]
        member _.NumCandidates(state: KnnQuery, value: CoreTypes.Integer) =
            { state with NumCandidates = Some value }

        [<CustomOperation("visitPercentage")>]
        member _.VisitPercentage(state: KnnQuery, value: CoreTypes.Float) =
            { state with VisitPercentage = Some value }

        [<CustomOperation("k")>]
        member _.K(state: KnnQuery, value: CoreTypes.Integer) =
            { state with K = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: KnnQuery, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: KnnQuery, value: CoreTypes.Float) =
            { state with Similarity = Some value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: KnnQuery, value: CoreTypes.RescoreVector) =
            { state with RescoreVector = Some value }

    let knnQuery = KnnQueryBuilder()

    type KnnRetrieverBuilder() =
        member _.Yield(_: unit) : KnnRetriever =
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
        member _.Field(state: KnnRetriever, value: string) =
            { state with Field = value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: KnnRetriever, value: CoreTypes.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: KnnRetriever, value: CoreTypes.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("k")>]
        member _.K(state: KnnRetriever, value: CoreTypes.Integer) =
            { state with K = value }

        [<CustomOperation("numCandidates")>]
        member _.NumCandidates(state: KnnRetriever, value: CoreTypes.Integer) =
            { state with NumCandidates = value }

        [<CustomOperation("visitPercentage")>]
        member _.VisitPercentage(state: KnnRetriever, value: CoreTypes.Float) =
            { state with VisitPercentage = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: KnnRetriever, value: CoreTypes.Float) =
            { state with Similarity = Some value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: KnnRetriever, value: CoreTypes.RescoreVector) =
            { state with RescoreVector = Some value }

    let knnRetriever = KnnRetrieverBuilder()

    type KnnSearchBuilder() =
        member _.Yield(_: unit) : KnnSearch =
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
        member _.Field(state: KnnSearch, value: CoreTypes.Field) =
            { state with Field = value }

        [<CustomOperation("queryVector")>]
        member _.QueryVector(state: KnnSearch, value: CoreTypes.QueryVector) =
            { state with QueryVector = Some value }

        [<CustomOperation("queryVectorBuilder")>]
        member _.QueryVectorBuilder(state: KnnSearch, value: CoreTypes.QueryVectorBuilder) =
            { state with QueryVectorBuilder = Some value }

        [<CustomOperation("k")>]
        member _.K(state: KnnSearch, value: CoreTypes.Integer) =
            { state with K = Some value }

        [<CustomOperation("numCandidates")>]
        member _.NumCandidates(state: KnnSearch, value: CoreTypes.Integer) =
            { state with NumCandidates = Some value }

        [<CustomOperation("visitPercentage")>]
        member _.VisitPercentage(state: KnnSearch, value: CoreTypes.Float) =
            { state with VisitPercentage = Some value }

        [<CustomOperation("boost")>]
        member _.Boost(state: KnnSearch, value: CoreTypes.Float) =
            { state with Boost = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: KnnSearch, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("similarity")>]
        member _.Similarity(state: KnnSearch, value: CoreTypes.Float) =
            { state with Similarity = Some value }

        [<CustomOperation("innerHits")>]
        member _.InnerHits(state: KnnSearch, value: GlobalSearchTypes.InnerHits) =
            { state with InnerHits = Some value }

        [<CustomOperation("rescoreVector")>]
        member _.RescoreVector(state: KnnSearch, value: CoreTypes.RescoreVector) =
            { state with RescoreVector = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: KnnSearch, value: string) =
            { state with Name = Some value }

    let knnSearch = KnnSearchBuilder()

    type LinearRetrieverBuilder() =
        member _.Yield(_: unit) : LinearRetriever =
            {
                Retrievers = None
                RankWindowSize = None
                Query = None
                Fields = None
                Normalizer = None
            }

        [<CustomOperation("retrievers")>]
        member _.Retrievers(state: LinearRetriever, value: CoreTypes.InnerRetriever list) =
            { state with Retrievers = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: LinearRetriever, value: CoreTypes.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: LinearRetriever, value: string) =
            { state with Query = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: LinearRetriever, value: string list) =
            { state with Fields = Some value }

        [<CustomOperation("normalizer")>]
        member _.Normalizer(state: LinearRetriever, value: CoreTypes.ScoreNormalizer) =
            { state with Normalizer = Some value }

    let linearRetriever = LinearRetrieverBuilder()

    type MergesStatsBuilder() =
        member _.Yield(_: unit) : MergesStats =
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
        member _.Current(state: MergesStats, value: CoreTypes.Long) =
            { state with Current = value }

        [<CustomOperation("currentDocs")>]
        member _.CurrentDocs(state: MergesStats, value: CoreTypes.Long) =
            { state with CurrentDocs = value }

        [<CustomOperation("currentSize")>]
        member _.CurrentSize(state: MergesStats, value: string) =
            { state with CurrentSize = Some value }

        [<CustomOperation("currentSizeInBytes")>]
        member _.CurrentSizeInBytes(state: MergesStats, value: CoreTypes.Long) =
            { state with CurrentSizeInBytes = value }

        [<CustomOperation("total")>]
        member _.Total(state: MergesStats, value: CoreTypes.Long) =
            { state with Total = value }

        [<CustomOperation("totalAutoThrottle")>]
        member _.TotalAutoThrottle(state: MergesStats, value: string) =
            { state with TotalAutoThrottle = Some value }

        [<CustomOperation("totalAutoThrottleInBytes")>]
        member _.TotalAutoThrottleInBytes(state: MergesStats, value: CoreTypes.Long) =
            { state with TotalAutoThrottleInBytes = value }

        [<CustomOperation("totalDocs")>]
        member _.TotalDocs(state: MergesStats, value: CoreTypes.Long) =
            { state with TotalDocs = value }

        [<CustomOperation("totalSize")>]
        member _.TotalSize(state: MergesStats, value: string) =
            { state with TotalSize = Some value }

        [<CustomOperation("totalSizeInBytes")>]
        member _.TotalSizeInBytes(state: MergesStats, value: CoreTypes.Long) =
            { state with TotalSizeInBytes = value }

        [<CustomOperation("totalStoppedTime")>]
        member _.TotalStoppedTime(state: MergesStats, value: CoreTypes.Duration) =
            { state with TotalStoppedTime = Some value }

        [<CustomOperation("totalStoppedTimeInMillis")>]
        member _.TotalStoppedTimeInMillis(state: MergesStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalStoppedTimeInMillis = value }

        [<CustomOperation("totalThrottledTime")>]
        member _.TotalThrottledTime(state: MergesStats, value: CoreTypes.Duration) =
            { state with TotalThrottledTime = Some value }

        [<CustomOperation("totalThrottledTimeInMillis")>]
        member _.TotalThrottledTimeInMillis(state: MergesStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalThrottledTimeInMillis = value }

        [<CustomOperation("totalTime")>]
        member _.TotalTime(state: MergesStats, value: CoreTypes.Duration) =
            { state with TotalTime = Some value }

        [<CustomOperation("totalTimeInMillis")>]
        member _.TotalTimeInMillis(state: MergesStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with TotalTimeInMillis = value }

    let mergesStats = MergesStatsBuilder()

    type NestedSortValueBuilder() =
        member _.Yield(_: unit) : NestedSortValue =
            {
                Filter = None
                MaxChildren = None
                Nested = None
                Path = Unchecked.defaultof<_>
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: NestedSortValue, value: CoreTypes.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("maxChildren")>]
        member _.MaxChildren(state: NestedSortValue, value: CoreTypes.Integer) =
            { state with MaxChildren = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: NestedSortValue, value: CoreTypes.NestedSortValue) =
            { state with Nested = Some value }

        [<CustomOperation("path")>]
        member _.Path(state: NestedSortValue, value: CoreTypes.Field) =
            { state with Path = value }

    let nestedSortValue = NestedSortValueBuilder()

    type NodeShardBuilder() =
        member _.Yield(_: unit) : NodeShard =
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
        member _.State(state: NodeShard, value: IndicesStats.ShardRoutingState) =
            { state with State = value }

        [<CustomOperation("primary")>]
        member _.Primary(state: NodeShard, value: bool) =
            { state with Primary = value }

        [<CustomOperation("node")>]
        member _.Node(state: NodeShard, value: CoreTypes.NodeName) =
            { state with Node = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: NodeShard, value: CoreTypes.Integer) =
            { state with Shard = value }

        [<CustomOperation("index")>]
        member _.Index(state: NodeShard, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("allocationId")>]
        member _.AllocationId(state: NodeShard, value: Map<string, CoreTypes.Id>) =
            { state with AllocationId = Some value }

        [<CustomOperation("recoverySource")>]
        member _.RecoverySource(state: NodeShard, value: Map<string, CoreTypes.Id>) =
            { state with RecoverySource = Some value }

        [<CustomOperation("unassignedInfo")>]
        member _.UnassignedInfo(state: NodeShard, value: ClusterAllocationExplain.UnassignedInformation) =
            { state with UnassignedInfo = Some value }

        [<CustomOperation("relocatingNode")>]
        member _.RelocatingNode(state: NodeShard, value: CoreTypes.NodeId option) =
            { state with RelocatingNode = Some value }

        [<CustomOperation("relocationFailureInfo")>]
        member _.RelocationFailureInfo(state: NodeShard, value: CoreTypes.RelocationFailureInfo) =
            { state with RelocationFailureInfo = Some value }

    let nodeShard = NodeShardBuilder()

    type PinnedRetrieverBuilder() =
        member _.Yield(_: unit) : PinnedRetriever =
            {
                Retriever = Unchecked.defaultof<_>
                Ids = None
                Docs = None
                RankWindowSize = None
            }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: PinnedRetriever, value: CoreTypes.RetrieverContainer) =
            { state with Retriever = value }

        [<CustomOperation("ids")>]
        member _.Ids(state: PinnedRetriever, value: string list) =
            { state with Ids = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: PinnedRetriever, value: CoreTypes.SpecifiedDocument list) =
            { state with Docs = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: PinnedRetriever, value: CoreTypes.Integer) =
            { state with RankWindowSize = Some value }

    let pinnedRetriever = PinnedRetrieverBuilder()

    module QueryVectorBuilder =

        let textEmbedding (value: CoreTypes.TextEmbedding) =
            QueryVectorBuilder.TextEmbedding value

        let lookup (value: CoreTypes.LookupQueryVectorBuilder) =
            QueryVectorBuilder.Lookup value

    type RRFRetrieverBuilder() =
        member _.Yield(_: unit) : RRFRetriever =
            {
                Retrievers = Unchecked.defaultof<_>
                RankConstant = None
                RankWindowSize = None
                Query = None
                Fields = None
            }

        [<CustomOperation("retrievers")>]
        member _.Retrievers(state: RRFRetriever, value: CoreTypes.RRFRetrieverEntry list) =
            { state with Retrievers = value }

        [<CustomOperation("rankConstant")>]
        member _.RankConstant(state: RRFRetriever, value: CoreTypes.Integer) =
            { state with RankConstant = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: RRFRetriever, value: CoreTypes.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("query")>]
        member _.Query(state: RRFRetriever, value: string) =
            { state with Query = Some value }

        [<CustomOperation("fields")>]
        member _.Fields(state: RRFRetriever, value: string list) =
            { state with Fields = Some value }

    let rRFRetriever = RRFRetrieverBuilder()

    module Rank =

        let rrf (value: CoreTypes.RrfRank) =
            RankContainer.Rrf value

    type ReindexStatusBuilder() =
        member _.Yield(_: unit) : ReindexStatus =
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
        member _.SliceId(state: ReindexStatus, value: CoreTypes.Integer) =
            { state with SliceId = Some value }

        [<CustomOperation("batches")>]
        member _.Batches(state: ReindexStatus, value: CoreTypes.Long) =
            { state with Batches = value }

        [<CustomOperation("created")>]
        member _.Created(state: ReindexStatus, value: CoreTypes.Long) =
            { state with Created = Some value }

        [<CustomOperation("deleted")>]
        member _.Deleted(state: ReindexStatus, value: CoreTypes.Long) =
            { state with Deleted = value }

        [<CustomOperation("noops")>]
        member _.Noops(state: ReindexStatus, value: CoreTypes.Long) =
            { state with Noops = value }

        [<CustomOperation("requestsPerSecond")>]
        member _.RequestsPerSecond(state: ReindexStatus, value: CoreTypes.Float) =
            { state with RequestsPerSecond = value }

        [<CustomOperation("retries")>]
        member _.Retries(state: ReindexStatus, value: CoreTypes.Retries) =
            { state with Retries = value }

        [<CustomOperation("throttled")>]
        member _.Throttled(state: ReindexStatus, value: CoreTypes.Duration) =
            { state with Throttled = Some value }

        [<CustomOperation("throttledMillis")>]
        member _.ThrottledMillis(state: ReindexStatus, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ThrottledMillis = value }

        [<CustomOperation("throttledUntil")>]
        member _.ThrottledUntil(state: ReindexStatus, value: CoreTypes.Duration) =
            { state with ThrottledUntil = Some value }

        [<CustomOperation("throttledUntilMillis")>]
        member _.ThrottledUntilMillis(state: ReindexStatus, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ThrottledUntilMillis = value }

        [<CustomOperation("total")>]
        member _.Total(state: ReindexStatus, value: CoreTypes.Long) =
            { state with Total = value }

        [<CustomOperation("updated")>]
        member _.Updated(state: ReindexStatus, value: CoreTypes.Long) =
            { state with Updated = Some value }

        [<CustomOperation("versionConflicts")>]
        member _.VersionConflicts(state: ReindexStatus, value: CoreTypes.Long) =
            { state with VersionConflicts = value }

        [<CustomOperation("cancelled")>]
        member _.Cancelled(state: ReindexStatus, value: string) =
            { state with Cancelled = Some value }

    let reindexStatus = ReindexStatusBuilder()

    type RetrieverBaseBuilder() =
        member _.Yield(_: unit) : RetrieverBase =
            {
                Filter = None
                MinScore = None
                Name = None
            }

        [<CustomOperation("filter")>]
        member _.Filter(state: RetrieverBase, value: System.Text.Json.JsonElement) =
            { state with Filter = Some value }

        [<CustomOperation("minScore")>]
        member _.MinScore(state: RetrieverBase, value: CoreTypes.Float) =
            { state with MinScore = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: RetrieverBase, value: string) =
            { state with Name = Some value }

    let retrieverBase = RetrieverBaseBuilder()

    module Retriever =

        let standard (value: CoreTypes.StandardRetriever) =
            RetrieverContainer.Standard value

        let knn (value: CoreTypes.KnnRetriever) =
            RetrieverContainer.Knn value

        let rrf (value: CoreTypes.RRFRetriever) =
            RetrieverContainer.Rrf value

        let textSimilarityReranker (value: CoreTypes.TextSimilarityReranker) =
            RetrieverContainer.TextSimilarityReranker value

        let rule (value: CoreTypes.RuleRetriever) =
            RetrieverContainer.Rule value

        let rescorer (value: CoreTypes.RescorerRetriever) =
            RetrieverContainer.Rescorer value

        let linear (value: CoreTypes.LinearRetriever) =
            RetrieverContainer.Linear value

        let pinned (value: CoreTypes.PinnedRetriever) =
            RetrieverContainer.Pinned value

        let diversify (value: CoreTypes.DiversifyRetriever) =
            RetrieverContainer.Diversify value

    type RrfRankBuilder() =
        member _.Yield(_: unit) : RrfRank =
            {
                RankConstant = None
                RankWindowSize = None
            }

        [<CustomOperation("rankConstant")>]
        member _.RankConstant(state: RrfRank, value: CoreTypes.Long) =
            { state with RankConstant = Some value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: RrfRank, value: CoreTypes.Long) =
            { state with RankWindowSize = Some value }

    let rrfRank = RrfRankBuilder()

    type ScriptBuilder() =
        member _.Yield(_: unit) : Script =
            {
                Source = None
                Id = None
                Params = None
                Lang = None
                Options = None
            }

        [<CustomOperation("source")>]
        member _.Source(state: Script, value: CoreTypes.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Script, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Script, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("lang")>]
        member _.Lang(state: Script, value: CoreTypes.ScriptLanguage) =
            { state with Lang = Some value }

        [<CustomOperation("options")>]
        member _.Options(state: Script, value: Map<string, string>) =
            { state with Options = Some value }

    let script = ScriptBuilder()

    let ofSource (value: CoreTypes.ScriptSource) : Script =
        {
            Source = value
            Id = None
            Params = None
            Lang = None
            Options = None
        }

    type ScriptSortBuilder() =
        member _.Yield(_: unit) : ScriptSort =
            {
                Order = None
                Script = Unchecked.defaultof<_>
                Type = None
                Mode = None
                Nested = None
            }

        [<CustomOperation("order")>]
        member _.Order(state: ScriptSort, value: CoreTypes.SortOrder) =
            { state with Order = Some value }

        [<CustomOperation("script")>]
        member _.Script(state: ScriptSort, value: CoreTypes.Script) =
            { state with Script = value }

        [<CustomOperation("type'")>]
        member _.Type(state: ScriptSort, value: CoreTypes.ScriptSortType) =
            { state with Type = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: ScriptSort, value: CoreTypes.SortMode) =
            { state with Mode = Some value }

        [<CustomOperation("nested")>]
        member _.Nested(state: ScriptSort, value: CoreTypes.NestedSortValue) =
            { state with Nested = Some value }

    let scriptSort = ScriptSortBuilder()

    type ScriptTransformBuilder() =
        member _.Yield(_: unit) : ScriptTransform =
            {
                Lang = None
                Params = None
                Source = None
                Id = None
            }

        [<CustomOperation("lang")>]
        member _.Lang(state: ScriptTransform, value: string) =
            { state with Lang = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: ScriptTransform, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: ScriptTransform, value: CoreTypes.ScriptSource) =
            { state with Source = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: ScriptTransform, value: string) =
            { state with Id = Some value }

    let scriptTransform = ScriptTransformBuilder()

    type SearchStatsBuilder() =
        member _.Yield(_: unit) : SearchStats =
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
        member _.FetchCurrent(state: SearchStats, value: CoreTypes.Long) =
            { state with FetchCurrent = value }

        [<CustomOperation("fetchTime")>]
        member _.FetchTime(state: SearchStats, value: CoreTypes.Duration) =
            { state with FetchTime = Some value }

        [<CustomOperation("fetchTimeInMillis")>]
        member _.FetchTimeInMillis(state: SearchStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with FetchTimeInMillis = value }

        [<CustomOperation("fetchTotal")>]
        member _.FetchTotal(state: SearchStats, value: CoreTypes.Long) =
            { state with FetchTotal = value }

        [<CustomOperation("openContexts")>]
        member _.OpenContexts(state: SearchStats, value: CoreTypes.Long) =
            { state with OpenContexts = Some value }

        [<CustomOperation("queryCurrent")>]
        member _.QueryCurrent(state: SearchStats, value: CoreTypes.Long) =
            { state with QueryCurrent = value }

        [<CustomOperation("queryTime")>]
        member _.QueryTime(state: SearchStats, value: CoreTypes.Duration) =
            { state with QueryTime = Some value }

        [<CustomOperation("queryTimeInMillis")>]
        member _.QueryTimeInMillis(state: SearchStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with QueryTimeInMillis = value }

        [<CustomOperation("queryTotal")>]
        member _.QueryTotal(state: SearchStats, value: CoreTypes.Long) =
            { state with QueryTotal = value }

        [<CustomOperation("scrollCurrent")>]
        member _.ScrollCurrent(state: SearchStats, value: CoreTypes.Long) =
            { state with ScrollCurrent = value }

        [<CustomOperation("scrollTime")>]
        member _.ScrollTime(state: SearchStats, value: CoreTypes.Duration) =
            { state with ScrollTime = Some value }

        [<CustomOperation("scrollTimeInMillis")>]
        member _.ScrollTimeInMillis(state: SearchStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with ScrollTimeInMillis = value }

        [<CustomOperation("scrollTotal")>]
        member _.ScrollTotal(state: SearchStats, value: CoreTypes.Long) =
            { state with ScrollTotal = value }

        [<CustomOperation("suggestCurrent")>]
        member _.SuggestCurrent(state: SearchStats, value: CoreTypes.Long) =
            { state with SuggestCurrent = value }

        [<CustomOperation("suggestTime")>]
        member _.SuggestTime(state: SearchStats, value: CoreTypes.Duration) =
            { state with SuggestTime = Some value }

        [<CustomOperation("suggestTimeInMillis")>]
        member _.SuggestTimeInMillis(state: SearchStats, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with SuggestTimeInMillis = value }

        [<CustomOperation("suggestTotal")>]
        member _.SuggestTotal(state: SearchStats, value: CoreTypes.Long) =
            { state with SuggestTotal = value }

        [<CustomOperation("recentSearchLoad")>]
        member _.RecentSearchLoad(state: SearchStats, value: CoreTypes.Double) =
            { state with RecentSearchLoad = Some value }

        [<CustomOperation("groups")>]
        member _.Groups(state: SearchStats, value: Map<string, CoreTypes.SearchStats>) =
            { state with Groups = Some value }

    let searchStats = SearchStatsBuilder()

    type SegmentsStatsBuilder() =
        member _.Yield(_: unit) : SegmentsStats =
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
        member _.Count(state: SegmentsStats, value: CoreTypes.Integer) =
            { state with Count = value }

        [<CustomOperation("docValuesMemory")>]
        member _.DocValuesMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with DocValuesMemory = Some value }

        [<CustomOperation("docValuesMemoryInBytes")>]
        member _.DocValuesMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with DocValuesMemoryInBytes = value }

        [<CustomOperation("fileSizes")>]
        member _.FileSizes(state: SegmentsStats, value: Map<string, IndicesStats.ShardFileSizeInfo>) =
            { state with FileSizes = value }

        [<CustomOperation("fixedBitSet")>]
        member _.FixedBitSet(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with FixedBitSet = Some value }

        [<CustomOperation("fixedBitSetMemoryInBytes")>]
        member _.FixedBitSetMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with FixedBitSetMemoryInBytes = value }

        [<CustomOperation("indexWriterMemory")>]
        member _.IndexWriterMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with IndexWriterMemory = Some value }

        [<CustomOperation("indexWriterMemoryInBytes")>]
        member _.IndexWriterMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with IndexWriterMemoryInBytes = value }

        [<CustomOperation("maxUnsafeAutoIdTimestamp")>]
        member _.MaxUnsafeAutoIdTimestamp(state: SegmentsStats, value: CoreTypes.Long) =
            { state with MaxUnsafeAutoIdTimestamp = value }

        [<CustomOperation("memory")>]
        member _.Memory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with Memory = Some value }

        [<CustomOperation("memoryInBytes")>]
        member _.MemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with MemoryInBytes = value }

        [<CustomOperation("normsMemory")>]
        member _.NormsMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with NormsMemory = Some value }

        [<CustomOperation("normsMemoryInBytes")>]
        member _.NormsMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with NormsMemoryInBytes = value }

        [<CustomOperation("pointsMemory")>]
        member _.PointsMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with PointsMemory = Some value }

        [<CustomOperation("pointsMemoryInBytes")>]
        member _.PointsMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with PointsMemoryInBytes = value }

        [<CustomOperation("storedFieldsMemoryInBytes")>]
        member _.StoredFieldsMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with StoredFieldsMemoryInBytes = value }

        [<CustomOperation("storedFieldsMemory")>]
        member _.StoredFieldsMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with StoredFieldsMemory = Some value }

        [<CustomOperation("termsMemoryInBytes")>]
        member _.TermsMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with TermsMemoryInBytes = value }

        [<CustomOperation("termsMemory")>]
        member _.TermsMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with TermsMemory = Some value }

        [<CustomOperation("termVectorsMemory")>]
        member _.TermVectorsMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with TermVectorsMemory = Some value }

        [<CustomOperation("termVectorsMemoryInBytes")>]
        member _.TermVectorsMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with TermVectorsMemoryInBytes = value }

        [<CustomOperation("versionMapMemory")>]
        member _.VersionMapMemory(state: SegmentsStats, value: CoreTypes.ByteSize) =
            { state with VersionMapMemory = Some value }

        [<CustomOperation("versionMapMemoryInBytes")>]
        member _.VersionMapMemoryInBytes(state: SegmentsStats, value: CoreTypes.Long) =
            { state with VersionMapMemoryInBytes = value }

    let segmentsStats = SegmentsStatsBuilder()

    type ShardFailureBuilder() =
        member _.Yield(_: unit) : ShardFailure =
            {
                Index = None
                Node = None
                Reason = Unchecked.defaultof<_>
                Shard = None
                Status = None
                Primary = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: ShardFailure, value: CoreTypes.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: ShardFailure, value: string) =
            { state with Node = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: ShardFailure, value: CoreTypes.ErrorCause) =
            { state with Reason = value }

        [<CustomOperation("shard")>]
        member _.Shard(state: ShardFailure, value: CoreTypes.Integer) =
            { state with Shard = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: ShardFailure, value: string) =
            { state with Status = Some value }

        [<CustomOperation("primary")>]
        member _.Primary(state: ShardFailure, value: bool) =
            { state with Primary = Some value }

    let shardFailure = ShardFailureBuilder()

    type ShardStatisticsBuilder() =
        member _.Yield(_: unit) : ShardStatistics =
            {
                Failed = Unchecked.defaultof<_>
                Successful = Unchecked.defaultof<_>
                Total = Unchecked.defaultof<_>
                Failures = None
                Skipped = None
            }

        [<CustomOperation("failed")>]
        member _.Failed(state: ShardStatistics, value: CoreTypes.Uint) =
            { state with Failed = value }

        [<CustomOperation("successful")>]
        member _.Successful(state: ShardStatistics, value: CoreTypes.Uint) =
            { state with Successful = value }

        [<CustomOperation("total")>]
        member _.Total(state: ShardStatistics, value: CoreTypes.Uint) =
            { state with Total = value }

        [<CustomOperation("failures")>]
        member _.Failures(state: ShardStatistics, value: CoreTypes.ShardFailure list) =
            { state with Failures = Some value }

        [<CustomOperation("skipped")>]
        member _.Skipped(state: ShardStatistics, value: CoreTypes.Uint) =
            { state with Skipped = Some value }

    let shardStatistics = ShardStatisticsBuilder()

    module SortOptions =

        let score (value: CoreTypes.ScoreSort) =
            SortOptions.Score value

        let doc (value: CoreTypes.ScoreSort) =
            SortOptions.Doc value

        let geoDistance (value: CoreTypes.GeoDistanceSort) =
            SortOptions.GeoDistance value

        let script (value: CoreTypes.ScriptSort) =
            SortOptions.Script value

    type StandardRetrieverBuilder() =
        member _.Yield(_: unit) : StandardRetriever =
            {
                Query = None
                SearchAfter = None
                TerminateAfter = None
                Sort = None
                Collapse = None
            }

        [<CustomOperation("query")>]
        member _.Query(state: StandardRetriever, value: CoreTypes.QueryContainer) =
            { state with Query = Some value }

        [<CustomOperation("searchAfter")>]
        member _.SearchAfter(state: StandardRetriever, value: CoreTypes.SortResults) =
            { state with SearchAfter = Some value }

        [<CustomOperation("terminateAfter")>]
        member _.TerminateAfter(state: StandardRetriever, value: CoreTypes.Integer) =
            { state with TerminateAfter = Some value }

        [<CustomOperation("sort")>]
        member _.Sort(state: StandardRetriever, value: CoreTypes.Sort) =
            { state with Sort = Some value }

        [<CustomOperation("collapse")>]
        member _.Collapse(state: StandardRetriever, value: GlobalSearchTypes.FieldCollapse) =
            { state with Collapse = Some value }

    let standardRetriever = StandardRetrieverBuilder()

    type StoreStatsBuilder() =
        member _.Yield(_: unit) : StoreStats =
            {
                Size = None
                SizeInBytes = Unchecked.defaultof<_>
                Reserved = None
                ReservedInBytes = Unchecked.defaultof<_>
                TotalDataSetSize = None
                TotalDataSetSizeInBytes = None
            }

        [<CustomOperation("size")>]
        member _.Size(state: StoreStats, value: CoreTypes.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: StoreStats, value: CoreTypes.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("reserved")>]
        member _.Reserved(state: StoreStats, value: CoreTypes.ByteSize) =
            { state with Reserved = Some value }

        [<CustomOperation("reservedInBytes")>]
        member _.ReservedInBytes(state: StoreStats, value: CoreTypes.Long) =
            { state with ReservedInBytes = value }

        [<CustomOperation("totalDataSetSize")>]
        member _.TotalDataSetSize(state: StoreStats, value: CoreTypes.ByteSize) =
            { state with TotalDataSetSize = Some value }

        [<CustomOperation("totalDataSetSizeInBytes")>]
        member _.TotalDataSetSizeInBytes(state: StoreStats, value: CoreTypes.Long) =
            { state with TotalDataSetSizeInBytes = Some value }

    let storeStats = StoreStatsBuilder()

    type TextSimilarityRerankerBuilder() =
        member _.Yield(_: unit) : TextSimilarityReranker =
            {
                Retriever = Unchecked.defaultof<_>
                RankWindowSize = None
                InferenceId = None
                InferenceText = Unchecked.defaultof<_>
                Field = Unchecked.defaultof<_>
                ChunkRescorer = None
            }

        [<CustomOperation("retriever")>]
        member _.Retriever(state: TextSimilarityReranker, value: CoreTypes.RetrieverContainer) =
            { state with Retriever = value }

        [<CustomOperation("rankWindowSize")>]
        member _.RankWindowSize(state: TextSimilarityReranker, value: CoreTypes.Integer) =
            { state with RankWindowSize = Some value }

        [<CustomOperation("inferenceId")>]
        member _.InferenceId(state: TextSimilarityReranker, value: string) =
            { state with InferenceId = Some value }

        [<CustomOperation("inferenceText")>]
        member _.InferenceText(state: TextSimilarityReranker, value: string) =
            { state with InferenceText = value }

        [<CustomOperation("field")>]
        member _.Field(state: TextSimilarityReranker, value: string) =
            { state with Field = value }

        [<CustomOperation("chunkRescorer")>]
        member _.ChunkRescorer(state: TextSimilarityReranker, value: CoreTypes.ChunkRescorer) =
            { state with ChunkRescorer = Some value }

    let textSimilarityReranker = TextSimilarityRerankerBuilder()

    type TokenPruningConfigBuilder() =
        member _.Yield(_: unit) : TokenPruningConfig =
            {
                TokensFreqRatioThreshold = None
                TokensWeightThreshold = None
                OnlyScorePrunedTokens = None
            }

        [<CustomOperation("tokensFreqRatioThreshold")>]
        member _.TokensFreqRatioThreshold(state: TokenPruningConfig, value: CoreTypes.Integer) =
            { state with TokensFreqRatioThreshold = Some value }

        [<CustomOperation("tokensWeightThreshold")>]
        member _.TokensWeightThreshold(state: TokenPruningConfig, value: CoreTypes.Float) =
            { state with TokensWeightThreshold = Some value }

        [<CustomOperation("onlyScorePrunedTokens")>]
        member _.OnlyScorePrunedTokens(state: TokenPruningConfig, value: bool) =
            { state with OnlyScorePrunedTokens = Some value }

    let tokenPruningConfig = TokenPruningConfigBuilder()

    module Transform =

        let chain (value: CoreTypes.TransformContainer list) =
            TransformContainer.Chain value

        let script (value: CoreTypes.ScriptTransform) =
            TransformContainer.Script value

        let search (value: CoreTypes.SearchTransform) =
            TransformContainer.Search value

    type TranslogStatsBuilder() =
        member _.Yield(_: unit) : TranslogStats =
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
        member _.EarliestLastModifiedAge(state: TranslogStats, value: CoreTypes.Long) =
            { state with EarliestLastModifiedAge = value }

        [<CustomOperation("operations")>]
        member _.Operations(state: TranslogStats, value: CoreTypes.Long) =
            { state with Operations = value }

        [<CustomOperation("size")>]
        member _.Size(state: TranslogStats, value: string) =
            { state with Size = Some value }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: TranslogStats, value: CoreTypes.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("uncommittedOperations")>]
        member _.UncommittedOperations(state: TranslogStats, value: CoreTypes.Integer) =
            { state with UncommittedOperations = value }

        [<CustomOperation("uncommittedSize")>]
        member _.UncommittedSize(state: TranslogStats, value: string) =
            { state with UncommittedSize = Some value }

        [<CustomOperation("uncommittedSizeInBytes")>]
        member _.UncommittedSizeInBytes(state: TranslogStats, value: CoreTypes.Long) =
            { state with UncommittedSizeInBytes = value }

    let translogStats = TranslogStatsBuilder()

    type WriteResponseBaseBuilder() =
        member _.Yield(_: unit) : WriteResponseBase =
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
        member _.Id(state: WriteResponseBase, value: CoreTypes.Id) =
            { state with Id = value }

        [<CustomOperation("index")>]
        member _.Index(state: WriteResponseBase, value: CoreTypes.IndexName) =
            { state with Index = value }

        [<CustomOperation("primaryTerm")>]
        member _.PrimaryTerm(state: WriteResponseBase, value: CoreTypes.Long) =
            { state with PrimaryTerm = Some value }

        [<CustomOperation("result")>]
        member _.Result(state: WriteResponseBase, value: CoreTypes.Result) =
            { state with Result = value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: WriteResponseBase, value: CoreTypes.SequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: WriteResponseBase, value: CoreTypes.ShardStatistics) =
            { state with Shards = value }

        [<CustomOperation("version")>]
        member _.Version(state: WriteResponseBase, value: CoreTypes.VersionNumber) =
            { state with Version = value }

        [<CustomOperation("failureStore")>]
        member _.FailureStore(state: WriteResponseBase, value: GlobalBulk.FailureStoreStatus) =
            { state with FailureStore = Some value }

        [<CustomOperation("forcedRefresh")>]
        member _.ForcedRefresh(state: WriteResponseBase, value: bool) =
            { state with ForcedRefresh = Some value }

    let writeResponseBase = WriteResponseBaseBuilder()


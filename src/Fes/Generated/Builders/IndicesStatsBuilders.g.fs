// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesStatsBuilders =

    type IndexStatsBuilder() =
        member _.Yield(_: unit) : IndexStats =
            {
                Completion = None
                Docs = None
                Fielddata = None
                Flush = None
                Get = None
                Indexing = None
                Indices = None
                Merges = None
                QueryCache = None
                Recovery = None
                Refresh = None
                RequestCache = None
                Search = None
                Segments = None
                Store = None
                Translog = None
                Warmer = None
                Bulk = None
                ShardStats = None
            }

        [<CustomOperation("completion")>]
        member _.Completion(state: IndexStats, value: CoreTypes.CompletionStats) =
            { state with Completion = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: IndexStats, value: CoreTypes.DocStats) =
            { state with Docs = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: IndexStats, value: CoreTypes.FielddataStats) =
            { state with Fielddata = Some value }

        [<CustomOperation("flush")>]
        member _.Flush(state: IndexStats, value: CoreTypes.FlushStats) =
            { state with Flush = Some value }

        [<CustomOperation("get")>]
        member _.Get(state: IndexStats, value: CoreTypes.GetStats) =
            { state with Get = Some value }

        [<CustomOperation("indexing")>]
        member _.Indexing(state: IndexStats, value: CoreTypes.IndexingStats) =
            { state with Indexing = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: IndexStats, value: IndicesStats.IndicesStats) =
            { state with Indices = Some value }

        [<CustomOperation("merges")>]
        member _.Merges(state: IndexStats, value: CoreTypes.MergesStats) =
            { state with Merges = Some value }

        [<CustomOperation("queryCache")>]
        member _.QueryCache(state: IndexStats, value: CoreTypes.QueryCacheStats) =
            { state with QueryCache = Some value }

        [<CustomOperation("recovery")>]
        member _.Recovery(state: IndexStats, value: CoreTypes.RecoveryStats) =
            { state with Recovery = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: IndexStats, value: CoreTypes.RefreshStats) =
            { state with Refresh = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: IndexStats, value: CoreTypes.RequestCacheStats) =
            { state with RequestCache = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: IndexStats, value: CoreTypes.SearchStats) =
            { state with Search = Some value }

        [<CustomOperation("segments")>]
        member _.Segments(state: IndexStats, value: CoreTypes.SegmentsStats) =
            { state with Segments = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: IndexStats, value: CoreTypes.StoreStats) =
            { state with Store = Some value }

        [<CustomOperation("translog")>]
        member _.Translog(state: IndexStats, value: CoreTypes.TranslogStats) =
            { state with Translog = Some value }

        [<CustomOperation("warmer")>]
        member _.Warmer(state: IndexStats, value: CoreTypes.WarmerStats) =
            { state with Warmer = Some value }

        [<CustomOperation("bulk")>]
        member _.Bulk(state: IndexStats, value: CoreTypes.BulkStats) =
            { state with Bulk = Some value }

        [<CustomOperation("shardStats")>]
        member _.ShardStats(state: IndexStats, value: IndicesStats.ShardsTotalStats) =
            { state with ShardStats = Some value }

    let indexStats = IndexStatsBuilder()

    type IndicesStatsBuilder() =
        member _.Yield(_: unit) : IndicesStats =
            {
                Primaries = None
                Shards = None
                Total = None
                Uuid = None
                Health = None
                Status = None
            }

        [<CustomOperation("primaries")>]
        member _.Primaries(state: IndicesStats, value: IndicesStats.IndexStats) =
            { state with Primaries = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: IndicesStats, value: Map<string, IndicesStats.ShardStats list>) =
            { state with Shards = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: IndicesStats, value: IndicesStats.IndexStats) =
            { state with Total = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: IndicesStats, value: CoreTypes.Uuid) =
            { state with Uuid = Some value }

        [<CustomOperation("health")>]
        member _.Health(state: IndicesStats, value: CoreTypes.HealthStatus) =
            { state with Health = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: IndicesStats, value: IndicesStats.IndexMetadataState) =
            { state with Status = Some value }

    let indicesStats = IndicesStatsBuilder()

    type ShardFileSizeInfoBuilder() =
        member _.Yield(_: unit) : ShardFileSizeInfo =
            {
                Description = Unchecked.defaultof<_>
                SizeInBytes = Unchecked.defaultof<_>
                MinSizeInBytes = None
                MaxSizeInBytes = None
                AverageSizeInBytes = None
                Count = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: ShardFileSizeInfo, value: string) =
            { state with Description = value }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: ShardFileSizeInfo, value: CoreTypes.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("minSizeInBytes")>]
        member _.MinSizeInBytes(state: ShardFileSizeInfo, value: CoreTypes.Long) =
            { state with MinSizeInBytes = Some value }

        [<CustomOperation("maxSizeInBytes")>]
        member _.MaxSizeInBytes(state: ShardFileSizeInfo, value: CoreTypes.Long) =
            { state with MaxSizeInBytes = Some value }

        [<CustomOperation("averageSizeInBytes")>]
        member _.AverageSizeInBytes(state: ShardFileSizeInfo, value: CoreTypes.Long) =
            { state with AverageSizeInBytes = Some value }

        [<CustomOperation("count")>]
        member _.Count(state: ShardFileSizeInfo, value: CoreTypes.Long) =
            { state with Count = Some value }

    let shardFileSizeInfo = ShardFileSizeInfoBuilder()

    type ShardStatsBuilder() =
        member _.Yield(_: unit) : ShardStats =
            {
                Commit = None
                Completion = None
                Docs = None
                Fielddata = None
                Flush = None
                Get = None
                Indexing = None
                Mappings = None
                Merges = None
                ShardPath = None
                QueryCache = None
                Recovery = None
                Refresh = None
                RequestCache = None
                RetentionLeases = None
                Routing = None
                Search = None
                Segments = None
                SeqNo = None
                Store = None
                Translog = None
                Warmer = None
                Bulk = None
                Shards = None
                ShardStats = None
                Indices = None
            }

        [<CustomOperation("commit")>]
        member _.Commit(state: ShardStats, value: IndicesStats.ShardCommit) =
            { state with Commit = Some value }

        [<CustomOperation("completion")>]
        member _.Completion(state: ShardStats, value: CoreTypes.CompletionStats) =
            { state with Completion = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: ShardStats, value: CoreTypes.DocStats) =
            { state with Docs = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: ShardStats, value: CoreTypes.FielddataStats) =
            { state with Fielddata = Some value }

        [<CustomOperation("flush")>]
        member _.Flush(state: ShardStats, value: CoreTypes.FlushStats) =
            { state with Flush = Some value }

        [<CustomOperation("get")>]
        member _.Get(state: ShardStats, value: CoreTypes.GetStats) =
            { state with Get = Some value }

        [<CustomOperation("indexing")>]
        member _.Indexing(state: ShardStats, value: CoreTypes.IndexingStats) =
            { state with Indexing = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: ShardStats, value: IndicesStats.MappingStats) =
            { state with Mappings = Some value }

        [<CustomOperation("merges")>]
        member _.Merges(state: ShardStats, value: CoreTypes.MergesStats) =
            { state with Merges = Some value }

        [<CustomOperation("shardPath")>]
        member _.ShardPath(state: ShardStats, value: IndicesStats.ShardPath) =
            { state with ShardPath = Some value }

        [<CustomOperation("queryCache")>]
        member _.QueryCache(state: ShardStats, value: IndicesStats.ShardQueryCache) =
            { state with QueryCache = Some value }

        [<CustomOperation("recovery")>]
        member _.Recovery(state: ShardStats, value: CoreTypes.RecoveryStats) =
            { state with Recovery = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: ShardStats, value: CoreTypes.RefreshStats) =
            { state with Refresh = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: ShardStats, value: CoreTypes.RequestCacheStats) =
            { state with RequestCache = Some value }

        [<CustomOperation("retentionLeases")>]
        member _.RetentionLeases(state: ShardStats, value: IndicesStats.ShardRetentionLeases) =
            { state with RetentionLeases = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: ShardStats, value: IndicesStats.ShardRouting) =
            { state with Routing = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: ShardStats, value: CoreTypes.SearchStats) =
            { state with Search = Some value }

        [<CustomOperation("segments")>]
        member _.Segments(state: ShardStats, value: CoreTypes.SegmentsStats) =
            { state with Segments = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: ShardStats, value: IndicesStats.ShardSequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: ShardStats, value: CoreTypes.StoreStats) =
            { state with Store = Some value }

        [<CustomOperation("translog")>]
        member _.Translog(state: ShardStats, value: CoreTypes.TranslogStats) =
            { state with Translog = Some value }

        [<CustomOperation("warmer")>]
        member _.Warmer(state: ShardStats, value: CoreTypes.WarmerStats) =
            { state with Warmer = Some value }

        [<CustomOperation("bulk")>]
        member _.Bulk(state: ShardStats, value: CoreTypes.BulkStats) =
            { state with Bulk = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: ShardStats, value: Map<CoreTypes.IndexName, System.Text.Json.JsonElement>) =
            { state with Shards = Some value }

        [<CustomOperation("shardStats")>]
        member _.ShardStats(state: ShardStats, value: IndicesStats.ShardsTotalStats) =
            { state with ShardStats = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: ShardStats, value: IndicesStats.IndicesStats) =
            { state with Indices = Some value }

    let shardStats = ShardStatsBuilder()


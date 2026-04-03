// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesStatsBuilders =

    type IndexStatsBuilder() =
        member _.Yield(_: unit) : Types.IndexStats =
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
        member _.Completion(state: Types.IndexStats, value: Types.CompletionStats) =
            { state with Completion = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: Types.IndexStats, value: Types.DocStats) =
            { state with Docs = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: Types.IndexStats, value: Types.FielddataStats) =
            { state with Fielddata = Some value }

        [<CustomOperation("flush")>]
        member _.Flush(state: Types.IndexStats, value: Types.FlushStats) =
            { state with Flush = Some value }

        [<CustomOperation("get")>]
        member _.Get(state: Types.IndexStats, value: Types.GetStats) =
            { state with Get = Some value }

        [<CustomOperation("indexing")>]
        member _.Indexing(state: Types.IndexStats, value: Types.IndexingStats) =
            { state with Indexing = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.IndexStats, value: Types.IndicesStats) =
            { state with Indices = Some value }

        [<CustomOperation("merges")>]
        member _.Merges(state: Types.IndexStats, value: Types.MergesStats) =
            { state with Merges = Some value }

        [<CustomOperation("queryCache")>]
        member _.QueryCache(state: Types.IndexStats, value: Types.QueryCacheStats) =
            { state with QueryCache = Some value }

        [<CustomOperation("recovery")>]
        member _.Recovery(state: Types.IndexStats, value: Types.RecoveryStats) =
            { state with Recovery = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: Types.IndexStats, value: Types.RefreshStats) =
            { state with Refresh = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: Types.IndexStats, value: Types.RequestCacheStats) =
            { state with RequestCache = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: Types.IndexStats, value: Types.SearchStats) =
            { state with Search = Some value }

        [<CustomOperation("segments")>]
        member _.Segments(state: Types.IndexStats, value: Types.SegmentsStats) =
            { state with Segments = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IndexStats, value: Types.StoreStats) =
            { state with Store = Some value }

        [<CustomOperation("translog")>]
        member _.Translog(state: Types.IndexStats, value: Types.TranslogStats) =
            { state with Translog = Some value }

        [<CustomOperation("warmer")>]
        member _.Warmer(state: Types.IndexStats, value: Types.WarmerStats) =
            { state with Warmer = Some value }

        [<CustomOperation("bulk")>]
        member _.Bulk(state: Types.IndexStats, value: Types.BulkStats) =
            { state with Bulk = Some value }

        [<CustomOperation("shardStats")>]
        member _.ShardStats(state: Types.IndexStats, value: Types.ShardsTotalStats) =
            { state with ShardStats = Some value }

    let indexStats = IndexStatsBuilder()

    type IndicesStatsBuilder() =
        member _.Yield(_: unit) : Types.IndicesStats =
            {
                Primaries = None
                Shards = None
                Total = None
                Uuid = None
                Health = None
                Status = None
            }

        [<CustomOperation("primaries")>]
        member _.Primaries(state: Types.IndicesStats, value: Types.IndexStats) =
            { state with Primaries = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.IndicesStats, value: Map<string, Types.IndicesStatsShardStats list>) =
            { state with Shards = Some value }

        [<CustomOperation("total")>]
        member _.Total(state: Types.IndicesStats, value: Types.IndexStats) =
            { state with Total = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: Types.IndicesStats, value: Types.Uuid) =
            { state with Uuid = Some value }

        [<CustomOperation("health")>]
        member _.Health(state: Types.IndicesStats, value: Types.HealthStatus) =
            { state with Health = Some value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.IndicesStats, value: Types.IndexMetadataState) =
            { state with Status = Some value }

    let indicesStats = IndicesStatsBuilder()

    type ShardFileSizeInfoBuilder() =
        member _.Yield(_: unit) : Types.ShardFileSizeInfo =
            {
                Description = Unchecked.defaultof<_>
                SizeInBytes = Unchecked.defaultof<_>
                MinSizeInBytes = None
                MaxSizeInBytes = None
                AverageSizeInBytes = None
                Count = None
            }

        [<CustomOperation("description")>]
        member _.Description(state: Types.ShardFileSizeInfo, value: string) =
            { state with Description = value }

        [<CustomOperation("sizeInBytes")>]
        member _.SizeInBytes(state: Types.ShardFileSizeInfo, value: Types.Long) =
            { state with SizeInBytes = value }

        [<CustomOperation("minSizeInBytes")>]
        member _.MinSizeInBytes(state: Types.ShardFileSizeInfo, value: Types.Long) =
            { state with MinSizeInBytes = Some value }

        [<CustomOperation("maxSizeInBytes")>]
        member _.MaxSizeInBytes(state: Types.ShardFileSizeInfo, value: Types.Long) =
            { state with MaxSizeInBytes = Some value }

        [<CustomOperation("averageSizeInBytes")>]
        member _.AverageSizeInBytes(state: Types.ShardFileSizeInfo, value: Types.Long) =
            { state with AverageSizeInBytes = Some value }

        [<CustomOperation("count")>]
        member _.Count(state: Types.ShardFileSizeInfo, value: Types.Long) =
            { state with Count = Some value }

    let shardFileSizeInfo = ShardFileSizeInfoBuilder()

    type IndicesStatsShardStatsBuilder() =
        member _.Yield(_: unit) : Types.IndicesStatsShardStats =
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
        member _.Commit(state: Types.IndicesStatsShardStats, value: Types.ShardCommit) =
            { state with Commit = Some value }

        [<CustomOperation("completion")>]
        member _.Completion(state: Types.IndicesStatsShardStats, value: Types.CompletionStats) =
            { state with Completion = Some value }

        [<CustomOperation("docs")>]
        member _.Docs(state: Types.IndicesStatsShardStats, value: Types.DocStats) =
            { state with Docs = Some value }

        [<CustomOperation("fielddata")>]
        member _.Fielddata(state: Types.IndicesStatsShardStats, value: Types.FielddataStats) =
            { state with Fielddata = Some value }

        [<CustomOperation("flush")>]
        member _.Flush(state: Types.IndicesStatsShardStats, value: Types.FlushStats) =
            { state with Flush = Some value }

        [<CustomOperation("get")>]
        member _.Get(state: Types.IndicesStatsShardStats, value: Types.GetStats) =
            { state with Get = Some value }

        [<CustomOperation("indexing")>]
        member _.Indexing(state: Types.IndicesStatsShardStats, value: Types.IndexingStats) =
            { state with Indexing = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.IndicesStatsShardStats, value: Types.MappingStats) =
            { state with Mappings = Some value }

        [<CustomOperation("merges")>]
        member _.Merges(state: Types.IndicesStatsShardStats, value: Types.MergesStats) =
            { state with Merges = Some value }

        [<CustomOperation("shardPath")>]
        member _.ShardPath(state: Types.IndicesStatsShardStats, value: Types.ShardPath) =
            { state with ShardPath = Some value }

        [<CustomOperation("queryCache")>]
        member _.QueryCache(state: Types.IndicesStatsShardStats, value: Types.ShardQueryCache) =
            { state with QueryCache = Some value }

        [<CustomOperation("recovery")>]
        member _.Recovery(state: Types.IndicesStatsShardStats, value: Types.RecoveryStats) =
            { state with Recovery = Some value }

        [<CustomOperation("refresh")>]
        member _.Refresh(state: Types.IndicesStatsShardStats, value: Types.RefreshStats) =
            { state with Refresh = Some value }

        [<CustomOperation("requestCache")>]
        member _.RequestCache(state: Types.IndicesStatsShardStats, value: Types.RequestCacheStats) =
            { state with RequestCache = Some value }

        [<CustomOperation("retentionLeases")>]
        member _.RetentionLeases(state: Types.IndicesStatsShardStats, value: Types.ShardRetentionLeases) =
            { state with RetentionLeases = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.IndicesStatsShardStats, value: Types.ShardRouting) =
            { state with Routing = Some value }

        [<CustomOperation("search")>]
        member _.Search(state: Types.IndicesStatsShardStats, value: Types.SearchStats) =
            { state with Search = Some value }

        [<CustomOperation("segments")>]
        member _.Segments(state: Types.IndicesStatsShardStats, value: Types.SegmentsStats) =
            { state with Segments = Some value }

        [<CustomOperation("seqNo")>]
        member _.SeqNo(state: Types.IndicesStatsShardStats, value: Types.ShardSequenceNumber) =
            { state with SeqNo = Some value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.IndicesStatsShardStats, value: Types.StoreStats) =
            { state with Store = Some value }

        [<CustomOperation("translog")>]
        member _.Translog(state: Types.IndicesStatsShardStats, value: Types.TranslogStats) =
            { state with Translog = Some value }

        [<CustomOperation("warmer")>]
        member _.Warmer(state: Types.IndicesStatsShardStats, value: Types.WarmerStats) =
            { state with Warmer = Some value }

        [<CustomOperation("bulk")>]
        member _.Bulk(state: Types.IndicesStatsShardStats, value: Types.BulkStats) =
            { state with Bulk = Some value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.IndicesStatsShardStats, value: Map<Types.IndexName, System.Text.Json.JsonElement>) =
            { state with Shards = Some value }

        [<CustomOperation("shardStats")>]
        member _.ShardStats(state: Types.IndicesStatsShardStats, value: Types.ShardsTotalStats) =
            { state with ShardStats = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.IndicesStatsShardStats, value: Types.IndicesStats) =
            { state with Indices = Some value }

    let indicesStatsShardStats = IndicesStatsShardStatsBuilder()


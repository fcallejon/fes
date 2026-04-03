// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesStats =

    [<RequireQualifiedAccess>]
    type IndexMetadataState =
        | Open
        | Close

    type ShardCommit = {
        [<System.Text.Json.Serialization.JsonPropertyName("generation")>]
        Generation: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("num_docs")>]
        NumDocs: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("user_data")>]
        UserData: Map<string, string>
    }

    type MappingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_estimated_overhead")>]
        TotalEstimatedOverhead: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_estimated_overhead_in_bytes")>]
        TotalEstimatedOverheadInBytes: Types.Long
    }

    type ShardPath = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_path")>]
        DataPath: string
        [<System.Text.Json.Serialization.JsonPropertyName("is_custom_data_path")>]
        IsCustomDataPath: bool
        [<System.Text.Json.Serialization.JsonPropertyName("state_path")>]
        StatePath: string
    }

    type ShardQueryCache = {
        [<System.Text.Json.Serialization.JsonPropertyName("cache_count")>]
        CacheCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("hit_count")>]
        HitCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("miss_count")>]
        MissCount: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: Types.Long
    }

    type ShardLease = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("retaining_seq_no")>]
        RetainingSeqNo: Types.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: string
    }

    type ShardRetentionLeases = {
        [<System.Text.Json.Serialization.JsonPropertyName("primary_term")>]
        PrimaryTerm: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("leases")>]
        Leases: IndicesStats.ShardLease list
    }

    [<RequireQualifiedAccess>]
    type ShardRoutingState =
        | UNASSIGNED
        | INITIALIZING
        | STARTED
        | RELOCATING

    type ShardRouting = {
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: string
        [<System.Text.Json.Serialization.JsonPropertyName("primary")>]
        Primary: bool
        [<System.Text.Json.Serialization.JsonPropertyName("relocating_node")>]
        RelocatingNode: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: IndicesStats.ShardRoutingState
    }

    type ShardSequenceNumber = {
        [<System.Text.Json.Serialization.JsonPropertyName("global_checkpoint")>]
        GlobalCheckpoint: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("local_checkpoint")>]
        LocalCheckpoint: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_seq_no")>]
        MaxSeqNo: Types.SequenceNumber
    }

    type ShardsTotalStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: Types.Long
    }

    type IndexStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("completion")>]
        Completion: Types.CompletionStats option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Types.DocStats option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: Types.FielddataStats option
        [<System.Text.Json.Serialization.JsonPropertyName("flush")>]
        Flush: Types.FlushStats option
        [<System.Text.Json.Serialization.JsonPropertyName("get")>]
        Get: Types.GetStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing")>]
        Indexing: Types.IndexingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesStats.IndicesStats option
        [<System.Text.Json.Serialization.JsonPropertyName("merges")>]
        Merges: Types.MergesStats option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache")>]
        QueryCache: Types.QueryCacheStats option
        [<System.Text.Json.Serialization.JsonPropertyName("recovery")>]
        Recovery: Types.RecoveryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh")>]
        Refresh: Types.RefreshStats option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache")>]
        RequestCache: Types.RequestCacheStats option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: Types.SearchStats option
        [<System.Text.Json.Serialization.JsonPropertyName("segments")>]
        Segments: Types.SegmentsStats option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: Types.StoreStats option
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: Types.TranslogStats option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer")>]
        Warmer: Types.WarmerStats option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk")>]
        Bulk: Types.BulkStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_stats")>]
        ShardStats: IndicesStats.ShardsTotalStats option
    }

    and IndicesStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("primaries")>]
        Primaries: IndicesStats.IndexStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, IndicesStats.ShardStats list> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: IndicesStats.IndexStats option
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: Types.Uuid option
        [<System.Text.Json.Serialization.JsonPropertyName("health")>]
        Health: Types.HealthStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: IndicesStats.IndexMetadataState option
    }

    and ShardStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("commit")>]
        Commit: IndicesStats.ShardCommit option
        [<System.Text.Json.Serialization.JsonPropertyName("completion")>]
        Completion: Types.CompletionStats option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: Types.DocStats option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: Types.FielddataStats option
        [<System.Text.Json.Serialization.JsonPropertyName("flush")>]
        Flush: Types.FlushStats option
        [<System.Text.Json.Serialization.JsonPropertyName("get")>]
        Get: Types.GetStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing")>]
        Indexing: Types.IndexingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: IndicesStats.MappingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("merges")>]
        Merges: Types.MergesStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_path")>]
        ShardPath: IndicesStats.ShardPath option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache")>]
        QueryCache: IndicesStats.ShardQueryCache option
        [<System.Text.Json.Serialization.JsonPropertyName("recovery")>]
        Recovery: Types.RecoveryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh")>]
        Refresh: Types.RefreshStats option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache")>]
        RequestCache: Types.RequestCacheStats option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_leases")>]
        RetentionLeases: IndicesStats.ShardRetentionLeases option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: IndicesStats.ShardRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: Types.SearchStats option
        [<System.Text.Json.Serialization.JsonPropertyName("segments")>]
        Segments: Types.SegmentsStats option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no")>]
        SeqNo: IndicesStats.ShardSequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: Types.StoreStats option
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: Types.TranslogStats option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer")>]
        Warmer: Types.WarmerStats option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk")>]
        Bulk: Types.BulkStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<Types.IndexName, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_stats")>]
        ShardStats: IndicesStats.ShardsTotalStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesStats.IndicesStats option
    }

    type ShardFileSizeInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min_size_in_bytes")>]
        MinSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size_in_bytes")>]
        MaxSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("average_size_in_bytes")>]
        AverageSizeInBytes: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long option
    }


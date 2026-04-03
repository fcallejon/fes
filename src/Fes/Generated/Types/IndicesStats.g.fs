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
        Generation: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("num_docs")>]
        NumDocs: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("user_data")>]
        UserData: Map<string, string>
    }

    type MappingStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_estimated_overhead")>]
        TotalEstimatedOverhead: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("total_estimated_overhead_in_bytes")>]
        TotalEstimatedOverheadInBytes: CoreTypes.Long
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
        CacheCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("cache_size")>]
        CacheSize: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("evictions")>]
        Evictions: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("hit_count")>]
        HitCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("memory_size_in_bytes")>]
        MemorySizeInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("miss_count")>]
        MissCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: CoreTypes.Long
    }

    type ShardLease = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("retaining_seq_no")>]
        RetainingSeqNo: CoreTypes.SequenceNumber
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp")>]
        Timestamp: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: string
    }

    type ShardRetentionLeases = {
        [<System.Text.Json.Serialization.JsonPropertyName("primary_term")>]
        PrimaryTerm: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("leases")>]
        Leases: ShardLease list
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
        State: ShardRoutingState
    }

    type ShardSequenceNumber = {
        [<System.Text.Json.Serialization.JsonPropertyName("global_checkpoint")>]
        GlobalCheckpoint: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("local_checkpoint")>]
        LocalCheckpoint: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("max_seq_no")>]
        MaxSeqNo: CoreTypes.SequenceNumber
    }

    type ShardsTotalStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_count")>]
        TotalCount: CoreTypes.Long
    }

    type IndexStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("completion")>]
        Completion: CoreTypes.CompletionStats option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: CoreTypes.DocStats option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: CoreTypes.FielddataStats option
        [<System.Text.Json.Serialization.JsonPropertyName("flush")>]
        Flush: CoreTypes.FlushStats option
        [<System.Text.Json.Serialization.JsonPropertyName("get")>]
        Get: CoreTypes.GetStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing")>]
        Indexing: CoreTypes.IndexingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesStats option
        [<System.Text.Json.Serialization.JsonPropertyName("merges")>]
        Merges: CoreTypes.MergesStats option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache")>]
        QueryCache: CoreTypes.QueryCacheStats option
        [<System.Text.Json.Serialization.JsonPropertyName("recovery")>]
        Recovery: CoreTypes.RecoveryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh")>]
        Refresh: CoreTypes.RefreshStats option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache")>]
        RequestCache: CoreTypes.RequestCacheStats option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: CoreTypes.SearchStats option
        [<System.Text.Json.Serialization.JsonPropertyName("segments")>]
        Segments: CoreTypes.SegmentsStats option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: CoreTypes.StoreStats option
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: CoreTypes.TranslogStats option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer")>]
        Warmer: CoreTypes.WarmerStats option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk")>]
        Bulk: CoreTypes.BulkStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_stats")>]
        ShardStats: ShardsTotalStats option
    }

    and IndicesStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("primaries")>]
        Primaries: IndexStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<string, ShardStats list> option
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: IndexStats option
        [<System.Text.Json.Serialization.JsonPropertyName("uuid")>]
        Uuid: CoreTypes.Uuid option
        [<System.Text.Json.Serialization.JsonPropertyName("health")>]
        Health: CoreTypes.HealthStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: IndexMetadataState option
    }

    and ShardStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("commit")>]
        Commit: ShardCommit option
        [<System.Text.Json.Serialization.JsonPropertyName("completion")>]
        Completion: CoreTypes.CompletionStats option
        [<System.Text.Json.Serialization.JsonPropertyName("docs")>]
        Docs: CoreTypes.DocStats option
        [<System.Text.Json.Serialization.JsonPropertyName("fielddata")>]
        Fielddata: CoreTypes.FielddataStats option
        [<System.Text.Json.Serialization.JsonPropertyName("flush")>]
        Flush: CoreTypes.FlushStats option
        [<System.Text.Json.Serialization.JsonPropertyName("get")>]
        Get: CoreTypes.GetStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indexing")>]
        Indexing: CoreTypes.IndexingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("mappings")>]
        Mappings: MappingStats option
        [<System.Text.Json.Serialization.JsonPropertyName("merges")>]
        Merges: CoreTypes.MergesStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_path")>]
        ShardPath: ShardPath option
        [<System.Text.Json.Serialization.JsonPropertyName("query_cache")>]
        QueryCache: ShardQueryCache option
        [<System.Text.Json.Serialization.JsonPropertyName("recovery")>]
        Recovery: CoreTypes.RecoveryStats option
        [<System.Text.Json.Serialization.JsonPropertyName("refresh")>]
        Refresh: CoreTypes.RefreshStats option
        [<System.Text.Json.Serialization.JsonPropertyName("request_cache")>]
        RequestCache: CoreTypes.RequestCacheStats option
        [<System.Text.Json.Serialization.JsonPropertyName("retention_leases")>]
        RetentionLeases: ShardRetentionLeases option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: ShardRouting option
        [<System.Text.Json.Serialization.JsonPropertyName("search")>]
        Search: CoreTypes.SearchStats option
        [<System.Text.Json.Serialization.JsonPropertyName("segments")>]
        Segments: CoreTypes.SegmentsStats option
        [<System.Text.Json.Serialization.JsonPropertyName("seq_no")>]
        SeqNo: ShardSequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: CoreTypes.StoreStats option
        [<System.Text.Json.Serialization.JsonPropertyName("translog")>]
        Translog: CoreTypes.TranslogStats option
        [<System.Text.Json.Serialization.JsonPropertyName("warmer")>]
        Warmer: CoreTypes.WarmerStats option
        [<System.Text.Json.Serialization.JsonPropertyName("bulk")>]
        Bulk: CoreTypes.BulkStats option
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: Map<CoreTypes.IndexName, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_stats")>]
        ShardStats: ShardsTotalStats option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: IndicesStats option
    }

    type ShardFileSizeInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("size_in_bytes")>]
        SizeInBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("min_size_in_bytes")>]
        MinSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_size_in_bytes")>]
        MaxSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("average_size_in_bytes")>]
        AverageSizeInBytes: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long option
    }


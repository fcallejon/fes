// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IlmTypes =

    type AllocateAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_replicas")>]
        NumberOfReplicas: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_shards_per_node")>]
        TotalShardsPerNode: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("include")>]
        Include: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("exclude")>]
        Exclude: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("require")>]
        Require: Map<string, string> option
    }

    type DeleteAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("delete_searchable_snapshot")>]
        DeleteSearchableSnapshot: bool option
    }

    type DownsampleAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("fixed_interval")>]
        FixedInterval: CoreTypes.DurationLarge
        [<System.Text.Json.Serialization.JsonPropertyName("wait_timeout")>]
        WaitTimeout: CoreTypes.Duration option
    }

    type ForceMergeAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_segments")>]
        MaxNumSegments: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_codec")>]
        IndexCodec: string option
    }

    type MigrateAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

    type RolloverAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_size")>]
        MaxSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        MaxDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_docs")>]
        MaxPrimaryShardDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size")>]
        MinSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size")>]
        MinPrimaryShardSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("min_docs")>]
        MinDocs: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_docs")>]
        MinPrimaryShardDocs: CoreTypes.Long option
    }

    type SetPriorityAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: CoreTypes.Integer option
    }

    type SearchableSnapshotAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_repository")>]
        SnapshotRepository: string
        [<System.Text.Json.Serialization.JsonPropertyName("force_merge_index")>]
        ForceMergeIndex: bool option
    }

    type ShrinkAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_shards")>]
        NumberOfShards: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_write_after_shrink")>]
        AllowWriteAfterShrink: bool option
    }

    type WaitForSnapshotAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: string
    }

    type Actions = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocate")>]
        Allocate: AllocateAction option
        [<System.Text.Json.Serialization.JsonPropertyName("delete")>]
        Delete: DeleteAction option
        [<System.Text.Json.Serialization.JsonPropertyName("downsample")>]
        Downsample: DownsampleAction option
        [<System.Text.Json.Serialization.JsonPropertyName("freeze")>]
        Freeze: CoreTypes.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("forcemerge")>]
        Forcemerge: ForceMergeAction option
        [<System.Text.Json.Serialization.JsonPropertyName("migrate")>]
        Migrate: MigrateAction option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: CoreTypes.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("rollover")>]
        Rollover: RolloverAction option
        [<System.Text.Json.Serialization.JsonPropertyName("set_priority")>]
        SetPriority: SetPriorityAction option
        [<System.Text.Json.Serialization.JsonPropertyName("searchable_snapshot")>]
        SearchableSnapshot: SearchableSnapshotAction option
        [<System.Text.Json.Serialization.JsonPropertyName("shrink")>]
        Shrink: ShrinkAction option
        [<System.Text.Json.Serialization.JsonPropertyName("unfollow")>]
        Unfollow: CoreTypes.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("wait_for_snapshot")>]
        WaitForSnapshot: WaitForSnapshotAction option
    }

    type Phase = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: Actions option
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: CoreTypes.Duration option
    }

    type Phases = {
        [<System.Text.Json.Serialization.JsonPropertyName("cold")>]
        Cold: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("delete")>]
        Delete: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen")>]
        Frozen: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("hot")>]
        Hot: Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("warm")>]
        Warm: Phase option
    }

    type Policy = {
        [<System.Text.Json.Serialization.JsonPropertyName("phases")>]
        Phases: Phases
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: CoreTypes.Metadata option
    }


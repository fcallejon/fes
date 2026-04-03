// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IlmTypes =

    type AllocateAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_replicas")>]
        NumberOfReplicas: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("total_shards_per_node")>]
        TotalShardsPerNode: Types.Integer option
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
        FixedInterval: Types.DurationLarge
        [<System.Text.Json.Serialization.JsonPropertyName("wait_timeout")>]
        WaitTimeout: Types.Duration option
    }

    type ForceMergeAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_segments")>]
        MaxNumSegments: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("index_codec")>]
        IndexCodec: string option
    }

    type MigrateAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("enabled")>]
        Enabled: bool option
    }

    type RolloverAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_size")>]
        MaxSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("max_age")>]
        MaxAge: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("max_docs")>]
        MaxDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_docs")>]
        MaxPrimaryShardDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_size")>]
        MinSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_size")>]
        MinPrimaryShardSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("min_docs")>]
        MinDocs: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("min_primary_shard_docs")>]
        MinPrimaryShardDocs: Types.Long option
    }

    type SetPriorityAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("priority")>]
        Priority: Types.Integer option
    }

    type SearchableSnapshotAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_repository")>]
        SnapshotRepository: string
        [<System.Text.Json.Serialization.JsonPropertyName("force_merge_index")>]
        ForceMergeIndex: bool option
    }

    type ShrinkAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_shards")>]
        NumberOfShards: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("max_primary_shard_size")>]
        MaxPrimaryShardSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("allow_write_after_shrink")>]
        AllowWriteAfterShrink: bool option
    }

    type WaitForSnapshotAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("policy")>]
        Policy: string
    }

    type Actions = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocate")>]
        Allocate: IlmTypes.AllocateAction option
        [<System.Text.Json.Serialization.JsonPropertyName("delete")>]
        Delete: IlmTypes.DeleteAction option
        [<System.Text.Json.Serialization.JsonPropertyName("downsample")>]
        Downsample: IlmTypes.DownsampleAction option
        [<System.Text.Json.Serialization.JsonPropertyName("freeze")>]
        Freeze: Types.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("forcemerge")>]
        Forcemerge: IlmTypes.ForceMergeAction option
        [<System.Text.Json.Serialization.JsonPropertyName("migrate")>]
        Migrate: IlmTypes.MigrateAction option
        [<System.Text.Json.Serialization.JsonPropertyName("readonly")>]
        Readonly: Types.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("rollover")>]
        Rollover: IlmTypes.RolloverAction option
        [<System.Text.Json.Serialization.JsonPropertyName("set_priority")>]
        SetPriority: IlmTypes.SetPriorityAction option
        [<System.Text.Json.Serialization.JsonPropertyName("searchable_snapshot")>]
        SearchableSnapshot: IlmTypes.SearchableSnapshotAction option
        [<System.Text.Json.Serialization.JsonPropertyName("shrink")>]
        Shrink: IlmTypes.ShrinkAction option
        [<System.Text.Json.Serialization.JsonPropertyName("unfollow")>]
        Unfollow: Types.EmptyObject option
        [<System.Text.Json.Serialization.JsonPropertyName("wait_for_snapshot")>]
        WaitForSnapshot: IlmTypes.WaitForSnapshotAction option
    }

    type Phase = {
        [<System.Text.Json.Serialization.JsonPropertyName("actions")>]
        Actions: IlmTypes.Actions option
        [<System.Text.Json.Serialization.JsonPropertyName("min_age")>]
        MinAge: Types.Duration option
    }

    type Phases = {
        [<System.Text.Json.Serialization.JsonPropertyName("cold")>]
        Cold: IlmTypes.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("delete")>]
        Delete: IlmTypes.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("frozen")>]
        Frozen: IlmTypes.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("hot")>]
        Hot: IlmTypes.Phase option
        [<System.Text.Json.Serialization.JsonPropertyName("warm")>]
        Warm: IlmTypes.Phase option
    }

    type Policy = {
        [<System.Text.Json.Serialization.JsonPropertyName("phases")>]
        Phases: IlmTypes.Phases
        [<System.Text.Json.Serialization.JsonPropertyName("_meta")>]
        Meta: Types.Metadata option
    }


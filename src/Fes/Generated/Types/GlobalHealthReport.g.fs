// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalHealthReport =

    [<RequireQualifiedAccess>]
    type IndicatorHealthStatus =
        | Green
        | Yellow
        | Red
        | Unknown
        | Unavailable

    [<RequireQualifiedAccess>]
    type ImpactArea =
        | Search
        | Ingest
        | Backup
        | DeploymentManagement

    type Impact = {
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("impact_areas")>]
        ImpactAreas: ImpactArea list
        [<System.Text.Json.Serialization.JsonPropertyName("severity")>]
        Severity: CoreTypes.Integer
    }

    type IndicatorNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: string option
    }

    type DiagnosisAffectedResources = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: IndicatorNode list option
        [<System.Text.Json.Serialization.JsonPropertyName("slm_policies")>]
        SlmPolicies: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_states")>]
        FeatureStates: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("snapshot_repositories")>]
        SnapshotRepositories: string list option
    }

    type Diagnosis = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string
        [<System.Text.Json.Serialization.JsonPropertyName("action")>]
        Action: string
        [<System.Text.Json.Serialization.JsonPropertyName("affected_resources")>]
        AffectedResources: DiagnosisAffectedResources
        [<System.Text.Json.Serialization.JsonPropertyName("cause")>]
        Cause: string
        [<System.Text.Json.Serialization.JsonPropertyName("help_url")>]
        HelpUrl: string
    }

    type BaseIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: IndicatorHealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("symptom")>]
        Symptom: string
        [<System.Text.Json.Serialization.JsonPropertyName("impacts")>]
        Impacts: Impact list option
        [<System.Text.Json.Serialization.JsonPropertyName("diagnosis")>]
        Diagnosis: Diagnosis list option
    }

    type StagnatingBackingIndices = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("first_occurrence_timestamp")>]
        FirstOccurrenceTimestamp: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("retry_count")>]
        RetryCount: CoreTypes.Integer
    }

    type DataStreamLifecycleDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("stagnating_backing_indices_count")>]
        StagnatingBackingIndicesCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_backing_indices_in_error")>]
        TotalBackingIndicesInError: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("stagnating_backing_indices")>]
        StagnatingBackingIndices: StagnatingBackingIndices list option
    }

    /// DATA_STREAM_LIFECYCLE
    type DataStreamLifecycleIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: DataStreamLifecycleDetails option
    }

    type DiskIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_with_readonly_block")>]
        IndicesWithReadonlyBlock: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_with_enough_disk_space")>]
        NodesWithEnoughDiskSpace: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_over_high_watermark")>]
        NodesOverHighWatermark: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_over_flood_stage_watermark")>]
        NodesOverFloodStageWatermark: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_with_unknown_disk_status")>]
        NodesWithUnknownDiskStatus: CoreTypes.Long
    }

    /// DISK
    type DiskIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: DiskIndicatorDetails option
    }

    type FileSettingsIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("failure_streak")>]
        FailureStreak: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("most_recent_failure")>]
        MostRecentFailure: string
    }

    /// FILE_SETTINGS
    type FileSettingsIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: FileSettingsIndicatorDetails option
    }

    type IlmIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("ilm_status")>]
        IlmStatus: CoreTypes.LifecycleOperationMode
        [<System.Text.Json.Serialization.JsonPropertyName("policies")>]
        Policies: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("stagnating_indices")>]
        StagnatingIndices: CoreTypes.Integer
    }

    /// ILM
    type IlmIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: IlmIndicatorDetails option
    }

    type MasterIsStableIndicatorExceptionFetchingHistory = {
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: string
        [<System.Text.Json.Serialization.JsonPropertyName("stack_trace")>]
        StackTrace: string
    }

    type MasterIsStableIndicatorClusterFormationNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: string
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_formation_message")>]
        ClusterFormationMessage: string
    }

    type MasterIsStableIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("current_master")>]
        CurrentMaster: IndicatorNode
        [<System.Text.Json.Serialization.JsonPropertyName("recent_masters")>]
        RecentMasters: IndicatorNode list
        [<System.Text.Json.Serialization.JsonPropertyName("exception_fetching_history")>]
        ExceptionFetchingHistory: MasterIsStableIndicatorExceptionFetchingHistory option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_formation")>]
        ClusterFormation: MasterIsStableIndicatorClusterFormationNode list option
    }

    /// MASTER_IS_STABLE
    type MasterIsStableIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: MasterIsStableIndicatorDetails option
    }

    type ShardsAvailabilityIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("creating_primaries")>]
        CreatingPrimaries: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("creating_replicas")>]
        CreatingReplicas: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_primaries")>]
        InitializingPrimaries: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_replicas")>]
        InitializingReplicas: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("restarting_primaries")>]
        RestartingPrimaries: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("restarting_replicas")>]
        RestartingReplicas: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("started_primaries")>]
        StartedPrimaries: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("started_replicas")>]
        StartedReplicas: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primaries")>]
        UnassignedPrimaries: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_replicas")>]
        UnassignedReplicas: CoreTypes.Long
    }

    /// SHARDS_AVAILABILITY
    type ShardsAvailabilityIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: ShardsAvailabilityIndicatorDetails option
    }

    type RepositoryIntegrityIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_repositories")>]
        TotalRepositories: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("corrupted_repositories")>]
        CorruptedRepositories: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("corrupted")>]
        Corrupted: string list option
    }

    /// REPOSITORY_INTEGRITY
    type RepositoryIntegrityIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: RepositoryIntegrityIndicatorDetails option
    }

    type SlmIndicatorUnhealthyPolicies = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("invocations_since_last_success")>]
        InvocationsSinceLastSuccess: Map<string, CoreTypes.Long> option
    }

    type SlmIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("slm_status")>]
        SlmStatus: CoreTypes.LifecycleOperationMode
        [<System.Text.Json.Serialization.JsonPropertyName("policies")>]
        Policies: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("unhealthy_policies")>]
        UnhealthyPolicies: SlmIndicatorUnhealthyPolicies option
    }

    /// SLM
    type SlmIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: SlmIndicatorDetails option
    }

    type ShardsCapacityIndicatorTierDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_shards_in_cluster")>]
        MaxShardsInCluster: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("current_used_shards")>]
        CurrentUsedShards: CoreTypes.Integer option
    }

    type ShardsCapacityIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: ShardsCapacityIndicatorTierDetail
        [<System.Text.Json.Serialization.JsonPropertyName("frozen")>]
        Frozen: ShardsCapacityIndicatorTierDetail
    }

    /// SHARDS_CAPACITY
    type ShardsCapacityIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: ShardsCapacityIndicatorDetails option
    }

    type Indicators = {
        [<System.Text.Json.Serialization.JsonPropertyName("master_is_stable")>]
        MasterIsStable: MasterIsStableIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("shards_availability")>]
        ShardsAvailability: ShardsAvailabilityIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("disk")>]
        Disk: DiskIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("repository_integrity")>]
        RepositoryIntegrity: RepositoryIntegrityIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_lifecycle")>]
        DataStreamLifecycle: DataStreamLifecycleIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("ilm")>]
        Ilm: IlmIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("slm")>]
        Slm: SlmIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("shards_capacity")>]
        ShardsCapacity: ShardsCapacityIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("file_settings")>]
        FileSettings: FileSettingsIndicator option
    }


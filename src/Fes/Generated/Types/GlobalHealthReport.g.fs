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
        ImpactAreas: GlobalHealthReport.ImpactArea list
        [<System.Text.Json.Serialization.JsonPropertyName("severity")>]
        Severity: Types.Integer
    }

    type IndicatorNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: string option
    }

    type DiagnosisAffectedResources = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: GlobalHealthReport.IndicatorNode list option
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
        AffectedResources: GlobalHealthReport.DiagnosisAffectedResources
        [<System.Text.Json.Serialization.JsonPropertyName("cause")>]
        Cause: string
        [<System.Text.Json.Serialization.JsonPropertyName("help_url")>]
        HelpUrl: string
    }

    type BaseIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: GlobalHealthReport.IndicatorHealthStatus
        [<System.Text.Json.Serialization.JsonPropertyName("symptom")>]
        Symptom: string
        [<System.Text.Json.Serialization.JsonPropertyName("impacts")>]
        Impacts: GlobalHealthReport.Impact list option
        [<System.Text.Json.Serialization.JsonPropertyName("diagnosis")>]
        Diagnosis: GlobalHealthReport.Diagnosis list option
    }

    type StagnatingBackingIndices = {
        [<System.Text.Json.Serialization.JsonPropertyName("index_name")>]
        IndexName: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("first_occurrence_timestamp")>]
        FirstOccurrenceTimestamp: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("retry_count")>]
        RetryCount: Types.Integer
    }

    type DataStreamLifecycleDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("stagnating_backing_indices_count")>]
        StagnatingBackingIndicesCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_backing_indices_in_error")>]
        TotalBackingIndicesInError: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("stagnating_backing_indices")>]
        StagnatingBackingIndices: GlobalHealthReport.StagnatingBackingIndices list option
    }

    /// DATA_STREAM_LIFECYCLE
    type DataStreamLifecycleIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.DataStreamLifecycleDetails option
    }

    type DiskIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices_with_readonly_block")>]
        IndicesWithReadonlyBlock: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_with_enough_disk_space")>]
        NodesWithEnoughDiskSpace: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_over_high_watermark")>]
        NodesOverHighWatermark: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_over_flood_stage_watermark")>]
        NodesOverFloodStageWatermark: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("nodes_with_unknown_disk_status")>]
        NodesWithUnknownDiskStatus: Types.Long
    }

    /// DISK
    type DiskIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.DiskIndicatorDetails option
    }

    type FileSettingsIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("failure_streak")>]
        FailureStreak: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("most_recent_failure")>]
        MostRecentFailure: string
    }

    /// FILE_SETTINGS
    type FileSettingsIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.FileSettingsIndicatorDetails option
    }

    type IlmIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("ilm_status")>]
        IlmStatus: Types.LifecycleOperationMode
        [<System.Text.Json.Serialization.JsonPropertyName("policies")>]
        Policies: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("stagnating_indices")>]
        StagnatingIndices: Types.Integer
    }

    /// ILM
    type IlmIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.IlmIndicatorDetails option
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
        CurrentMaster: GlobalHealthReport.IndicatorNode
        [<System.Text.Json.Serialization.JsonPropertyName("recent_masters")>]
        RecentMasters: GlobalHealthReport.IndicatorNode list
        [<System.Text.Json.Serialization.JsonPropertyName("exception_fetching_history")>]
        ExceptionFetchingHistory: GlobalHealthReport.MasterIsStableIndicatorExceptionFetchingHistory option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_formation")>]
        ClusterFormation: GlobalHealthReport.MasterIsStableIndicatorClusterFormationNode list option
    }

    /// MASTER_IS_STABLE
    type MasterIsStableIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.MasterIsStableIndicatorDetails option
    }

    type ShardsAvailabilityIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("creating_primaries")>]
        CreatingPrimaries: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("creating_replicas")>]
        CreatingReplicas: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_primaries")>]
        InitializingPrimaries: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("initializing_replicas")>]
        InitializingReplicas: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("restarting_primaries")>]
        RestartingPrimaries: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("restarting_replicas")>]
        RestartingReplicas: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("started_primaries")>]
        StartedPrimaries: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("started_replicas")>]
        StartedReplicas: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_primaries")>]
        UnassignedPrimaries: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("unassigned_replicas")>]
        UnassignedReplicas: Types.Long
    }

    /// SHARDS_AVAILABILITY
    type ShardsAvailabilityIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.ShardsAvailabilityIndicatorDetails option
    }

    type RepositoryIntegrityIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("total_repositories")>]
        TotalRepositories: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("corrupted_repositories")>]
        CorruptedRepositories: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("corrupted")>]
        Corrupted: string list option
    }

    /// REPOSITORY_INTEGRITY
    type RepositoryIntegrityIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.RepositoryIntegrityIndicatorDetails option
    }

    type SlmIndicatorUnhealthyPolicies = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("invocations_since_last_success")>]
        InvocationsSinceLastSuccess: Map<string, Types.Long> option
    }

    type SlmIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("slm_status")>]
        SlmStatus: Types.LifecycleOperationMode
        [<System.Text.Json.Serialization.JsonPropertyName("policies")>]
        Policies: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("unhealthy_policies")>]
        UnhealthyPolicies: GlobalHealthReport.SlmIndicatorUnhealthyPolicies option
    }

    /// SLM
    type SlmIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.SlmIndicatorDetails option
    }

    type ShardsCapacityIndicatorTierDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("max_shards_in_cluster")>]
        MaxShardsInCluster: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("current_used_shards")>]
        CurrentUsedShards: Types.Integer option
    }

    type ShardsCapacityIndicatorDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("data")>]
        Data: GlobalHealthReport.ShardsCapacityIndicatorTierDetail
        [<System.Text.Json.Serialization.JsonPropertyName("frozen")>]
        Frozen: GlobalHealthReport.ShardsCapacityIndicatorTierDetail
    }

    /// SHARDS_CAPACITY
    type ShardsCapacityIndicator = {
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: GlobalHealthReport.ShardsCapacityIndicatorDetails option
    }

    type Indicators = {
        [<System.Text.Json.Serialization.JsonPropertyName("master_is_stable")>]
        MasterIsStable: GlobalHealthReport.MasterIsStableIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("shards_availability")>]
        ShardsAvailability: GlobalHealthReport.ShardsAvailabilityIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("disk")>]
        Disk: GlobalHealthReport.DiskIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("repository_integrity")>]
        RepositoryIntegrity: GlobalHealthReport.RepositoryIntegrityIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream_lifecycle")>]
        DataStreamLifecycle: GlobalHealthReport.DataStreamLifecycleIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("ilm")>]
        Ilm: GlobalHealthReport.IlmIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("slm")>]
        Slm: GlobalHealthReport.SlmIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("shards_capacity")>]
        ShardsCapacity: GlobalHealthReport.ShardsCapacityIndicator option
        [<System.Text.Json.Serialization.JsonPropertyName("file_settings")>]
        FileSettings: GlobalHealthReport.FileSettingsIndicator option
    }


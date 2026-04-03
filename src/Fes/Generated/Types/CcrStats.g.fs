// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CcrStats =

    type AutoFollowedCluster = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster_name")>]
        ClusterName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("last_seen_metadata_version")>]
        LastSeenMetadataVersion: Types.VersionNumber
        [<System.Text.Json.Serialization.JsonPropertyName("time_since_last_check_millis")>]
        TimeSinceLastCheckMillis: Types.DurationValue<Types.UnitMillis>
    }

    type AutoFollowStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("auto_followed_clusters")>]
        AutoFollowedClusters: CcrStats.AutoFollowedCluster list
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_failed_follow_indices")>]
        NumberOfFailedFollowIndices: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_failed_remote_cluster_state_requests")>]
        NumberOfFailedRemoteClusterStateRequests: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("number_of_successful_follow_indices")>]
        NumberOfSuccessfulFollowIndices: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("recent_auto_follow_errors")>]
        RecentAutoFollowErrors: Types.ErrorCause list
    }

    type FollowStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CcrTypes.FollowIndexStats list
    }


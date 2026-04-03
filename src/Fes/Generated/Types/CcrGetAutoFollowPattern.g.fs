// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CcrGetAutoFollowPattern =

    type AutoFollowPatternSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("active")>]
        Active: bool
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: string
        [<System.Text.Json.Serialization.JsonPropertyName("follow_index_pattern")>]
        FollowIndexPattern: CoreTypes.IndexPattern option
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index_patterns")>]
        LeaderIndexPatterns: CoreTypes.IndexPatterns
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index_exclusion_patterns")>]
        LeaderIndexExclusionPatterns: CoreTypes.IndexPatterns
        [<System.Text.Json.Serialization.JsonPropertyName("max_outstanding_read_requests")>]
        MaxOutstandingReadRequests: CoreTypes.Integer
    }

    type AutoFollowPattern = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: AutoFollowPatternSummary
    }


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
        FollowIndexPattern: Types.IndexPattern option
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index_patterns")>]
        LeaderIndexPatterns: Types.IndexPatterns
        [<System.Text.Json.Serialization.JsonPropertyName("leader_index_exclusion_patterns")>]
        LeaderIndexExclusionPatterns: Types.IndexPatterns
        [<System.Text.Json.Serialization.JsonPropertyName("max_outstanding_read_requests")>]
        MaxOutstandingReadRequests: Types.Integer
    }

    type AutoFollowPattern = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("pattern")>]
        Pattern: CcrGetAutoFollowPattern.AutoFollowPatternSummary
    }


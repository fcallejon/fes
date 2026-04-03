// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module ClusterAllocationExplain =

    [<RequireQualifiedAccess>]
    type AllocationExplainDecision =
        | NO
        | YES
        | THROTTLE
        | ALWAYS

    type AllocationDecision = {
        [<System.Text.Json.Serialization.JsonPropertyName("decider")>]
        Decider: string
        [<System.Text.Json.Serialization.JsonPropertyName("decision")>]
        Decision: ClusterAllocationExplain.AllocationExplainDecision
        [<System.Text.Json.Serialization.JsonPropertyName("explanation")>]
        Explanation: string
    }

    type AllocationStore = {
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_id")>]
        AllocationId: string
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool
        [<System.Text.Json.Serialization.JsonPropertyName("in_sync")>]
        InSync: bool
        [<System.Text.Json.Serialization.JsonPropertyName("matching_size_in_bytes")>]
        MatchingSizeInBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("matching_sync_id")>]
        MatchingSyncId: bool
        [<System.Text.Json.Serialization.JsonPropertyName("store_exception")>]
        StoreException: string
    }

    type DiskUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_bytes")>]
        TotalBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("used_bytes")>]
        UsedBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("free_bytes")>]
        FreeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("free_disk_percent")>]
        FreeDiskPercent: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("used_disk_percent")>]
        UsedDiskPercent: Types.Double
    }

    type NodeDiskUsage = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_name")>]
        NodeName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("least_available")>]
        LeastAvailable: ClusterAllocationExplain.DiskUsage
        [<System.Text.Json.Serialization.JsonPropertyName("most_available")>]
        MostAvailable: ClusterAllocationExplain.DiskUsage
    }

    type ReservedSize = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("path")>]
        Path: string
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("shards")>]
        Shards: string list
    }

    type ClusterInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("nodes")>]
        Nodes: Map<string, ClusterAllocationExplain.NodeDiskUsage>
        [<System.Text.Json.Serialization.JsonPropertyName("shard_sizes")>]
        ShardSizes: Map<string, Types.Long>
        [<System.Text.Json.Serialization.JsonPropertyName("shard_data_set_sizes")>]
        ShardDataSetSizes: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("shard_paths")>]
        ShardPaths: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("reserved_sizes")>]
        ReservedSizes: ClusterAllocationExplain.ReservedSize list
    }

    type CurrentNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: Types.NodeRoles
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("weight_ranking")>]
        WeightRanking: Types.Integer
    }

    [<RequireQualifiedAccess>]
    type Decision =
        | Yes
        | No
        | WorseBalance
        | Throttled
        | AwaitingInfo
        | AllocationDelayed
        | NoValidShardCopy
        | NoAttempt

    type NodeAllocationExplanation = {
        [<System.Text.Json.Serialization.JsonPropertyName("deciders")>]
        Deciders: ClusterAllocationExplain.AllocationDecision list option
        [<System.Text.Json.Serialization.JsonPropertyName("node_attributes")>]
        NodeAttributes: Map<string, string>
        [<System.Text.Json.Serialization.JsonPropertyName("node_decision")>]
        NodeDecision: ClusterAllocationExplain.Decision
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("node_name")>]
        NodeName: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("roles")>]
        Roles: Types.NodeRoles
        [<System.Text.Json.Serialization.JsonPropertyName("store")>]
        Store: ClusterAllocationExplain.AllocationStore option
        [<System.Text.Json.Serialization.JsonPropertyName("transport_address")>]
        TransportAddress: Types.TransportAddress
        [<System.Text.Json.Serialization.JsonPropertyName("weight_ranking")>]
        WeightRanking: Types.Integer option
    }

    [<RequireQualifiedAccess>]
    type UnassignedInformationReason =
        | INDEXCREATED
        | CLUSTERRECOVERED
        | INDEXREOPENED
        | DANGLINGINDEXIMPORTED
        | NEWINDEXRESTORED
        | EXISTINGINDEXRESTORED
        | REPLICAADDED
        | ALLOCATIONFAILED
        | NODELEFT
        | REROUTECANCELLED
        | REINITIALIZED
        | REALLOCATEDREPLICA
        | PRIMARYFAILED
        | FORCEDEMPTYPRIMARY
        | MANUALALLOCATION

    type UnassignedInformation = {
        [<System.Text.Json.Serialization.JsonPropertyName("at")>]
        At: Types.DateTime
        [<System.Text.Json.Serialization.JsonPropertyName("last_allocation_status")>]
        LastAllocationStatus: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: ClusterAllocationExplain.UnassignedInformationReason
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: string option
        [<System.Text.Json.Serialization.JsonPropertyName("failed_allocation_attempts")>]
        FailedAllocationAttempts: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("delayed")>]
        Delayed: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("allocation_status")>]
        AllocationStatus: string option
    }


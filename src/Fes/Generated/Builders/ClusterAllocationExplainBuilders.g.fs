// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module ClusterAllocationExplainBuilders =

    type NodeAllocationExplanationBuilder() =
        member _.Yield(_: unit) : NodeAllocationExplanation =
            {
                Deciders = None
                NodeAttributes = Unchecked.defaultof<_>
                NodeDecision = Unchecked.defaultof<_>
                NodeId = Unchecked.defaultof<_>
                NodeName = Unchecked.defaultof<_>
                Roles = Unchecked.defaultof<_>
                Store = None
                TransportAddress = Unchecked.defaultof<_>
                WeightRanking = None
            }

        [<CustomOperation("deciders")>]
        member _.Deciders(state: NodeAllocationExplanation, value: ClusterAllocationExplain.AllocationDecision list) =
            { state with Deciders = Some value }

        [<CustomOperation("nodeAttributes")>]
        member _.NodeAttributes(state: NodeAllocationExplanation, value: Map<string, string>) =
            { state with NodeAttributes = value }

        [<CustomOperation("nodeDecision")>]
        member _.NodeDecision(state: NodeAllocationExplanation, value: ClusterAllocationExplain.Decision) =
            { state with NodeDecision = value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: NodeAllocationExplanation, value: CoreTypes.Id) =
            { state with NodeId = value }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: NodeAllocationExplanation, value: CoreTypes.Name) =
            { state with NodeName = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: NodeAllocationExplanation, value: CoreTypes.NodeRoles) =
            { state with Roles = value }

        [<CustomOperation("store")>]
        member _.Store(state: NodeAllocationExplanation, value: ClusterAllocationExplain.AllocationStore) =
            { state with Store = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: NodeAllocationExplanation, value: CoreTypes.TransportAddress) =
            { state with TransportAddress = value }

        [<CustomOperation("weightRanking")>]
        member _.WeightRanking(state: NodeAllocationExplanation, value: CoreTypes.Integer) =
            { state with WeightRanking = Some value }

    let nodeAllocationExplanation = NodeAllocationExplanationBuilder()

    type UnassignedInformationBuilder() =
        member _.Yield(_: unit) : UnassignedInformation =
            {
                At = Unchecked.defaultof<_>
                LastAllocationStatus = None
                Reason = Unchecked.defaultof<_>
                Details = None
                FailedAllocationAttempts = None
                Delayed = None
                AllocationStatus = None
            }

        [<CustomOperation("at")>]
        member _.At(state: UnassignedInformation, value: CoreTypes.DateTime) =
            { state with At = value }

        [<CustomOperation("lastAllocationStatus")>]
        member _.LastAllocationStatus(state: UnassignedInformation, value: string) =
            { state with LastAllocationStatus = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: UnassignedInformation, value: ClusterAllocationExplain.UnassignedInformationReason) =
            { state with Reason = value }

        [<CustomOperation("details")>]
        member _.Details(state: UnassignedInformation, value: string) =
            { state with Details = Some value }

        [<CustomOperation("failedAllocationAttempts")>]
        member _.FailedAllocationAttempts(state: UnassignedInformation, value: CoreTypes.Integer) =
            { state with FailedAllocationAttempts = Some value }

        [<CustomOperation("delayed")>]
        member _.Delayed(state: UnassignedInformation, value: bool) =
            { state with Delayed = Some value }

        [<CustomOperation("allocationStatus")>]
        member _.AllocationStatus(state: UnassignedInformation, value: string) =
            { state with AllocationStatus = Some value }

    let unassignedInformation = UnassignedInformationBuilder()


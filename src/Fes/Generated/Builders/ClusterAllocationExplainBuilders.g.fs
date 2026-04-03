// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module ClusterAllocationExplainBuilders =

    type NodeAllocationExplanationBuilder() =
        member _.Yield(_: unit) : Types.NodeAllocationExplanation =
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
        member _.Deciders(state: Types.NodeAllocationExplanation, value: Types.AllocationDecision list) =
            { state with Deciders = Some value }

        [<CustomOperation("nodeAttributes")>]
        member _.NodeAttributes(state: Types.NodeAllocationExplanation, value: Map<string, string>) =
            { state with NodeAttributes = value }

        [<CustomOperation("nodeDecision")>]
        member _.NodeDecision(state: Types.NodeAllocationExplanation, value: Types.Decision) =
            { state with NodeDecision = value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: Types.NodeAllocationExplanation, value: Types.Id) =
            { state with NodeId = value }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: Types.NodeAllocationExplanation, value: Types.Name) =
            { state with NodeName = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.NodeAllocationExplanation, value: Types.NodeRoles) =
            { state with Roles = value }

        [<CustomOperation("store")>]
        member _.Store(state: Types.NodeAllocationExplanation, value: Types.AllocationStore) =
            { state with Store = Some value }

        [<CustomOperation("transportAddress")>]
        member _.TransportAddress(state: Types.NodeAllocationExplanation, value: Types.TransportAddress) =
            { state with TransportAddress = value }

        [<CustomOperation("weightRanking")>]
        member _.WeightRanking(state: Types.NodeAllocationExplanation, value: Types.Integer) =
            { state with WeightRanking = Some value }

    let nodeAllocationExplanation = NodeAllocationExplanationBuilder()

    type UnassignedInformationBuilder() =
        member _.Yield(_: unit) : Types.UnassignedInformation =
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
        member _.At(state: Types.UnassignedInformation, value: Types.DateTime) =
            { state with At = value }

        [<CustomOperation("lastAllocationStatus")>]
        member _.LastAllocationStatus(state: Types.UnassignedInformation, value: string) =
            { state with LastAllocationStatus = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.UnassignedInformation, value: Types.UnassignedInformationReason) =
            { state with Reason = value }

        [<CustomOperation("details")>]
        member _.Details(state: Types.UnassignedInformation, value: string) =
            { state with Details = Some value }

        [<CustomOperation("failedAllocationAttempts")>]
        member _.FailedAllocationAttempts(state: Types.UnassignedInformation, value: Types.Integer) =
            { state with FailedAllocationAttempts = Some value }

        [<CustomOperation("delayed")>]
        member _.Delayed(state: Types.UnassignedInformation, value: bool) =
            { state with Delayed = Some value }

        [<CustomOperation("allocationStatus")>]
        member _.AllocationStatus(state: Types.UnassignedInformation, value: string) =
            { state with AllocationStatus = Some value }

    let unassignedInformation = UnassignedInformationBuilder()


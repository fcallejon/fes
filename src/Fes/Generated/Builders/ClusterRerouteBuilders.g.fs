// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module ClusterRerouteBuilders =

    type CommandBuilder() =
        member _.Yield(_: unit) : Types.Command =
            {
                Cancel = None
                Move = None
                AllocateReplica = None
                AllocateStalePrimary = None
                AllocateEmptyPrimary = None
            }

        [<CustomOperation("cancel")>]
        member _.Cancel(state: Types.Command, value: Types.CommandCancelAction) =
            { state with Cancel = Some value }

        [<CustomOperation("move")>]
        member _.Move(state: Types.Command, value: Types.CommandMoveAction) =
            { state with Move = Some value }

        [<CustomOperation("allocateReplica")>]
        member _.AllocateReplica(state: Types.Command, value: Types.CommandAllocateReplicaAction) =
            { state with AllocateReplica = Some value }

        [<CustomOperation("allocateStalePrimary")>]
        member _.AllocateStalePrimary(state: Types.Command, value: Types.CommandAllocatePrimaryAction) =
            { state with AllocateStalePrimary = Some value }

        [<CustomOperation("allocateEmptyPrimary")>]
        member _.AllocateEmptyPrimary(state: Types.Command, value: Types.CommandAllocatePrimaryAction) =
            { state with AllocateEmptyPrimary = Some value }

    let command = CommandBuilder()

    type RerouteParametersBuilder() =
        member _.Yield(_: unit) : Types.RerouteParameters =
            {
                AllowPrimary = Unchecked.defaultof<_>
                Index = Unchecked.defaultof<_>
                Node = Unchecked.defaultof<_>
                Shard = Unchecked.defaultof<_>
                FromNode = None
                ToNode = None
            }

        [<CustomOperation("allowPrimary")>]
        member _.AllowPrimary(state: Types.RerouteParameters, value: bool) =
            { state with AllowPrimary = value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.RerouteParameters, value: Types.IndexName) =
            { state with Index = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.RerouteParameters, value: Types.NodeName) =
            { state with Node = value }

        [<CustomOperation("shard")>]
        member _.Shard(state: Types.RerouteParameters, value: Types.Integer) =
            { state with Shard = value }

        [<CustomOperation("fromNode")>]
        member _.FromNode(state: Types.RerouteParameters, value: Types.NodeName) =
            { state with FromNode = Some value }

        [<CustomOperation("toNode")>]
        member _.ToNode(state: Types.RerouteParameters, value: Types.NodeName) =
            { state with ToNode = Some value }

    let rerouteParameters = RerouteParametersBuilder()


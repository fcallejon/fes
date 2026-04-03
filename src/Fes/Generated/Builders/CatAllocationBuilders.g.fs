// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatAllocationBuilders =

    type AllocationRecordBuilder() =
        member _.Yield(_: unit) : Types.AllocationRecord =
            {
                Shards = None
                ShardsUndesired = None
                WriteLoadForecast = None
                DiskIndicesForecast = None
                DiskIndices = None
                DiskUsed = None
                DiskAvail = None
                DiskTotal = None
                DiskPercent = None
                Host = None
                Ip = None
                Node = None
                NodeRole = None
            }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.AllocationRecord, value: string) =
            { state with Shards = Some value }

        [<CustomOperation("shardsUndesired")>]
        member _.ShardsUndesired(state: Types.AllocationRecord, value: string option) =
            { state with ShardsUndesired = Some value }

        [<CustomOperation("writeLoadForecast")>]
        member _.WriteLoadForecast(state: Types.AllocationRecord, value: Types.Stringified<Types.Double> option) =
            { state with WriteLoadForecast = Some value }

        [<CustomOperation("diskIndicesForecast")>]
        member _.DiskIndicesForecast(state: Types.AllocationRecord, value: Types.ByteSize option) =
            { state with DiskIndicesForecast = Some value }

        [<CustomOperation("diskIndices")>]
        member _.DiskIndices(state: Types.AllocationRecord, value: Types.ByteSize option) =
            { state with DiskIndices = Some value }

        [<CustomOperation("diskUsed")>]
        member _.DiskUsed(state: Types.AllocationRecord, value: Types.ByteSize option) =
            { state with DiskUsed = Some value }

        [<CustomOperation("diskAvail")>]
        member _.DiskAvail(state: Types.AllocationRecord, value: Types.ByteSize option) =
            { state with DiskAvail = Some value }

        [<CustomOperation("diskTotal")>]
        member _.DiskTotal(state: Types.AllocationRecord, value: Types.ByteSize option) =
            { state with DiskTotal = Some value }

        [<CustomOperation("diskPercent")>]
        member _.DiskPercent(state: Types.AllocationRecord, value: Types.Percentage option) =
            { state with DiskPercent = Some value }

        [<CustomOperation("host")>]
        member _.Host(state: Types.AllocationRecord, value: Types.Host option) =
            { state with Host = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.AllocationRecord, value: Types.Ip option) =
            { state with Ip = Some value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.AllocationRecord, value: string) =
            { state with Node = Some value }

        [<CustomOperation("nodeRole")>]
        member _.NodeRole(state: Types.AllocationRecord, value: string option) =
            { state with NodeRole = Some value }

    let allocationRecord = AllocationRecordBuilder()


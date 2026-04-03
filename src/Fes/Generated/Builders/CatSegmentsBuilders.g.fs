// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatSegmentsBuilders =

    type SegmentsRecordBuilder() =
        member _.Yield(_: unit) : Types.SegmentsRecord =
            {
                Index = None
                Shard = None
                Prirep = None
                Ip = None
                Id = None
                Segment = None
                Generation = None
                DocsCount = None
                DocsDeleted = None
                Size = None
                SizeMemory = None
                Committed = None
                Searchable = None
                Version = None
                Compound = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.SegmentsRecord, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: Types.SegmentsRecord, value: string) =
            { state with Shard = Some value }

        [<CustomOperation("prirep")>]
        member _.Prirep(state: Types.SegmentsRecord, value: string) =
            { state with Prirep = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: Types.SegmentsRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.SegmentsRecord, value: Types.NodeId) =
            { state with Id = Some value }

        [<CustomOperation("segment")>]
        member _.Segment(state: Types.SegmentsRecord, value: string) =
            { state with Segment = Some value }

        [<CustomOperation("generation")>]
        member _.Generation(state: Types.SegmentsRecord, value: string) =
            { state with Generation = Some value }

        [<CustomOperation("docsCount")>]
        member _.DocsCount(state: Types.SegmentsRecord, value: string) =
            { state with DocsCount = Some value }

        [<CustomOperation("docsDeleted")>]
        member _.DocsDeleted(state: Types.SegmentsRecord, value: string) =
            { state with DocsDeleted = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: Types.SegmentsRecord, value: Types.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("sizeMemory")>]
        member _.SizeMemory(state: Types.SegmentsRecord, value: Types.ByteSize) =
            { state with SizeMemory = Some value }

        [<CustomOperation("committed")>]
        member _.Committed(state: Types.SegmentsRecord, value: string) =
            { state with Committed = Some value }

        [<CustomOperation("searchable")>]
        member _.Searchable(state: Types.SegmentsRecord, value: string) =
            { state with Searchable = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.SegmentsRecord, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("compound")>]
        member _.Compound(state: Types.SegmentsRecord, value: string) =
            { state with Compound = Some value }

    let segmentsRecord = SegmentsRecordBuilder()


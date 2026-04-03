// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatSegmentsBuilders =

    type SegmentsRecordBuilder() =
        member _.Yield(_: unit) : SegmentsRecord =
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
        member _.Index(state: SegmentsRecord, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("shard")>]
        member _.Shard(state: SegmentsRecord, value: string) =
            { state with Shard = Some value }

        [<CustomOperation("prirep")>]
        member _.Prirep(state: SegmentsRecord, value: string) =
            { state with Prirep = Some value }

        [<CustomOperation("ip")>]
        member _.Ip(state: SegmentsRecord, value: string) =
            { state with Ip = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: SegmentsRecord, value: Types.NodeId) =
            { state with Id = Some value }

        [<CustomOperation("segment")>]
        member _.Segment(state: SegmentsRecord, value: string) =
            { state with Segment = Some value }

        [<CustomOperation("generation")>]
        member _.Generation(state: SegmentsRecord, value: string) =
            { state with Generation = Some value }

        [<CustomOperation("docsCount")>]
        member _.DocsCount(state: SegmentsRecord, value: string) =
            { state with DocsCount = Some value }

        [<CustomOperation("docsDeleted")>]
        member _.DocsDeleted(state: SegmentsRecord, value: string) =
            { state with DocsDeleted = Some value }

        [<CustomOperation("size")>]
        member _.Size(state: SegmentsRecord, value: Types.ByteSize) =
            { state with Size = Some value }

        [<CustomOperation("sizeMemory")>]
        member _.SizeMemory(state: SegmentsRecord, value: Types.ByteSize) =
            { state with SizeMemory = Some value }

        [<CustomOperation("committed")>]
        member _.Committed(state: SegmentsRecord, value: string) =
            { state with Committed = Some value }

        [<CustomOperation("searchable")>]
        member _.Searchable(state: SegmentsRecord, value: string) =
            { state with Searchable = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: SegmentsRecord, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("compound")>]
        member _.Compound(state: SegmentsRecord, value: string) =
            { state with Compound = Some value }

    let segmentsRecord = SegmentsRecordBuilder()


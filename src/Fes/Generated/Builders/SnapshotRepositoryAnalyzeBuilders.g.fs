// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SnapshotRepositoryAnalyzeBuilders =

    type DetailsInfoBuilder() =
        member _.Yield(_: unit) : Types.DetailsInfo =
            {
                Blob = Unchecked.defaultof<_>
                OverwriteElapsed = None
                OverwriteElapsedNanos = None
                WriteElapsed = Unchecked.defaultof<_>
                WriteElapsedNanos = Unchecked.defaultof<_>
                WriteThrottled = Unchecked.defaultof<_>
                WriteThrottledNanos = Unchecked.defaultof<_>
                WriterNode = Unchecked.defaultof<_>
            }

        [<CustomOperation("blob")>]
        member _.Blob(state: Types.DetailsInfo, value: Types.BlobDetails) =
            { state with Blob = value }

        [<CustomOperation("overwriteElapsed")>]
        member _.OverwriteElapsed(state: Types.DetailsInfo, value: Types.Duration) =
            { state with OverwriteElapsed = Some value }

        [<CustomOperation("overwriteElapsedNanos")>]
        member _.OverwriteElapsedNanos(state: Types.DetailsInfo, value: Types.DurationValue<Types.UnitNanos>) =
            { state with OverwriteElapsedNanos = Some value }

        [<CustomOperation("writeElapsed")>]
        member _.WriteElapsed(state: Types.DetailsInfo, value: Types.Duration) =
            { state with WriteElapsed = value }

        [<CustomOperation("writeElapsedNanos")>]
        member _.WriteElapsedNanos(state: Types.DetailsInfo, value: Types.DurationValue<Types.UnitNanos>) =
            { state with WriteElapsedNanos = value }

        [<CustomOperation("writeThrottled")>]
        member _.WriteThrottled(state: Types.DetailsInfo, value: Types.Duration) =
            { state with WriteThrottled = value }

        [<CustomOperation("writeThrottledNanos")>]
        member _.WriteThrottledNanos(state: Types.DetailsInfo, value: Types.DurationValue<Types.UnitNanos>) =
            { state with WriteThrottledNanos = value }

        [<CustomOperation("writerNode")>]
        member _.WriterNode(state: Types.DetailsInfo, value: Types.SnapshotNodeInfo) =
            { state with WriterNode = value }

    let detailsInfo = DetailsInfoBuilder()

    type ReadBlobDetailsBuilder() =
        member _.Yield(_: unit) : Types.ReadBlobDetails =
            {
                BeforeWriteComplete = None
                Elapsed = None
                ElapsedNanos = None
                FirstByteTime = None
                FirstByteTimeNanos = Unchecked.defaultof<_>
                Found = Unchecked.defaultof<_>
                Node = Unchecked.defaultof<_>
                Throttled = None
                ThrottledNanos = None
            }

        [<CustomOperation("beforeWriteComplete")>]
        member _.BeforeWriteComplete(state: Types.ReadBlobDetails, value: bool) =
            { state with BeforeWriteComplete = Some value }

        [<CustomOperation("elapsed")>]
        member _.Elapsed(state: Types.ReadBlobDetails, value: Types.Duration) =
            { state with Elapsed = Some value }

        [<CustomOperation("elapsedNanos")>]
        member _.ElapsedNanos(state: Types.ReadBlobDetails, value: Types.DurationValue<Types.UnitNanos>) =
            { state with ElapsedNanos = Some value }

        [<CustomOperation("firstByteTime")>]
        member _.FirstByteTime(state: Types.ReadBlobDetails, value: Types.Duration) =
            { state with FirstByteTime = Some value }

        [<CustomOperation("firstByteTimeNanos")>]
        member _.FirstByteTimeNanos(state: Types.ReadBlobDetails, value: Types.DurationValue<Types.UnitNanos>) =
            { state with FirstByteTimeNanos = value }

        [<CustomOperation("found")>]
        member _.Found(state: Types.ReadBlobDetails, value: bool) =
            { state with Found = value }

        [<CustomOperation("node")>]
        member _.Node(state: Types.ReadBlobDetails, value: Types.SnapshotNodeInfo) =
            { state with Node = value }

        [<CustomOperation("throttled")>]
        member _.Throttled(state: Types.ReadBlobDetails, value: Types.Duration) =
            { state with Throttled = Some value }

        [<CustomOperation("throttledNanos")>]
        member _.ThrottledNanos(state: Types.ReadBlobDetails, value: Types.DurationValue<Types.UnitNanos>) =
            { state with ThrottledNanos = Some value }

    let readBlobDetails = ReadBlobDetailsBuilder()


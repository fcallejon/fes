// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SnapshotRepositoryAnalyzeBuilders =

    type DetailsInfoBuilder() =
        member _.Yield(_: unit) : DetailsInfo =
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
        member _.Blob(state: DetailsInfo, value: SnapshotRepositoryAnalyze.BlobDetails) =
            { state with Blob = value }

        [<CustomOperation("overwriteElapsed")>]
        member _.OverwriteElapsed(state: DetailsInfo, value: CoreTypes.Duration) =
            { state with OverwriteElapsed = Some value }

        [<CustomOperation("overwriteElapsedNanos")>]
        member _.OverwriteElapsedNanos(state: DetailsInfo, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with OverwriteElapsedNanos = Some value }

        [<CustomOperation("writeElapsed")>]
        member _.WriteElapsed(state: DetailsInfo, value: CoreTypes.Duration) =
            { state with WriteElapsed = value }

        [<CustomOperation("writeElapsedNanos")>]
        member _.WriteElapsedNanos(state: DetailsInfo, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with WriteElapsedNanos = value }

        [<CustomOperation("writeThrottled")>]
        member _.WriteThrottled(state: DetailsInfo, value: CoreTypes.Duration) =
            { state with WriteThrottled = value }

        [<CustomOperation("writeThrottledNanos")>]
        member _.WriteThrottledNanos(state: DetailsInfo, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with WriteThrottledNanos = value }

        [<CustomOperation("writerNode")>]
        member _.WriterNode(state: DetailsInfo, value: SnapshotRepositoryAnalyze.SnapshotNodeInfo) =
            { state with WriterNode = value }

    let detailsInfo = DetailsInfoBuilder()

    type ReadBlobDetailsBuilder() =
        member _.Yield(_: unit) : ReadBlobDetails =
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
        member _.BeforeWriteComplete(state: ReadBlobDetails, value: bool) =
            { state with BeforeWriteComplete = Some value }

        [<CustomOperation("elapsed")>]
        member _.Elapsed(state: ReadBlobDetails, value: CoreTypes.Duration) =
            { state with Elapsed = Some value }

        [<CustomOperation("elapsedNanos")>]
        member _.ElapsedNanos(state: ReadBlobDetails, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with ElapsedNanos = Some value }

        [<CustomOperation("firstByteTime")>]
        member _.FirstByteTime(state: ReadBlobDetails, value: CoreTypes.Duration) =
            { state with FirstByteTime = Some value }

        [<CustomOperation("firstByteTimeNanos")>]
        member _.FirstByteTimeNanos(state: ReadBlobDetails, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with FirstByteTimeNanos = value }

        [<CustomOperation("found")>]
        member _.Found(state: ReadBlobDetails, value: bool) =
            { state with Found = value }

        [<CustomOperation("node")>]
        member _.Node(state: ReadBlobDetails, value: SnapshotRepositoryAnalyze.SnapshotNodeInfo) =
            { state with Node = value }

        [<CustomOperation("throttled")>]
        member _.Throttled(state: ReadBlobDetails, value: CoreTypes.Duration) =
            { state with Throttled = Some value }

        [<CustomOperation("throttledNanos")>]
        member _.ThrottledNanos(state: ReadBlobDetails, value: CoreTypes.DurationValue<CoreTypes.UnitNanos>) =
            { state with ThrottledNanos = Some value }

    let readBlobDetails = ReadBlobDetailsBuilder()


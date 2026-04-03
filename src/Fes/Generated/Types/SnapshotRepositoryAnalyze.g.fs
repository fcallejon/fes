// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SnapshotRepositoryAnalyze =

    type SnapshotNodeInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
    }

    type ReadBlobDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("before_write_complete")>]
        BeforeWriteComplete: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("elapsed")>]
        Elapsed: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("elapsed_nanos")>]
        ElapsedNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos> option
        [<System.Text.Json.Serialization.JsonPropertyName("first_byte_time")>]
        FirstByteTime: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("first_byte_time_nanos")>]
        FirstByteTimeNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: SnapshotNodeInfo
        [<System.Text.Json.Serialization.JsonPropertyName("throttled")>]
        Throttled: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_nanos")>]
        ThrottledNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos> option
    }

    type BlobDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("overwritten")>]
        Overwritten: bool
        [<System.Text.Json.Serialization.JsonPropertyName("read_early")>]
        ReadEarly: bool
        [<System.Text.Json.Serialization.JsonPropertyName("read_end")>]
        ReadEnd: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("read_start")>]
        ReadStart: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reads")>]
        Reads: ReadBlobDetails
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("size_bytes")>]
        SizeBytes: CoreTypes.Long
    }

    type DetailsInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("blob")>]
        Blob: BlobDetails
        [<System.Text.Json.Serialization.JsonPropertyName("overwrite_elapsed")>]
        OverwriteElapsed: CoreTypes.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("overwrite_elapsed_nanos")>]
        OverwriteElapsedNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos> option
        [<System.Text.Json.Serialization.JsonPropertyName("write_elapsed")>]
        WriteElapsed: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("write_elapsed_nanos")>]
        WriteElapsedNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("write_throttled")>]
        WriteThrottled: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("write_throttled_nanos")>]
        WriteThrottledNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("writer_node")>]
        WriterNode: SnapshotNodeInfo
    }

    type ReadSummaryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max_wait")>]
        MaxWait: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("max_wait_nanos")>]
        MaxWaitNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed")>]
        TotalElapsed: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed_nanos")>]
        TotalElapsedNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled")>]
        TotalThrottled: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_nanos")>]
        TotalThrottledNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_wait")>]
        TotalWait: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_wait_nanos")>]
        TotalWaitNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
    }

    type WriteSummaryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed")>]
        TotalElapsed: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed_nanos")>]
        TotalElapsedNanos: CoreTypes.DurationValue<CoreTypes.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: CoreTypes.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled")>]
        TotalThrottled: CoreTypes.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_nanos")>]
        TotalThrottledNanos: CoreTypes.Long
    }

    type SummaryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("read")>]
        Read: ReadSummaryInfo
        [<System.Text.Json.Serialization.JsonPropertyName("write")>]
        Write: WriteSummaryInfo
    }


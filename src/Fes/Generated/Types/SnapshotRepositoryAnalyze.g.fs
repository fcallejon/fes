// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SnapshotRepositoryAnalyze =

    type SnapshotNodeInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
    }

    type ReadBlobDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("before_write_complete")>]
        BeforeWriteComplete: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("elapsed")>]
        Elapsed: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("elapsed_nanos")>]
        ElapsedNanos: Types.DurationValue<Types.UnitNanos> option
        [<System.Text.Json.Serialization.JsonPropertyName("first_byte_time")>]
        FirstByteTime: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("first_byte_time_nanos")>]
        FirstByteTimeNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: SnapshotRepositoryAnalyze.SnapshotNodeInfo
        [<System.Text.Json.Serialization.JsonPropertyName("throttled")>]
        Throttled: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("throttled_nanos")>]
        ThrottledNanos: Types.DurationValue<Types.UnitNanos> option
    }

    type BlobDetails = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
        [<System.Text.Json.Serialization.JsonPropertyName("overwritten")>]
        Overwritten: bool
        [<System.Text.Json.Serialization.JsonPropertyName("read_early")>]
        ReadEarly: bool
        [<System.Text.Json.Serialization.JsonPropertyName("read_end")>]
        ReadEnd: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("read_start")>]
        ReadStart: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reads")>]
        Reads: SnapshotRepositoryAnalyze.ReadBlobDetails
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("size_bytes")>]
        SizeBytes: Types.Long
    }

    type DetailsInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("blob")>]
        Blob: SnapshotRepositoryAnalyze.BlobDetails
        [<System.Text.Json.Serialization.JsonPropertyName("overwrite_elapsed")>]
        OverwriteElapsed: Types.Duration option
        [<System.Text.Json.Serialization.JsonPropertyName("overwrite_elapsed_nanos")>]
        OverwriteElapsedNanos: Types.DurationValue<Types.UnitNanos> option
        [<System.Text.Json.Serialization.JsonPropertyName("write_elapsed")>]
        WriteElapsed: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("write_elapsed_nanos")>]
        WriteElapsedNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("write_throttled")>]
        WriteThrottled: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("write_throttled_nanos")>]
        WriteThrottledNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("writer_node")>]
        WriterNode: SnapshotRepositoryAnalyze.SnapshotNodeInfo
    }

    type ReadSummaryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("max_wait")>]
        MaxWait: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("max_wait_nanos")>]
        MaxWaitNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed")>]
        TotalElapsed: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed_nanos")>]
        TotalElapsedNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled")>]
        TotalThrottled: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_nanos")>]
        TotalThrottledNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_wait")>]
        TotalWait: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_wait_nanos")>]
        TotalWaitNanos: Types.DurationValue<Types.UnitNanos>
    }

    type WriteSummaryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed")>]
        TotalElapsed: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_elapsed_nanos")>]
        TotalElapsedNanos: Types.DurationValue<Types.UnitNanos>
        [<System.Text.Json.Serialization.JsonPropertyName("total_size")>]
        TotalSize: Types.ByteSize
        [<System.Text.Json.Serialization.JsonPropertyName("total_size_bytes")>]
        TotalSizeBytes: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled")>]
        TotalThrottled: Types.Duration
        [<System.Text.Json.Serialization.JsonPropertyName("total_throttled_nanos")>]
        TotalThrottledNanos: Types.Long
    }

    type SummaryInfo = {
        [<System.Text.Json.Serialization.JsonPropertyName("read")>]
        Read: SnapshotRepositoryAnalyze.ReadSummaryInfo
        [<System.Text.Json.Serialization.JsonPropertyName("write")>]
        Write: SnapshotRepositoryAnalyze.WriteSummaryInfo
    }


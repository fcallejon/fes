// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SnapshotTypesBuilders =

    type AzureRepositoryBuilder() =
        member _.Yield(_: unit) : Types.AzureRepository =
            {
                Type = "azure"
                Settings = None
                Uuid = None
            }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.AzureRepository, value: string) =
            { state with Type = value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.AzureRepository, value: Types.AzureRepositorySettings) =
            { state with Settings = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: Types.AzureRepository, value: Types.Uuid) =
            { state with Uuid = Some value }

    let azureRepository = AzureRepositoryBuilder()

    type AzureRepositorySettingsBuilder() =
        member _.Yield(_: unit) : Types.AzureRepositorySettings =
            {
                BasePath = None
                Client = None
                Container = None
                DeleteObjectsMaxSize = None
                LocationMode = None
                MaxConcurrentBatchDeletes = None
                Readonly = None
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: Types.AzureRepositorySettings, value: string) =
            { state with BasePath = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: Types.AzureRepositorySettings, value: string) =
            { state with Client = Some value }

        [<CustomOperation("container")>]
        member _.Container(state: Types.AzureRepositorySettings, value: string) =
            { state with Container = Some value }

        [<CustomOperation("deleteObjectsMaxSize")>]
        member _.DeleteObjectsMaxSize(state: Types.AzureRepositorySettings, value: Types.Integer) =
            { state with DeleteObjectsMaxSize = Some value }

        [<CustomOperation("locationMode")>]
        member _.LocationMode(state: Types.AzureRepositorySettings, value: string) =
            { state with LocationMode = Some value }

        [<CustomOperation("maxConcurrentBatchDeletes")>]
        member _.MaxConcurrentBatchDeletes(state: Types.AzureRepositorySettings, value: Types.Integer) =
            { state with MaxConcurrentBatchDeletes = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: Types.AzureRepositorySettings, value: bool) =
            { state with Readonly = Some value }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: Types.AzureRepositorySettings, value: Types.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.AzureRepositorySettings, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: Types.AzureRepositorySettings, value: Types.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: Types.AzureRepositorySettings, value: Types.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let azureRepositorySettings = AzureRepositorySettingsBuilder()

    type GcsRepositorySettingsBuilder() =
        member _.Yield(_: unit) : Types.GcsRepositorySettings =
            {
                Bucket = Unchecked.defaultof<_>
                ApplicationName = None
                BasePath = None
                Client = None
                Readonly = None
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("bucket")>]
        member _.Bucket(state: Types.GcsRepositorySettings, value: string) =
            { state with Bucket = value }

        [<CustomOperation("applicationName")>]
        member _.ApplicationName(state: Types.GcsRepositorySettings, value: string) =
            { state with ApplicationName = Some value }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: Types.GcsRepositorySettings, value: string) =
            { state with BasePath = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: Types.GcsRepositorySettings, value: string) =
            { state with Client = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: Types.GcsRepositorySettings, value: bool) =
            { state with Readonly = Some value }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: Types.GcsRepositorySettings, value: Types.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.GcsRepositorySettings, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: Types.GcsRepositorySettings, value: Types.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: Types.GcsRepositorySettings, value: Types.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let gcsRepositorySettings = GcsRepositorySettingsBuilder()

    type ReadOnlyUrlRepositorySettingsBuilder() =
        member _.Yield(_: unit) : Types.ReadOnlyUrlRepositorySettings =
            {
                HttpMaxRetries = None
                HttpSocketTimeout = None
                MaxNumberOfSnapshots = None
                Url = Unchecked.defaultof<_>
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("httpMaxRetries")>]
        member _.HttpMaxRetries(state: Types.ReadOnlyUrlRepositorySettings, value: Types.Integer) =
            { state with HttpMaxRetries = Some value }

        [<CustomOperation("httpSocketTimeout")>]
        member _.HttpSocketTimeout(state: Types.ReadOnlyUrlRepositorySettings, value: Types.Duration) =
            { state with HttpSocketTimeout = Some value }

        [<CustomOperation("maxNumberOfSnapshots")>]
        member _.MaxNumberOfSnapshots(state: Types.ReadOnlyUrlRepositorySettings, value: Types.Integer) =
            { state with MaxNumberOfSnapshots = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.ReadOnlyUrlRepositorySettings, value: string) =
            { state with Url = value }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: Types.ReadOnlyUrlRepositorySettings, value: Types.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.ReadOnlyUrlRepositorySettings, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: Types.ReadOnlyUrlRepositorySettings, value: Types.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: Types.ReadOnlyUrlRepositorySettings, value: Types.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let readOnlyUrlRepositorySettings = ReadOnlyUrlRepositorySettingsBuilder()

    type RepositorySettingsBaseBuilder() =
        member _.Yield(_: unit) : Types.RepositorySettingsBase =
            {
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: Types.RepositorySettingsBase, value: Types.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.RepositorySettingsBase, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: Types.RepositorySettingsBase, value: Types.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: Types.RepositorySettingsBase, value: Types.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let repositorySettingsBase = RepositorySettingsBaseBuilder()

    type S3RepositorySettingsBuilder() =
        member _.Yield(_: unit) : Types.S3RepositorySettings =
            {
                Bucket = Unchecked.defaultof<_>
                BasePath = None
                BufferSize = None
                CannedAcl = None
                Client = None
                DeleteObjectsMaxSize = None
                GetRegisterRetryDelay = None
                MaxMultipartParts = None
                MaxMultipartUploadCleanupSize = None
                Readonly = None
                ServerSideEncryption = None
                StorageClass = None
                ThrottledDeleteRetryDelayIncrement = None
                ThrottledDeleteRetryMaximumDelay = None
                ThrottledDeleteRetryMaximumNumberOfRetries = None
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("bucket")>]
        member _.Bucket(state: Types.S3RepositorySettings, value: string) =
            { state with Bucket = value }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: Types.S3RepositorySettings, value: string) =
            { state with BasePath = Some value }

        [<CustomOperation("bufferSize")>]
        member _.BufferSize(state: Types.S3RepositorySettings, value: Types.ByteSize) =
            { state with BufferSize = Some value }

        [<CustomOperation("cannedAcl")>]
        member _.CannedAcl(state: Types.S3RepositorySettings, value: string) =
            { state with CannedAcl = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: Types.S3RepositorySettings, value: string) =
            { state with Client = Some value }

        [<CustomOperation("deleteObjectsMaxSize")>]
        member _.DeleteObjectsMaxSize(state: Types.S3RepositorySettings, value: Types.Integer) =
            { state with DeleteObjectsMaxSize = Some value }

        [<CustomOperation("getRegisterRetryDelay")>]
        member _.GetRegisterRetryDelay(state: Types.S3RepositorySettings, value: Types.Duration) =
            { state with GetRegisterRetryDelay = Some value }

        [<CustomOperation("maxMultipartParts")>]
        member _.MaxMultipartParts(state: Types.S3RepositorySettings, value: Types.Integer) =
            { state with MaxMultipartParts = Some value }

        [<CustomOperation("maxMultipartUploadCleanupSize")>]
        member _.MaxMultipartUploadCleanupSize(state: Types.S3RepositorySettings, value: Types.Integer) =
            { state with MaxMultipartUploadCleanupSize = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: Types.S3RepositorySettings, value: bool) =
            { state with Readonly = Some value }

        [<CustomOperation("serverSideEncryption")>]
        member _.ServerSideEncryption(state: Types.S3RepositorySettings, value: bool) =
            { state with ServerSideEncryption = Some value }

        [<CustomOperation("storageClass")>]
        member _.StorageClass(state: Types.S3RepositorySettings, value: string) =
            { state with StorageClass = Some value }

        [<CustomOperation("throttledDeleteRetryDelayIncrement")>]
        member _.ThrottledDeleteRetryDelayIncrement(state: Types.S3RepositorySettings, value: Types.Duration) =
            { state with ThrottledDeleteRetryDelayIncrement = Some value }

        [<CustomOperation("throttledDeleteRetryMaximumDelay")>]
        member _.ThrottledDeleteRetryMaximumDelay(state: Types.S3RepositorySettings, value: Types.Duration) =
            { state with ThrottledDeleteRetryMaximumDelay = Some value }

        [<CustomOperation("throttledDeleteRetryMaximumNumberOfRetries")>]
        member _.ThrottledDeleteRetryMaximumNumberOfRetries(state: Types.S3RepositorySettings, value: Types.Integer) =
            { state with ThrottledDeleteRetryMaximumNumberOfRetries = Some value }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: Types.S3RepositorySettings, value: Types.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.S3RepositorySettings, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: Types.S3RepositorySettings, value: Types.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: Types.S3RepositorySettings, value: Types.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let s3RepositorySettings = S3RepositorySettingsBuilder()

    type SharedFileSystemRepositorySettingsBuilder() =
        member _.Yield(_: unit) : Types.SharedFileSystemRepositorySettings =
            {
                Location = Unchecked.defaultof<_>
                MaxNumberOfSnapshots = None
                Readonly = None
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("location")>]
        member _.Location(state: Types.SharedFileSystemRepositorySettings, value: string) =
            { state with Location = value }

        [<CustomOperation("maxNumberOfSnapshots")>]
        member _.MaxNumberOfSnapshots(state: Types.SharedFileSystemRepositorySettings, value: Types.Integer) =
            { state with MaxNumberOfSnapshots = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: Types.SharedFileSystemRepositorySettings, value: bool) =
            { state with Readonly = Some value }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: Types.SharedFileSystemRepositorySettings, value: Types.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.SharedFileSystemRepositorySettings, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: Types.SharedFileSystemRepositorySettings, value: Types.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: Types.SharedFileSystemRepositorySettings, value: Types.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let sharedFileSystemRepositorySettings = SharedFileSystemRepositorySettingsBuilder()

    type SnapshotInfoBuilder() =
        member _.Yield(_: unit) : Types.SnapshotInfo =
            {
                DataStreams = Unchecked.defaultof<_>
                Duration = None
                DurationInMillis = None
                EndTime = None
                EndTimeInMillis = None
                Failures = None
                IncludeGlobalState = None
                Indices = None
                IndexDetails = None
                Metadata = None
                Reason = None
                Repository = None
                Snapshot = Unchecked.defaultof<_>
                Shards = None
                StartTime = None
                StartTimeInMillis = None
                State = None
                Uuid = Unchecked.defaultof<_>
                Version = None
                VersionId = None
                FeatureStates = None
            }

        [<CustomOperation("dataStreams")>]
        member _.DataStreams(state: Types.SnapshotInfo, value: string list) =
            { state with DataStreams = value }

        [<CustomOperation("duration")>]
        member _.Duration(state: Types.SnapshotInfo, value: Types.Duration) =
            { state with Duration = Some value }

        [<CustomOperation("durationInMillis")>]
        member _.DurationInMillis(state: Types.SnapshotInfo, value: Types.DurationValue<Types.UnitMillis>) =
            { state with DurationInMillis = Some value }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: Types.SnapshotInfo, value: Types.DateTime) =
            { state with EndTime = Some value }

        [<CustomOperation("endTimeInMillis")>]
        member _.EndTimeInMillis(state: Types.SnapshotInfo, value: Types.EpochTime<Types.UnitMillis>) =
            { state with EndTimeInMillis = Some value }

        [<CustomOperation("failures")>]
        member _.Failures(state: Types.SnapshotInfo, value: Types.SnapshotShardFailure list) =
            { state with Failures = Some value }

        [<CustomOperation("includeGlobalState")>]
        member _.IncludeGlobalState(state: Types.SnapshotInfo, value: bool) =
            { state with IncludeGlobalState = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.SnapshotInfo, value: Types.IndexName list) =
            { state with Indices = Some value }

        [<CustomOperation("indexDetails")>]
        member _.IndexDetails(state: Types.SnapshotInfo, value: Map<Types.IndexName, Types.IndexDetails>) =
            { state with IndexDetails = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.SnapshotInfo, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: Types.SnapshotInfo, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: Types.SnapshotInfo, value: Types.Name) =
            { state with Repository = Some value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: Types.SnapshotInfo, value: Types.Name) =
            { state with Snapshot = value }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.SnapshotInfo, value: Types.ShardStatistics) =
            { state with Shards = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.SnapshotInfo, value: Types.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: Types.SnapshotInfo, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTimeInMillis = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.SnapshotInfo, value: string) =
            { state with State = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: Types.SnapshotInfo, value: Types.Uuid) =
            { state with Uuid = value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.SnapshotInfo, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("versionId")>]
        member _.VersionId(state: Types.SnapshotInfo, value: Types.VersionNumber) =
            { state with VersionId = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: Types.SnapshotInfo, value: Types.InfoFeatureState list) =
            { state with FeatureStates = Some value }

    let snapshotInfo = SnapshotInfoBuilder()

    type SourceOnlyRepositorySettingsBuilder() =
        member _.Yield(_: unit) : Types.SourceOnlyRepositorySettings =
            {
                DelegateType = None
                MaxNumberOfSnapshots = None
                ReadOnly = None
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("delegateType")>]
        member _.DelegateType(state: Types.SourceOnlyRepositorySettings, value: string) =
            { state with DelegateType = Some value }

        [<CustomOperation("maxNumberOfSnapshots")>]
        member _.MaxNumberOfSnapshots(state: Types.SourceOnlyRepositorySettings, value: Types.Integer) =
            { state with MaxNumberOfSnapshots = Some value }

        [<CustomOperation("readOnly")>]
        member _.ReadOnly(state: Types.SourceOnlyRepositorySettings, value: bool) =
            { state with ReadOnly = Some value }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: Types.SourceOnlyRepositorySettings, value: Types.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: Types.SourceOnlyRepositorySettings, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: Types.SourceOnlyRepositorySettings, value: Types.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: Types.SourceOnlyRepositorySettings, value: Types.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let sourceOnlyRepositorySettings = SourceOnlyRepositorySettingsBuilder()


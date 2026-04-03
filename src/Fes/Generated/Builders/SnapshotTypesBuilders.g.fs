// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SnapshotTypesBuilders =

    type AzureRepositorySettingsBuilder() =
        member _.Yield(_: unit) : AzureRepositorySettings =
            {
                BasePath = None
                Client = None
                Container = None
                DeleteObjectsMaxSize = None
                LocationMode = None
                MaxConcurrentBatchDeletes = None
                Readonly = None
            }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: AzureRepositorySettings, value: string) =
            { state with BasePath = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: AzureRepositorySettings, value: string) =
            { state with Client = Some value }

        [<CustomOperation("container")>]
        member _.Container(state: AzureRepositorySettings, value: string) =
            { state with Container = Some value }

        [<CustomOperation("deleteObjectsMaxSize")>]
        member _.DeleteObjectsMaxSize(state: AzureRepositorySettings, value: CoreTypes.Integer) =
            { state with DeleteObjectsMaxSize = Some value }

        [<CustomOperation("locationMode")>]
        member _.LocationMode(state: AzureRepositorySettings, value: string) =
            { state with LocationMode = Some value }

        [<CustomOperation("maxConcurrentBatchDeletes")>]
        member _.MaxConcurrentBatchDeletes(state: AzureRepositorySettings, value: CoreTypes.Integer) =
            { state with MaxConcurrentBatchDeletes = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: AzureRepositorySettings, value: bool) =
            { state with Readonly = Some value }

    let azureRepositorySettings = AzureRepositorySettingsBuilder()

    type GcsRepositorySettingsBuilder() =
        member _.Yield(_: unit) : GcsRepositorySettings =
            {
                Bucket = Unchecked.defaultof<_>
                ApplicationName = None
                BasePath = None
                Client = None
                Readonly = None
            }

        [<CustomOperation("bucket")>]
        member _.Bucket(state: GcsRepositorySettings, value: string) =
            { state with Bucket = value }

        [<CustomOperation("applicationName")>]
        member _.ApplicationName(state: GcsRepositorySettings, value: string) =
            { state with ApplicationName = Some value }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: GcsRepositorySettings, value: string) =
            { state with BasePath = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: GcsRepositorySettings, value: string) =
            { state with Client = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: GcsRepositorySettings, value: bool) =
            { state with Readonly = Some value }

    let gcsRepositorySettings = GcsRepositorySettingsBuilder()

    type ReadOnlyUrlRepositorySettingsBuilder() =
        member _.Yield(_: unit) : ReadOnlyUrlRepositorySettings =
            {
                HttpMaxRetries = None
                HttpSocketTimeout = None
                MaxNumberOfSnapshots = None
                Url = Unchecked.defaultof<_>
            }

        [<CustomOperation("httpMaxRetries")>]
        member _.HttpMaxRetries(state: ReadOnlyUrlRepositorySettings, value: CoreTypes.Integer) =
            { state with HttpMaxRetries = Some value }

        [<CustomOperation("httpSocketTimeout")>]
        member _.HttpSocketTimeout(state: ReadOnlyUrlRepositorySettings, value: CoreTypes.Duration) =
            { state with HttpSocketTimeout = Some value }

        [<CustomOperation("maxNumberOfSnapshots")>]
        member _.MaxNumberOfSnapshots(state: ReadOnlyUrlRepositorySettings, value: CoreTypes.Integer) =
            { state with MaxNumberOfSnapshots = Some value }

        [<CustomOperation("url")>]
        member _.Url(state: ReadOnlyUrlRepositorySettings, value: string) =
            { state with Url = value }

    let readOnlyUrlRepositorySettings = ReadOnlyUrlRepositorySettingsBuilder()

    type RepositorySettingsBaseBuilder() =
        member _.Yield(_: unit) : RepositorySettingsBase =
            {
                ChunkSize = None
                Compress = None
                MaxRestoreBytesPerSec = None
                MaxSnapshotBytesPerSec = None
            }

        [<CustomOperation("chunkSize")>]
        member _.ChunkSize(state: RepositorySettingsBase, value: CoreTypes.ByteSize) =
            { state with ChunkSize = Some value }

        [<CustomOperation("compress")>]
        member _.Compress(state: RepositorySettingsBase, value: bool) =
            { state with Compress = Some value }

        [<CustomOperation("maxRestoreBytesPerSec")>]
        member _.MaxRestoreBytesPerSec(state: RepositorySettingsBase, value: CoreTypes.ByteSize) =
            { state with MaxRestoreBytesPerSec = Some value }

        [<CustomOperation("maxSnapshotBytesPerSec")>]
        member _.MaxSnapshotBytesPerSec(state: RepositorySettingsBase, value: CoreTypes.ByteSize) =
            { state with MaxSnapshotBytesPerSec = Some value }

    let repositorySettingsBase = RepositorySettingsBaseBuilder()

    type S3RepositorySettingsBuilder() =
        member _.Yield(_: unit) : S3RepositorySettings =
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
            }

        [<CustomOperation("bucket")>]
        member _.Bucket(state: S3RepositorySettings, value: string) =
            { state with Bucket = value }

        [<CustomOperation("basePath")>]
        member _.BasePath(state: S3RepositorySettings, value: string) =
            { state with BasePath = Some value }

        [<CustomOperation("bufferSize")>]
        member _.BufferSize(state: S3RepositorySettings, value: CoreTypes.ByteSize) =
            { state with BufferSize = Some value }

        [<CustomOperation("cannedAcl")>]
        member _.CannedAcl(state: S3RepositorySettings, value: string) =
            { state with CannedAcl = Some value }

        [<CustomOperation("client")>]
        member _.Client(state: S3RepositorySettings, value: string) =
            { state with Client = Some value }

        [<CustomOperation("deleteObjectsMaxSize")>]
        member _.DeleteObjectsMaxSize(state: S3RepositorySettings, value: CoreTypes.Integer) =
            { state with DeleteObjectsMaxSize = Some value }

        [<CustomOperation("getRegisterRetryDelay")>]
        member _.GetRegisterRetryDelay(state: S3RepositorySettings, value: CoreTypes.Duration) =
            { state with GetRegisterRetryDelay = Some value }

        [<CustomOperation("maxMultipartParts")>]
        member _.MaxMultipartParts(state: S3RepositorySettings, value: CoreTypes.Integer) =
            { state with MaxMultipartParts = Some value }

        [<CustomOperation("maxMultipartUploadCleanupSize")>]
        member _.MaxMultipartUploadCleanupSize(state: S3RepositorySettings, value: CoreTypes.Integer) =
            { state with MaxMultipartUploadCleanupSize = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: S3RepositorySettings, value: bool) =
            { state with Readonly = Some value }

        [<CustomOperation("serverSideEncryption")>]
        member _.ServerSideEncryption(state: S3RepositorySettings, value: bool) =
            { state with ServerSideEncryption = Some value }

        [<CustomOperation("storageClass")>]
        member _.StorageClass(state: S3RepositorySettings, value: string) =
            { state with StorageClass = Some value }

        [<CustomOperation("throttledDeleteRetryDelayIncrement")>]
        member _.ThrottledDeleteRetryDelayIncrement(state: S3RepositorySettings, value: CoreTypes.Duration) =
            { state with ThrottledDeleteRetryDelayIncrement = Some value }

        [<CustomOperation("throttledDeleteRetryMaximumDelay")>]
        member _.ThrottledDeleteRetryMaximumDelay(state: S3RepositorySettings, value: CoreTypes.Duration) =
            { state with ThrottledDeleteRetryMaximumDelay = Some value }

        [<CustomOperation("throttledDeleteRetryMaximumNumberOfRetries")>]
        member _.ThrottledDeleteRetryMaximumNumberOfRetries(state: S3RepositorySettings, value: CoreTypes.Integer) =
            { state with ThrottledDeleteRetryMaximumNumberOfRetries = Some value }

    let s3RepositorySettings = S3RepositorySettingsBuilder()

    type SharedFileSystemRepositorySettingsBuilder() =
        member _.Yield(_: unit) : SharedFileSystemRepositorySettings =
            {
                Location = Unchecked.defaultof<_>
                MaxNumberOfSnapshots = None
                Readonly = None
            }

        [<CustomOperation("location")>]
        member _.Location(state: SharedFileSystemRepositorySettings, value: string) =
            { state with Location = value }

        [<CustomOperation("maxNumberOfSnapshots")>]
        member _.MaxNumberOfSnapshots(state: SharedFileSystemRepositorySettings, value: CoreTypes.Integer) =
            { state with MaxNumberOfSnapshots = Some value }

        [<CustomOperation("readonly")>]
        member _.Readonly(state: SharedFileSystemRepositorySettings, value: bool) =
            { state with Readonly = Some value }

    let sharedFileSystemRepositorySettings = SharedFileSystemRepositorySettingsBuilder()

    type SnapshotInfoBuilder() =
        member _.Yield(_: unit) : SnapshotInfo =
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
        member _.DataStreams(state: SnapshotInfo, value: string list) =
            { state with DataStreams = value }

        [<CustomOperation("duration")>]
        member _.Duration(state: SnapshotInfo, value: CoreTypes.Duration) =
            { state with Duration = Some value }

        [<CustomOperation("durationInMillis")>]
        member _.DurationInMillis(state: SnapshotInfo, value: CoreTypes.DurationValue<CoreTypes.UnitMillis>) =
            { state with DurationInMillis = Some value }

        [<CustomOperation("endTime")>]
        member _.EndTime(state: SnapshotInfo, value: CoreTypes.DateTime) =
            { state with EndTime = Some value }

        [<CustomOperation("endTimeInMillis")>]
        member _.EndTimeInMillis(state: SnapshotInfo, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with EndTimeInMillis = Some value }

        [<CustomOperation("failures")>]
        member _.Failures(state: SnapshotInfo, value: SnapshotTypes.SnapshotShardFailure list) =
            { state with Failures = Some value }

        [<CustomOperation("includeGlobalState")>]
        member _.IncludeGlobalState(state: SnapshotInfo, value: bool) =
            { state with IncludeGlobalState = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: SnapshotInfo, value: CoreTypes.IndexName list) =
            { state with Indices = Some value }

        [<CustomOperation("indexDetails")>]
        member _.IndexDetails(state: SnapshotInfo, value: Map<CoreTypes.IndexName, SnapshotTypes.IndexDetails>) =
            { state with IndexDetails = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: SnapshotInfo, value: CoreTypes.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("reason")>]
        member _.Reason(state: SnapshotInfo, value: string) =
            { state with Reason = Some value }

        [<CustomOperation("repository")>]
        member _.Repository(state: SnapshotInfo, value: CoreTypes.Name) =
            { state with Repository = Some value }

        [<CustomOperation("snapshot")>]
        member _.Snapshot(state: SnapshotInfo, value: CoreTypes.Name) =
            { state with Snapshot = value }

        [<CustomOperation("shards")>]
        member _.Shards(state: SnapshotInfo, value: CoreTypes.ShardStatistics) =
            { state with Shards = Some value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: SnapshotInfo, value: CoreTypes.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: SnapshotInfo, value: CoreTypes.EpochTime<CoreTypes.UnitMillis>) =
            { state with StartTimeInMillis = Some value }

        [<CustomOperation("state")>]
        member _.State(state: SnapshotInfo, value: string) =
            { state with State = Some value }

        [<CustomOperation("uuid")>]
        member _.Uuid(state: SnapshotInfo, value: CoreTypes.Uuid) =
            { state with Uuid = value }

        [<CustomOperation("version")>]
        member _.Version(state: SnapshotInfo, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("versionId")>]
        member _.VersionId(state: SnapshotInfo, value: CoreTypes.VersionNumber) =
            { state with VersionId = Some value }

        [<CustomOperation("featureStates")>]
        member _.FeatureStates(state: SnapshotInfo, value: SnapshotTypes.InfoFeatureState list) =
            { state with FeatureStates = Some value }

    let snapshotInfo = SnapshotInfoBuilder()

    type SourceOnlyRepositorySettingsBuilder() =
        member _.Yield(_: unit) : SourceOnlyRepositorySettings =
            {
                DelegateType = None
                MaxNumberOfSnapshots = None
                ReadOnly = None
            }

        [<CustomOperation("delegateType")>]
        member _.DelegateType(state: SourceOnlyRepositorySettings, value: string) =
            { state with DelegateType = Some value }

        [<CustomOperation("maxNumberOfSnapshots")>]
        member _.MaxNumberOfSnapshots(state: SourceOnlyRepositorySettings, value: CoreTypes.Integer) =
            { state with MaxNumberOfSnapshots = Some value }

        [<CustomOperation("readOnly")>]
        member _.ReadOnly(state: SourceOnlyRepositorySettings, value: bool) =
            { state with ReadOnly = Some value }

    let sourceOnlyRepositorySettings = SourceOnlyRepositorySettingsBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatTypes =

    [<RequireQualifiedAccess>]
    type CatAliasesColumn =
        | Alias
        | Index
        | Filter
        | RoutingIndex
        | RoutingSearch
        | IsWriteIndex
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatAliasesColumns =
        | CatAliasesColumn of CatTypes.CatAliasesColumn
        | Array of CatTypes.CatAliasesColumn list

    [<RequireQualifiedAccess>]
    type CatAllocationColumn =
        | Shards
        | ShardsUndesired
        | WriteLoadForecast
        | DiskIndicesForecast
        | DiskIndices
        | DiskUsed
        | DiskAvail
        | DiskTotal
        | DiskPercent
        | Host
        | Ip
        | Node
        | NodeRole
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatAllocationColumns =
        | CatAllocationColumn of CatTypes.CatAllocationColumn
        | Array of CatTypes.CatAllocationColumn list

    [<RequireQualifiedAccess>]
    type CatAnomalyDetectorColumn =
        | AssignmentExplanation
        | BucketsCount
        | BucketsTimeExpAvg
        | BucketsTimeExpAvgHour
        | BucketsTimeMax
        | BucketsTimeMin
        | BucketsTimeTotal
        | DataBuckets
        | DataEarliestRecord
        | DataEmptyBuckets
        | DataInputBytes
        | DataInputFields
        | DataInputRecords
        | DataInvalidDates
        | DataLast
        | DataLastEmptyBucket
        | DataLastSparseBucket
        | DataLatestRecord
        | DataMissingFields
        | DataOutOfOrderTimestamps
        | DataProcessedFields
        | DataProcessedRecords
        | DataSparseBuckets
        | ForecastsMemoryAvg
        | ForecastsMemoryMax
        | ForecastsMemoryMin
        | ForecastsMemoryTotal
        | ForecastsRecordsAvg
        | ForecastsRecordsMax
        | ForecastsRecordsMin
        | ForecastsRecordsTotal
        | ForecastsTimeAvg
        | ForecastsTimeMax
        | ForecastsTimeMin
        | ForecastsTimeTotal
        | ForecastsTotal
        | Id
        | ModelBucketAllocationFailures
        | ModelByFields
        | ModelBytes
        | ModelBytesExceeded
        | ModelCategorizationStatus
        | ModelCategorizedDocCount
        | ModelDeadCategoryCount
        | ModelFailedCategoryCount
        | ModelFrequentCategoryCount
        | ModelLogTime
        | ModelMemoryLimit
        | ModelMemoryStatus
        | ModelOverFields
        | ModelPartitionFields
        | ModelRareCategoryCount
        | ModelTimestamp
        | ModelTotalCategoryCount
        | NodeAddress
        | NodeEphemeralId
        | NodeId
        | NodeName
        | OpenedTime
        | State

    [<RequireQualifiedAccess>]
    type CatAnomalyDetectorColumns =
        | CatAnomalyDetectorColumn of CatTypes.CatAnomalyDetectorColumn
        | Array of CatTypes.CatAnomalyDetectorColumn list

    [<RequireQualifiedAccess>]
    type CatCircuitBreakerColumn =
        | NodeId
        | NodeName
        | Breaker
        | Limit
        | LimitBytes
        | Estimated
        | EstimatedBytes
        | Tripped
        | Overhead
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatCircuitBreakerColumns =
        | CatCircuitBreakerColumn of CatTypes.CatCircuitBreakerColumn
        | Array of CatTypes.CatCircuitBreakerColumn list

    [<RequireQualifiedAccess>]
    type CatComponentColumn =
        | Name
        | Version
        | AliasCount
        | MappingCount
        | SettingsCount
        | MetadataCount
        | IncludedIn
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatComponentColumns =
        | CatComponentColumn of CatTypes.CatComponentColumn
        | Array of CatTypes.CatComponentColumn list

    [<RequireQualifiedAccess>]
    type CatCountColumn =
        | Epoch
        | Timestamp
        | Count
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatCountColumns =
        | CatCountColumn of CatTypes.CatCountColumn
        | Array of CatTypes.CatCountColumn list

    [<RequireQualifiedAccess>]
    type CatDatafeedColumn =
        | Ae
        | Bc
        | Id
        | Na
        | Ne
        | Ni
        | Nn
        | Sba
        | Sc
        | Seah
        | St
        | S

    [<RequireQualifiedAccess>]
    type CatDatafeedColumns =
        | CatDatafeedColumn of CatTypes.CatDatafeedColumn
        | Array of CatTypes.CatDatafeedColumn list

    [<RequireQualifiedAccess>]
    type CatDfaColumn =
        | AssignmentExplanation
        | CreateTime
        | Description
        | DestIndex
        | FailureReason
        | Id
        | ModelMemoryLimit
        | NodeAddress
        | NodeEphemeralId
        | NodeId
        | NodeName
        | Progress
        | SourceIndex
        | State
        | Type
        | Version

    [<RequireQualifiedAccess>]
    type CatDfaColumns =
        | CatDfaColumn of CatTypes.CatDfaColumn
        | Array of CatTypes.CatDfaColumn list

    [<RequireQualifiedAccess>]
    type CatFieldDataColumn =
        | Id
        | Host
        | Ip
        | Node
        | Field
        | Size
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatFieldDataColumns =
        | CatFieldDataColumn of CatTypes.CatFieldDataColumn
        | Array of CatTypes.CatFieldDataColumn list

    [<RequireQualifiedAccess>]
    type CatHealthColumn =
        | Epoch
        | Timestamp
        | Cluster
        | Status
        | NodeTotal
        | NodeData
        | Shards
        | Pri
        | Relo
        | Init
        | Unassign
        | UnassignPri
        | PendingTasks
        | MaxTaskWaitTime
        | ActiveShardsPercent
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatHealthColumns =
        | CatHealthColumn of CatTypes.CatHealthColumn
        | Array of CatTypes.CatHealthColumn list

    [<RequireQualifiedAccess>]
    type CatIndicesColumn =
        | Health
        | Status
        | Index
        | Uuid
        | Pri
        | Rep
        | DocsCount
        | DocsDeleted
        | CreationDate
        | CreationDateString
        | StoreSize
        | PriStoreSize
        | DatasetSize
        | CompletionSize
        | PriCompletionSize
        | FielddataMemorySize
        | PriFielddataMemorySize
        | FielddataEvictions
        | PriFielddataEvictions
        | QueryCacheMemorySize
        | PriQueryCacheMemorySize
        | QueryCacheEvictions
        | PriQueryCacheEvictions
        | RequestCacheMemorySize
        | PriRequestCacheMemorySize
        | RequestCacheEvictions
        | PriRequestCacheEvictions
        | RequestCacheHitCount
        | PriRequestCacheHitCount
        | RequestCacheMissCount
        | PriRequestCacheMissCount
        | FlushTotal
        | PriFlushTotal
        | FlushTotalTime
        | PriFlushTotalTime
        | GetCurrent
        | PriGetCurrent
        | GetTime
        | PriGetTime
        | GetTotal
        | PriGetTotal
        | GetExistsTime
        | PriGetExistsTime
        | GetExistsTotal
        | PriGetExistsTotal
        | GetMissingTime
        | PriGetMissingTime
        | GetMissingTotal
        | PriGetMissingTotal
        | IndexingDeleteCurrent
        | PriIndexingDeleteCurrent
        | IndexingDeleteTime
        | PriIndexingDeleteTime
        | IndexingDeleteTotal
        | PriIndexingDeleteTotal
        | IndexingIndexCurrent
        | PriIndexingIndexCurrent
        | IndexingIndexTime
        | PriIndexingIndexTime
        | IndexingIndexTotal
        | PriIndexingIndexTotal
        | IndexingIndexFailed
        | PriIndexingIndexFailed
        | IndexingIndexFailedDueToVersionConflict
        | PriIndexingIndexFailedDueToVersionConflict
        | MergesCurrent
        | PriMergesCurrent
        | MergesCurrentDocs
        | PriMergesCurrentDocs
        | MergesCurrentSize
        | PriMergesCurrentSize
        | MergesTotal
        | PriMergesTotal
        | MergesTotalDocs
        | PriMergesTotalDocs
        | MergesTotalSize
        | PriMergesTotalSize
        | MergesTotalTime
        | PriMergesTotalTime
        | RefreshTotal
        | PriRefreshTotal
        | RefreshTime
        | PriRefreshTime
        | RefreshExternalTotal
        | PriRefreshExternalTotal
        | RefreshExternalTime
        | PriRefreshExternalTime
        | RefreshListeners
        | PriRefreshListeners
        | SearchFetchCurrent
        | PriSearchFetchCurrent
        | SearchFetchTime
        | PriSearchFetchTime
        | SearchFetchTotal
        | PriSearchFetchTotal
        | SearchOpenContexts
        | PriSearchOpenContexts
        | SearchQueryCurrent
        | PriSearchQueryCurrent
        | SearchQueryTime
        | PriSearchQueryTime
        | SearchQueryTotal
        | PriSearchQueryTotal
        | SearchScrollCurrent
        | PriSearchScrollCurrent
        | SearchScrollTime
        | PriSearchScrollTime
        | SearchScrollTotal
        | PriSearchScrollTotal
        | SegmentsCount
        | PriSegmentsCount
        | SegmentsMemory
        | PriSegmentsMemory
        | SegmentsIndexWriterMemory
        | PriSegmentsIndexWriterMemory
        | SegmentsVersionMapMemory
        | PriSegmentsVersionMapMemory
        | SegmentsFixedBitsetMemory
        | PriSegmentsFixedBitsetMemory
        | WarmerCurrent
        | PriWarmerCurrent
        | WarmerTotal
        | PriWarmerTotal
        | WarmerTotalTime
        | PriWarmerTotalTime
        | SuggestCurrent
        | PriSuggestCurrent
        | SuggestTime
        | PriSuggestTime
        | SuggestTotal
        | PriSuggestTotal
        | MemoryTotal
        | PriMemoryTotal
        | BulkTotalOperations
        | PriBulkTotalOperations
        | BulkTotalTime
        | PriBulkTotalTime
        | BulkTotalSizeInBytes
        | PriBulkTotalSizeInBytes
        | BulkAvgTime
        | PriBulkAvgTime
        | BulkAvgSizeInBytes
        | PriBulkAvgSizeInBytes
        | DenseVectorValueCount
        | PriDenseVectorValueCount
        | SparseVectorValueCount
        | PriSparseVectorValueCount
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatIndicesColumns =
        | CatIndicesColumn of CatTypes.CatIndicesColumn
        | Array of CatTypes.CatIndicesColumn list

    [<RequireQualifiedAccess>]
    type CatMasterColumn =
        | Id
        | Host
        | Ip
        | Node
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatMasterColumns =
        | CatMasterColumn of CatTypes.CatMasterColumn
        | Array of CatTypes.CatMasterColumn list

    [<RequireQualifiedAccess>]
    type CatNodeColumn =
        | Build
        | CompletionSize
        | Cpu
        | DiskAvail
        | DiskTotal
        | DiskUsed
        | DiskUsedPercent
        | FielddataEvictions
        | FielddataMemorySize
        | FileDescCurrent
        | FileDescMax
        | FileDescPercent
        | FlushTotal
        | FlushTotalTime
        | GetCurrent
        | GetExistsTime
        | GetExistsTotal
        | GetMissingTime
        | GetMissingTotal
        | GetTime
        | GetTotal
        | HeapCurrent
        | HeapMax
        | HeapPercent
        | HttpAddress
        | Id
        | IndexingDeleteCurrent
        | IndexingDeleteTime
        | IndexingDeleteTotal
        | IndexingIndexCurrent
        | IndexingIndexFailed
        | IndexingIndexFailedDueToVersionConflict
        | IndexingIndexTime
        | IndexingIndexTotal
        | Ip
        | Jdk
        | Load1m
        | Load5m
        | Load15m
        | AvailableProcessors
        | MappingsTotalCount
        | MappingsTotalEstimatedOverheadInBytes
        | Master
        | MergesCurrent
        | MergesCurrentDocs
        | MergesCurrentSize
        | MergesTotal
        | MergesTotalDocs
        | MergesTotalSize
        | MergesTotalTime
        | Name
        | NodeRole
        | Pid
        | Port
        | QueryCacheMemorySize
        | QueryCacheEvictions
        | QueryCacheHitCount
        | QueryCacheMissCount
        | RamCurrent
        | RamMax
        | RamPercent
        | RefreshTotal
        | RefreshTime
        | RequestCacheMemorySize
        | RequestCacheEvictions
        | RequestCacheHitCount
        | RequestCacheMissCount
        | ScriptCompilations
        | ScriptCacheEvictions
        | SearchFetchCurrent
        | SearchFetchTime
        | SearchFetchTotal
        | SearchOpenContexts
        | SearchQueryCurrent
        | SearchQueryTime
        | SearchQueryTotal
        | SearchScrollCurrent
        | SearchScrollTime
        | SearchScrollTotal
        | SegmentsCount
        | SegmentsFixedBitsetMemory
        | SegmentsIndexWriterMemory
        | SegmentsMemory
        | SegmentsVersionMapMemory
        | ShardStatsTotalCount
        | SuggestCurrent
        | SuggestTime
        | SuggestTotal
        | Uptime
        | Version
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatNodeColumns =
        | CatNodeColumn of CatTypes.CatNodeColumn
        | Array of CatTypes.CatNodeColumn list

    [<RequireQualifiedAccess>]
    type CatNodeattrsColumn =
        | Node
        | Id
        | Pid
        | Host
        | Ip
        | Port
        | Attr
        | Value
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatNodeattrsColumns =
        | CatNodeattrsColumn of CatTypes.CatNodeattrsColumn
        | Array of CatTypes.CatNodeattrsColumn list

    [<RequireQualifiedAccess>]
    type CatPendingTasksColumn =
        | InsertOrder
        | TimeInQueue
        | Priority
        | Source
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatPendingTasksColumns =
        | CatPendingTasksColumn of CatTypes.CatPendingTasksColumn
        | Array of CatTypes.CatPendingTasksColumn list

    [<RequireQualifiedAccess>]
    type CatPluginsColumn =
        | Id
        | Name
        | Component
        | Version
        | Description
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatPluginsColumns =
        | CatPluginsColumn of CatTypes.CatPluginsColumn
        | Array of CatTypes.CatPluginsColumn list

    [<RequireQualifiedAccess>]
    type CatRecoveryColumn =
        | Index
        | Shard
        | StartTime
        | StartTimeMillis
        | StopTime
        | StopTimeMillis
        | Time
        | Type
        | Stage
        | SourceHost
        | SourceNode
        | TargetHost
        | TargetNode
        | Repository
        | Snapshot
        | Files
        | FilesRecovered
        | FilesPercent
        | FilesTotal
        | Bytes
        | BytesRecovered
        | BytesPercent
        | BytesTotal
        | TranslogOps
        | TranslogOpsRecovered
        | TranslogOpsPercent
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatRecoveryColumns =
        | CatRecoveryColumn of CatTypes.CatRecoveryColumn
        | Array of CatTypes.CatRecoveryColumn list

    type CatRequestBase = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type CatSegmentsColumn =
        | Index
        | Shard
        | Prirep
        | Ip
        | Segment
        | Generation
        | DocsCount
        | DocsDeleted
        | Size
        | SizeMemory
        | Committed
        | Searchable
        | Version
        | Compound
        | Id
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatSegmentsColumns =
        | CatSegmentsColumn of CatTypes.CatSegmentsColumn
        | Array of CatTypes.CatSegmentsColumn list

    [<RequireQualifiedAccess>]
    type CatShardColumn =
        | CompletionSize
        | DatasetSize
        | DenseVectorValueCount
        | Docs
        | FielddataEvictions
        | FielddataMemorySize
        | FlushTotal
        | FlushTotalTime
        | GetCurrent
        | GetExistsTime
        | GetExistsTotal
        | GetMissingTime
        | GetMissingTotal
        | GetTime
        | GetTotal
        | Id
        | Index
        | IndexingDeleteCurrent
        | IndexingDeleteTime
        | IndexingDeleteTotal
        | IndexingIndexCurrent
        | IndexingIndexFailedDueToVersionConflict
        | IndexingIndexFailed
        | IndexingIndexTime
        | IndexingIndexTotal
        | Ip
        | MergesCurrent
        | MergesCurrentDocs
        | MergesCurrentSize
        | MergesTotal
        | MergesTotalDocs
        | MergesTotalSize
        | MergesTotalTime
        | Node
        | Prirep
        | QueryCacheEvictions
        | QueryCacheMemorySize
        | RecoverysourceType
        | RefreshTime
        | RefreshTotal
        | SearchFetchCurrent
        | SearchFetchTime
        | SearchFetchTotal
        | SearchOpenContexts
        | SearchQueryCurrent
        | SearchQueryTime
        | SearchQueryTotal
        | SearchScrollCurrent
        | SearchScrollTime
        | SearchScrollTotal
        | SegmentsCount
        | SegmentsFixedBitsetMemory
        | SegmentsIndexWriterMemory
        | SegmentsMemory
        | SegmentsVersionMapMemory
        | SeqNoGlobalCheckpoint
        | SeqNoLocalCheckpoint
        | SeqNoMax
        | Shard
        | DsparseVectorValueCount
        | State
        | Store
        | SuggestCurrent
        | SuggestTime
        | SuggestTotal
        | SyncId
        | UnassignedAt
        | UnassignedDetails
        | UnassignedFor
        | UnassignedReason
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatShardColumns =
        | CatShardColumn of CatTypes.CatShardColumn
        | Array of CatTypes.CatShardColumn list

    [<RequireQualifiedAccess>]
    type CatSnapshotsColumn =
        | Id
        | Repository
        | Status
        | StartEpoch
        | StartTime
        | EndEpoch
        | EndTime
        | Duration
        | Indices
        | SuccessfulShards
        | FailedShards
        | TotalShards
        | Reason
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatSnapshotsColumns =
        | CatSnapshotsColumn of CatTypes.CatSnapshotsColumn
        | Array of CatTypes.CatSnapshotsColumn list

    [<RequireQualifiedAccess>]
    type CatTasksColumn =
        | Id
        | Action
        | TaskId
        | ParentTaskId
        | Type
        | StartTime
        | Timestamp
        | RunningTimeNs
        | RunningTime
        | NodeId
        | Ip
        | Port
        | Node
        | Version
        | XOpaqueId
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatTasksColumns =
        | CatTasksColumn of CatTypes.CatTasksColumn
        | Array of CatTypes.CatTasksColumn list

    [<RequireQualifiedAccess>]
    type CatTemplatesColumn =
        | Name
        | IndexPatterns
        | Order
        | Version
        | ComposedOf
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatTemplatesColumns =
        | CatTemplatesColumn of CatTypes.CatTemplatesColumn
        | Array of CatTypes.CatTemplatesColumn list

    [<RequireQualifiedAccess>]
    type CatThreadPoolColumn =
        | Active
        | Completed
        | Core
        | EphemeralId
        | Host
        | Ip
        | KeepAlive
        | Largest
        | Max
        | Name
        | NodeId
        | NodeName
        | Pid
        | PoolSize
        | Port
        | Queue
        | QueueSize
        | Rejected
        | Size
        | Type
        | Custom of string

    [<RequireQualifiedAccess>]
    type CatThreadPoolColumns =
        | CatThreadPoolColumn of CatTypes.CatThreadPoolColumn
        | Array of CatTypes.CatThreadPoolColumn list

    [<RequireQualifiedAccess>]
    type CatTrainedModelsColumn =
        | CreateTime
        | CreatedBy
        | DataFrameAnalyticsId
        | Description
        | HeapSize
        | Id
        | IngestCount
        | IngestCurrent
        | IngestFailed
        | IngestPipelines
        | IngestTime
        | License
        | Operations
        | Version

    [<RequireQualifiedAccess>]
    type CatTrainedModelsColumns =
        | CatTrainedModelsColumn of CatTypes.CatTrainedModelsColumn
        | Array of CatTypes.CatTrainedModelsColumn list

    [<RequireQualifiedAccess>]
    type CatTransformColumn =
        | ChangesLastDetectionTime
        | Checkpoint
        | CheckpointDurationTimeExpAvg
        | CheckpointProgress
        | CreateTime
        | DeleteTime
        | Description
        | DestIndex
        | DocumentsDeleted
        | DocumentsIndexed
        | DocsPerSecond
        | DocumentsProcessed
        | Frequency
        | Id
        | IndexFailure
        | IndexTime
        | IndexTotal
        | IndexedDocumentsExpAvg
        | LastSearchTime
        | MaxPageSearchSize
        | PagesProcessed
        | Pipeline
        | ProcessedDocumentsExpAvg
        | ProcessingTime
        | Reason
        | SearchFailure
        | SearchTime
        | SearchTotal
        | SourceIndex
        | State
        | TransformType
        | TriggerCount
        | Version

    [<RequireQualifiedAccess>]
    type CatTransformColumns =
        | CatTransformColumn of CatTypes.CatTransformColumn
        | Array of CatTypes.CatTransformColumn list


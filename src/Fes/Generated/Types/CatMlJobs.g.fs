// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatMlJobs =

    type JobsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.JobState option
        [<System.Text.Json.Serialization.JsonPropertyName("opened_time")>]
        OpenedTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.processed_records")>]
        DataProcessedRecords: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.processed_fields")>]
        DataProcessedFields: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.input_bytes")>]
        DataInputBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("data.input_records")>]
        DataInputRecords: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.input_fields")>]
        DataInputFields: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.invalid_dates")>]
        DataInvalidDates: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.missing_fields")>]
        DataMissingFields: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.out_of_order_timestamps")>]
        DataOutOfOrderTimestamps: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.empty_buckets")>]
        DataEmptyBuckets: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.sparse_buckets")>]
        DataSparseBuckets: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.buckets")>]
        DataBuckets: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.earliest_record")>]
        DataEarliestRecord: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.latest_record")>]
        DataLatestRecord: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.last")>]
        DataLast: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.last_empty_bucket")>]
        DataLastEmptyBucket: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data.last_sparse_bucket")>]
        DataLastSparseBucket: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.bytes")>]
        ModelBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("model.memory_status")>]
        ModelMemoryStatus: MlTypes.MemoryStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("model.bytes_exceeded")>]
        ModelBytesExceeded: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("model.memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.by_fields")>]
        ModelByFields: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.over_fields")>]
        ModelOverFields: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.partition_fields")>]
        ModelPartitionFields: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.bucket_allocation_failures")>]
        ModelBucketAllocationFailures: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.categorization_status")>]
        ModelCategorizationStatus: MlTypes.CategorizationStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("model.categorized_doc_count")>]
        ModelCategorizedDocCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.total_category_count")>]
        ModelTotalCategoryCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.frequent_category_count")>]
        ModelFrequentCategoryCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.rare_category_count")>]
        ModelRareCategoryCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.dead_category_count")>]
        ModelDeadCategoryCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.failed_category_count")>]
        ModelFailedCategoryCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.log_time")>]
        ModelLogTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("model.timestamp")>]
        ModelTimestamp: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.total")>]
        ForecastsTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.memory.min")>]
        ForecastsMemoryMin: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.memory.max")>]
        ForecastsMemoryMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.memory.avg")>]
        ForecastsMemoryAvg: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.memory.total")>]
        ForecastsMemoryTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.records.min")>]
        ForecastsRecordsMin: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.records.max")>]
        ForecastsRecordsMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.records.avg")>]
        ForecastsRecordsAvg: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.records.total")>]
        ForecastsRecordsTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.time.min")>]
        ForecastsTimeMin: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.time.max")>]
        ForecastsTimeMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.time.avg")>]
        ForecastsTimeAvg: string option
        [<System.Text.Json.Serialization.JsonPropertyName("forecasts.time.total")>]
        ForecastsTimeTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.id")>]
        NodeId: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("node.name")>]
        NodeName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.ephemeral_id")>]
        NodeEphemeralId: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("node.address")>]
        NodeAddress: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets.count")>]
        BucketsCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets.time.total")>]
        BucketsTimeTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets.time.min")>]
        BucketsTimeMin: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets.time.max")>]
        BucketsTimeMax: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets.time.exp_avg")>]
        BucketsTimeExpAvg: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets.time.exp_avg_hour")>]
        BucketsTimeExpAvgHour: string option
    }


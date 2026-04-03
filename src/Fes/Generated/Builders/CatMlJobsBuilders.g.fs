// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatMlJobsBuilders =

    type JobsRecordBuilder() =
        member _.Yield(_: unit) : Types.JobsRecord =
            {
                Id = None
                State = None
                OpenedTime = None
                AssignmentExplanation = None
                DataProcessedRecords = None
                DataProcessedFields = None
                DataInputBytes = None
                DataInputRecords = None
                DataInputFields = None
                DataInvalidDates = None
                DataMissingFields = None
                DataOutOfOrderTimestamps = None
                DataEmptyBuckets = None
                DataSparseBuckets = None
                DataBuckets = None
                DataEarliestRecord = None
                DataLatestRecord = None
                DataLast = None
                DataLastEmptyBucket = None
                DataLastSparseBucket = None
                ModelBytes = None
                ModelMemoryStatus = None
                ModelBytesExceeded = None
                ModelMemoryLimit = None
                ModelByFields = None
                ModelOverFields = None
                ModelPartitionFields = None
                ModelBucketAllocationFailures = None
                ModelCategorizationStatus = None
                ModelCategorizedDocCount = None
                ModelTotalCategoryCount = None
                ModelFrequentCategoryCount = None
                ModelRareCategoryCount = None
                ModelDeadCategoryCount = None
                ModelFailedCategoryCount = None
                ModelLogTime = None
                ModelTimestamp = None
                ForecastsTotal = None
                ForecastsMemoryMin = None
                ForecastsMemoryMax = None
                ForecastsMemoryAvg = None
                ForecastsMemoryTotal = None
                ForecastsRecordsMin = None
                ForecastsRecordsMax = None
                ForecastsRecordsAvg = None
                ForecastsRecordsTotal = None
                ForecastsTimeMin = None
                ForecastsTimeMax = None
                ForecastsTimeAvg = None
                ForecastsTimeTotal = None
                NodeId = None
                NodeName = None
                NodeEphemeralId = None
                NodeAddress = None
                BucketsCount = None
                BucketsTimeTotal = None
                BucketsTimeMin = None
                BucketsTimeMax = None
                BucketsTimeExpAvg = None
                BucketsTimeExpAvgHour = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.JobsRecord, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.JobsRecord, value: Types.JobState) =
            { state with State = Some value }

        [<CustomOperation("openedTime")>]
        member _.OpenedTime(state: Types.JobsRecord, value: string) =
            { state with OpenedTime = Some value }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: Types.JobsRecord, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("dataProcessedRecords")>]
        member _.DataProcessedRecords(state: Types.JobsRecord, value: string) =
            { state with DataProcessedRecords = Some value }

        [<CustomOperation("dataProcessedFields")>]
        member _.DataProcessedFields(state: Types.JobsRecord, value: string) =
            { state with DataProcessedFields = Some value }

        [<CustomOperation("dataInputBytes")>]
        member _.DataInputBytes(state: Types.JobsRecord, value: Types.ByteSize) =
            { state with DataInputBytes = Some value }

        [<CustomOperation("dataInputRecords")>]
        member _.DataInputRecords(state: Types.JobsRecord, value: string) =
            { state with DataInputRecords = Some value }

        [<CustomOperation("dataInputFields")>]
        member _.DataInputFields(state: Types.JobsRecord, value: string) =
            { state with DataInputFields = Some value }

        [<CustomOperation("dataInvalidDates")>]
        member _.DataInvalidDates(state: Types.JobsRecord, value: string) =
            { state with DataInvalidDates = Some value }

        [<CustomOperation("dataMissingFields")>]
        member _.DataMissingFields(state: Types.JobsRecord, value: string) =
            { state with DataMissingFields = Some value }

        [<CustomOperation("dataOutOfOrderTimestamps")>]
        member _.DataOutOfOrderTimestamps(state: Types.JobsRecord, value: string) =
            { state with DataOutOfOrderTimestamps = Some value }

        [<CustomOperation("dataEmptyBuckets")>]
        member _.DataEmptyBuckets(state: Types.JobsRecord, value: string) =
            { state with DataEmptyBuckets = Some value }

        [<CustomOperation("dataSparseBuckets")>]
        member _.DataSparseBuckets(state: Types.JobsRecord, value: string) =
            { state with DataSparseBuckets = Some value }

        [<CustomOperation("dataBuckets")>]
        member _.DataBuckets(state: Types.JobsRecord, value: string) =
            { state with DataBuckets = Some value }

        [<CustomOperation("dataEarliestRecord")>]
        member _.DataEarliestRecord(state: Types.JobsRecord, value: string) =
            { state with DataEarliestRecord = Some value }

        [<CustomOperation("dataLatestRecord")>]
        member _.DataLatestRecord(state: Types.JobsRecord, value: string) =
            { state with DataLatestRecord = Some value }

        [<CustomOperation("dataLast")>]
        member _.DataLast(state: Types.JobsRecord, value: string) =
            { state with DataLast = Some value }

        [<CustomOperation("dataLastEmptyBucket")>]
        member _.DataLastEmptyBucket(state: Types.JobsRecord, value: string) =
            { state with DataLastEmptyBucket = Some value }

        [<CustomOperation("dataLastSparseBucket")>]
        member _.DataLastSparseBucket(state: Types.JobsRecord, value: string) =
            { state with DataLastSparseBucket = Some value }

        [<CustomOperation("modelBytes")>]
        member _.ModelBytes(state: Types.JobsRecord, value: Types.ByteSize) =
            { state with ModelBytes = Some value }

        [<CustomOperation("modelMemoryStatus")>]
        member _.ModelMemoryStatus(state: Types.JobsRecord, value: Types.MemoryStatus) =
            { state with ModelMemoryStatus = Some value }

        [<CustomOperation("modelBytesExceeded")>]
        member _.ModelBytesExceeded(state: Types.JobsRecord, value: Types.ByteSize) =
            { state with ModelBytesExceeded = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: Types.JobsRecord, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("modelByFields")>]
        member _.ModelByFields(state: Types.JobsRecord, value: string) =
            { state with ModelByFields = Some value }

        [<CustomOperation("modelOverFields")>]
        member _.ModelOverFields(state: Types.JobsRecord, value: string) =
            { state with ModelOverFields = Some value }

        [<CustomOperation("modelPartitionFields")>]
        member _.ModelPartitionFields(state: Types.JobsRecord, value: string) =
            { state with ModelPartitionFields = Some value }

        [<CustomOperation("modelBucketAllocationFailures")>]
        member _.ModelBucketAllocationFailures(state: Types.JobsRecord, value: string) =
            { state with ModelBucketAllocationFailures = Some value }

        [<CustomOperation("modelCategorizationStatus")>]
        member _.ModelCategorizationStatus(state: Types.JobsRecord, value: Types.CategorizationStatus) =
            { state with ModelCategorizationStatus = Some value }

        [<CustomOperation("modelCategorizedDocCount")>]
        member _.ModelCategorizedDocCount(state: Types.JobsRecord, value: string) =
            { state with ModelCategorizedDocCount = Some value }

        [<CustomOperation("modelTotalCategoryCount")>]
        member _.ModelTotalCategoryCount(state: Types.JobsRecord, value: string) =
            { state with ModelTotalCategoryCount = Some value }

        [<CustomOperation("modelFrequentCategoryCount")>]
        member _.ModelFrequentCategoryCount(state: Types.JobsRecord, value: string) =
            { state with ModelFrequentCategoryCount = Some value }

        [<CustomOperation("modelRareCategoryCount")>]
        member _.ModelRareCategoryCount(state: Types.JobsRecord, value: string) =
            { state with ModelRareCategoryCount = Some value }

        [<CustomOperation("modelDeadCategoryCount")>]
        member _.ModelDeadCategoryCount(state: Types.JobsRecord, value: string) =
            { state with ModelDeadCategoryCount = Some value }

        [<CustomOperation("modelFailedCategoryCount")>]
        member _.ModelFailedCategoryCount(state: Types.JobsRecord, value: string) =
            { state with ModelFailedCategoryCount = Some value }

        [<CustomOperation("modelLogTime")>]
        member _.ModelLogTime(state: Types.JobsRecord, value: string) =
            { state with ModelLogTime = Some value }

        [<CustomOperation("modelTimestamp")>]
        member _.ModelTimestamp(state: Types.JobsRecord, value: string) =
            { state with ModelTimestamp = Some value }

        [<CustomOperation("forecastsTotal")>]
        member _.ForecastsTotal(state: Types.JobsRecord, value: string) =
            { state with ForecastsTotal = Some value }

        [<CustomOperation("forecastsMemoryMin")>]
        member _.ForecastsMemoryMin(state: Types.JobsRecord, value: string) =
            { state with ForecastsMemoryMin = Some value }

        [<CustomOperation("forecastsMemoryMax")>]
        member _.ForecastsMemoryMax(state: Types.JobsRecord, value: string) =
            { state with ForecastsMemoryMax = Some value }

        [<CustomOperation("forecastsMemoryAvg")>]
        member _.ForecastsMemoryAvg(state: Types.JobsRecord, value: string) =
            { state with ForecastsMemoryAvg = Some value }

        [<CustomOperation("forecastsMemoryTotal")>]
        member _.ForecastsMemoryTotal(state: Types.JobsRecord, value: string) =
            { state with ForecastsMemoryTotal = Some value }

        [<CustomOperation("forecastsRecordsMin")>]
        member _.ForecastsRecordsMin(state: Types.JobsRecord, value: string) =
            { state with ForecastsRecordsMin = Some value }

        [<CustomOperation("forecastsRecordsMax")>]
        member _.ForecastsRecordsMax(state: Types.JobsRecord, value: string) =
            { state with ForecastsRecordsMax = Some value }

        [<CustomOperation("forecastsRecordsAvg")>]
        member _.ForecastsRecordsAvg(state: Types.JobsRecord, value: string) =
            { state with ForecastsRecordsAvg = Some value }

        [<CustomOperation("forecastsRecordsTotal")>]
        member _.ForecastsRecordsTotal(state: Types.JobsRecord, value: string) =
            { state with ForecastsRecordsTotal = Some value }

        [<CustomOperation("forecastsTimeMin")>]
        member _.ForecastsTimeMin(state: Types.JobsRecord, value: string) =
            { state with ForecastsTimeMin = Some value }

        [<CustomOperation("forecastsTimeMax")>]
        member _.ForecastsTimeMax(state: Types.JobsRecord, value: string) =
            { state with ForecastsTimeMax = Some value }

        [<CustomOperation("forecastsTimeAvg")>]
        member _.ForecastsTimeAvg(state: Types.JobsRecord, value: string) =
            { state with ForecastsTimeAvg = Some value }

        [<CustomOperation("forecastsTimeTotal")>]
        member _.ForecastsTimeTotal(state: Types.JobsRecord, value: string) =
            { state with ForecastsTimeTotal = Some value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: Types.JobsRecord, value: Types.NodeId) =
            { state with NodeId = Some value }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: Types.JobsRecord, value: string) =
            { state with NodeName = Some value }

        [<CustomOperation("nodeEphemeralId")>]
        member _.NodeEphemeralId(state: Types.JobsRecord, value: Types.NodeId) =
            { state with NodeEphemeralId = Some value }

        [<CustomOperation("nodeAddress")>]
        member _.NodeAddress(state: Types.JobsRecord, value: string) =
            { state with NodeAddress = Some value }

        [<CustomOperation("bucketsCount")>]
        member _.BucketsCount(state: Types.JobsRecord, value: string) =
            { state with BucketsCount = Some value }

        [<CustomOperation("bucketsTimeTotal")>]
        member _.BucketsTimeTotal(state: Types.JobsRecord, value: string) =
            { state with BucketsTimeTotal = Some value }

        [<CustomOperation("bucketsTimeMin")>]
        member _.BucketsTimeMin(state: Types.JobsRecord, value: string) =
            { state with BucketsTimeMin = Some value }

        [<CustomOperation("bucketsTimeMax")>]
        member _.BucketsTimeMax(state: Types.JobsRecord, value: string) =
            { state with BucketsTimeMax = Some value }

        [<CustomOperation("bucketsTimeExpAvg")>]
        member _.BucketsTimeExpAvg(state: Types.JobsRecord, value: string) =
            { state with BucketsTimeExpAvg = Some value }

        [<CustomOperation("bucketsTimeExpAvgHour")>]
        member _.BucketsTimeExpAvgHour(state: Types.JobsRecord, value: string) =
            { state with BucketsTimeExpAvgHour = Some value }

    let jobsRecord = JobsRecordBuilder()


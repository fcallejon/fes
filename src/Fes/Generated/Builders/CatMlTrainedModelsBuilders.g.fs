// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatMlTrainedModelsBuilders =

    type TrainedModelsRecordBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelsRecord =
            {
                Id = None
                CreatedBy = None
                HeapSize = None
                Operations = None
                License = None
                CreateTime = None
                Version = None
                Description = None
                IngestPipelines = None
                IngestCount = None
                IngestTime = None
                IngestCurrent = None
                IngestFailed = None
                DataFrameId = None
                DataFrameCreateTime = None
                DataFrameSourceIndex = None
                DataFrameAnalysis = None
                Type = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.TrainedModelsRecord, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("createdBy")>]
        member _.CreatedBy(state: Types.TrainedModelsRecord, value: string) =
            { state with CreatedBy = Some value }

        [<CustomOperation("heapSize")>]
        member _.HeapSize(state: Types.TrainedModelsRecord, value: Types.ByteSize) =
            { state with HeapSize = Some value }

        [<CustomOperation("operations")>]
        member _.Operations(state: Types.TrainedModelsRecord, value: string) =
            { state with Operations = Some value }

        [<CustomOperation("license")>]
        member _.License(state: Types.TrainedModelsRecord, value: string) =
            { state with License = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: Types.TrainedModelsRecord, value: Types.DateTime) =
            { state with CreateTime = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.TrainedModelsRecord, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.TrainedModelsRecord, value: string) =
            { state with Description = Some value }

        [<CustomOperation("ingestPipelines")>]
        member _.IngestPipelines(state: Types.TrainedModelsRecord, value: string) =
            { state with IngestPipelines = Some value }

        [<CustomOperation("ingestCount")>]
        member _.IngestCount(state: Types.TrainedModelsRecord, value: string) =
            { state with IngestCount = Some value }

        [<CustomOperation("ingestTime")>]
        member _.IngestTime(state: Types.TrainedModelsRecord, value: string) =
            { state with IngestTime = Some value }

        [<CustomOperation("ingestCurrent")>]
        member _.IngestCurrent(state: Types.TrainedModelsRecord, value: string) =
            { state with IngestCurrent = Some value }

        [<CustomOperation("ingestFailed")>]
        member _.IngestFailed(state: Types.TrainedModelsRecord, value: string) =
            { state with IngestFailed = Some value }

        [<CustomOperation("dataFrameId")>]
        member _.DataFrameId(state: Types.TrainedModelsRecord, value: string) =
            { state with DataFrameId = Some value }

        [<CustomOperation("dataFrameCreateTime")>]
        member _.DataFrameCreateTime(state: Types.TrainedModelsRecord, value: string) =
            { state with DataFrameCreateTime = Some value }

        [<CustomOperation("dataFrameSourceIndex")>]
        member _.DataFrameSourceIndex(state: Types.TrainedModelsRecord, value: string) =
            { state with DataFrameSourceIndex = Some value }

        [<CustomOperation("dataFrameAnalysis")>]
        member _.DataFrameAnalysis(state: Types.TrainedModelsRecord, value: string) =
            { state with DataFrameAnalysis = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.TrainedModelsRecord, value: string) =
            { state with Type = Some value }

    let trainedModelsRecord = TrainedModelsRecordBuilder()


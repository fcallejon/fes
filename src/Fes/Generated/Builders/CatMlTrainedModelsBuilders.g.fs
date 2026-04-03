// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatMlTrainedModelsBuilders =

    type TrainedModelsRecordBuilder() =
        member _.Yield(_: unit) : TrainedModelsRecord =
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
        member _.Id(state: TrainedModelsRecord, value: CoreTypes.Id) =
            { state with Id = Some value }

        [<CustomOperation("createdBy")>]
        member _.CreatedBy(state: TrainedModelsRecord, value: string) =
            { state with CreatedBy = Some value }

        [<CustomOperation("heapSize")>]
        member _.HeapSize(state: TrainedModelsRecord, value: CoreTypes.ByteSize) =
            { state with HeapSize = Some value }

        [<CustomOperation("operations")>]
        member _.Operations(state: TrainedModelsRecord, value: string) =
            { state with Operations = Some value }

        [<CustomOperation("license")>]
        member _.License(state: TrainedModelsRecord, value: string) =
            { state with License = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: TrainedModelsRecord, value: CoreTypes.DateTime) =
            { state with CreateTime = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TrainedModelsRecord, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: TrainedModelsRecord, value: string) =
            { state with Description = Some value }

        [<CustomOperation("ingestPipelines")>]
        member _.IngestPipelines(state: TrainedModelsRecord, value: string) =
            { state with IngestPipelines = Some value }

        [<CustomOperation("ingestCount")>]
        member _.IngestCount(state: TrainedModelsRecord, value: string) =
            { state with IngestCount = Some value }

        [<CustomOperation("ingestTime")>]
        member _.IngestTime(state: TrainedModelsRecord, value: string) =
            { state with IngestTime = Some value }

        [<CustomOperation("ingestCurrent")>]
        member _.IngestCurrent(state: TrainedModelsRecord, value: string) =
            { state with IngestCurrent = Some value }

        [<CustomOperation("ingestFailed")>]
        member _.IngestFailed(state: TrainedModelsRecord, value: string) =
            { state with IngestFailed = Some value }

        [<CustomOperation("dataFrameId")>]
        member _.DataFrameId(state: TrainedModelsRecord, value: string) =
            { state with DataFrameId = Some value }

        [<CustomOperation("dataFrameCreateTime")>]
        member _.DataFrameCreateTime(state: TrainedModelsRecord, value: string) =
            { state with DataFrameCreateTime = Some value }

        [<CustomOperation("dataFrameSourceIndex")>]
        member _.DataFrameSourceIndex(state: TrainedModelsRecord, value: string) =
            { state with DataFrameSourceIndex = Some value }

        [<CustomOperation("dataFrameAnalysis")>]
        member _.DataFrameAnalysis(state: TrainedModelsRecord, value: string) =
            { state with DataFrameAnalysis = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: TrainedModelsRecord, value: string) =
            { state with Type = Some value }

    let trainedModelsRecord = TrainedModelsRecordBuilder()


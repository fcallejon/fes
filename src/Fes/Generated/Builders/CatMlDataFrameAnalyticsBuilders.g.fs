// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatMlDataFrameAnalyticsBuilders =

    type DataFrameAnalyticsRecordBuilder() =
        member _.Yield(_: unit) : DataFrameAnalyticsRecord =
            {
                Id = None
                Type = None
                CreateTime = None
                Version = None
                SourceIndex = None
                DestIndex = None
                Description = None
                ModelMemoryLimit = None
                State = None
                FailureReason = None
                Progress = None
                AssignmentExplanation = None
                NodeId = None
                NodeName = None
                NodeEphemeralId = None
                NodeAddress = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: DataFrameAnalyticsRecord, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: DataFrameAnalyticsRecord, value: string) =
            { state with Type = Some value }

        [<CustomOperation("createTime")>]
        member _.CreateTime(state: DataFrameAnalyticsRecord, value: string) =
            { state with CreateTime = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: DataFrameAnalyticsRecord, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("sourceIndex")>]
        member _.SourceIndex(state: DataFrameAnalyticsRecord, value: Types.IndexName) =
            { state with SourceIndex = Some value }

        [<CustomOperation("destIndex")>]
        member _.DestIndex(state: DataFrameAnalyticsRecord, value: Types.IndexName) =
            { state with DestIndex = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: DataFrameAnalyticsRecord, value: string) =
            { state with Description = Some value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: DataFrameAnalyticsRecord, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("state")>]
        member _.State(state: DataFrameAnalyticsRecord, value: string) =
            { state with State = Some value }

        [<CustomOperation("failureReason")>]
        member _.FailureReason(state: DataFrameAnalyticsRecord, value: string) =
            { state with FailureReason = Some value }

        [<CustomOperation("progress")>]
        member _.Progress(state: DataFrameAnalyticsRecord, value: string) =
            { state with Progress = Some value }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: DataFrameAnalyticsRecord, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: DataFrameAnalyticsRecord, value: Types.Id) =
            { state with NodeId = Some value }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: DataFrameAnalyticsRecord, value: Types.Name) =
            { state with NodeName = Some value }

        [<CustomOperation("nodeEphemeralId")>]
        member _.NodeEphemeralId(state: DataFrameAnalyticsRecord, value: Types.Id) =
            { state with NodeEphemeralId = Some value }

        [<CustomOperation("nodeAddress")>]
        member _.NodeAddress(state: DataFrameAnalyticsRecord, value: string) =
            { state with NodeAddress = Some value }

    let dataFrameAnalyticsRecord = DataFrameAnalyticsRecordBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatMlDatafeedsBuilders =

    type DatafeedsRecordBuilder() =
        member _.Yield(_: unit) : DatafeedsRecord =
            {
                Id = None
                State = None
                AssignmentExplanation = None
                BucketsCount = None
                SearchCount = None
                SearchTime = None
                SearchBucketAvg = None
                SearchExpAvgHour = None
                NodeId = None
                NodeName = None
                NodeEphemeralId = None
                NodeAddress = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: DatafeedsRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("state")>]
        member _.State(state: DatafeedsRecord, value: MlTypes.DatafeedState) =
            { state with State = Some value }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: DatafeedsRecord, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("bucketsCount")>]
        member _.BucketsCount(state: DatafeedsRecord, value: string) =
            { state with BucketsCount = Some value }

        [<CustomOperation("searchCount")>]
        member _.SearchCount(state: DatafeedsRecord, value: string) =
            { state with SearchCount = Some value }

        [<CustomOperation("searchTime")>]
        member _.SearchTime(state: DatafeedsRecord, value: string) =
            { state with SearchTime = Some value }

        [<CustomOperation("searchBucketAvg")>]
        member _.SearchBucketAvg(state: DatafeedsRecord, value: string) =
            { state with SearchBucketAvg = Some value }

        [<CustomOperation("searchExpAvgHour")>]
        member _.SearchExpAvgHour(state: DatafeedsRecord, value: string) =
            { state with SearchExpAvgHour = Some value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: DatafeedsRecord, value: string) =
            { state with NodeId = Some value }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: DatafeedsRecord, value: string) =
            { state with NodeName = Some value }

        [<CustomOperation("nodeEphemeralId")>]
        member _.NodeEphemeralId(state: DatafeedsRecord, value: string) =
            { state with NodeEphemeralId = Some value }

        [<CustomOperation("nodeAddress")>]
        member _.NodeAddress(state: DatafeedsRecord, value: string) =
            { state with NodeAddress = Some value }

    let datafeedsRecord = DatafeedsRecordBuilder()


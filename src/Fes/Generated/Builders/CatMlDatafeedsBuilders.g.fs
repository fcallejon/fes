// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatMlDatafeedsBuilders =

    type DatafeedsRecordBuilder() =
        member _.Yield(_: unit) : Types.DatafeedsRecord =
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
        member _.Id(state: Types.DatafeedsRecord, value: string) =
            { state with Id = Some value }

        [<CustomOperation("state")>]
        member _.State(state: Types.DatafeedsRecord, value: Types.DatafeedState) =
            { state with State = Some value }

        [<CustomOperation("assignmentExplanation")>]
        member _.AssignmentExplanation(state: Types.DatafeedsRecord, value: string) =
            { state with AssignmentExplanation = Some value }

        [<CustomOperation("bucketsCount")>]
        member _.BucketsCount(state: Types.DatafeedsRecord, value: string) =
            { state with BucketsCount = Some value }

        [<CustomOperation("searchCount")>]
        member _.SearchCount(state: Types.DatafeedsRecord, value: string) =
            { state with SearchCount = Some value }

        [<CustomOperation("searchTime")>]
        member _.SearchTime(state: Types.DatafeedsRecord, value: string) =
            { state with SearchTime = Some value }

        [<CustomOperation("searchBucketAvg")>]
        member _.SearchBucketAvg(state: Types.DatafeedsRecord, value: string) =
            { state with SearchBucketAvg = Some value }

        [<CustomOperation("searchExpAvgHour")>]
        member _.SearchExpAvgHour(state: Types.DatafeedsRecord, value: string) =
            { state with SearchExpAvgHour = Some value }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: Types.DatafeedsRecord, value: string) =
            { state with NodeId = Some value }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: Types.DatafeedsRecord, value: string) =
            { state with NodeName = Some value }

        [<CustomOperation("nodeEphemeralId")>]
        member _.NodeEphemeralId(state: Types.DatafeedsRecord, value: string) =
            { state with NodeEphemeralId = Some value }

        [<CustomOperation("nodeAddress")>]
        member _.NodeAddress(state: Types.DatafeedsRecord, value: string) =
            { state with NodeAddress = Some value }

    let datafeedsRecord = DatafeedsRecordBuilder()


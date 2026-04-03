// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatMlDatafeeds =

    type DatafeedsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: string option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: MlTypes.DatafeedState option
        [<System.Text.Json.Serialization.JsonPropertyName("assignment_explanation")>]
        AssignmentExplanation: string option
        [<System.Text.Json.Serialization.JsonPropertyName("buckets.count")>]
        BucketsCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.count")>]
        SearchCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.time")>]
        SearchTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.bucket_avg")>]
        SearchBucketAvg: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search.exp_avg_hour")>]
        SearchExpAvgHour: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.id")>]
        NodeId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.name")>]
        NodeName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.ephemeral_id")>]
        NodeEphemeralId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("node.address")>]
        NodeAddress: string option
    }


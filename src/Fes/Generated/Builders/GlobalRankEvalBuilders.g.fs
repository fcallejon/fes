// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module GlobalRankEvalBuilders =

    type RankEvalMetricBuilder() =
        member _.Yield(_: unit) : Types.RankEvalMetric =
            {
                Precision = None
                Recall = None
                MeanReciprocalRank = None
                Dcg = None
                ExpectedReciprocalRank = None
            }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.RankEvalMetric, value: Types.RankEvalMetricPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: Types.RankEvalMetric, value: Types.RankEvalMetricRecall) =
            { state with Recall = Some value }

        [<CustomOperation("meanReciprocalRank")>]
        member _.MeanReciprocalRank(state: Types.RankEvalMetric, value: Types.RankEvalMetricMeanReciprocalRank) =
            { state with MeanReciprocalRank = Some value }

        [<CustomOperation("dcg")>]
        member _.Dcg(state: Types.RankEvalMetric, value: Types.RankEvalMetricDiscountedCumulativeGain) =
            { state with Dcg = Some value }

        [<CustomOperation("expectedReciprocalRank")>]
        member _.ExpectedReciprocalRank(state: Types.RankEvalMetric, value: Types.RankEvalMetricExpectedReciprocalRank) =
            { state with ExpectedReciprocalRank = Some value }

    let rankEvalMetric = RankEvalMetricBuilder()

    type RankEvalMetricDiscountedCumulativeGainBuilder() =
        member _.Yield(_: unit) : Types.RankEvalMetricDiscountedCumulativeGain =
            {
                Normalize = None
                K = None
            }

        [<CustomOperation("normalize")>]
        member _.Normalize(state: Types.RankEvalMetricDiscountedCumulativeGain, value: bool) =
            { state with Normalize = Some value }

        [<CustomOperation("k")>]
        member _.K(state: Types.RankEvalMetricDiscountedCumulativeGain, value: Types.Integer) =
            { state with K = Some value }

    let rankEvalMetricDiscountedCumulativeGain = RankEvalMetricDiscountedCumulativeGainBuilder()

    type RankEvalMetricMeanReciprocalRankBuilder() =
        member _.Yield(_: unit) : Types.RankEvalMetricMeanReciprocalRank =
            {
                K = None
                RelevantRatingThreshold = None
            }

        [<CustomOperation("k")>]
        member _.K(state: Types.RankEvalMetricMeanReciprocalRank, value: Types.Integer) =
            { state with K = Some value }

        [<CustomOperation("relevantRatingThreshold")>]
        member _.RelevantRatingThreshold(state: Types.RankEvalMetricMeanReciprocalRank, value: Types.Integer) =
            { state with RelevantRatingThreshold = Some value }

    let rankEvalMetricMeanReciprocalRank = RankEvalMetricMeanReciprocalRankBuilder()

    type RankEvalMetricPrecisionBuilder() =
        member _.Yield(_: unit) : Types.RankEvalMetricPrecision =
            {
                IgnoreUnlabeled = None
                K = None
                RelevantRatingThreshold = None
            }

        [<CustomOperation("ignoreUnlabeled")>]
        member _.IgnoreUnlabeled(state: Types.RankEvalMetricPrecision, value: bool) =
            { state with IgnoreUnlabeled = Some value }

        [<CustomOperation("k")>]
        member _.K(state: Types.RankEvalMetricPrecision, value: Types.Integer) =
            { state with K = Some value }

        [<CustomOperation("relevantRatingThreshold")>]
        member _.RelevantRatingThreshold(state: Types.RankEvalMetricPrecision, value: Types.Integer) =
            { state with RelevantRatingThreshold = Some value }

    let rankEvalMetricPrecision = RankEvalMetricPrecisionBuilder()

    type RankEvalMetricRatingTresholdBuilder() =
        member _.Yield(_: unit) : Types.RankEvalMetricRatingTreshold =
            {
                RelevantRatingThreshold = None
                K = None
            }

        [<CustomOperation("relevantRatingThreshold")>]
        member _.RelevantRatingThreshold(state: Types.RankEvalMetricRatingTreshold, value: Types.Integer) =
            { state with RelevantRatingThreshold = Some value }

        [<CustomOperation("k")>]
        member _.K(state: Types.RankEvalMetricRatingTreshold, value: Types.Integer) =
            { state with K = Some value }

    let rankEvalMetricRatingTreshold = RankEvalMetricRatingTresholdBuilder()

    type RankEvalMetricRecallBuilder() =
        member _.Yield(_: unit) : Types.RankEvalMetricRecall =
            {
                K = None
                RelevantRatingThreshold = None
            }

        [<CustomOperation("k")>]
        member _.K(state: Types.RankEvalMetricRecall, value: Types.Integer) =
            { state with K = Some value }

        [<CustomOperation("relevantRatingThreshold")>]
        member _.RelevantRatingThreshold(state: Types.RankEvalMetricRecall, value: Types.Integer) =
            { state with RelevantRatingThreshold = Some value }

    let rankEvalMetricRecall = RankEvalMetricRecallBuilder()

    type RankEvalRequestItemBuilder() =
        member _.Yield(_: unit) : Types.RankEvalRequestItem =
            {
                Id = Unchecked.defaultof<_>
                Request = None
                Ratings = Unchecked.defaultof<_>
                TemplateId = None
                Params = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.RankEvalRequestItem, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("request")>]
        member _.Request(state: Types.RankEvalRequestItem, value: Types.RankEvalQuery) =
            { state with Request = Some value }

        [<CustomOperation("ratings")>]
        member _.Ratings(state: Types.RankEvalRequestItem, value: Types.DocumentRating list) =
            { state with Ratings = value }

        [<CustomOperation("templateId")>]
        member _.TemplateId(state: Types.RankEvalRequestItem, value: Types.Id) =
            { state with TemplateId = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: Types.RankEvalRequestItem, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

    let rankEvalRequestItem = RankEvalRequestItemBuilder()


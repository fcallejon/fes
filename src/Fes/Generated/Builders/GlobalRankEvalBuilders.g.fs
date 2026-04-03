// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalRankEvalBuilders =

    type RankEvalMetricBuilder() =
        member _.Yield(_: unit) : RankEvalMetric =
            {
                Precision = None
                Recall = None
                MeanReciprocalRank = None
                Dcg = None
                ExpectedReciprocalRank = None
            }

        [<CustomOperation("precision")>]
        member _.Precision(state: RankEvalMetric, value: GlobalRankEval.RankEvalMetricPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: RankEvalMetric, value: GlobalRankEval.RankEvalMetricRecall) =
            { state with Recall = Some value }

        [<CustomOperation("meanReciprocalRank")>]
        member _.MeanReciprocalRank(state: RankEvalMetric, value: GlobalRankEval.RankEvalMetricMeanReciprocalRank) =
            { state with MeanReciprocalRank = Some value }

        [<CustomOperation("dcg")>]
        member _.Dcg(state: RankEvalMetric, value: GlobalRankEval.RankEvalMetricDiscountedCumulativeGain) =
            { state with Dcg = Some value }

        [<CustomOperation("expectedReciprocalRank")>]
        member _.ExpectedReciprocalRank(state: RankEvalMetric, value: GlobalRankEval.RankEvalMetricExpectedReciprocalRank) =
            { state with ExpectedReciprocalRank = Some value }

    let rankEvalMetric = RankEvalMetricBuilder()

    type RankEvalRequestItemBuilder() =
        member _.Yield(_: unit) : RankEvalRequestItem =
            {
                Id = Unchecked.defaultof<_>
                Request = None
                Ratings = Unchecked.defaultof<_>
                TemplateId = None
                Params = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: RankEvalRequestItem, value: Types.Id) =
            { state with Id = value }

        [<CustomOperation("request")>]
        member _.Request(state: RankEvalRequestItem, value: GlobalRankEval.RankEvalQuery) =
            { state with Request = Some value }

        [<CustomOperation("ratings")>]
        member _.Ratings(state: RankEvalRequestItem, value: GlobalRankEval.DocumentRating list) =
            { state with Ratings = value }

        [<CustomOperation("templateId")>]
        member _.TemplateId(state: RankEvalRequestItem, value: Types.Id) =
            { state with TemplateId = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: RankEvalRequestItem, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

    let rankEvalRequestItem = RankEvalRequestItemBuilder()


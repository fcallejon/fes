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


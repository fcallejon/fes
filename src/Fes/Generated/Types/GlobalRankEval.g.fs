// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalRankEval =

    type DocumentRating = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("rating")>]
        Rating: Types.Integer
    }

    type RankEvalHit = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_score")>]
        Score: Types.Double
    }

    type RankEvalHitItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("hit")>]
        Hit: GlobalRankEval.RankEvalHit
        [<System.Text.Json.Serialization.JsonPropertyName("rating")>]
        Rating: Types.Double option option
    }

    type RankEvalMetricBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: Types.Integer option
    }

    type RankEvalMetricRatingTreshold = {
        [<System.Text.Json.Serialization.JsonPropertyName("relevant_rating_threshold")>]
        RelevantRatingThreshold: Types.Integer option
    }

    /// Precision at K (P@k)
    type RankEvalMetricPrecision = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unlabeled")>]
        IgnoreUnlabeled: bool option
    }

    /// Recall at K (R@k)
    type RankEvalMetricRecall = {
    }

    /// Mean Reciprocal Rank
    type RankEvalMetricMeanReciprocalRank = {
    }

    /// Discounted cumulative gain (DCG)
    type RankEvalMetricDiscountedCumulativeGain = {
        [<System.Text.Json.Serialization.JsonPropertyName("normalize")>]
        Normalize: bool option
    }

    /// Expected Reciprocal Rank (ERR)
    type RankEvalMetricExpectedReciprocalRank = {
        [<System.Text.Json.Serialization.JsonPropertyName("maximum_relevance")>]
        MaximumRelevance: Types.Integer
    }

    type RankEvalMetric = {
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: GlobalRankEval.RankEvalMetricPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("recall")>]
        Recall: GlobalRankEval.RankEvalMetricRecall option
        [<System.Text.Json.Serialization.JsonPropertyName("mean_reciprocal_rank")>]
        MeanReciprocalRank: GlobalRankEval.RankEvalMetricMeanReciprocalRank option
        [<System.Text.Json.Serialization.JsonPropertyName("dcg")>]
        Dcg: GlobalRankEval.RankEvalMetricDiscountedCumulativeGain option
        [<System.Text.Json.Serialization.JsonPropertyName("expected_reciprocal_rank")>]
        ExpectedReciprocalRank: GlobalRankEval.RankEvalMetricExpectedReciprocalRank option
    }

    type UnratedDocument = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
    }

    type RankEvalMetricDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("metric_score")>]
        MetricScore: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("unrated_docs")>]
        UnratedDocs: GlobalRankEval.UnratedDocument list
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: GlobalRankEval.RankEvalHitItem list
        [<System.Text.Json.Serialization.JsonPropertyName("metric_details")>]
        MetricDetails: Map<string, Map<string, System.Text.Json.JsonElement>>
    }

    type RankEvalQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: TypesQueryDsl.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: Types.Integer option
    }

    type RankEvalRequestItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: GlobalRankEval.RankEvalQuery option
        [<System.Text.Json.Serialization.JsonPropertyName("ratings")>]
        Ratings: GlobalRankEval.DocumentRating list
        [<System.Text.Json.Serialization.JsonPropertyName("template_id")>]
        TemplateId: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
    }


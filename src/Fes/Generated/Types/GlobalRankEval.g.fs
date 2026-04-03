// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalRankEval =

    type DocumentRating = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("rating")>]
        Rating: CoreTypes.Integer
    }

    type RankEvalHit = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_score")>]
        Score: CoreTypes.Double
    }

    type RankEvalHitItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("hit")>]
        Hit: RankEvalHit
        [<System.Text.Json.Serialization.JsonPropertyName("rating")>]
        Rating: CoreTypes.Double option option
    }

    type RankEvalMetricBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("k")>]
        K: CoreTypes.Integer option
    }

    type RankEvalMetricRatingTreshold = {
        [<System.Text.Json.Serialization.JsonPropertyName("relevant_rating_threshold")>]
        RelevantRatingThreshold: CoreTypes.Integer option
    }

    /// Precision at K (P@k)
    type RankEvalMetricPrecision = {
        [<System.Text.Json.Serialization.JsonPropertyName("ignore_unlabeled")>]
        IgnoreUnlabeled: bool option
    }

    /// Recall at K (R@k)
    type RankEvalMetricRecall = System.Text.Json.JsonElement

    /// Mean Reciprocal Rank
    type RankEvalMetricMeanReciprocalRank = System.Text.Json.JsonElement

    /// Discounted cumulative gain (DCG)
    type RankEvalMetricDiscountedCumulativeGain = {
        [<System.Text.Json.Serialization.JsonPropertyName("normalize")>]
        Normalize: bool option
    }

    /// Expected Reciprocal Rank (ERR)
    type RankEvalMetricExpectedReciprocalRank = {
        [<System.Text.Json.Serialization.JsonPropertyName("maximum_relevance")>]
        MaximumRelevance: CoreTypes.Integer
    }

    type RankEvalMetric = {
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: RankEvalMetricPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("recall")>]
        Recall: RankEvalMetricRecall option
        [<System.Text.Json.Serialization.JsonPropertyName("mean_reciprocal_rank")>]
        MeanReciprocalRank: RankEvalMetricMeanReciprocalRank option
        [<System.Text.Json.Serialization.JsonPropertyName("dcg")>]
        Dcg: RankEvalMetricDiscountedCumulativeGain option
        [<System.Text.Json.Serialization.JsonPropertyName("expected_reciprocal_rank")>]
        ExpectedReciprocalRank: RankEvalMetricExpectedReciprocalRank option
    }

    type UnratedDocument = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName
    }

    type RankEvalMetricDetail = {
        [<System.Text.Json.Serialization.JsonPropertyName("metric_score")>]
        MetricScore: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("unrated_docs")>]
        UnratedDocs: UnratedDocument list
        [<System.Text.Json.Serialization.JsonPropertyName("hits")>]
        Hits: RankEvalHitItem list
        [<System.Text.Json.Serialization.JsonPropertyName("metric_details")>]
        MetricDetails: Map<string, Map<string, System.Text.Json.JsonElement>>
    }

    type RankEvalQuery = {
        [<System.Text.Json.Serialization.JsonPropertyName("query")>]
        Query: CoreTypes.QueryContainer
        [<System.Text.Json.Serialization.JsonPropertyName("size")>]
        Size: CoreTypes.Integer option
    }

    type RankEvalRequestItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("request")>]
        Request: RankEvalQuery option
        [<System.Text.Json.Serialization.JsonPropertyName("ratings")>]
        Ratings: DocumentRating list
        [<System.Text.Json.Serialization.JsonPropertyName("template_id")>]
        TemplateId: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("params")>]
        Params: Map<string, System.Text.Json.JsonElement> option
    }


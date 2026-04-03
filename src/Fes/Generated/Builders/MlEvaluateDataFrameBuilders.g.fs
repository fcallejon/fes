// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module MlEvaluateDataFrameBuilders =

    type DataframeClassificationSummaryBuilder() =
        member _.Yield(_: unit) : Types.DataframeClassificationSummary =
            {
                AucRoc = None
                Accuracy = None
                MulticlassConfusionMatrix = None
                Precision = None
                Recall = None
            }

        [<CustomOperation("aucRoc")>]
        member _.AucRoc(state: Types.DataframeClassificationSummary, value: Types.DataframeEvaluationSummaryAucRoc) =
            { state with AucRoc = Some value }

        [<CustomOperation("accuracy")>]
        member _.Accuracy(state: Types.DataframeClassificationSummary, value: Types.DataframeClassificationSummaryAccuracy) =
            { state with Accuracy = Some value }

        [<CustomOperation("multiclassConfusionMatrix")>]
        member _.MulticlassConfusionMatrix(state: Types.DataframeClassificationSummary, value: Types.DataframeClassificationSummaryMulticlassConfusionMatrix) =
            { state with MulticlassConfusionMatrix = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.DataframeClassificationSummary, value: Types.DataframeClassificationSummaryPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: Types.DataframeClassificationSummary, value: Types.DataframeClassificationSummaryRecall) =
            { state with Recall = Some value }

    let dataframeClassificationSummary = DataframeClassificationSummaryBuilder()

    type DataframeOutlierDetectionSummaryBuilder() =
        member _.Yield(_: unit) : Types.DataframeOutlierDetectionSummary =
            {
                AucRoc = None
                Precision = None
                Recall = None
                ConfusionMatrix = None
            }

        [<CustomOperation("aucRoc")>]
        member _.AucRoc(state: Types.DataframeOutlierDetectionSummary, value: Types.DataframeEvaluationSummaryAucRoc) =
            { state with AucRoc = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: Types.DataframeOutlierDetectionSummary, value: Map<string, Types.Double>) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: Types.DataframeOutlierDetectionSummary, value: Map<string, Types.Double>) =
            { state with Recall = Some value }

        [<CustomOperation("confusionMatrix")>]
        member _.ConfusionMatrix(state: Types.DataframeOutlierDetectionSummary, value: Map<string, Types.ConfusionMatrixThreshold>) =
            { state with ConfusionMatrix = Some value }

    let dataframeOutlierDetectionSummary = DataframeOutlierDetectionSummaryBuilder()

    type DataframeRegressionSummaryBuilder() =
        member _.Yield(_: unit) : Types.DataframeRegressionSummary =
            {
                Huber = None
                Mse = None
                Msle = None
                RSquared = None
            }

        [<CustomOperation("huber")>]
        member _.Huber(state: Types.DataframeRegressionSummary, value: Types.DataframeEvaluationValue) =
            { state with Huber = Some value }

        [<CustomOperation("mse")>]
        member _.Mse(state: Types.DataframeRegressionSummary, value: Types.DataframeEvaluationValue) =
            { state with Mse = Some value }

        [<CustomOperation("msle")>]
        member _.Msle(state: Types.DataframeRegressionSummary, value: Types.DataframeEvaluationValue) =
            { state with Msle = Some value }

        [<CustomOperation("rSquared")>]
        member _.RSquared(state: Types.DataframeRegressionSummary, value: Types.DataframeEvaluationValue) =
            { state with RSquared = Some value }

    let dataframeRegressionSummary = DataframeRegressionSummaryBuilder()


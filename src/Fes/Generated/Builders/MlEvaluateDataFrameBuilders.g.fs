// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module MlEvaluateDataFrameBuilders =

    type DataframeClassificationSummaryBuilder() =
        member _.Yield(_: unit) : DataframeClassificationSummary =
            {
                AucRoc = None
                Accuracy = None
                MulticlassConfusionMatrix = None
                Precision = None
                Recall = None
            }

        [<CustomOperation("aucRoc")>]
        member _.AucRoc(state: DataframeClassificationSummary, value: MlEvaluateDataFrame.DataframeEvaluationSummaryAucRoc) =
            { state with AucRoc = Some value }

        [<CustomOperation("accuracy")>]
        member _.Accuracy(state: DataframeClassificationSummary, value: MlEvaluateDataFrame.DataframeClassificationSummaryAccuracy) =
            { state with Accuracy = Some value }

        [<CustomOperation("multiclassConfusionMatrix")>]
        member _.MulticlassConfusionMatrix(state: DataframeClassificationSummary, value: MlEvaluateDataFrame.DataframeClassificationSummaryMulticlassConfusionMatrix) =
            { state with MulticlassConfusionMatrix = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: DataframeClassificationSummary, value: MlEvaluateDataFrame.DataframeClassificationSummaryPrecision) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: DataframeClassificationSummary, value: MlEvaluateDataFrame.DataframeClassificationSummaryRecall) =
            { state with Recall = Some value }

    let dataframeClassificationSummary = DataframeClassificationSummaryBuilder()

    type DataframeOutlierDetectionSummaryBuilder() =
        member _.Yield(_: unit) : DataframeOutlierDetectionSummary =
            {
                AucRoc = None
                Precision = None
                Recall = None
                ConfusionMatrix = None
            }

        [<CustomOperation("aucRoc")>]
        member _.AucRoc(state: DataframeOutlierDetectionSummary, value: MlEvaluateDataFrame.DataframeEvaluationSummaryAucRoc) =
            { state with AucRoc = Some value }

        [<CustomOperation("precision")>]
        member _.Precision(state: DataframeOutlierDetectionSummary, value: Map<string, CoreTypes.Double>) =
            { state with Precision = Some value }

        [<CustomOperation("recall")>]
        member _.Recall(state: DataframeOutlierDetectionSummary, value: Map<string, CoreTypes.Double>) =
            { state with Recall = Some value }

        [<CustomOperation("confusionMatrix")>]
        member _.ConfusionMatrix(state: DataframeOutlierDetectionSummary, value: Map<string, MlEvaluateDataFrame.ConfusionMatrixThreshold>) =
            { state with ConfusionMatrix = Some value }

    let dataframeOutlierDetectionSummary = DataframeOutlierDetectionSummaryBuilder()

    type DataframeRegressionSummaryBuilder() =
        member _.Yield(_: unit) : DataframeRegressionSummary =
            {
                Huber = None
                Mse = None
                Msle = None
                RSquared = None
            }

        [<CustomOperation("huber")>]
        member _.Huber(state: DataframeRegressionSummary, value: MlEvaluateDataFrame.DataframeEvaluationValue) =
            { state with Huber = Some value }

        [<CustomOperation("mse")>]
        member _.Mse(state: DataframeRegressionSummary, value: MlEvaluateDataFrame.DataframeEvaluationValue) =
            { state with Mse = Some value }

        [<CustomOperation("msle")>]
        member _.Msle(state: DataframeRegressionSummary, value: MlEvaluateDataFrame.DataframeEvaluationValue) =
            { state with Msle = Some value }

        [<CustomOperation("rSquared")>]
        member _.RSquared(state: DataframeRegressionSummary, value: MlEvaluateDataFrame.DataframeEvaluationValue) =
            { state with RSquared = Some value }

    let dataframeRegressionSummary = DataframeRegressionSummaryBuilder()


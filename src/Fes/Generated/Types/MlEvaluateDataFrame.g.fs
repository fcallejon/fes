// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlEvaluateDataFrame =

    type ConfusionMatrixPrediction = {
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_class")>]
        PredictedClass: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Integer
    }

    type ConfusionMatrixItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_class")>]
        ActualClass: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("actual_class_doc_count")>]
        ActualClassDocCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_classes")>]
        PredictedClasses: MlEvaluateDataFrame.ConfusionMatrixPrediction list
        [<System.Text.Json.Serialization.JsonPropertyName("other_predicted_class_doc_count")>]
        OtherPredictedClassDocCount: Types.Integer
    }

    type ConfusionMatrixThreshold = {
        [<System.Text.Json.Serialization.JsonPropertyName("tp")>]
        Tp: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("fp")>]
        Fp: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("tn")>]
        Tn: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("fn")>]
        Fn: Types.Integer
    }

    type DataframeEvaluationSummaryAucRocCurveItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("tpr")>]
        Tpr: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("fpr")>]
        Fpr: Types.Double
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: Types.Double
    }

    type DataframeEvaluationValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: Types.Double
    }

    type DataframeEvaluationSummaryAucRoc = {
        [<System.Text.Json.Serialization.JsonPropertyName("curve")>]
        Curve: MlEvaluateDataFrame.DataframeEvaluationSummaryAucRocCurveItem list option
    }

    type DataframeEvaluationClass = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: Types.Name
    }

    type DataframeClassificationSummaryAccuracy = {
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: MlEvaluateDataFrame.DataframeEvaluationClass list
        [<System.Text.Json.Serialization.JsonPropertyName("overall_accuracy")>]
        OverallAccuracy: Types.Double
    }

    type DataframeClassificationSummaryMulticlassConfusionMatrix = {
        [<System.Text.Json.Serialization.JsonPropertyName("confusion_matrix")>]
        ConfusionMatrix: MlEvaluateDataFrame.ConfusionMatrixItem list
        [<System.Text.Json.Serialization.JsonPropertyName("other_actual_class_count")>]
        OtherActualClassCount: Types.Integer
    }

    type DataframeClassificationSummaryPrecision = {
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: MlEvaluateDataFrame.DataframeEvaluationClass list
        [<System.Text.Json.Serialization.JsonPropertyName("avg_precision")>]
        AvgPrecision: Types.Double
    }

    type DataframeClassificationSummaryRecall = {
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: MlEvaluateDataFrame.DataframeEvaluationClass list
        [<System.Text.Json.Serialization.JsonPropertyName("avg_recall")>]
        AvgRecall: Types.Double
    }

    type DataframeClassificationSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("auc_roc")>]
        AucRoc: MlEvaluateDataFrame.DataframeEvaluationSummaryAucRoc option
        [<System.Text.Json.Serialization.JsonPropertyName("accuracy")>]
        Accuracy: MlEvaluateDataFrame.DataframeClassificationSummaryAccuracy option
        [<System.Text.Json.Serialization.JsonPropertyName("multiclass_confusion_matrix")>]
        MulticlassConfusionMatrix: MlEvaluateDataFrame.DataframeClassificationSummaryMulticlassConfusionMatrix option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: MlEvaluateDataFrame.DataframeClassificationSummaryPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("recall")>]
        Recall: MlEvaluateDataFrame.DataframeClassificationSummaryRecall option
    }

    type DataframeOutlierDetectionSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("auc_roc")>]
        AucRoc: MlEvaluateDataFrame.DataframeEvaluationSummaryAucRoc option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Map<string, Types.Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("recall")>]
        Recall: Map<string, Types.Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("confusion_matrix")>]
        ConfusionMatrix: Map<string, MlEvaluateDataFrame.ConfusionMatrixThreshold> option
    }

    type DataframeRegressionSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("huber")>]
        Huber: MlEvaluateDataFrame.DataframeEvaluationValue option
        [<System.Text.Json.Serialization.JsonPropertyName("mse")>]
        Mse: MlEvaluateDataFrame.DataframeEvaluationValue option
        [<System.Text.Json.Serialization.JsonPropertyName("msle")>]
        Msle: MlEvaluateDataFrame.DataframeEvaluationValue option
        [<System.Text.Json.Serialization.JsonPropertyName("r_squared")>]
        RSquared: MlEvaluateDataFrame.DataframeEvaluationValue option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlEvaluateDataFrame =

    type ConfusionMatrixPrediction = {
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_class")>]
        PredictedClass: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: CoreTypes.Integer
    }

    type ConfusionMatrixItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("actual_class")>]
        ActualClass: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("actual_class_doc_count")>]
        ActualClassDocCount: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("predicted_classes")>]
        PredictedClasses: ConfusionMatrixPrediction list
        [<System.Text.Json.Serialization.JsonPropertyName("other_predicted_class_doc_count")>]
        OtherPredictedClassDocCount: CoreTypes.Integer
    }

    type ConfusionMatrixThreshold = {
        [<System.Text.Json.Serialization.JsonPropertyName("tp")>]
        Tp: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("fp")>]
        Fp: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("tn")>]
        Tn: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("fn")>]
        Fn: CoreTypes.Integer
    }

    type DataframeEvaluationSummaryAucRocCurveItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("tpr")>]
        Tpr: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("fpr")>]
        Fpr: CoreTypes.Double
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: CoreTypes.Double
    }

    type DataframeEvaluationValue = {
        [<System.Text.Json.Serialization.JsonPropertyName("value")>]
        Value: CoreTypes.Double
    }

    type DataframeEvaluationSummaryAucRoc = {
        [<System.Text.Json.Serialization.JsonPropertyName("curve")>]
        Curve: DataframeEvaluationSummaryAucRocCurveItem list option
    }

    type DataframeEvaluationClass = {
        [<System.Text.Json.Serialization.JsonPropertyName("class_name")>]
        ClassName: CoreTypes.Name
    }

    type DataframeClassificationSummaryAccuracy = {
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: DataframeEvaluationClass list
        [<System.Text.Json.Serialization.JsonPropertyName("overall_accuracy")>]
        OverallAccuracy: CoreTypes.Double
    }

    type DataframeClassificationSummaryMulticlassConfusionMatrix = {
        [<System.Text.Json.Serialization.JsonPropertyName("confusion_matrix")>]
        ConfusionMatrix: ConfusionMatrixItem list
        [<System.Text.Json.Serialization.JsonPropertyName("other_actual_class_count")>]
        OtherActualClassCount: CoreTypes.Integer
    }

    type DataframeClassificationSummaryPrecision = {
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: DataframeEvaluationClass list
        [<System.Text.Json.Serialization.JsonPropertyName("avg_precision")>]
        AvgPrecision: CoreTypes.Double
    }

    type DataframeClassificationSummaryRecall = {
        [<System.Text.Json.Serialization.JsonPropertyName("classes")>]
        Classes: DataframeEvaluationClass list
        [<System.Text.Json.Serialization.JsonPropertyName("avg_recall")>]
        AvgRecall: CoreTypes.Double
    }

    type DataframeClassificationSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("auc_roc")>]
        AucRoc: DataframeEvaluationSummaryAucRoc option
        [<System.Text.Json.Serialization.JsonPropertyName("accuracy")>]
        Accuracy: DataframeClassificationSummaryAccuracy option
        [<System.Text.Json.Serialization.JsonPropertyName("multiclass_confusion_matrix")>]
        MulticlassConfusionMatrix: DataframeClassificationSummaryMulticlassConfusionMatrix option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: DataframeClassificationSummaryPrecision option
        [<System.Text.Json.Serialization.JsonPropertyName("recall")>]
        Recall: DataframeClassificationSummaryRecall option
    }

    type DataframeOutlierDetectionSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("auc_roc")>]
        AucRoc: DataframeEvaluationSummaryAucRoc option
        [<System.Text.Json.Serialization.JsonPropertyName("precision")>]
        Precision: Map<string, CoreTypes.Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("recall")>]
        Recall: Map<string, CoreTypes.Double> option
        [<System.Text.Json.Serialization.JsonPropertyName("confusion_matrix")>]
        ConfusionMatrix: Map<string, ConfusionMatrixThreshold> option
    }

    type DataframeRegressionSummary = {
        [<System.Text.Json.Serialization.JsonPropertyName("huber")>]
        Huber: DataframeEvaluationValue option
        [<System.Text.Json.Serialization.JsonPropertyName("mse")>]
        Mse: DataframeEvaluationValue option
        [<System.Text.Json.Serialization.JsonPropertyName("msle")>]
        Msle: DataframeEvaluationValue option
        [<System.Text.Json.Serialization.JsonPropertyName("r_squared")>]
        RSquared: DataframeEvaluationValue option
    }


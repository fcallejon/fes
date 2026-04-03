// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlPutTrainedModel =

    type Weights = {
        [<System.Text.Json.Serialization.JsonPropertyName("weights")>]
        Weights: Types.Double
    }

    type AggregateOutput = {
        [<System.Text.Json.Serialization.JsonPropertyName("logistic_regression")>]
        LogisticRegression: MlPutTrainedModel.Weights option
        [<System.Text.Json.Serialization.JsonPropertyName("weighted_sum")>]
        WeightedSum: MlPutTrainedModel.Weights option
        [<System.Text.Json.Serialization.JsonPropertyName("weighted_mode")>]
        WeightedMode: MlPutTrainedModel.Weights option
        [<System.Text.Json.Serialization.JsonPropertyName("exponent")>]
        Exponent: MlPutTrainedModel.Weights option
    }

    type FrequencyEncodingPreprocessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("frequency_map")>]
        FrequencyMap: Map<string, Types.Double>
    }

    type OneHotEncodingPreprocessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("hot_map")>]
        HotMap: Map<string, string>
    }

    type TargetMeanEncodingPreprocessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("target_map")>]
        TargetMap: Map<string, Types.Double>
        [<System.Text.Json.Serialization.JsonPropertyName("default_value")>]
        DefaultValue: Types.Double
    }

    [<RequireQualifiedAccess>]
    type Preprocessor =
        | FrequencyEncoding of MlPutTrainedModel.FrequencyEncodingPreprocessor
        | OneHotEncoding of MlPutTrainedModel.OneHotEncodingPreprocessor
        | TargetMeanEncoding of MlPutTrainedModel.TargetMeanEncodingPreprocessor

    type TrainedModelTreeNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("decision_type")>]
        DecisionType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("default_left")>]
        DefaultLeft: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("leaf_value")>]
        LeafValue: Types.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("left_child")>]
        LeftChild: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("node_index")>]
        NodeIndex: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("right_child")>]
        RightChild: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("split_feature")>]
        SplitFeature: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("split_gain")>]
        SplitGain: Types.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: Types.Double option
    }

    type TrainedModelTree = {
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_names")>]
        FeatureNames: string list
        [<System.Text.Json.Serialization.JsonPropertyName("target_type")>]
        TargetType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("tree_structure")>]
        TreeStructure: MlPutTrainedModel.TrainedModelTreeNode list
    }

    type TrainedModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("tree")>]
        Tree: MlPutTrainedModel.TrainedModelTree option
        [<System.Text.Json.Serialization.JsonPropertyName("tree_node")>]
        TreeNode: MlPutTrainedModel.TrainedModelTreeNode option
        [<System.Text.Json.Serialization.JsonPropertyName("ensemble")>]
        Ensemble: MlPutTrainedModel.Ensemble option
    }

    and Ensemble = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregate_output")>]
        AggregateOutput: MlPutTrainedModel.AggregateOutput option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_names")>]
        FeatureNames: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_type")>]
        TargetType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("trained_models")>]
        TrainedModels: MlPutTrainedModel.TrainedModel list
    }

    type Definition = {
        [<System.Text.Json.Serialization.JsonPropertyName("preprocessors")>]
        Preprocessors: MlPutTrainedModel.Preprocessor list option
        [<System.Text.Json.Serialization.JsonPropertyName("trained_model")>]
        TrainedModel: MlPutTrainedModel.TrainedModel
    }

    type Input = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_names")>]
        FieldNames: Types.Names
    }


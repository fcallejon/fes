// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlPutTrainedModel =

    type Weights = {
        [<System.Text.Json.Serialization.JsonPropertyName("weights")>]
        Weights: CoreTypes.Double
    }

    type AggregateOutput = {
        [<System.Text.Json.Serialization.JsonPropertyName("logistic_regression")>]
        LogisticRegression: Weights option
        [<System.Text.Json.Serialization.JsonPropertyName("weighted_sum")>]
        WeightedSum: Weights option
        [<System.Text.Json.Serialization.JsonPropertyName("weighted_mode")>]
        WeightedMode: Weights option
        [<System.Text.Json.Serialization.JsonPropertyName("exponent")>]
        Exponent: Weights option
    }

    type FrequencyEncodingPreprocessor = {
        [<System.Text.Json.Serialization.JsonPropertyName("field")>]
        Field: string
        [<System.Text.Json.Serialization.JsonPropertyName("feature_name")>]
        FeatureName: string
        [<System.Text.Json.Serialization.JsonPropertyName("frequency_map")>]
        FrequencyMap: Map<string, CoreTypes.Double>
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
        TargetMap: Map<string, CoreTypes.Double>
        [<System.Text.Json.Serialization.JsonPropertyName("default_value")>]
        DefaultValue: CoreTypes.Double
    }

    [<RequireQualifiedAccess>]
    type Preprocessor =
        | FrequencyEncoding of FrequencyEncodingPreprocessor
        | OneHotEncoding of OneHotEncodingPreprocessor
        | TargetMeanEncoding of TargetMeanEncodingPreprocessor

    type TrainedModelTreeNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("decision_type")>]
        DecisionType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("default_left")>]
        DefaultLeft: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("leaf_value")>]
        LeafValue: CoreTypes.Double option
        [<System.Text.Json.Serialization.JsonPropertyName("left_child")>]
        LeftChild: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("node_index")>]
        NodeIndex: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("right_child")>]
        RightChild: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("split_feature")>]
        SplitFeature: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("split_gain")>]
        SplitGain: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("threshold")>]
        Threshold: CoreTypes.Double option
    }

    type TrainedModelTree = {
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_names")>]
        FeatureNames: string list
        [<System.Text.Json.Serialization.JsonPropertyName("target_type")>]
        TargetType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("tree_structure")>]
        TreeStructure: TrainedModelTreeNode list
    }

    type TrainedModel = {
        [<System.Text.Json.Serialization.JsonPropertyName("tree")>]
        Tree: TrainedModelTree option
        [<System.Text.Json.Serialization.JsonPropertyName("tree_node")>]
        TreeNode: TrainedModelTreeNode option
        [<System.Text.Json.Serialization.JsonPropertyName("ensemble")>]
        Ensemble: Ensemble option
    }

    and Ensemble = {
        [<System.Text.Json.Serialization.JsonPropertyName("aggregate_output")>]
        AggregateOutput: AggregateOutput option
        [<System.Text.Json.Serialization.JsonPropertyName("classification_labels")>]
        ClassificationLabels: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("feature_names")>]
        FeatureNames: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("target_type")>]
        TargetType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("trained_models")>]
        TrainedModels: TrainedModel list
    }

    type Definition = {
        [<System.Text.Json.Serialization.JsonPropertyName("preprocessors")>]
        Preprocessors: Preprocessor list option
        [<System.Text.Json.Serialization.JsonPropertyName("trained_model")>]
        TrainedModel: TrainedModel
    }

    type Input = {
        [<System.Text.Json.Serialization.JsonPropertyName("field_names")>]
        FieldNames: CoreTypes.Names
    }


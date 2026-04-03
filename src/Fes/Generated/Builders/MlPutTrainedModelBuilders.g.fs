// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module MlPutTrainedModelBuilders =

    type AggregateOutputBuilder() =
        member _.Yield(_: unit) : Types.AggregateOutput =
            {
                LogisticRegression = None
                WeightedSum = None
                WeightedMode = None
                Exponent = None
            }

        [<CustomOperation("logisticRegression")>]
        member _.LogisticRegression(state: Types.AggregateOutput, value: Types.Weights) =
            { state with LogisticRegression = Some value }

        [<CustomOperation("weightedSum")>]
        member _.WeightedSum(state: Types.AggregateOutput, value: Types.Weights) =
            { state with WeightedSum = Some value }

        [<CustomOperation("weightedMode")>]
        member _.WeightedMode(state: Types.AggregateOutput, value: Types.Weights) =
            { state with WeightedMode = Some value }

        [<CustomOperation("exponent")>]
        member _.Exponent(state: Types.AggregateOutput, value: Types.Weights) =
            { state with Exponent = Some value }

    let aggregateOutput = AggregateOutputBuilder()

    type EnsembleBuilder() =
        member _.Yield(_: unit) : Types.Ensemble =
            {
                AggregateOutput = None
                ClassificationLabels = None
                FeatureNames = None
                TargetType = None
                TrainedModels = Unchecked.defaultof<_>
            }

        [<CustomOperation("aggregateOutput")>]
        member _.AggregateOutput(state: Types.Ensemble, value: Types.AggregateOutput) =
            { state with AggregateOutput = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: Types.Ensemble, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("featureNames")>]
        member _.FeatureNames(state: Types.Ensemble, value: string list) =
            { state with FeatureNames = Some value }

        [<CustomOperation("targetType")>]
        member _.TargetType(state: Types.Ensemble, value: string) =
            { state with TargetType = Some value }

        [<CustomOperation("trainedModels")>]
        member _.TrainedModels(state: Types.Ensemble, value: Types.TrainedModel list) =
            { state with TrainedModels = value }

    let ensemble = EnsembleBuilder()

    module Preprocessor =

        let frequencyEncoding (value: Types.FrequencyEncodingPreprocessor) =
            Types.Preprocessor.FrequencyEncoding value

        let oneHotEncoding (value: Types.OneHotEncodingPreprocessor) =
            Types.Preprocessor.OneHotEncoding value

        let targetMeanEncoding (value: Types.TargetMeanEncodingPreprocessor) =
            Types.Preprocessor.TargetMeanEncoding value

    type TrainedModelBuilder() =
        member _.Yield(_: unit) : Types.TrainedModel =
            {
                Tree = None
                TreeNode = None
                Ensemble = None
            }

        [<CustomOperation("tree")>]
        member _.Tree(state: Types.TrainedModel, value: Types.TrainedModelTree) =
            { state with Tree = Some value }

        [<CustomOperation("treeNode")>]
        member _.TreeNode(state: Types.TrainedModel, value: Types.TrainedModelTreeNode) =
            { state with TreeNode = Some value }

        [<CustomOperation("ensemble")>]
        member _.Ensemble(state: Types.TrainedModel, value: Types.Ensemble) =
            { state with Ensemble = Some value }

    let trainedModel = TrainedModelBuilder()

    type TrainedModelTreeBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelTree =
            {
                ClassificationLabels = None
                FeatureNames = Unchecked.defaultof<_>
                TargetType = None
                TreeStructure = Unchecked.defaultof<_>
            }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: Types.TrainedModelTree, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("featureNames")>]
        member _.FeatureNames(state: Types.TrainedModelTree, value: string list) =
            { state with FeatureNames = value }

        [<CustomOperation("targetType")>]
        member _.TargetType(state: Types.TrainedModelTree, value: string) =
            { state with TargetType = Some value }

        [<CustomOperation("treeStructure")>]
        member _.TreeStructure(state: Types.TrainedModelTree, value: Types.TrainedModelTreeNode list) =
            { state with TreeStructure = value }

    let trainedModelTree = TrainedModelTreeBuilder()

    type TrainedModelTreeNodeBuilder() =
        member _.Yield(_: unit) : Types.TrainedModelTreeNode =
            {
                DecisionType = None
                DefaultLeft = None
                LeafValue = None
                LeftChild = None
                NodeIndex = Unchecked.defaultof<_>
                RightChild = None
                SplitFeature = None
                SplitGain = None
                Threshold = None
            }

        [<CustomOperation("decisionType")>]
        member _.DecisionType(state: Types.TrainedModelTreeNode, value: string) =
            { state with DecisionType = Some value }

        [<CustomOperation("defaultLeft")>]
        member _.DefaultLeft(state: Types.TrainedModelTreeNode, value: bool) =
            { state with DefaultLeft = Some value }

        [<CustomOperation("leafValue")>]
        member _.LeafValue(state: Types.TrainedModelTreeNode, value: Types.Double) =
            { state with LeafValue = Some value }

        [<CustomOperation("leftChild")>]
        member _.LeftChild(state: Types.TrainedModelTreeNode, value: Types.Integer) =
            { state with LeftChild = Some value }

        [<CustomOperation("nodeIndex")>]
        member _.NodeIndex(state: Types.TrainedModelTreeNode, value: Types.Integer) =
            { state with NodeIndex = value }

        [<CustomOperation("rightChild")>]
        member _.RightChild(state: Types.TrainedModelTreeNode, value: Types.Integer) =
            { state with RightChild = Some value }

        [<CustomOperation("splitFeature")>]
        member _.SplitFeature(state: Types.TrainedModelTreeNode, value: Types.Integer) =
            { state with SplitFeature = Some value }

        [<CustomOperation("splitGain")>]
        member _.SplitGain(state: Types.TrainedModelTreeNode, value: Types.Integer) =
            { state with SplitGain = Some value }

        [<CustomOperation("threshold")>]
        member _.Threshold(state: Types.TrainedModelTreeNode, value: Types.Double) =
            { state with Threshold = Some value }

    let trainedModelTreeNode = TrainedModelTreeNodeBuilder()


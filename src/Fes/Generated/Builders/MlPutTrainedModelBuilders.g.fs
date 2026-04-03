// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module MlPutTrainedModelBuilders =

    type AggregateOutputBuilder() =
        member _.Yield(_: unit) : AggregateOutput =
            {
                LogisticRegression = None
                WeightedSum = None
                WeightedMode = None
                Exponent = None
            }

        [<CustomOperation("logisticRegression")>]
        member _.LogisticRegression(state: AggregateOutput, value: MlPutTrainedModel.Weights) =
            { state with LogisticRegression = Some value }

        [<CustomOperation("weightedSum")>]
        member _.WeightedSum(state: AggregateOutput, value: MlPutTrainedModel.Weights) =
            { state with WeightedSum = Some value }

        [<CustomOperation("weightedMode")>]
        member _.WeightedMode(state: AggregateOutput, value: MlPutTrainedModel.Weights) =
            { state with WeightedMode = Some value }

        [<CustomOperation("exponent")>]
        member _.Exponent(state: AggregateOutput, value: MlPutTrainedModel.Weights) =
            { state with Exponent = Some value }

    let aggregateOutput = AggregateOutputBuilder()

    type EnsembleBuilder() =
        member _.Yield(_: unit) : Ensemble =
            {
                AggregateOutput = None
                ClassificationLabels = None
                FeatureNames = None
                TargetType = None
                TrainedModels = Unchecked.defaultof<_>
            }

        [<CustomOperation("aggregateOutput")>]
        member _.AggregateOutput(state: Ensemble, value: MlPutTrainedModel.AggregateOutput) =
            { state with AggregateOutput = Some value }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: Ensemble, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("featureNames")>]
        member _.FeatureNames(state: Ensemble, value: string list) =
            { state with FeatureNames = Some value }

        [<CustomOperation("targetType")>]
        member _.TargetType(state: Ensemble, value: string) =
            { state with TargetType = Some value }

        [<CustomOperation("trainedModels")>]
        member _.TrainedModels(state: Ensemble, value: MlPutTrainedModel.TrainedModel list) =
            { state with TrainedModels = value }

    let ensemble = EnsembleBuilder()

    module Preprocessor =

        let frequencyEncoding (value: MlPutTrainedModel.FrequencyEncodingPreprocessor) =
            Preprocessor.FrequencyEncoding value

        let oneHotEncoding (value: MlPutTrainedModel.OneHotEncodingPreprocessor) =
            Preprocessor.OneHotEncoding value

        let targetMeanEncoding (value: MlPutTrainedModel.TargetMeanEncodingPreprocessor) =
            Preprocessor.TargetMeanEncoding value

    type TrainedModelBuilder() =
        member _.Yield(_: unit) : TrainedModel =
            {
                Tree = None
                TreeNode = None
                Ensemble = None
            }

        [<CustomOperation("tree")>]
        member _.Tree(state: TrainedModel, value: MlPutTrainedModel.TrainedModelTree) =
            { state with Tree = Some value }

        [<CustomOperation("treeNode")>]
        member _.TreeNode(state: TrainedModel, value: MlPutTrainedModel.TrainedModelTreeNode) =
            { state with TreeNode = Some value }

        [<CustomOperation("ensemble")>]
        member _.Ensemble(state: TrainedModel, value: MlPutTrainedModel.Ensemble) =
            { state with Ensemble = Some value }

    let trainedModel = TrainedModelBuilder()

    type TrainedModelTreeBuilder() =
        member _.Yield(_: unit) : TrainedModelTree =
            {
                ClassificationLabels = None
                FeatureNames = Unchecked.defaultof<_>
                TargetType = None
                TreeStructure = Unchecked.defaultof<_>
            }

        [<CustomOperation("classificationLabels")>]
        member _.ClassificationLabels(state: TrainedModelTree, value: string list) =
            { state with ClassificationLabels = Some value }

        [<CustomOperation("featureNames")>]
        member _.FeatureNames(state: TrainedModelTree, value: string list) =
            { state with FeatureNames = value }

        [<CustomOperation("targetType")>]
        member _.TargetType(state: TrainedModelTree, value: string) =
            { state with TargetType = Some value }

        [<CustomOperation("treeStructure")>]
        member _.TreeStructure(state: TrainedModelTree, value: MlPutTrainedModel.TrainedModelTreeNode list) =
            { state with TreeStructure = value }

    let trainedModelTree = TrainedModelTreeBuilder()

    type TrainedModelTreeNodeBuilder() =
        member _.Yield(_: unit) : TrainedModelTreeNode =
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
        member _.DecisionType(state: TrainedModelTreeNode, value: string) =
            { state with DecisionType = Some value }

        [<CustomOperation("defaultLeft")>]
        member _.DefaultLeft(state: TrainedModelTreeNode, value: bool) =
            { state with DefaultLeft = Some value }

        [<CustomOperation("leafValue")>]
        member _.LeafValue(state: TrainedModelTreeNode, value: CoreTypes.Double) =
            { state with LeafValue = Some value }

        [<CustomOperation("leftChild")>]
        member _.LeftChild(state: TrainedModelTreeNode, value: CoreTypes.Integer) =
            { state with LeftChild = Some value }

        [<CustomOperation("nodeIndex")>]
        member _.NodeIndex(state: TrainedModelTreeNode, value: CoreTypes.Integer) =
            { state with NodeIndex = value }

        [<CustomOperation("rightChild")>]
        member _.RightChild(state: TrainedModelTreeNode, value: CoreTypes.Integer) =
            { state with RightChild = Some value }

        [<CustomOperation("splitFeature")>]
        member _.SplitFeature(state: TrainedModelTreeNode, value: CoreTypes.Integer) =
            { state with SplitFeature = Some value }

        [<CustomOperation("splitGain")>]
        member _.SplitGain(state: TrainedModelTreeNode, value: CoreTypes.Integer) =
            { state with SplitGain = Some value }

        [<CustomOperation("threshold")>]
        member _.Threshold(state: TrainedModelTreeNode, value: CoreTypes.Double) =
            { state with Threshold = Some value }

    let trainedModelTreeNode = TrainedModelTreeNodeBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module MlPreviewDataFrameAnalyticsBuilders =

    type DataframePreviewConfigBuilder() =
        member _.Yield(_: unit) : DataframePreviewConfig =
            {
                Source = Unchecked.defaultof<_>
                Analysis = Unchecked.defaultof<_>
                ModelMemoryLimit = None
                MaxNumThreads = None
                AnalyzedFields = None
            }

        [<CustomOperation("source")>]
        member _.Source(state: DataframePreviewConfig, value: MlTypes.DataframeAnalyticsSource) =
            { state with Source = value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: DataframePreviewConfig, value: MlTypes.DataframeAnalysisContainer) =
            { state with Analysis = value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: DataframePreviewConfig, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: DataframePreviewConfig, value: CoreTypes.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: DataframePreviewConfig, value: MlTypes.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

    let dataframePreviewConfig = DataframePreviewConfigBuilder()


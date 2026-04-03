// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module MlPreviewDataFrameAnalyticsBuilders =

    type DataframePreviewConfigBuilder() =
        member _.Yield(_: unit) : Types.DataframePreviewConfig =
            {
                Source = Unchecked.defaultof<_>
                Analysis = Unchecked.defaultof<_>
                ModelMemoryLimit = None
                MaxNumThreads = None
                AnalyzedFields = None
            }

        [<CustomOperation("source")>]
        member _.Source(state: Types.DataframePreviewConfig, value: Types.DataframeAnalyticsSource) =
            { state with Source = value }

        [<CustomOperation("analysis")>]
        member _.Analysis(state: Types.DataframePreviewConfig, value: Types.DataframeAnalysisContainer) =
            { state with Analysis = value }

        [<CustomOperation("modelMemoryLimit")>]
        member _.ModelMemoryLimit(state: Types.DataframePreviewConfig, value: string) =
            { state with ModelMemoryLimit = Some value }

        [<CustomOperation("maxNumThreads")>]
        member _.MaxNumThreads(state: Types.DataframePreviewConfig, value: Types.Integer) =
            { state with MaxNumThreads = Some value }

        [<CustomOperation("analyzedFields")>]
        member _.AnalyzedFields(state: Types.DataframePreviewConfig, value: Types.DataframeAnalysisAnalyzedFields) =
            { state with AnalyzedFields = Some value }

    let dataframePreviewConfig = DataframePreviewConfigBuilder()


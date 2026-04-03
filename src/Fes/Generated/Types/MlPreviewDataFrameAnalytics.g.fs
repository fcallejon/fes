// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module MlPreviewDataFrameAnalytics =

    type DataframePreviewConfig = {
        [<System.Text.Json.Serialization.JsonPropertyName("source")>]
        Source: MlTypes.DataframeAnalyticsSource
        [<System.Text.Json.Serialization.JsonPropertyName("analysis")>]
        Analysis: MlTypes.DataframeAnalysisContainer
        [<System.Text.Json.Serialization.JsonPropertyName("model_memory_limit")>]
        ModelMemoryLimit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_num_threads")>]
        MaxNumThreads: CoreTypes.Integer option
        [<System.Text.Json.Serialization.JsonPropertyName("analyzed_fields")>]
        AnalyzedFields: MlTypes.DataframeAnalysisAnalyzedFields option
    }


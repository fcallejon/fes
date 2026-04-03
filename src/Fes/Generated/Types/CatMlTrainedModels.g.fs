// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatMlTrainedModels =

    type TrainedModelsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("created_by")>]
        CreatedBy: string option
        [<System.Text.Json.Serialization.JsonPropertyName("heap_size")>]
        HeapSize: Types.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("operations")>]
        Operations: string option
        [<System.Text.Json.Serialization.JsonPropertyName("license")>]
        License: string option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: Types.DateTime option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest.pipelines")>]
        IngestPipelines: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest.count")>]
        IngestCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest.time")>]
        IngestTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest.current")>]
        IngestCurrent: string option
        [<System.Text.Json.Serialization.JsonPropertyName("ingest.failed")>]
        IngestFailed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame.id")>]
        DataFrameId: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame.create_time")>]
        DataFrameCreateTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame.source_index")>]
        DataFrameSourceIndex: string option
        [<System.Text.Json.Serialization.JsonPropertyName("data_frame.analysis")>]
        DataFrameAnalysis: string option
        [<System.Text.Json.Serialization.JsonPropertyName("type")>]
        Type: string option
    }


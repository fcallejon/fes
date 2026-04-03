// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatTransforms =

    type TransformsRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("state")>]
        State: string option
        [<System.Text.Json.Serialization.JsonPropertyName("checkpoint")>]
        Checkpoint: string option
        [<System.Text.Json.Serialization.JsonPropertyName("documents_processed")>]
        DocumentsProcessed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("checkpoint_progress")>]
        CheckpointProgress: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("last_search_time")>]
        LastSearchTime: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("changes_last_detection_time")>]
        ChangesLastDetectionTime: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("create_time")>]
        CreateTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionString option
        [<System.Text.Json.Serialization.JsonPropertyName("source_index")>]
        SourceIndex: string option
        [<System.Text.Json.Serialization.JsonPropertyName("dest_index")>]
        DestIndex: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: string option
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("transform_type")>]
        TransformType: string option
        [<System.Text.Json.Serialization.JsonPropertyName("frequency")>]
        Frequency: string option
        [<System.Text.Json.Serialization.JsonPropertyName("max_page_search_size")>]
        MaxPageSearchSize: string option
        [<System.Text.Json.Serialization.JsonPropertyName("docs_per_second")>]
        DocsPerSecond: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reason")>]
        Reason: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_total")>]
        SearchTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_failure")>]
        SearchFailure: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_time")>]
        SearchTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index_total")>]
        IndexTotal: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index_failure")>]
        IndexFailure: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index_time")>]
        IndexTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("documents_indexed")>]
        DocumentsIndexed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("delete_time")>]
        DeleteTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("documents_deleted")>]
        DocumentsDeleted: string option
        [<System.Text.Json.Serialization.JsonPropertyName("trigger_count")>]
        TriggerCount: string option
        [<System.Text.Json.Serialization.JsonPropertyName("pages_processed")>]
        PagesProcessed: string option
        [<System.Text.Json.Serialization.JsonPropertyName("processing_time")>]
        ProcessingTime: string option
        [<System.Text.Json.Serialization.JsonPropertyName("checkpoint_duration_time_exp_avg")>]
        CheckpointDurationTimeExpAvg: string option
        [<System.Text.Json.Serialization.JsonPropertyName("indexed_documents_exp_avg")>]
        IndexedDocumentsExpAvg: string option
        [<System.Text.Json.Serialization.JsonPropertyName("processed_documents_exp_avg")>]
        ProcessedDocumentsExpAvg: string option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesGetMigrateReindexStatus =

    type StatusError = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: string
        [<System.Text.Json.Serialization.JsonPropertyName("message")>]
        Message: string
    }

    type StatusInProgress = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: string
        [<System.Text.Json.Serialization.JsonPropertyName("total_doc_count")>]
        TotalDocCount: CoreTypes.Long
        [<System.Text.Json.Serialization.JsonPropertyName("reindexed_doc_count")>]
        ReindexedDocCount: CoreTypes.Long
    }


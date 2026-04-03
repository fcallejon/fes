// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalBulk =

    type OperationBase = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("if_primary_term")>]
        IfPrimaryTerm: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("if_seq_no")>]
        IfSeqNo: CoreTypes.SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: CoreTypes.VersionType option
    }

    type WriteOperation = {
        [<System.Text.Json.Serialization.JsonPropertyName("dynamic_templates")>]
        DynamicTemplates: Map<string, string> option
        [<System.Text.Json.Serialization.JsonPropertyName("pipeline")>]
        Pipeline: string option
        [<System.Text.Json.Serialization.JsonPropertyName("require_alias")>]
        RequireAlias: bool option
    }

    type CreateOperation = System.Text.Json.JsonElement

    type DeleteOperation = System.Text.Json.JsonElement

    [<RequireQualifiedAccess>]
    type FailureStoreStatus =
        | NotApplicableOrUnknown
        | Used
        | NotEnabled
        | Failed

    type IndexOperation = System.Text.Json.JsonElement

    type UpdateOperation = {
        [<System.Text.Json.Serialization.JsonPropertyName("require_alias")>]
        RequireAlias: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("retry_on_conflict")>]
        RetryOnConflict: CoreTypes.Integer option
    }

    [<RequireQualifiedAccess>]
    type OperationContainer =
        | Index of IndexOperation
        | Create of CreateOperation
        | Update of UpdateOperation
        | Delete of DeleteOperation

    [<RequireQualifiedAccess>]
    type OperationType =
        | Index
        | Create
        | Update
        | Delete

    type ResponseItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: string option option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: string
        [<System.Text.Json.Serialization.JsonPropertyName("status")>]
        Status: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("failure_store")>]
        FailureStore: FailureStoreStatus option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("result")>]
        Result: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: CoreTypes.SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_shards")>]
        Shards: CoreTypes.ShardStatistics option
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("forced_refresh")>]
        ForcedRefresh: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("get")>]
        Get: CoreTypes.InlineGet<Map<string, System.Text.Json.JsonElement>> option
    }

    type UpdateAction<'tDocument, 'tPartialDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("detect_noop")>]
        DetectNoop: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: 'tPartialDocument option
        [<System.Text.Json.Serialization.JsonPropertyName("doc_as_upsert")>]
        DocAsUpsert: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("script")>]
        Script: CoreTypes.Script option
        [<System.Text.Json.Serialization.JsonPropertyName("scripted_upsert")>]
        ScriptedUpsert: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("upsert")>]
        Upsert: 'tDocument option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SimulateIngest =

    /// The results of ingest simulation on a single document. The _source of the document contains
    type IngestDocumentSimulation = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: CoreTypes.Stringified<CoreTypes.VersionNumber>
        [<System.Text.Json.Serialization.JsonPropertyName("executed_pipelines")>]
        ExecutedPipelines: string list
        [<System.Text.Json.Serialization.JsonPropertyName("ignored_fields")>]
        IgnoredFields: Map<string, string> list option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("effective_mapping")>]
        EffectiveMapping: CoreTypes.TypeMapping option
    }

    [<RequireQualifiedAccess>]
    type MergeType =
        | Index
        | Template

    type SimulateIngestDocumentResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: IngestDocumentSimulation option
    }


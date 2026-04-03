// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SimulateIngest =

    /// The results of ingest simulation on a single document. The _source of the document contains
the results after running all pipelines listed in executed_pipelines on the document. The
list of executed p...
    type IngestDocumentSimulation = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: Map<string, System.Text.Json.JsonElement>
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: SpecUtils.Stringified<Types.VersionNumber>
        [<System.Text.Json.Serialization.JsonPropertyName("executed_pipelines")>]
        ExecutedPipelines: string list
        [<System.Text.Json.Serialization.JsonPropertyName("ignored_fields")>]
        IgnoredFields: Map<string, string> list option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
        [<System.Text.Json.Serialization.JsonPropertyName("effective_mapping")>]
        EffectiveMapping: TypesMapping.TypeMapping option
    }

    [<RequireQualifiedAccess>]
    type MergeType =
        | Index
        | Template

    type SimulateIngestDocumentResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: SimulateIngest.IngestDocumentSimulation option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalMget =

    type MultiGetError = {
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
    }

    type Operation = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: Types.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: GlobalSearchTypes.SourceConfig option
        [<System.Text.Json.Serialization.JsonPropertyName("stored_fields")>]
        StoredFields: Types.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: Types.VersionType option
    }

    [<RequireQualifiedAccess>]
    type ResponseItem<'tDocument> =
        | GetResult of GlobalGet.GetResult<'tDocument>
        | MultiGetError of GlobalMget.MultiGetError


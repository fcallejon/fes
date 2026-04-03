// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalMtermvectors =

    type Operation = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: CoreTypes.Fields option
        [<System.Text.Json.Serialization.JsonPropertyName("field_statistics")>]
        FieldStatistics: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: GlobalTermvectors.Filter option
        [<System.Text.Json.Serialization.JsonPropertyName("offsets")>]
        Offsets: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("payloads")>]
        Payloads: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("positions")>]
        Positions: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: CoreTypes.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("term_statistics")>]
        TermStatistics: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: CoreTypes.VersionType option
    }

    type TermVectorsResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: CoreTypes.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: CoreTypes.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: CoreTypes.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors")>]
        TermVectors: Map<CoreTypes.Field, GlobalTermvectors.TermVector> option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: CoreTypes.ErrorCause option
    }


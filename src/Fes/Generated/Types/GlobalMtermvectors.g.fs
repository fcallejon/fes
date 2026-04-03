// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalMtermvectors =

    type Operation = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("doc")>]
        Doc: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Types.Fields option
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
        Routing: Types.Routing option
        [<System.Text.Json.Serialization.JsonPropertyName("term_statistics")>]
        TermStatistics: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("version_type")>]
        VersionType: Types.VersionType option
    }

    type TermVectorsResult = {
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id option
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: Types.VersionNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("took")>]
        Took: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("term_vectors")>]
        TermVectors: Map<Types.Field, GlobalTermvectors.TermVector> option
        [<System.Text.Json.Serialization.JsonPropertyName("error")>]
        Error: Types.ErrorCause option
    }


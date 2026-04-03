// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module GlobalGet =

    type GetResult<'tDocument> = {
        [<System.Text.Json.Serialization.JsonPropertyName("_index")>]
        Index: Types.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("fields")>]
        Fields: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("_ignored")>]
        Ignored: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("found")>]
        Found: bool
        [<System.Text.Json.Serialization.JsonPropertyName("_id")>]
        Id: Types.Id
        [<System.Text.Json.Serialization.JsonPropertyName("_primary_term")>]
        PrimaryTerm: Types.Long option
        [<System.Text.Json.Serialization.JsonPropertyName("_routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("_seq_no")>]
        SeqNo: Types.SequenceNumber option
        [<System.Text.Json.Serialization.JsonPropertyName("_source")>]
        Source: 'tDocument option
        [<System.Text.Json.Serialization.JsonPropertyName("_version")>]
        Version: Types.VersionNumber option
    }


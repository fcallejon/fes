// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesResolveIndex =

    type ResolveIndexAliasItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices
    }

    type ResolveIndexDataStreamsItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.DataStreamName
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_field")>]
        TimestampField: Types.Field
        [<System.Text.Json.Serialization.JsonPropertyName("backing_indices")>]
        BackingIndices: Types.Indices
    }

    type ResolveIndexItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: Types.Name
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: string list
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: Types.DataStreamName option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: IndicesTypes.IndexMode option
    }


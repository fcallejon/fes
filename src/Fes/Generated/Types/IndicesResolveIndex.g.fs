// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesResolveIndex =

    type ResolveIndexAliasItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices
    }

    type ResolveIndexDataStreamsItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.DataStreamName
        [<System.Text.Json.Serialization.JsonPropertyName("timestamp_field")>]
        TimestampField: CoreTypes.Field
        [<System.Text.Json.Serialization.JsonPropertyName("backing_indices")>]
        BackingIndices: CoreTypes.Indices
    }

    type ResolveIndexItem = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.Name
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("attributes")>]
        Attributes: string list
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: CoreTypes.DataStreamName option
        [<System.Text.Json.Serialization.JsonPropertyName("mode")>]
        Mode: IndicesTypes.IndexMode option
    }


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesModifyDataStream =

    type IndexAndDataStreamAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("data_stream")>]
        DataStream: CoreTypes.DataStreamName
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName
    }

    [<RequireQualifiedAccess>]
    type Action =
        | AddBackingIndex of IndexAndDataStreamAction
        | RemoveBackingIndex of IndexAndDataStreamAction


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesRemoveBlock =

    type RemoveIndicesBlockStatus = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.IndexName
        [<System.Text.Json.Serialization.JsonPropertyName("unblocked")>]
        Unblocked: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("exception")>]
        Exception: CoreTypes.ErrorCause option
    }


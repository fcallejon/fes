// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesUpdateAliases =

    type AddAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("alias")>]
        Alias: CoreTypes.IndexAlias option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: CoreTypes.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("index_routing")>]
        IndexRouting: string option
        [<System.Text.Json.Serialization.JsonPropertyName("is_hidden")>]
        IsHidden: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("is_write_index")>]
        IsWriteIndex: bool option
        [<System.Text.Json.Serialization.JsonPropertyName("routing")>]
        Routing: string option
        [<System.Text.Json.Serialization.JsonPropertyName("search_routing")>]
        SearchRouting: string option
        [<System.Text.Json.Serialization.JsonPropertyName("must_exist")>]
        MustExist: bool option
    }

    type RemoveAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("alias")>]
        Alias: CoreTypes.IndexAlias option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("must_exist")>]
        MustExist: bool option
    }

    type RemoveIndexAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: CoreTypes.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: CoreTypes.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("must_exist")>]
        MustExist: bool option
    }

    [<RequireQualifiedAccess>]
    type Action =
        | Add of AddAction
        | Remove of RemoveAction
        | RemoveIndex of RemoveIndexAction


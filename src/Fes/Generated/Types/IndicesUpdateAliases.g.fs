// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module IndicesUpdateAliases =

    type AddAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("alias")>]
        Alias: Types.IndexAlias option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: TypesQueryDsl.QueryContainer option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
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
        Alias: Types.IndexAlias option
        [<System.Text.Json.Serialization.JsonPropertyName("aliases")>]
        Aliases: System.Text.Json.JsonElement option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("must_exist")>]
        MustExist: bool option
    }

    type RemoveIndexAction = {
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: Types.Indices option
        [<System.Text.Json.Serialization.JsonPropertyName("must_exist")>]
        MustExist: bool option
    }

    [<RequireQualifiedAccess>]
    type Action =
        | Add of IndicesUpdateAliases.AddAction
        | Remove of IndicesUpdateAliases.RemoveAction
        | RemoveIndex of IndicesUpdateAliases.RemoveIndexAction


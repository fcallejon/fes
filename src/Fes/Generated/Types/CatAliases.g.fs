// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatAliases =

    type AliasesRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("alias")>]
        Alias: string option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: Types.IndexName option
        [<System.Text.Json.Serialization.JsonPropertyName("filter")>]
        Filter: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing.index")>]
        RoutingIndex: string option
        [<System.Text.Json.Serialization.JsonPropertyName("routing.search")>]
        RoutingSearch: string option
        [<System.Text.Json.Serialization.JsonPropertyName("is_write_index")>]
        IsWriteIndex: string option
    }


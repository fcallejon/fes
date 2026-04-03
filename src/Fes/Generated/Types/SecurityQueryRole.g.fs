// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityQueryRole =

    type QueryRole = {
        [<System.Text.Json.Serialization.JsonPropertyName("_sort")>]
        Sort: Types.SortResults option
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: string
    }

    [<RequireQualifiedAccess>]
    type RoleQueryContainer =
        | Bool of TypesQueryDsl.BoolQuery
        | Exists of TypesQueryDsl.ExistsQuery
        | Ids of TypesQueryDsl.IdsQuery
        | Match of field: string * TypesQueryDsl.MatchQuery
        | MatchAll of TypesQueryDsl.MatchAllQuery
        | Prefix of field: string * TypesQueryDsl.PrefixQuery
        | Range of field: string * TypesQueryDsl.RangeQuery
        | SimpleQueryString of TypesQueryDsl.SimpleQueryStringQuery
        | Term of field: string * TypesQueryDsl.TermQuery
        | Terms of TypesQueryDsl.TermsQuery
        | Wildcard of field: string * TypesQueryDsl.WildcardQuery
        | Unknown of name: string * System.Text.Json.JsonElement


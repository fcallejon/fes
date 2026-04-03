// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityQueryUser =

    type QueryUser = {
        [<System.Text.Json.Serialization.JsonPropertyName("_sort")>]
        Sort: CoreTypes.SortResults option
    }

    [<RequireQualifiedAccess>]
    type UserQueryContainer =
        | Ids of CoreTypes.IdsQuery
        | Bool of CoreTypes.BoolQuery
        | Exists of CoreTypes.ExistsQuery
        | Match of field: string * CoreTypes.MatchQuery
        | MatchAll of CoreTypes.MatchAllQuery
        | Prefix of field: string * CoreTypes.PrefixQuery
        | Range of field: string * CoreTypes.RangeQuery
        | SimpleQueryString of CoreTypes.SimpleQueryStringQuery
        | Term of field: string * CoreTypes.TermQuery
        | Terms of CoreTypes.TermsQuery
        | Wildcard of field: string * CoreTypes.WildcardQuery
        | Unknown of name: string * System.Text.Json.JsonElement


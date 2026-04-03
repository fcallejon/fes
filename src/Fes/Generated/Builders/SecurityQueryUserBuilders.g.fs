// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityQueryUserBuilders =

    module UserQuery =

        let ids (value: Types.IdsQuery) =
            Types.UserQueryContainer.Ids value

        let bool (value: Types.BoolQuery) =
            Types.UserQueryContainer.Bool value

        let exists (value: Types.ExistsQuery) =
            Types.UserQueryContainer.Exists value

        let match' (field: string) (value: Types.MatchQuery) =
            Types.UserQueryContainer.Match (field, value)

        let matchAll (value: Types.MatchAllQuery) =
            Types.UserQueryContainer.MatchAll value

        let prefix (field: string) (value: Types.PrefixQuery) =
            Types.UserQueryContainer.Prefix (field, value)

        let range (field: string) (value: Types.RangeQuery) =
            Types.UserQueryContainer.Range (field, value)

        let simpleQueryString (value: Types.SimpleQueryStringQuery) =
            Types.UserQueryContainer.SimpleQueryString value

        let term (field: string) (value: Types.TermQuery) =
            Types.UserQueryContainer.Term (field, value)

        let terms (value: Types.TermsQuery) =
            Types.UserQueryContainer.Terms value

        let wildcard (field: string) (value: Types.WildcardQuery) =
            Types.UserQueryContainer.Wildcard (field, value)


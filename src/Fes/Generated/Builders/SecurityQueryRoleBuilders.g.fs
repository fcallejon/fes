// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityQueryRoleBuilders =

    module RoleQuery =

        let bool (value: Types.BoolQuery) =
            Types.RoleQueryContainer.Bool value

        let exists (value: Types.ExistsQuery) =
            Types.RoleQueryContainer.Exists value

        let ids (value: Types.IdsQuery) =
            Types.RoleQueryContainer.Ids value

        let match' (field: string) (value: Types.MatchQuery) =
            Types.RoleQueryContainer.Match (field, value)

        let matchAll (value: Types.MatchAllQuery) =
            Types.RoleQueryContainer.MatchAll value

        let prefix (field: string) (value: Types.PrefixQuery) =
            Types.RoleQueryContainer.Prefix (field, value)

        let range (field: string) (value: Types.RangeQuery) =
            Types.RoleQueryContainer.Range (field, value)

        let simpleQueryString (value: Types.SimpleQueryStringQuery) =
            Types.RoleQueryContainer.SimpleQueryString value

        let term (field: string) (value: Types.TermQuery) =
            Types.RoleQueryContainer.Term (field, value)

        let terms (value: Types.TermsQuery) =
            Types.RoleQueryContainer.Terms value

        let wildcard (field: string) (value: Types.WildcardQuery) =
            Types.RoleQueryContainer.Wildcard (field, value)


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityQueryRoleBuilders =

    module RoleQuery =

        let bool (value: TypesQueryDsl.BoolQuery) =
            RoleQueryContainer.Bool value

        let exists (value: TypesQueryDsl.ExistsQuery) =
            RoleQueryContainer.Exists value

        let ids (value: TypesQueryDsl.IdsQuery) =
            RoleQueryContainer.Ids value

        let match' (field: string) (value: TypesQueryDsl.MatchQuery) =
            RoleQueryContainer.Match (field, value)

        let matchAll (value: TypesQueryDsl.MatchAllQuery) =
            RoleQueryContainer.MatchAll value

        let prefix (field: string) (value: TypesQueryDsl.PrefixQuery) =
            RoleQueryContainer.Prefix (field, value)

        let range (field: string) (value: TypesQueryDsl.RangeQuery) =
            RoleQueryContainer.Range (field, value)

        let simpleQueryString (value: TypesQueryDsl.SimpleQueryStringQuery) =
            RoleQueryContainer.SimpleQueryString value

        let term (field: string) (value: TypesQueryDsl.TermQuery) =
            RoleQueryContainer.Term (field, value)

        let terms (value: TypesQueryDsl.TermsQuery) =
            RoleQueryContainer.Terms value

        let wildcard (field: string) (value: TypesQueryDsl.WildcardQuery) =
            RoleQueryContainer.Wildcard (field, value)


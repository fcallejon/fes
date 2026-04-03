// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityQueryRoleBuilders =

    module RoleQuery =

        let bool (value: CoreTypes.BoolQuery) =
            RoleQueryContainer.Bool value

        let exists (value: CoreTypes.ExistsQuery) =
            RoleQueryContainer.Exists value

        let ids (value: CoreTypes.IdsQuery) =
            RoleQueryContainer.Ids value

        let match' (field: string) (value: CoreTypes.MatchQuery) =
            RoleQueryContainer.Match (field, value)

        let matchAll (value: CoreTypes.MatchAllQuery) =
            RoleQueryContainer.MatchAll value

        let prefix (field: string) (value: CoreTypes.PrefixQuery) =
            RoleQueryContainer.Prefix (field, value)

        let range (field: string) (value: CoreTypes.RangeQuery) =
            RoleQueryContainer.Range (field, value)

        let simpleQueryString (value: CoreTypes.SimpleQueryStringQuery) =
            RoleQueryContainer.SimpleQueryString value

        let term (field: string) (value: CoreTypes.TermQuery) =
            RoleQueryContainer.Term (field, value)

        let terms (value: CoreTypes.TermsQuery) =
            RoleQueryContainer.Terms value

        let wildcard (field: string) (value: CoreTypes.WildcardQuery) =
            RoleQueryContainer.Wildcard (field, value)


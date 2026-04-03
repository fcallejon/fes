// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityQueryUserBuilders =

    module UserQuery =

        let ids (value: TypesQueryDsl.IdsQuery) =
            UserQueryContainer.Ids value

        let bool (value: TypesQueryDsl.BoolQuery) =
            UserQueryContainer.Bool value

        let exists (value: TypesQueryDsl.ExistsQuery) =
            UserQueryContainer.Exists value

        let match' (field: string) (value: TypesQueryDsl.MatchQuery) =
            UserQueryContainer.Match (field, value)

        let matchAll (value: TypesQueryDsl.MatchAllQuery) =
            UserQueryContainer.MatchAll value

        let prefix (field: string) (value: TypesQueryDsl.PrefixQuery) =
            UserQueryContainer.Prefix (field, value)

        let range (field: string) (value: TypesQueryDsl.RangeQuery) =
            UserQueryContainer.Range (field, value)

        let simpleQueryString (value: TypesQueryDsl.SimpleQueryStringQuery) =
            UserQueryContainer.SimpleQueryString value

        let term (field: string) (value: TypesQueryDsl.TermQuery) =
            UserQueryContainer.Term (field, value)

        let terms (value: TypesQueryDsl.TermsQuery) =
            UserQueryContainer.Terms value

        let wildcard (field: string) (value: TypesQueryDsl.WildcardQuery) =
            UserQueryContainer.Wildcard (field, value)


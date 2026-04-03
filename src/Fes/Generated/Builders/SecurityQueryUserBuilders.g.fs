// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityQueryUserBuilders =

    module UserQuery =

        let ids (value: CoreTypes.IdsQuery) =
            UserQueryContainer.Ids value

        let bool (value: CoreTypes.BoolQuery) =
            UserQueryContainer.Bool value

        let exists (value: CoreTypes.ExistsQuery) =
            UserQueryContainer.Exists value

        let match' (field: string) (value: CoreTypes.MatchQuery) =
            UserQueryContainer.Match (field, value)

        let matchAll (value: CoreTypes.MatchAllQuery) =
            UserQueryContainer.MatchAll value

        let prefix (field: string) (value: CoreTypes.PrefixQuery) =
            UserQueryContainer.Prefix (field, value)

        let range (field: string) (value: CoreTypes.RangeQuery) =
            UserQueryContainer.Range (field, value)

        let simpleQueryString (value: CoreTypes.SimpleQueryStringQuery) =
            UserQueryContainer.SimpleQueryString value

        let term (field: string) (value: CoreTypes.TermQuery) =
            UserQueryContainer.Term (field, value)

        let terms (value: CoreTypes.TermsQuery) =
            UserQueryContainer.Terms value

        let wildcard (field: string) (value: CoreTypes.WildcardQuery) =
            UserQueryContainer.Wildcard (field, value)


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityQueryUserBuilders =

    type QueryUserBuilder() =
        member _.Yield(_: unit) : Types.QueryUser =
            {
                Sort = None
                Email = None
                FullName = None
                Metadata = Unchecked.defaultof<_>
                Roles = Unchecked.defaultof<_>
                Username = Unchecked.defaultof<_>
                Enabled = Unchecked.defaultof<_>
                ProfileUid = None
            }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.QueryUser, value: Types.SortResults) =
            { state with Sort = Some value }

        [<CustomOperation("email")>]
        member _.Email(state: Types.QueryUser, value: string option) =
            { state with Email = Some value }

        [<CustomOperation("fullName")>]
        member _.FullName(state: Types.QueryUser, value: Types.Name option) =
            { state with FullName = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.QueryUser, value: Types.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("roles")>]
        member _.Roles(state: Types.QueryUser, value: string list) =
            { state with Roles = value }

        [<CustomOperation("username")>]
        member _.Username(state: Types.QueryUser, value: Types.Username) =
            { state with Username = value }

        [<CustomOperation("enabled")>]
        member _.Enabled(state: Types.QueryUser, value: bool) =
            { state with Enabled = value }

        [<CustomOperation("profileUid")>]
        member _.ProfileUid(state: Types.QueryUser, value: Types.UserProfileId) =
            { state with ProfileUid = Some value }

    let queryUser = QueryUserBuilder()

    module UserQuery =

        let ids (value: Types.IdsQuery) =
            Types.UserQueryContainer.Ids value

        let bool (value: Types.BoolQuery) =
            Types.UserQueryContainer.Bool value

        let exists (value: Types.ExistsQuery) =
            Types.UserQueryContainer.Exists value

        let match' (field: Types.Field) (value: Types.MatchQuery) =
            Types.UserQueryContainer.Match (field, value)

        let matchAll (value: Types.MatchAllQuery) =
            Types.UserQueryContainer.MatchAll value

        let prefix (field: Types.Field) (value: Types.PrefixQuery) =
            Types.UserQueryContainer.Prefix (field, value)

        let range (field: Types.Field) (value: Types.RangeQuery) =
            Types.UserQueryContainer.Range (field, value)

        let simpleQueryString (value: Types.SimpleQueryStringQuery) =
            Types.UserQueryContainer.SimpleQueryString value

        let term (field: Types.Field) (value: Types.TermQuery) =
            Types.UserQueryContainer.Term (field, value)

        let terms (value: Types.TermsQuery) =
            Types.UserQueryContainer.Terms value

        let wildcard (field: Types.Field) (value: Types.WildcardQuery) =
            Types.UserQueryContainer.Wildcard (field, value)


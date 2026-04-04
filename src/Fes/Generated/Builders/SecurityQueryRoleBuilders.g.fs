// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityQueryRoleBuilders =

    type QueryRoleBuilder() =
        member _.Yield(_: unit) : Types.QueryRole =
            {
                Sort = None
                Name = Unchecked.defaultof<_>
                Cluster = None
                Indices = None
                RemoteIndices = None
                RemoteCluster = None
                Global = None
                Applications = None
                Metadata = None
                RunAs = None
                Description = None
                Restriction = None
                TransientMetadata = None
            }

        [<CustomOperation("sort")>]
        member _.Sort(state: Types.QueryRole, value: Types.SortResults) =
            { state with Sort = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.QueryRole, value: string) =
            { state with Name = value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: Types.QueryRole, value: Types.ClusterPrivilege list) =
            { state with Cluster = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.QueryRole, value: Types.IndicesPrivileges list) =
            { state with Indices = Some value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: Types.QueryRole, value: Types.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: Types.QueryRole, value: Types.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: Types.QueryRole, value: Types.GlobalPrivilege list) =
            { state with Global = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: Types.QueryRole, value: Types.ApplicationPrivileges list) =
            { state with Applications = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.QueryRole, value: Types.Metadata) =
            { state with Metadata = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: Types.QueryRole, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.QueryRole, value: string) =
            { state with Description = Some value }

        [<CustomOperation("restriction")>]
        member _.Restriction(state: Types.QueryRole, value: Types.Restriction) =
            { state with Restriction = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: Types.QueryRole, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

    let queryRole = QueryRoleBuilder()

    module RoleQuery =

        let bool (value: Types.BoolQuery) =
            Types.RoleQueryContainer.Bool value

        let exists (value: Types.ExistsQuery) =
            Types.RoleQueryContainer.Exists value

        let ids (value: Types.IdsQuery) =
            Types.RoleQueryContainer.Ids value

        let match' (field: Types.Field) (value: Types.MatchQuery) =
            Types.RoleQueryContainer.Match (field, value)

        let matchAll (value: Types.MatchAllQuery) =
            Types.RoleQueryContainer.MatchAll value

        let prefix (field: Types.Field) (value: Types.PrefixQuery) =
            Types.RoleQueryContainer.Prefix (field, value)

        let range (field: Types.Field) (value: Types.RangeQuery) =
            Types.RoleQueryContainer.Range (field, value)

        let simpleQueryString (value: Types.SimpleQueryStringQuery) =
            Types.RoleQueryContainer.SimpleQueryString value

        let term (field: Types.Field) (value: Types.TermQuery) =
            Types.RoleQueryContainer.Term (field, value)

        let terms (value: Types.TermsQuery) =
            Types.RoleQueryContainer.Terms value

        let wildcard (field: Types.Field) (value: Types.WildcardQuery) =
            Types.RoleQueryContainer.Wildcard (field, value)


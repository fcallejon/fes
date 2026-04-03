// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityGetRoleBuilders =

    type RoleBuilder() =
        member _.Yield(_: unit) : Types.Role =
            {
                Cluster = Unchecked.defaultof<_>
                Indices = Unchecked.defaultof<_>
                RemoteIndices = None
                RemoteCluster = None
                Metadata = Unchecked.defaultof<_>
                Description = None
                RunAs = None
                TransientMetadata = None
                Applications = Unchecked.defaultof<_>
                RoleTemplates = None
                Global = None
            }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: Types.Role, value: Types.ClusterPrivilege list) =
            { state with Cluster = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.Role, value: Types.IndicesPrivileges list) =
            { state with Indices = value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: Types.Role, value: Types.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: Types.Role, value: Types.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Types.Role, value: Types.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.Role, value: string) =
            { state with Description = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: Types.Role, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: Types.Role, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: Types.Role, value: Types.ApplicationPrivileges list) =
            { state with Applications = value }

        [<CustomOperation("roleTemplates")>]
        member _.RoleTemplates(state: Types.Role, value: Types.RoleTemplate list) =
            { state with RoleTemplates = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: Types.Role, value: Map<string, Map<string, Map<string, string list>>>) =
            { state with Global = Some value }

    let role = RoleBuilder()


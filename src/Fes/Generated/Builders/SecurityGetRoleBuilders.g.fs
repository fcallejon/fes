// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityGetRoleBuilders =

    type RoleBuilder() =
        member _.Yield(_: unit) : Role =
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
        member _.Cluster(state: Role, value: SecurityTypes.ClusterPrivilege list) =
            { state with Cluster = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Role, value: SecurityTypes.IndicesPrivileges list) =
            { state with Indices = value }

        [<CustomOperation("remoteIndices")>]
        member _.RemoteIndices(state: Role, value: SecurityTypes.RemoteIndicesPrivileges list) =
            { state with RemoteIndices = Some value }

        [<CustomOperation("remoteCluster")>]
        member _.RemoteCluster(state: Role, value: SecurityTypes.RemoteClusterPrivileges list) =
            { state with RemoteCluster = Some value }

        [<CustomOperation("metadata")>]
        member _.Metadata(state: Role, value: CoreTypes.Metadata) =
            { state with Metadata = value }

        [<CustomOperation("description")>]
        member _.Description(state: Role, value: string) =
            { state with Description = Some value }

        [<CustomOperation("runAs")>]
        member _.RunAs(state: Role, value: string list) =
            { state with RunAs = Some value }

        [<CustomOperation("transientMetadata")>]
        member _.TransientMetadata(state: Role, value: Map<string, System.Text.Json.JsonElement>) =
            { state with TransientMetadata = Some value }

        [<CustomOperation("applications")>]
        member _.Applications(state: Role, value: SecurityTypes.ApplicationPrivileges list) =
            { state with Applications = value }

        [<CustomOperation("roleTemplates")>]
        member _.RoleTemplates(state: Role, value: SecurityTypes.RoleTemplate list) =
            { state with RoleTemplates = Some value }

        [<CustomOperation("global'")>]
        member _.Global(state: Role, value: Map<string, Map<string, Map<string, string list>>>) =
            { state with Global = Some value }

    let role = RoleBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityGetRole =

    type Role = {
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: SecurityTypes.ClusterPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("indices")>]
        Indices: SecurityTypes.IndicesPrivileges list
        [<System.Text.Json.Serialization.JsonPropertyName("remote_indices")>]
        RemoteIndices: SecurityTypes.RemoteIndicesPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("remote_cluster")>]
        RemoteCluster: SecurityTypes.RemoteClusterPrivileges list option
        [<System.Text.Json.Serialization.JsonPropertyName("metadata")>]
        Metadata: CoreTypes.Metadata
        [<System.Text.Json.Serialization.JsonPropertyName("description")>]
        Description: string option
        [<System.Text.Json.Serialization.JsonPropertyName("run_as")>]
        RunAs: string list option
        [<System.Text.Json.Serialization.JsonPropertyName("transient_metadata")>]
        TransientMetadata: Map<string, System.Text.Json.JsonElement> option
        [<System.Text.Json.Serialization.JsonPropertyName("applications")>]
        Applications: SecurityTypes.ApplicationPrivileges list
        [<System.Text.Json.Serialization.JsonPropertyName("role_templates")>]
        RoleTemplates: SecurityTypes.RoleTemplate list option
        [<System.Text.Json.Serialization.JsonPropertyName("global")>]
        Global: Map<string, Map<string, Map<string, string list>>> option
    }


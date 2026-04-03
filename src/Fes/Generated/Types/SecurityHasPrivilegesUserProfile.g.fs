// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityHasPrivilegesUserProfile =

    type HasPrivilegesUserProfileErrors = {
        [<System.Text.Json.Serialization.JsonPropertyName("count")>]
        Count: Types.Long
        [<System.Text.Json.Serialization.JsonPropertyName("details")>]
        Details: Map<SecurityTypes.UserProfileId, Types.ErrorCause>
    }

    type PrivilegesCheck = {
        [<System.Text.Json.Serialization.JsonPropertyName("application")>]
        Application: SecurityHasPrivileges.ApplicationPrivilegesCheck list option
        [<System.Text.Json.Serialization.JsonPropertyName("cluster")>]
        Cluster: SecurityTypes.ClusterPrivilege list option
        [<System.Text.Json.Serialization.JsonPropertyName("index")>]
        Index: SecurityHasPrivileges.IndexPrivilegesCheck list option
    }


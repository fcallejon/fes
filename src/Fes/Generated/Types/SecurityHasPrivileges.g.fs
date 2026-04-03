// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module SecurityHasPrivileges =

    type ApplicationPrivilegesCheck = {
        [<System.Text.Json.Serialization.JsonPropertyName("application")>]
        Application: string
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: string list
        [<System.Text.Json.Serialization.JsonPropertyName("resources")>]
        Resources: string list
    }

    type Privileges = Map<string, bool>

    type ResourcePrivileges = Map<Types.Name, SecurityHasPrivileges.Privileges>

    type ApplicationsPrivileges = Map<Types.Name, SecurityHasPrivileges.ResourcePrivileges>

    type IndexPrivilegesCheck = {
        [<System.Text.Json.Serialization.JsonPropertyName("names")>]
        Names: Types.Indices
        [<System.Text.Json.Serialization.JsonPropertyName("privileges")>]
        Privileges: SecurityTypes.IndexPrivilege list
        [<System.Text.Json.Serialization.JsonPropertyName("allow_restricted_indices")>]
        AllowRestrictedIndices: bool option
    }


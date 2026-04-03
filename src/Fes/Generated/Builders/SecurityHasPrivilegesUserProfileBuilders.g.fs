// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module SecurityHasPrivilegesUserProfileBuilders =

    type PrivilegesCheckBuilder() =
        member _.Yield(_: unit) : PrivilegesCheck =
            {
                Application = None
                Cluster = None
                Index = None
            }

        [<CustomOperation("application")>]
        member _.Application(state: PrivilegesCheck, value: SecurityHasPrivileges.ApplicationPrivilegesCheck list) =
            { state with Application = Some value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: PrivilegesCheck, value: SecurityTypes.ClusterPrivilege list) =
            { state with Cluster = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: PrivilegesCheck, value: SecurityHasPrivileges.IndexPrivilegesCheck list) =
            { state with Index = Some value }

    let privilegesCheck = PrivilegesCheckBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module SecurityHasPrivilegesUserProfileBuilders =

    type PrivilegesCheckBuilder() =
        member _.Yield(_: unit) : Types.PrivilegesCheck =
            {
                Application = None
                Cluster = None
                Index = None
            }

        [<CustomOperation("application")>]
        member _.Application(state: Types.PrivilegesCheck, value: Types.ApplicationPrivilegesCheck list) =
            { state with Application = Some value }

        [<CustomOperation("cluster")>]
        member _.Cluster(state: Types.PrivilegesCheck, value: Types.ClusterPrivilege list) =
            { state with Cluster = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.PrivilegesCheck, value: Types.IndexPrivilegesCheck list) =
            { state with Index = Some value }

    let privilegesCheck = PrivilegesCheckBuilder()


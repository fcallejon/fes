// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatPluginsBuilders =

    type PluginsRecordBuilder() =
        member _.Yield(_: unit) : PluginsRecord =
            {
                Id = None
                Name = None
                Component = None
                Version = None
                Description = None
                Type = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: PluginsRecord, value: CoreTypes.NodeId) =
            { state with Id = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: PluginsRecord, value: CoreTypes.Name) =
            { state with Name = Some value }

        [<CustomOperation("component")>]
        member _.Component(state: PluginsRecord, value: string) =
            { state with Component = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: PluginsRecord, value: CoreTypes.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: PluginsRecord, value: string) =
            { state with Description = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: PluginsRecord, value: string) =
            { state with Type = Some value }

    let pluginsRecord = PluginsRecordBuilder()


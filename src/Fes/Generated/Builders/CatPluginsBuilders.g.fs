// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module CatPluginsBuilders =

    type PluginsRecordBuilder() =
        member _.Yield(_: unit) : Types.PluginsRecord =
            {
                Id = None
                Name = None
                Component = None
                Version = None
                Description = None
                Type = None
            }

        [<CustomOperation("id")>]
        member _.Id(state: Types.PluginsRecord, value: Types.NodeId) =
            { state with Id = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: Types.PluginsRecord, value: Types.Name) =
            { state with Name = Some value }

        [<CustomOperation("component")>]
        member _.Component(state: Types.PluginsRecord, value: string) =
            { state with Component = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: Types.PluginsRecord, value: Types.VersionString) =
            { state with Version = Some value }

        [<CustomOperation("description")>]
        member _.Description(state: Types.PluginsRecord, value: string) =
            { state with Description = Some value }

        [<CustomOperation("type'")>]
        member _.Type(state: Types.PluginsRecord, value: string) =
            { state with Type = Some value }

    let pluginsRecord = PluginsRecordBuilder()


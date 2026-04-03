// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesCreateFromBuilders =

    type CreateFromBuilder() =
        member _.Yield(_: unit) : Types.CreateFrom =
            {
                MappingsOverride = None
                SettingsOverride = None
                RemoveIndexBlocks = None
            }

        [<CustomOperation("mappingsOverride")>]
        member _.MappingsOverride(state: Types.CreateFrom, value: Types.TypeMapping) =
            { state with MappingsOverride = Some value }

        [<CustomOperation("settingsOverride")>]
        member _.SettingsOverride(state: Types.CreateFrom, value: Types.IndexSettings) =
            { state with SettingsOverride = Some value }

        [<CustomOperation("removeIndexBlocks")>]
        member _.RemoveIndexBlocks(state: Types.CreateFrom, value: bool) =
            { state with RemoveIndexBlocks = Some value }

    let createFrom = CreateFromBuilder()


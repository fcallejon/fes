// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesCreateFromBuilders =

    type CreateFromBuilder() =
        member _.Yield(_: unit) : CreateFrom =
            {
                MappingsOverride = None
                SettingsOverride = None
                RemoveIndexBlocks = None
            }

        [<CustomOperation("mappingsOverride")>]
        member _.MappingsOverride(state: CreateFrom, value: CoreTypes.TypeMapping) =
            { state with MappingsOverride = Some value }

        [<CustomOperation("settingsOverride")>]
        member _.SettingsOverride(state: CreateFrom, value: IndicesTypes.IndexSettings) =
            { state with SettingsOverride = Some value }

        [<CustomOperation("removeIndexBlocks")>]
        member _.RemoveIndexBlocks(state: CreateFrom, value: bool) =
            { state with RemoveIndexBlocks = Some value }

    let createFrom = CreateFromBuilder()


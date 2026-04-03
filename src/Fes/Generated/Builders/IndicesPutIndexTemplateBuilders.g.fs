// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesPutIndexTemplateBuilders =

    type IndexTemplateMappingBuilder() =
        member _.Yield(_: unit) : Types.IndexTemplateMapping =
            {
                Aliases = None
                Mappings = None
                Settings = None
                Lifecycle = None
                DataStreamOptions = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.IndexTemplateMapping, value: Map<Types.IndexName, Types.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: Types.IndexTemplateMapping, value: Types.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: Types.IndexTemplateMapping, value: Types.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: Types.IndexTemplateMapping, value: Types.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: Types.IndexTemplateMapping, value: Types.DataStreamOptionsTemplate option) =
            { state with DataStreamOptions = Some value }

    let indexTemplateMapping = IndexTemplateMappingBuilder()


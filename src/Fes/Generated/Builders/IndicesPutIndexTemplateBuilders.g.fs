// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesPutIndexTemplateBuilders =

    type IndexTemplateMappingBuilder() =
        member _.Yield(_: unit) : IndexTemplateMapping =
            {
                Aliases = None
                Mappings = None
                Settings = None
                Lifecycle = None
                DataStreamOptions = None
            }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: IndexTemplateMapping, value: Map<Types.IndexName, IndicesTypes.Alias>) =
            { state with Aliases = Some value }

        [<CustomOperation("mappings")>]
        member _.Mappings(state: IndexTemplateMapping, value: TypesMapping.TypeMapping) =
            { state with Mappings = Some value }

        [<CustomOperation("settings")>]
        member _.Settings(state: IndexTemplateMapping, value: IndicesTypes.IndexSettings) =
            { state with Settings = Some value }

        [<CustomOperation("lifecycle")>]
        member _.Lifecycle(state: IndexTemplateMapping, value: IndicesTypes.DataStreamLifecycle) =
            { state with Lifecycle = Some value }

        [<CustomOperation("dataStreamOptions")>]
        member _.DataStreamOptions(state: IndexTemplateMapping, value: IndicesTypes.DataStreamOptionsTemplate option) =
            { state with DataStreamOptions = Some value }

    let indexTemplateMapping = IndexTemplateMappingBuilder()


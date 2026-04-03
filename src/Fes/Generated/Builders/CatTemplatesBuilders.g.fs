// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatTemplatesBuilders =

    type TemplatesRecordBuilder() =
        member _.Yield(_: unit) : TemplatesRecord =
            {
                Name = None
                IndexPatterns = None
                Order = None
                Version = None
                ComposedOf = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: TemplatesRecord, value: CoreTypes.Name) =
            { state with Name = Some value }

        [<CustomOperation("indexPatterns")>]
        member _.IndexPatterns(state: TemplatesRecord, value: string) =
            { state with IndexPatterns = Some value }

        [<CustomOperation("order")>]
        member _.Order(state: TemplatesRecord, value: string) =
            { state with Order = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: TemplatesRecord, value: CoreTypes.VersionString option) =
            { state with Version = Some value }

        [<CustomOperation("composedOf")>]
        member _.ComposedOf(state: TemplatesRecord, value: string) =
            { state with ComposedOf = Some value }

    let templatesRecord = TemplatesRecordBuilder()


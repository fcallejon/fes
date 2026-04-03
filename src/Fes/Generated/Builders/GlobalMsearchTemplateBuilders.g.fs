// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module GlobalMsearchTemplateBuilders =

    type TemplateConfigBuilder() =
        member _.Yield(_: unit) : TemplateConfig =
            {
                Explain = None
                Id = None
                Params = None
                Profile = None
                Source = None
            }

        [<CustomOperation("explain")>]
        member _.Explain(state: TemplateConfig, value: bool) =
            { state with Explain = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: TemplateConfig, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("params")>]
        member _.Params(state: TemplateConfig, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Params = Some value }

        [<CustomOperation("profile")>]
        member _.Profile(state: TemplateConfig, value: bool) =
            { state with Profile = Some value }

        [<CustomOperation("source")>]
        member _.Source(state: TemplateConfig, value: Types.ScriptSource) =
            { state with Source = Some value }

    let templateConfig = TemplateConfigBuilder()


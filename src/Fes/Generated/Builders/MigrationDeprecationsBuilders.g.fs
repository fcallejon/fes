// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module MigrationDeprecationsBuilders =

    type DeprecationBuilder() =
        member _.Yield(_: unit) : Types.Deprecation =
            {
                Details = None
                Level = Unchecked.defaultof<_>
                Message = Unchecked.defaultof<_>
                Url = Unchecked.defaultof<_>
                ResolveDuringRollingUpgrade = Unchecked.defaultof<_>
                Meta = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Types.Deprecation, value: string) =
            { state with Details = Some value }

        [<CustomOperation("level")>]
        member _.Level(state: Types.Deprecation, value: Types.DeprecationLevel) =
            { state with Level = value }

        [<CustomOperation("message")>]
        member _.Message(state: Types.Deprecation, value: string) =
            { state with Message = value }

        [<CustomOperation("url")>]
        member _.Url(state: Types.Deprecation, value: string) =
            { state with Url = value }

        [<CustomOperation("resolveDuringRollingUpgrade")>]
        member _.ResolveDuringRollingUpgrade(state: Types.Deprecation, value: bool) =
            { state with ResolveDuringRollingUpgrade = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Types.Deprecation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Meta = Some value }

    let deprecation = DeprecationBuilder()


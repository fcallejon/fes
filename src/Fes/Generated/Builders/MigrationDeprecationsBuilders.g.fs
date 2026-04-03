// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module MigrationDeprecationsBuilders =

    type DeprecationBuilder() =
        member _.Yield(_: unit) : Deprecation =
            {
                Details = None
                Level = Unchecked.defaultof<_>
                Message = Unchecked.defaultof<_>
                Url = Unchecked.defaultof<_>
                ResolveDuringRollingUpgrade = Unchecked.defaultof<_>
                Meta = None
            }

        [<CustomOperation("details")>]
        member _.Details(state: Deprecation, value: string) =
            { state with Details = Some value }

        [<CustomOperation("level")>]
        member _.Level(state: Deprecation, value: MigrationDeprecations.DeprecationLevel) =
            { state with Level = value }

        [<CustomOperation("message")>]
        member _.Message(state: Deprecation, value: string) =
            { state with Message = value }

        [<CustomOperation("url")>]
        member _.Url(state: Deprecation, value: string) =
            { state with Url = value }

        [<CustomOperation("resolveDuringRollingUpgrade")>]
        member _.ResolveDuringRollingUpgrade(state: Deprecation, value: bool) =
            { state with ResolveDuringRollingUpgrade = value }

        [<CustomOperation("meta")>]
        member _.Meta(state: Deprecation, value: Map<string, System.Text.Json.JsonElement>) =
            { state with Meta = Some value }

    let deprecation = DeprecationBuilder()


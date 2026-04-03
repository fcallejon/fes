// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IlmMoveToStepBuilders =

    type StepKeyBuilder() =
        member _.Yield(_: unit) : StepKey =
            {
                Action = None
                Name = None
                Phase = Unchecked.defaultof<_>
            }

        [<CustomOperation("action")>]
        member _.Action(state: StepKey, value: string) =
            { state with Action = Some value }

        [<CustomOperation("name")>]
        member _.Name(state: StepKey, value: string) =
            { state with Name = Some value }

        [<CustomOperation("phase")>]
        member _.Phase(state: StepKey, value: string) =
            { state with Phase = value }

    let stepKey = StepKeyBuilder()


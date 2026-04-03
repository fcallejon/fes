// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module AutoscalingGetAutoscalingCapacityBuilders =

    type AutoscalingDeciderBuilder() =
        member _.Yield(_: unit) : AutoscalingDecider =
            {
                RequiredCapacity = Unchecked.defaultof<_>
                ReasonSummary = None
                ReasonDetails = None
            }

        [<CustomOperation("requiredCapacity")>]
        member _.RequiredCapacity(state: AutoscalingDecider, value: AutoscalingGetAutoscalingCapacity.AutoscalingCapacity) =
            { state with RequiredCapacity = value }

        [<CustomOperation("reasonSummary")>]
        member _.ReasonSummary(state: AutoscalingDecider, value: string) =
            { state with ReasonSummary = Some value }

        [<CustomOperation("reasonDetails")>]
        member _.ReasonDetails(state: AutoscalingDecider, value: System.Text.Json.JsonElement) =
            { state with ReasonDetails = Some value }

    let autoscalingDecider = AutoscalingDeciderBuilder()


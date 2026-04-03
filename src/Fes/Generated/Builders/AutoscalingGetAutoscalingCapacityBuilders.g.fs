// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module AutoscalingGetAutoscalingCapacityBuilders =

    type AutoscalingDeciderBuilder() =
        member _.Yield(_: unit) : Types.AutoscalingDecider =
            {
                RequiredCapacity = Unchecked.defaultof<_>
                ReasonSummary = None
                ReasonDetails = None
            }

        [<CustomOperation("requiredCapacity")>]
        member _.RequiredCapacity(state: Types.AutoscalingDecider, value: Types.AutoscalingCapacity) =
            { state with RequiredCapacity = value }

        [<CustomOperation("reasonSummary")>]
        member _.ReasonSummary(state: Types.AutoscalingDecider, value: string) =
            { state with ReasonSummary = Some value }

        [<CustomOperation("reasonDetails")>]
        member _.ReasonDetails(state: Types.AutoscalingDecider, value: System.Text.Json.JsonElement) =
            { state with ReasonDetails = Some value }

    let autoscalingDecider = AutoscalingDeciderBuilder()


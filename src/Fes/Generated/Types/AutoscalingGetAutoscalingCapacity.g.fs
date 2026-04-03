// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module AutoscalingGetAutoscalingCapacity =

    type AutoscalingResources = {
        [<System.Text.Json.Serialization.JsonPropertyName("storage")>]
        Storage: CoreTypes.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("memory")>]
        Memory: CoreTypes.Integer
    }

    type AutoscalingCapacity = {
        [<System.Text.Json.Serialization.JsonPropertyName("node")>]
        Node: AutoscalingResources
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: AutoscalingResources
    }

    type AutoscalingDecider = {
        [<System.Text.Json.Serialization.JsonPropertyName("required_capacity")>]
        RequiredCapacity: AutoscalingCapacity
        [<System.Text.Json.Serialization.JsonPropertyName("reason_summary")>]
        ReasonSummary: string option
        [<System.Text.Json.Serialization.JsonPropertyName("reason_details")>]
        ReasonDetails: System.Text.Json.JsonElement option
    }

    type AutoscalingNode = {
        [<System.Text.Json.Serialization.JsonPropertyName("name")>]
        Name: CoreTypes.NodeName
    }

    type AutoscalingDeciders = {
        [<System.Text.Json.Serialization.JsonPropertyName("required_capacity")>]
        RequiredCapacity: AutoscalingCapacity
        [<System.Text.Json.Serialization.JsonPropertyName("current_capacity")>]
        CurrentCapacity: AutoscalingCapacity
        [<System.Text.Json.Serialization.JsonPropertyName("current_nodes")>]
        CurrentNodes: AutoscalingNode list
        [<System.Text.Json.Serialization.JsonPropertyName("deciders")>]
        Deciders: Map<string, AutoscalingDecider>
    }


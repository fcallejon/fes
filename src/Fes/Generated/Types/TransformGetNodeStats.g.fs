// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module TransformGetNodeStats =

    type TransformSchedulerStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("registered_transform_count")>]
        RegisteredTransformCount: Types.Integer
        [<System.Text.Json.Serialization.JsonPropertyName("peek_transform")>]
        PeekTransform: string option
    }

    type TransformNodeStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("scheduler")>]
        Scheduler: TransformGetNodeStats.TransformSchedulerStats
    }

    type TransformNodeFullStats = {
        [<System.Text.Json.Serialization.JsonPropertyName("total")>]
        Total: TransformGetNodeStats.TransformNodeStats
    }


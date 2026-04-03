// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Types


open System.Text.Json.Serialization

module CatCircuitBreaker =

    type CircuitBreakerRecord = {
        [<System.Text.Json.Serialization.JsonPropertyName("node_id")>]
        NodeId: CoreTypes.NodeId option
        [<System.Text.Json.Serialization.JsonPropertyName("node_name")>]
        NodeName: string option
        [<System.Text.Json.Serialization.JsonPropertyName("breaker")>]
        Breaker: string option
        [<System.Text.Json.Serialization.JsonPropertyName("limit")>]
        Limit: string option
        [<System.Text.Json.Serialization.JsonPropertyName("limit_bytes")>]
        LimitBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated")>]
        Estimated: string option
        [<System.Text.Json.Serialization.JsonPropertyName("estimated_bytes")>]
        EstimatedBytes: CoreTypes.ByteSize option
        [<System.Text.Json.Serialization.JsonPropertyName("tripped")>]
        Tripped: string option
        [<System.Text.Json.Serialization.JsonPropertyName("overhead")>]
        Overhead: string option
    }


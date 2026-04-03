// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CatCircuitBreakerBuilders =

    type CircuitBreakerRecordBuilder() =
        member _.Yield(_: unit) : CircuitBreakerRecord =
            {
                NodeId = None
                NodeName = None
                Breaker = None
                Limit = None
                LimitBytes = None
                Estimated = None
                EstimatedBytes = None
                Tripped = None
                Overhead = None
            }

        [<CustomOperation("nodeId")>]
        member _.NodeId(state: CircuitBreakerRecord, value: CoreTypes.NodeId) =
            { state with NodeId = Some value }

        [<CustomOperation("nodeName")>]
        member _.NodeName(state: CircuitBreakerRecord, value: string) =
            { state with NodeName = Some value }

        [<CustomOperation("breaker")>]
        member _.Breaker(state: CircuitBreakerRecord, value: string) =
            { state with Breaker = Some value }

        [<CustomOperation("limit")>]
        member _.Limit(state: CircuitBreakerRecord, value: string) =
            { state with Limit = Some value }

        [<CustomOperation("limitBytes")>]
        member _.LimitBytes(state: CircuitBreakerRecord, value: CoreTypes.ByteSize) =
            { state with LimitBytes = Some value }

        [<CustomOperation("estimated")>]
        member _.Estimated(state: CircuitBreakerRecord, value: string) =
            { state with Estimated = Some value }

        [<CustomOperation("estimatedBytes")>]
        member _.EstimatedBytes(state: CircuitBreakerRecord, value: CoreTypes.ByteSize) =
            { state with EstimatedBytes = Some value }

        [<CustomOperation("tripped")>]
        member _.Tripped(state: CircuitBreakerRecord, value: string) =
            { state with Tripped = Some value }

        [<CustomOperation("overhead")>]
        member _.Overhead(state: CircuitBreakerRecord, value: string) =
            { state with Overhead = Some value }

    let circuitBreakerRecord = CircuitBreakerRecordBuilder()


// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module ClusterHealthBuilders =

    type HealthResponseBodyBuilder() =
        member _.Yield(_: unit) : Types.HealthResponseBody =
            {
                ActivePrimaryShards = Unchecked.defaultof<_>
                ActiveShards = Unchecked.defaultof<_>
                ActiveShardsPercent = None
                ActiveShardsPercentAsNumber = Unchecked.defaultof<_>
                ClusterName = Unchecked.defaultof<_>
                DelayedUnassignedShards = Unchecked.defaultof<_>
                Indices = None
                InitializingShards = Unchecked.defaultof<_>
                NumberOfDataNodes = Unchecked.defaultof<_>
                NumberOfInFlightFetch = Unchecked.defaultof<_>
                NumberOfNodes = Unchecked.defaultof<_>
                NumberOfPendingTasks = Unchecked.defaultof<_>
                RelocatingShards = Unchecked.defaultof<_>
                Status = Unchecked.defaultof<_>
                TaskMaxWaitingInQueue = None
                TaskMaxWaitingInQueueMillis = Unchecked.defaultof<_>
                TimedOut = Unchecked.defaultof<_>
                UnassignedPrimaryShards = Unchecked.defaultof<_>
                UnassignedShards = Unchecked.defaultof<_>
            }

        [<CustomOperation("activePrimaryShards")>]
        member _.ActivePrimaryShards(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with ActivePrimaryShards = value }

        [<CustomOperation("activeShards")>]
        member _.ActiveShards(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with ActiveShards = value }

        [<CustomOperation("activeShardsPercent")>]
        member _.ActiveShardsPercent(state: Types.HealthResponseBody, value: string) =
            { state with ActiveShardsPercent = Some value }

        [<CustomOperation("activeShardsPercentAsNumber")>]
        member _.ActiveShardsPercentAsNumber(state: Types.HealthResponseBody, value: Types.Double) =
            { state with ActiveShardsPercentAsNumber = value }

        [<CustomOperation("clusterName")>]
        member _.ClusterName(state: Types.HealthResponseBody, value: Types.Name) =
            { state with ClusterName = value }

        [<CustomOperation("delayedUnassignedShards")>]
        member _.DelayedUnassignedShards(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with DelayedUnassignedShards = value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.HealthResponseBody, value: Map<Types.IndexName, Types.IndexHealthStats>) =
            { state with Indices = Some value }

        [<CustomOperation("initializingShards")>]
        member _.InitializingShards(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with InitializingShards = value }

        [<CustomOperation("numberOfDataNodes")>]
        member _.NumberOfDataNodes(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with NumberOfDataNodes = value }

        [<CustomOperation("numberOfInFlightFetch")>]
        member _.NumberOfInFlightFetch(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with NumberOfInFlightFetch = value }

        [<CustomOperation("numberOfNodes")>]
        member _.NumberOfNodes(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with NumberOfNodes = value }

        [<CustomOperation("numberOfPendingTasks")>]
        member _.NumberOfPendingTasks(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with NumberOfPendingTasks = value }

        [<CustomOperation("relocatingShards")>]
        member _.RelocatingShards(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with RelocatingShards = value }

        [<CustomOperation("status")>]
        member _.Status(state: Types.HealthResponseBody, value: Types.HealthStatus) =
            { state with Status = value }

        [<CustomOperation("taskMaxWaitingInQueue")>]
        member _.TaskMaxWaitingInQueue(state: Types.HealthResponseBody, value: Types.Duration) =
            { state with TaskMaxWaitingInQueue = Some value }

        [<CustomOperation("taskMaxWaitingInQueueMillis")>]
        member _.TaskMaxWaitingInQueueMillis(state: Types.HealthResponseBody, value: Types.DurationValue<Types.UnitMillis>) =
            { state with TaskMaxWaitingInQueueMillis = value }

        [<CustomOperation("timedOut")>]
        member _.TimedOut(state: Types.HealthResponseBody, value: bool) =
            { state with TimedOut = value }

        [<CustomOperation("unassignedPrimaryShards")>]
        member _.UnassignedPrimaryShards(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with UnassignedPrimaryShards = value }

        [<CustomOperation("unassignedShards")>]
        member _.UnassignedShards(state: Types.HealthResponseBody, value: Types.Integer) =
            { state with UnassignedShards = value }

    let healthResponseBody = HealthResponseBodyBuilder()


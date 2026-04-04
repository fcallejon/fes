// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module AsyncSearchStatusBuilders =

    type StatusResponseBaseBuilder() =
        member _.Yield(_: unit) : Types.StatusResponseBase =
            {
                Shards = Unchecked.defaultof<_>
                Clusters = None
                CompletionStatus = None
                Id = None
                IsPartial = Unchecked.defaultof<_>
                IsRunning = Unchecked.defaultof<_>
                ExpirationTime = None
                ExpirationTimeInMillis = Unchecked.defaultof<_>
                StartTime = None
                StartTimeInMillis = Unchecked.defaultof<_>
                CompletionTime = None
                CompletionTimeInMillis = None
                Error = None
            }

        [<CustomOperation("shards")>]
        member _.Shards(state: Types.StatusResponseBase, value: Types.ShardStatistics) =
            { state with Shards = value }

        [<CustomOperation("clusters")>]
        member _.Clusters(state: Types.StatusResponseBase, value: Types.ClusterStatistics) =
            { state with Clusters = Some value }

        [<CustomOperation("completionStatus")>]
        member _.CompletionStatus(state: Types.StatusResponseBase, value: Types.Integer) =
            { state with CompletionStatus = Some value }

        [<CustomOperation("id")>]
        member _.Id(state: Types.StatusResponseBase, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: Types.StatusResponseBase, value: bool) =
            { state with IsPartial = value }

        [<CustomOperation("isRunning")>]
        member _.IsRunning(state: Types.StatusResponseBase, value: bool) =
            { state with IsRunning = value }

        [<CustomOperation("expirationTime")>]
        member _.ExpirationTime(state: Types.StatusResponseBase, value: Types.DateTime) =
            { state with ExpirationTime = Some value }

        [<CustomOperation("expirationTimeInMillis")>]
        member _.ExpirationTimeInMillis(state: Types.StatusResponseBase, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ExpirationTimeInMillis = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.StatusResponseBase, value: Types.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: Types.StatusResponseBase, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTimeInMillis = value }

        [<CustomOperation("completionTime")>]
        member _.CompletionTime(state: Types.StatusResponseBase, value: Types.DateTime) =
            { state with CompletionTime = Some value }

        [<CustomOperation("completionTimeInMillis")>]
        member _.CompletionTimeInMillis(state: Types.StatusResponseBase, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CompletionTimeInMillis = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.StatusResponseBase, value: Types.ErrorCause) =
            { state with Error = Some value }

    let statusResponseBase = StatusResponseBaseBuilder()


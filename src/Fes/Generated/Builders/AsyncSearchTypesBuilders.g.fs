// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module AsyncSearchTypesBuilders =

    type AsyncSearchResponseBaseBuilder() =
        member _.Yield(_: unit) : Types.AsyncSearchResponseBase =
            {
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

        [<CustomOperation("id")>]
        member _.Id(state: Types.AsyncSearchResponseBase, value: Types.Id) =
            { state with Id = Some value }

        [<CustomOperation("isPartial")>]
        member _.IsPartial(state: Types.AsyncSearchResponseBase, value: bool) =
            { state with IsPartial = value }

        [<CustomOperation("isRunning")>]
        member _.IsRunning(state: Types.AsyncSearchResponseBase, value: bool) =
            { state with IsRunning = value }

        [<CustomOperation("expirationTime")>]
        member _.ExpirationTime(state: Types.AsyncSearchResponseBase, value: Types.DateTime) =
            { state with ExpirationTime = Some value }

        [<CustomOperation("expirationTimeInMillis")>]
        member _.ExpirationTimeInMillis(state: Types.AsyncSearchResponseBase, value: Types.EpochTime<Types.UnitMillis>) =
            { state with ExpirationTimeInMillis = value }

        [<CustomOperation("startTime")>]
        member _.StartTime(state: Types.AsyncSearchResponseBase, value: Types.DateTime) =
            { state with StartTime = Some value }

        [<CustomOperation("startTimeInMillis")>]
        member _.StartTimeInMillis(state: Types.AsyncSearchResponseBase, value: Types.EpochTime<Types.UnitMillis>) =
            { state with StartTimeInMillis = value }

        [<CustomOperation("completionTime")>]
        member _.CompletionTime(state: Types.AsyncSearchResponseBase, value: Types.DateTime) =
            { state with CompletionTime = Some value }

        [<CustomOperation("completionTimeInMillis")>]
        member _.CompletionTimeInMillis(state: Types.AsyncSearchResponseBase, value: Types.EpochTime<Types.UnitMillis>) =
            { state with CompletionTimeInMillis = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: Types.AsyncSearchResponseBase, value: Types.ErrorCause) =
            { state with Error = Some value }

    let asyncSearchResponseBase = AsyncSearchResponseBaseBuilder()


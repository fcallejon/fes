// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module CcrFollowInfoBuilders =

    type FollowerIndexParametersBuilder() =
        member _.Yield(_: unit) : FollowerIndexParameters =
            {
                MaxOutstandingReadRequests = None
                MaxOutstandingWriteRequests = None
                MaxReadRequestOperationCount = None
                MaxReadRequestSize = None
                MaxRetryDelay = None
                MaxWriteBufferCount = None
                MaxWriteBufferSize = None
                MaxWriteRequestOperationCount = None
                MaxWriteRequestSize = None
                ReadPollTimeout = None
            }

        [<CustomOperation("maxOutstandingReadRequests")>]
        member _.MaxOutstandingReadRequests(state: FollowerIndexParameters, value: CoreTypes.Long) =
            { state with MaxOutstandingReadRequests = Some value }

        [<CustomOperation("maxOutstandingWriteRequests")>]
        member _.MaxOutstandingWriteRequests(state: FollowerIndexParameters, value: CoreTypes.Integer) =
            { state with MaxOutstandingWriteRequests = Some value }

        [<CustomOperation("maxReadRequestOperationCount")>]
        member _.MaxReadRequestOperationCount(state: FollowerIndexParameters, value: CoreTypes.Integer) =
            { state with MaxReadRequestOperationCount = Some value }

        [<CustomOperation("maxReadRequestSize")>]
        member _.MaxReadRequestSize(state: FollowerIndexParameters, value: CoreTypes.ByteSize) =
            { state with MaxReadRequestSize = Some value }

        [<CustomOperation("maxRetryDelay")>]
        member _.MaxRetryDelay(state: FollowerIndexParameters, value: CoreTypes.Duration) =
            { state with MaxRetryDelay = Some value }

        [<CustomOperation("maxWriteBufferCount")>]
        member _.MaxWriteBufferCount(state: FollowerIndexParameters, value: CoreTypes.Integer) =
            { state with MaxWriteBufferCount = Some value }

        [<CustomOperation("maxWriteBufferSize")>]
        member _.MaxWriteBufferSize(state: FollowerIndexParameters, value: CoreTypes.ByteSize) =
            { state with MaxWriteBufferSize = Some value }

        [<CustomOperation("maxWriteRequestOperationCount")>]
        member _.MaxWriteRequestOperationCount(state: FollowerIndexParameters, value: CoreTypes.Integer) =
            { state with MaxWriteRequestOperationCount = Some value }

        [<CustomOperation("maxWriteRequestSize")>]
        member _.MaxWriteRequestSize(state: FollowerIndexParameters, value: CoreTypes.ByteSize) =
            { state with MaxWriteRequestSize = Some value }

        [<CustomOperation("readPollTimeout")>]
        member _.ReadPollTimeout(state: FollowerIndexParameters, value: CoreTypes.Duration) =
            { state with ReadPollTimeout = Some value }

    let followerIndexParameters = FollowerIndexParametersBuilder()


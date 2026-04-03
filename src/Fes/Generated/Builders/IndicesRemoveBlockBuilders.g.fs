// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesRemoveBlockBuilders =

    type RemoveIndicesBlockStatusBuilder() =
        member _.Yield(_: unit) : RemoveIndicesBlockStatus =
            {
                Name = Unchecked.defaultof<_>
                Unblocked = None
                Exception = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: RemoveIndicesBlockStatus, value: Types.IndexName) =
            { state with Name = value }

        [<CustomOperation("unblocked")>]
        member _.Unblocked(state: RemoveIndicesBlockStatus, value: bool) =
            { state with Unblocked = Some value }

        [<CustomOperation("exception'")>]
        member _.Exception(state: RemoveIndicesBlockStatus, value: Types.ErrorCause) =
            { state with Exception = Some value }

    let removeIndicesBlockStatus = RemoveIndicesBlockStatusBuilder()


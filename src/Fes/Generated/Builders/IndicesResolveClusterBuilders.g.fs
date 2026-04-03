// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesResolveClusterBuilders =

    type ResolveClusterInfoBuilder() =
        member _.Yield(_: unit) : ResolveClusterInfo =
            {
                Connected = Unchecked.defaultof<_>
                SkipUnavailable = Unchecked.defaultof<_>
                MatchingIndices = None
                Error = None
                Version = None
            }

        [<CustomOperation("connected")>]
        member _.Connected(state: ResolveClusterInfo, value: bool) =
            { state with Connected = value }

        [<CustomOperation("skipUnavailable")>]
        member _.SkipUnavailable(state: ResolveClusterInfo, value: bool) =
            { state with SkipUnavailable = value }

        [<CustomOperation("matchingIndices")>]
        member _.MatchingIndices(state: ResolveClusterInfo, value: bool) =
            { state with MatchingIndices = Some value }

        [<CustomOperation("error")>]
        member _.Error(state: ResolveClusterInfo, value: string) =
            { state with Error = Some value }

        [<CustomOperation("version")>]
        member _.Version(state: ResolveClusterInfo, value: CoreTypes.ElasticsearchVersionMinInfo) =
            { state with Version = Some value }

    let resolveClusterInfo = ResolveClusterInfoBuilder()


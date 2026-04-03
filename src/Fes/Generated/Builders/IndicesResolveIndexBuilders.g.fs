// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesResolveIndexBuilders =

    type ResolveIndexItemBuilder() =
        member _.Yield(_: unit) : Types.ResolveIndexItem =
            {
                Name = Unchecked.defaultof<_>
                Aliases = None
                Attributes = Unchecked.defaultof<_>
                DataStream = None
                Mode = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: Types.ResolveIndexItem, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.ResolveIndexItem, value: string list) =
            { state with Aliases = Some value }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: Types.ResolveIndexItem, value: string list) =
            { state with Attributes = value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: Types.ResolveIndexItem, value: Types.DataStreamName) =
            { state with DataStream = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: Types.ResolveIndexItem, value: Types.IndexMode) =
            { state with Mode = Some value }

    let resolveIndexItem = ResolveIndexItemBuilder()


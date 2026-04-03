// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesResolveIndexBuilders =

    type ResolveIndexItemBuilder() =
        member _.Yield(_: unit) : ResolveIndexItem =
            {
                Name = Unchecked.defaultof<_>
                Aliases = None
                Attributes = Unchecked.defaultof<_>
                DataStream = None
                Mode = None
            }

        [<CustomOperation("name")>]
        member _.Name(state: ResolveIndexItem, value: Types.Name) =
            { state with Name = value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: ResolveIndexItem, value: string list) =
            { state with Aliases = Some value }

        [<CustomOperation("attributes")>]
        member _.Attributes(state: ResolveIndexItem, value: string list) =
            { state with Attributes = value }

        [<CustomOperation("dataStream")>]
        member _.DataStream(state: ResolveIndexItem, value: Types.DataStreamName) =
            { state with DataStream = Some value }

        [<CustomOperation("mode")>]
        member _.Mode(state: ResolveIndexItem, value: IndicesTypes.IndexMode) =
            { state with Mode = Some value }

    let resolveIndexItem = ResolveIndexItemBuilder()


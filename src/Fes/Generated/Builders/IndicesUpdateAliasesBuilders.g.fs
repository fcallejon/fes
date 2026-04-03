// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated

[<AutoOpen>]
module IndicesUpdateAliasesBuilders =

    module Action =

        let add (value: Types.AddAction) =
            Types.IndicesUpdateAliasesAction.Add value

        let remove (value: Types.RemoveAction) =
            Types.IndicesUpdateAliasesAction.Remove value

        let removeIndex (value: Types.RemoveIndexAction) =
            Types.IndicesUpdateAliasesAction.RemoveIndex value

    type AddActionBuilder() =
        member _.Yield(_: unit) : Types.AddAction =
            {
                Alias = None
                Aliases = None
                Filter = None
                Index = None
                Indices = None
                IndexRouting = None
                IsHidden = None
                IsWriteIndex = None
                Routing = None
                SearchRouting = None
                MustExist = None
            }

        [<CustomOperation("alias")>]
        member _.Alias(state: Types.AddAction, value: Types.IndexAlias) =
            { state with Alias = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.AddAction, value: System.Text.Json.JsonElement) =
            { state with Aliases = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: Types.AddAction, value: Types.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.AddAction, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.AddAction, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("indexRouting")>]
        member _.IndexRouting(state: Types.AddAction, value: string) =
            { state with IndexRouting = Some value }

        [<CustomOperation("isHidden")>]
        member _.IsHidden(state: Types.AddAction, value: bool) =
            { state with IsHidden = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: Types.AddAction, value: bool) =
            { state with IsWriteIndex = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: Types.AddAction, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("searchRouting")>]
        member _.SearchRouting(state: Types.AddAction, value: string) =
            { state with SearchRouting = Some value }

        [<CustomOperation("mustExist")>]
        member _.MustExist(state: Types.AddAction, value: bool) =
            { state with MustExist = Some value }

    let addAction = AddActionBuilder()

    type RemoveActionBuilder() =
        member _.Yield(_: unit) : Types.RemoveAction =
            {
                Alias = None
                Aliases = None
                Index = None
                Indices = None
                MustExist = None
            }

        [<CustomOperation("alias")>]
        member _.Alias(state: Types.RemoveAction, value: Types.IndexAlias) =
            { state with Alias = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: Types.RemoveAction, value: System.Text.Json.JsonElement) =
            { state with Aliases = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: Types.RemoveAction, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.RemoveAction, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("mustExist")>]
        member _.MustExist(state: Types.RemoveAction, value: bool) =
            { state with MustExist = Some value }

    let removeAction = RemoveActionBuilder()

    type RemoveIndexActionBuilder() =
        member _.Yield(_: unit) : Types.RemoveIndexAction =
            {
                Index = None
                Indices = None
                MustExist = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: Types.RemoveIndexAction, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: Types.RemoveIndexAction, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("mustExist")>]
        member _.MustExist(state: Types.RemoveIndexAction, value: bool) =
            { state with MustExist = Some value }

    let removeIndexAction = RemoveIndexActionBuilder()


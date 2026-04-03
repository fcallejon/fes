// Auto-generated from Elasticsearch schema.json — do not edit manually

namespace Fes.Generated.Builders


open System.Text.Json.Serialization
open Fes.Generated.Types

[<AutoOpen>]
module IndicesUpdateAliasesBuilders =

    module Action =

        let add (value: IndicesUpdateAliases.AddAction) =
            Action.Add value

        let remove (value: IndicesUpdateAliases.RemoveAction) =
            Action.Remove value

        let removeIndex (value: IndicesUpdateAliases.RemoveIndexAction) =
            Action.RemoveIndex value

    type AddActionBuilder() =
        member _.Yield(_: unit) : AddAction =
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
        member _.Alias(state: AddAction, value: Types.IndexAlias) =
            { state with Alias = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: AddAction, value: System.Text.Json.JsonElement) =
            { state with Aliases = Some value }

        [<CustomOperation("filter")>]
        member _.Filter(state: AddAction, value: TypesQueryDsl.QueryContainer) =
            { state with Filter = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: AddAction, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: AddAction, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("indexRouting")>]
        member _.IndexRouting(state: AddAction, value: string) =
            { state with IndexRouting = Some value }

        [<CustomOperation("isHidden")>]
        member _.IsHidden(state: AddAction, value: bool) =
            { state with IsHidden = Some value }

        [<CustomOperation("isWriteIndex")>]
        member _.IsWriteIndex(state: AddAction, value: bool) =
            { state with IsWriteIndex = Some value }

        [<CustomOperation("routing")>]
        member _.Routing(state: AddAction, value: string) =
            { state with Routing = Some value }

        [<CustomOperation("searchRouting")>]
        member _.SearchRouting(state: AddAction, value: string) =
            { state with SearchRouting = Some value }

        [<CustomOperation("mustExist")>]
        member _.MustExist(state: AddAction, value: bool) =
            { state with MustExist = Some value }

    let addAction = AddActionBuilder()

    type RemoveActionBuilder() =
        member _.Yield(_: unit) : RemoveAction =
            {
                Alias = None
                Aliases = None
                Index = None
                Indices = None
                MustExist = None
            }

        [<CustomOperation("alias")>]
        member _.Alias(state: RemoveAction, value: Types.IndexAlias) =
            { state with Alias = Some value }

        [<CustomOperation("aliases")>]
        member _.Aliases(state: RemoveAction, value: System.Text.Json.JsonElement) =
            { state with Aliases = Some value }

        [<CustomOperation("index")>]
        member _.Index(state: RemoveAction, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: RemoveAction, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("mustExist")>]
        member _.MustExist(state: RemoveAction, value: bool) =
            { state with MustExist = Some value }

    let removeAction = RemoveActionBuilder()

    type RemoveIndexActionBuilder() =
        member _.Yield(_: unit) : RemoveIndexAction =
            {
                Index = None
                Indices = None
                MustExist = None
            }

        [<CustomOperation("index")>]
        member _.Index(state: RemoveIndexAction, value: Types.IndexName) =
            { state with Index = Some value }

        [<CustomOperation("indices")>]
        member _.Indices(state: RemoveIndexAction, value: Types.Indices) =
            { state with Indices = Some value }

        [<CustomOperation("mustExist")>]
        member _.MustExist(state: RemoveIndexAction, value: bool) =
            { state with MustExist = Some value }

    let removeIndexAction = RemoveIndexActionBuilder()


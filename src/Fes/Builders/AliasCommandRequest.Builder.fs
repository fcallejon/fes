namespace Fes.Builders

[<AutoOpen>]
module AliasCommandRequestBuilder =
    open Fes.DSL.Aliases

    type AliasCommandRequestBuilder () =
        
        member private _.appendAction state action =
            let newActions =
                action
                |> Array.singleton
                |> Array.append state.Actions
            { state with Actions = newActions }

        member _.Yield _ =
            { AliasCommandRequest.Actions = Array.empty
              Parameters = None }
        
        [<CustomOperation "actions" >]
        member _.Actions (state: AliasCommandRequest, value) = { state with Actions = value }
        
        [<CustomOperation "add" >]
        member this.AddActions (state: AliasCommandRequest, value: AliasAction) =
            value |> Add
            |> this.appendAction state
        
        [<CustomOperation "remove" >]
        member this.RemoveActions (state: AliasCommandRequest, value: AliasAction) =
            value |> Remove
            |> this.appendAction state
        
        [<CustomOperation "removeIndex" >]
        member this.RemoveIndexActions (state: AliasCommandRequest, value: AliasAction) =
            value |> RemoveIndex
            |> this.appendAction state
        
        [<CustomOperation "parameters" >]
        member _.Parameters (state: AliasCommandRequest, value) = { state with Parameters = Some value }
        
    type AliasActionBuilder () =
        member _.Yield _ =
            { AliasAction.On = Unchecked.defaultof<ActionOn>
              Names = Unchecked.defaultof<AliasNames>
              IsHidden = None
              MustExists = None
              IsWriteIndex = None
              Routing = None
              IndexRouting = None
              SearchRouting = None
              Filter = None }
        
        [<CustomOperation "on" >]
        member _.On (state: AliasAction, value) = { state with On = value }
        
        [<CustomOperation "names" >]
        member _.Names (state: AliasAction, value) = { state with Names = value }
        
        [<CustomOperation "isHidden" >]
        member _.IsHidden (state: AliasAction, value) = { state with IsHidden = Some value }
        
        [<CustomOperation "mustExists" >]
        member _.MustExists (state: AliasAction, value) = { state with MustExists = Some value }
        
        [<CustomOperation "isWriteIndex" >]
        member _.IsWriteIndex (state: AliasAction, value) = { state with IsWriteIndex = Some value }
        
        [<CustomOperation "routing" >]
        member _.Routing (state: AliasAction, value) = { state with Routing = Some value }
        
        [<CustomOperation "indexRouting" >]
        member _.IndexRouting (state: AliasAction, value) = { state with IndexRouting = Some value }
        
        [<CustomOperation "searchRouting" >]
        member _.SearchRouting (state: AliasAction, value) = { state with SearchRouting = Some value }
        
        [<CustomOperation "filter" >]
        member _.Filter (state: AliasAction, value) = { state with Filter = Some value }
        
    type AliasQueryParameterBuilder () =
        member _.Yield _ =
            { AliasQueryParameter.MasterTimeout = None
              Timeout = None }
        
        [<CustomOperation "masterTimeout" >]
        member _.MasterTimeout (state: AliasQueryParameter, value) = { state with MasterTimeout = Some value }
        
        [<CustomOperation "timeout" >]
        member _.Timeout (state: AliasQueryParameter, value) = { state with Timeout = Some value }
        
    let aliasCommandRequest = AliasCommandRequestBuilder()
    let aliasQueryParameter = AliasQueryParameterBuilder()
    let aliasAction = AliasActionBuilder()
namespace Fes.Contracts

module Aliases =
    open System
    open FSharpPlus.Operators
    open Fes
    open Fes.Contracts.Units
    open Fleece.SystemTextJson
    open Fleece.SystemTextJson.Operators

    type AliasQueryParameter =
        { MasterTimeout: option<TimeoutUnit>
          Timeout: option<TimeoutUnit> }
        static member ToQueryParams queryParams =
            let masterTimeout =
                queryParams.MasterTimeout
                |> Option.map (
                    TimeoutUnit.ToString
                    >> sprintf "master_timeout=%s"
                )

            let timeout =
                queryParams.Timeout
                |> Option.map (TimeoutUnit.ToString >> sprintf "timeout=%s")

            [| masterTimeout; timeout |]
            |> QueryStringBuilder.mk

    type ActionOn =
        | Index of string
        | Indices of string []

    type AliasNames =
        | Alias of string
        | Aliases of string []


    type AliasAction =
        { On: ActionOn
          Names: AliasNames
          IsHidden: option<bool>
          MustExists: option<bool>
          IsWriteIndex: option<bool>
          Routing: option<string>
          IndexRouting: option<string>
          SearchRouting: option<string> }
        static member ToJson aliasAction =
            let on =
                match aliasAction.On with
                | Index index -> "index" .= index
                | Indices indices -> "indices" .= indices

            let names =
                match aliasAction.Names with
                | Alias alias -> "alias" .= alias
                | Aliases aliases -> "aliases" .= aliases

            jobj [ on
                   names
                   "is_hidden" .=? aliasAction.IsHidden
                   "must_exist" .=? aliasAction.MustExists
                   "is_write_index" .=? aliasAction.IsWriteIndex
                   "routing" .=? aliasAction.Routing
                   "index_routing" .=? aliasAction.IndexRouting
                   "search_routing" .=? aliasAction.SearchRouting ]

    type Action =
        | Add of AliasAction
        | Remove of AliasAction
        | RemoveIndex of AliasAction
        static member ToJson action =
            match action with
            | Add add -> jobj [ "add" .= (AliasAction.ToJson add) ]
            | Remove remove -> jobj [ "remove" .= (AliasAction.ToJson remove) ]
            | RemoveIndex removeIndex -> jobj [ "remove_index" .= (AliasAction.ToJson removeIndex) ]

    type AliasCommandRequest =
        { Actions: Action[]
          Parameters: option<AliasQueryParameter> }
        static member ToJson command =
            jobj [ "actions" .= (command.Actions |> Array.map Action.ToJson) ]

        static member ToRequest(request: AliasCommandRequest) =
            let query =
                request.Parameters
                |> Option.map toQueryParams
                |> Option.defaultValue (Ok String.Empty)

            let mk query =
                $"_aliases{query}"
                |> Http.Request.mk
                |> Http.Request.withMethod Http.Post
                |> Http.Request.withJsonBody request
            mk <!> query
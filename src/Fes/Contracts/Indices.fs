module Fes.Contracts.Indices

open Fes
open Fes.Contracts.Mappings
open FSharp.Data.UnitSystems.SI
open FSharpPlus
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open System
open System.Collections.ObjectModel

[<AutoOpen>]
module private QueryParams =
    let inline toQueryParams x =
        (^T : (static member ToQueryParams: ^T -> Result<string, exn>) x)

type WaitForActiveShards =
    | One
    | All
    | Other of uint8

[<RequireQualifiedAccess>]
module WaitForActiveShards =
    let mkValue =
        function
        | One -> "1"
        | All -> "All"
        | Other value -> string value

type IndexSettings =
    { NumberOfShards: option<uint16>
      NumberOfReplicas: option<uint16> }
    static member ToJson settings =
        jobj [ "number_of_shards" .=? settings.NumberOfShards
               "number_of_replicas" .=? settings.NumberOfReplicas ]

type IndexAlias =
    { Name: string
      Filter: option<string>
      IndexRouting: option<string>
      IsHidden: option<bool>
      IsWriteIndex: option<bool>
      Routing: option<string>
      SearchRouting: option<string> }

    static member mk name =
        { Name = name
          Filter = None
          IndexRouting = None
          IsHidden = None
          IsWriteIndex = None
          Routing = None
          SearchRouting = None }


    static member ToJson settings =
        let alias =
            jobj [ "filter" .=? settings.Filter
                   "index_routing" .=? settings.IndexRouting
                   "is_hidden" .=? settings.IsHidden
                   "is_write_index" .=? settings.IsWriteIndex
                   "routing" .=? settings.Routing
                   "search_routing" .=? settings.SearchRouting ]

        jobj [ settings.Name .= alias ]

    static member asJsonTuple settings =
        let alias =
            jobj [ "filter" .=? settings.Filter
                   "index_routing" .=? settings.IndexRouting
                   "is_hidden" .=? settings.IsHidden
                   "is_write_index" .=? settings.IsWriteIndex
                   "routing" .=? settings.Routing
                   "search_routing" .=? settings.SearchRouting ]

        settings.Name, alias

type IndexRequestQueryParams =
    { WaitForActiveShards: option<WaitForActiveShards>
      MasterTimeout: option<uint16<UnitSymbols.s>>
      Timeout: option<uint16<UnitSymbols.s>> }
    static member ToQueryParams queryParams =
        let waitForActiveShards =
            queryParams.WaitForActiveShards
            |> Option.map (
                WaitForActiveShards.mkValue
                >> sprintf "wait_for_active_shards=%s"
            )

        let masterTimeout =
            queryParams.MasterTimeout
            |> Option.map (sprintf "master_timeout=%A")

        let timeout =
            queryParams.Timeout
            |> Option.map (sprintf "timeout=%A")

        let mk (values: string []) =
            sprintf "?%s" <| String.Join("&", values)

        [| waitForActiveShards
           masterTimeout
           timeout |]
        |> Array.choose id
        |> mk
        |> Result.Ok

type IndexRequest =
    { Name: string
      Mappings: option<MappingDefinition []>
      Settings: option<IndexSettings>
      Aliases: option<IndexAlias []>
      Parameters: option<IndexRequestQueryParams> }
    static member ToJson index =
        let mappings =
            let mkMapping (mapping: MappingDefinition) =
                mapping.Name, jobj [ "type" .= mapping.Type ]

            let mkJson mappings =
                let rod = ReadOnlyDictionary(mappings)
                jobj [ "properties" .= (dictAsJsonObject rod) ]

            index.Mappings
            |> Option.map (Array.map mkMapping)
            |> Option.map (dict >> mkJson)

        let aliases =
            index.Aliases
            |> Option.map (
                (Array.map IndexAlias.asJsonTuple)
                >> dict
                >> ReadOnlyDictionary
                >> dictAsJsonObject
            )

        jobj [ "aliases" .=? aliases
               "settings" .=? index.Settings
               "mappings" .=? mappings ]

    static member ToRequest(request: IndexRequest) =
        let query =
            request.Parameters
            |> Option.map toQueryParams
            |> Option.defaultValue (Result.Ok String.Empty)
        
        let mk query =
            $"%s{request.Name}%s{query}"
            |> (Http.Request.mk
            >> (Http.Request.withMethod Http.Put)
            >> (Http.Request.withJsonBody request))
        mk <!> query

type UpdateIndexSettingsRequest =
    { Target: option<string>
      Mappings: option<MappingDefinition []>
      Settings: option<IndexSettings>
      Aliases: option<IndexAlias []>
      Parameters: option<IndexRequestQueryParams> }
    static member ToJson index =
        let mappings =
            let mkMapping (mapping: MappingDefinition) =
                mapping.Name, jobj [ "type" .= mapping.Type ]

            let mkJson mappings =
                let rod = ReadOnlyDictionary(mappings)
                jobj [ "properties" .= (dictAsJsonObject rod) ]

            index.Mappings
            |> Option.map (Array.map mkMapping)
            |> Option.map (dict >> mkJson)

        let aliases =
            index.Aliases
            |> Option.map (
                (Array.map IndexAlias.asJsonTuple)
                >> dict
                >> ReadOnlyDictionary
                >> dictAsJsonObject
            )

        jobj [ "aliases" .=? aliases
               "settings" .=? index.Settings
               "mappings" .=? mappings ]

    static member ToRequest(request: UpdateIndexSettingsRequest) =
        let target = request.Target |> Option.defaultValue "_all"

        $"%s{target}/_settings"
        |> Http.Request.mk
        |> Http.Request.withMethod Http.Put
        |> Http.Request.withJsonBody (jobj [ "index" .= request ])
        |> Result.Ok

type IndexCreateResponse =
    { Acknowledged: bool
      ShardsAcknowledged: bool
      Index: string }
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! acknowledged = o .@ "acknowledged"
                let! shardsAcknowledged = o .@ "shards_acknowledged"
                let! index = o .@ "index"

                return
                    { Acknowledged = acknowledged
                      ShardsAcknowledged = shardsAcknowledged
                      Index = index }
            }
        | x -> Decode.Fail.objExpected x

type Request = { Query: string }

module Fes.DSL.Indices

open System.Collections.Generic
open FSharpPlus
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open System
open System.Collections.ObjectModel
open Fes
open Fes.DSL.Mappings
open Fes.QueryParams.Builder.Operators
open Fes.QueryParams.Builder
open Fes.DSL.Units

[<RequireQualifiedAccess>]
type WaitForActiveShards =
    | One
    | All
    | Other of uint8
    member this.ToString =
        match this with
        | One -> "1"
        | All -> "all"
        | Other other -> string other

[<RequireQualifiedAccess>]
type ShardCheckOnStartup =
    | False
    | True
    | Checksum
    static member ToJson value =
        match value with
        | False -> "false"
        | True -> "true"
        | Checksum -> "checksum"
        |> JString

[<RequireQualifiedAccess>]
type Codec =
| Default
| BestCompression
with
    static member ToJson value =
        match value with
        | Default -> "default"
        | BestCompression -> "best_compression"
        |> JString
        
type AutoExpandReplicas =
| Disabled
| Delimited of uint16*uint16
| LowerBoundOnly of uint16
with
    static member ToJson value =
        match value with
        | Disabled -> "false"
        | Delimited (min, max) -> $"%i{max}-%i{min}"
        | LowerBoundOnly min -> $"%i{min}-all"
        |> JString

type StaticIndexSettings =
    { NumberOfRoutingShards: option<uint16>
      ShardCheckOnStartup: option<ShardCheckOnStartup>
      Hidden: option<bool>
      Codec: option<Codec>
      RoutingPartitionSize: option<uint16>
      SoftDeletesRetention: option<TimeoutUnit>
      LoadFixedBitsetFiltersEagerly: option<bool> }
    
type DynamicIndexSettings =
    { RefreshInterval: option<TimeoutUnit>
      AutoExpandReplicas: option<AutoExpandReplicas>
      SearchIdleAfter: option<TimeoutUnit>
      MaxResultWindow: option<uint16>
      MaxInnerResultWindow: option<uint16>
      MaxReScoreWindow: option<uint16>
      MaxDocValueFieldsSearch: option<uint16>
      MaxScriptFields: option<uint16> }

type IndexSettings =
    { NumberOfShards: option<uint16>
      NumberOfReplicas: option<uint16>
      Static: option<StaticIndexSettings>
      Dynamic: option<DynamicIndexSettings> }
    static member ToJson settings =
        jobj [ yield "number_of_shards" .=? settings.NumberOfShards
               yield "number_of_replicas" .=? settings.NumberOfReplicas

               if settings.Static.IsSome then
                   let staticSettings = settings.Static.Value
                   yield "number_of_routing_shards" .=? staticSettings.NumberOfRoutingShards
                   yield "shard.check_on_startup" .=? staticSettings.ShardCheckOnStartup
                   yield "hidden" .=? staticSettings.Hidden
                   yield "codec" .=? staticSettings.Codec
                   yield "load_fixed_bitset_filters_eagerly" .=? staticSettings.LoadFixedBitsetFiltersEagerly
                   yield "routing_partition_size" .=? staticSettings.RoutingPartitionSize
                   yield "soft_deletes.retention_lease.period" .=? staticSettings.SoftDeletesRetention

               if settings.Dynamic.IsSome then
                   let dynamicSettings = settings.Dynamic.Value
                   yield "refresh_interval" .=? dynamicSettings.RefreshInterval
                   yield "auto_expand_replicas" .=? dynamicSettings.AutoExpandReplicas
                   yield "search.idle.after" .=? dynamicSettings.SearchIdleAfter
                   yield "max_result_window" .=? dynamicSettings.MaxResultWindow
                   yield "max_inner_result_window" .=? dynamicSettings.MaxInnerResultWindow
                   yield "max_rescore_window" .=? dynamicSettings.MaxReScoreWindow
                   yield "max_docvalue_fields_search" .=? dynamicSettings.MaxDocValueFieldsSearch
                   yield "max_script_fields" .=? dynamicSettings.MaxScriptFields
                   yield "max_ngram_diff" .=? dynamicSettings.MaxScriptFields
             ]

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
      MasterTimeout: option<TimeoutUnit>
      Timeout: option<TimeoutUnit> }
    static member ToQueryParams queryParams =
        qparams [
            "wait_for_active_shards" &=? (queryParams.WaitForActiveShards |> Option.map string)
            "master_timeout" &=? queryParams.MasterTimeout
            "timeout" &=? queryParams.Timeout
        ]

type IndexRequest =
    { Name: string
      Mappings: option<MappingDefinition []>
      Settings: option<IndexSettings>
      Aliases: option<IndexAlias []>
      Parameters: option<IndexRequestQueryParams> }
    static member ToJson index =
        let mappings =
            let mkMapping (mapping: MappingDefinition) =
                let mappingRoot (extra: JsonValue[]) =
                    let extraAsDict =
                        let unwrapDict =
                            function
                            | JObject e -> e
                            | _ -> failwith "There should only be JObjects here, better check why is not the case."
                        let innerDict = Dictionary<string, JsonValue>()
                        extra
                        |> Array.append [| jobj [ "type" .= mapping.Type ] |]
                        |> Seq.map unwrapDict
                        |> Seq.iter (fun current -> current.Keys |> Seq.iter (fun k -> innerDict.Add(k, current.[k])))
                        ReadOnlyDictionary(innerDict)
                        
                    mapping.Name, ((extraAsDict |> dictAsJsonObject) |> JObject)
                
                mapping.Mappings
                |> Array.map toJson
                |> mappingRoot

            
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
            |> (Http.Request.fromPath
                >> (Http.Request.withMethod Http.Put)
                >> (Http.Request.withJsonBody request))

        mk <!> query

type UpdateRequestQueryParams =
    { AllowNoIndices: option<bool>
      FlatSettings: option<bool>
      IgnoreUnavailable: option<bool>
      PreserveExisting: option<bool>
      ExpandWildcards: option<ExpandWildcardsOptions>
      MasterTimeout: option<TimeoutUnit>
      Timeout: option<TimeoutUnit> }
    static member ToQueryParams queryParams =
        qparams [
            "expand_wildcards" &=? (queryParams.ExpandWildcards |> Option.map string)
            "master_timeout" &=? queryParams.MasterTimeout
            "timeout" &=? queryParams.Timeout
        ]

type UpdateIndexSettingsRequest =
    { Target: option<string>
      Settings: option<IndexSettings>
      Parameters: option<UpdateRequestQueryParams> }
    static member ToJson index =
        jobj [ "index" .=? index.Settings ]

    static member ToRequest(request: UpdateIndexSettingsRequest) =
        let target =
            request.Target |> Option.defaultValue "_all"
        let query = queryParamsOfOption request.Parameters
            

        let mk query =
            $"%s{target}/_settings{query}"
            |> Http.Request.fromPath
            |> Http.Request.withMethod Http.Put
            |> Http.Request.withJsonBody request
        mk <!> query

type ElasticsearchGenericResponse =
    { Acknowledged: bool }
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! acknowledged = o .@ "acknowledged"

                return
                    { Acknowledged = acknowledged }
            }
        | x -> Decode.Fail.objExpected x

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

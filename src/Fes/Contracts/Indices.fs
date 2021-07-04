module Fes.Contracts.Indices

open Fes
open Fes.Contracts.Mappings
open FSharpPlus
open Fes.Contracts.Units
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open System
open System.Collections.ObjectModel

[<AutoOpen>]
module private QueryParams =
    let inline toQueryParams x =
        (^T: (static member ToQueryParams : ^T -> Result<string, exn>) x)

[<RequireQualifiedAccess>]
type WaitForActiveShards =
    | One
    | All
    | Other of uint8
    static member AsString =
        function
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
    static member ToJson value =
        match value with
        | Default -> "default"
        | BestCompression -> "best_compression"
        |> JString

type IndexSettings =
    //TODO: Complete props from
    // https://www.elastic.co/guide/en/elasticsearch/reference/current/index-modules.html#dynamic-index-settings
    { NumberOfShards: option<uint16>
      NumberOfReplicas: option<uint16>
      NumberOfRoutingShards: option<uint16>
      ShardCheckOnStartup: option<ShardCheckOnStartup>
      Hidden: option<bool>
      Codec: option<Codec>
      LoadFixedBitsetFiltersEagerly: option<bool>
      RoutingPartitionSize: option<uint16>
      SoftDeletesRetention: option<TimeoutUnit>
      RefreshInterval: option<TimeoutUnit> }
    static member ToJson settings =
        jobj [ "number_of_shards" .=? settings.NumberOfShards
               "number_of_replicas" .=? settings.NumberOfReplicas
               "number_of_routing_shards" .=? settings.NumberOfRoutingShards
               "shard.check_on_startup" .=? settings.ShardCheckOnStartup
               "hidden" .=? settings.Hidden
               "codec" .=? settings.Codec
               "load_fixed_bitset_filters_eagerly" .=? settings.LoadFixedBitsetFiltersEagerly
               "routing_partition_size" .=? settings.RoutingPartitionSize
               "soft_deletes.retention_lease.period" .=? settings.SoftDeletesRetention
               "refresh_interval" .=? settings.RefreshInterval ]

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
        let waitForActiveShards =
            queryParams.WaitForActiveShards
            |> Option.map (
                WaitForActiveShards.AsString
                >> sprintf "wait_for_active_shards=%s"
            )

        let masterTimeout =
            queryParams.MasterTimeout
            |> Option.map (
                TimeoutUnit.ToString
                >> sprintf "master_timeout=%s"
            )

        let timeout =
            queryParams.Timeout
            |> Option.map (TimeoutUnit.ToString >> sprintf "timeout=%s")

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

[<RequireQualifiedAccess>]
type ExpandWildcardsOptions =
    | All
    | Open
    | Closed
    | Hidden
    | None
    static member AsString =
        function
        | All -> "all"
        | Open -> "open"
        | Closed -> "closed"
        | Hidden -> "hidden"
        | None -> "none"

type UpdateRequestQueryParams =
    { AllowNoIndices: option<bool>
      FlatSettings: option<bool>
      IgnoreUnavailable: option<bool>
      PreserveExisting: option<bool>
      ExpandWildcards: option<ExpandWildcardsOptions>
      MasterTimeout: option<TimeoutUnit>
      Timeout: option<TimeoutUnit> }
    static member ToQueryParams queryParams =
        let waitForActiveShards =
            queryParams.ExpandWildcards
            |> Option.map (
                ExpandWildcardsOptions.AsString
                >> sprintf "expand_wildcards=%s"
            )

        let masterTimeout =
            queryParams.MasterTimeout
            |> Option.map (
                TimeoutUnit.ToString
                >> sprintf "master_timeout=%s"
            )

        let timeout =
            queryParams.Timeout
            |> Option.map (TimeoutUnit.ToString >> sprintf "timeout=%s")

        let mk (values: string []) =
            sprintf "?%s" <| String.Join("&", values)

        [| waitForActiveShards
           masterTimeout
           timeout |]
        |> Array.choose id
        |> mk
        |> Result.Ok

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

        jobj [ // "aliases" .=? aliases
               "index" .=? index.Settings
               //"mappings" .=? mappings
             ]

    static member ToRequest(request: UpdateIndexSettingsRequest) =
        let target =
            request.Target |> Option.defaultValue "_all"

        $"%s{target}/_settings"
        |> Http.Request.mk
        |> Http.Request.withMethod Http.Put
        |> Http.Request.withJsonBody request
        |> Result.Ok

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

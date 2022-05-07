module Fes.DSL.Indices

open System.Text.RegularExpressions
open FSharpPlus
open Fes.DSL.Mapping
open Fleece
open Fleece.SystemTextJson
open System
open Fes
open Fes.QueryParams.Builder.Operators
open Fes.QueryParams.Builder

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

    static member OfJson value =
        match value with
        | JString "false" -> False |> Decode.Success
        | JString "true" -> True |> Decode.Success
        | JString "checksum" -> Checksum |> Decode.Success
        | JString x as v -> Decode.Fail.invalidValue v $"Invalid ShardCheckOnStartup: %s{x}"
        | x -> Decode.Fail.strExpected x
        
    static member get_Codec () = ShardCheckOnStartup.OfJson <-> ShardCheckOnStartup.ToJson

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
        
    static member OfJson value =
        match value with
        | JString "default" -> Default |> Decode.Success
        | JString "best_compression" -> BestCompression |> Decode.Success
        | JString x as v -> Decode.Fail.invalidValue v $"Invalid Codec: %s{x}"
        | x -> Decode.Fail.strExpected x
        
    static member get_Codec () = Codec.OfJson <-> Codec.ToJson
        
type AutoExpandReplicas =
| Disabled
| Delimited of uint16*uint16
| LowerBoundOnly of uint16

[<RequireQualifiedAccess>]
module private AutoExpandReplicas =
    let private delimitedRegex = Regex("^(\d*)-(\d{1,})$", RegexOptions.Compiled ||| RegexOptions.Singleline)
    let private lowerBoundOnlyRegex = Regex("^(\d*)-all$", RegexOptions.Compiled ||| RegexOptions.Singleline)
    let (|IsDelimited|_|) value =
        let rxMatch = delimitedRegex.Match(value)
        if rxMatch.Success
        then
            let min = UInt16.Parse(rxMatch.Groups[0].Value)
            let max = UInt16.Parse(rxMatch.Groups[1].Value)
            (min, max)
            |> Delimited
            |> Some
        else None

    let (|IsLowerBoundOnly|_|) value =
        let rxMatch = lowerBoundOnlyRegex.Match(value)
        if rxMatch.Success
        then
            UInt16.Parse(rxMatch.Groups[0].Value)
            |> LowerBoundOnly
            |> Some
        else None

type AutoExpandReplicas
with
    static member ToJson value =
        match value with
        | Disabled -> "false"
        | Delimited (min, max) -> $"%i{min}-%i{max}"
        | LowerBoundOnly min -> $"%i{min}-all"
        |> JString
        
    static member OfJson value =
        match value with
        | JString "false" -> Disabled |> Decode.Success
        | JString (AutoExpandReplicas.IsDelimited del) -> del |> Decode.Success
        | JString (AutoExpandReplicas.IsLowerBoundOnly lower) -> lower |> Decode.Success
        | JString x as v -> Decode.Fail.invalidValue v $"Invalid Codec: %s{x}"
        | x -> Decode.Fail.strExpected x
        
    static member get_Codec () = AutoExpandReplicas.OfJson <-> AutoExpandReplicas.ToJson

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

type IndexAlias =
    { Name: string
      Filter: option<string>
      IndexRouting: option<string>
      IsHidden: option<bool>
      IsWriteIndex: option<bool>
      Routing: option<string>
      SearchRouting: option<string> }

    static member Create name =
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
            let mkFieldOrProp =
                let mergeExtrasWithType (x: MappingDefinition) =
                    let typeProp =
                        ("type", x.Type :> obj)
                        |> Array.singleton
                        |> PropertyList
                    let properties =
                        x.Mappings
                        |> Seq.map FieldMapping.ToPropertyList
                        |> Seq.fold (++) typeProp

                    PropertyList [| (x.Name, properties) |] 
                
                Array.map mergeExtrasWithType
                >> Array.sum
                >> (fun m -> PropertyList [| ("properties", m) |])

            index.Mappings
            |> Option.map mkFieldOrProp

        let aliases =
            index.Aliases
            |> Option.map (
                (Array.map IndexAlias.asJsonTuple)
                >> JsonObject
            )

        let g =
            codec {
                let! gf = jopt "aliases" () aliases
                return gf
            }
        g
        
    static member get_Codec () : Codec<'Encoding, _> =
        codec {
            let! name     = jreq "name"     (fun x -> Some x.Name)
            and! settings = jreq "settings" (fun x -> Some x.Settings)
            return
                { Name = name
                  Settings = settings
                  Mappings = maappings
                  Aliases = failwith "todo"
                  Parameters = failwith "todo" }
        } |> ofObjCodec

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
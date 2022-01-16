namespace Fes.Builders.Indices

open Fes.DSL
open Fes.DSL.FieldTypes
open Fes.DSL.Fields

[<AutoOpen>]
module IndexRequestBuilder =
    open System
    open Fes.DSL.Indices

    type IndexRequestBuilder () =
        member _.Yield _ =
            { IndexRequest.Name = String.Empty
              Mappings = None
              Settings = None
              Aliases = None
              Parameters = None }
        
        [<CustomOperation "name" >]
        member _.Name (state: IndexRequest, value) = { state with Name = value }
        
        [<CustomOperation "mappings" >]
        member _.Mappings (state: IndexRequest, value) = { state with Mappings = Some value }
        
        [<CustomOperation "addMapping" >]
        member _.addMapping (state: IndexRequest, value) =
            let newMapping =
                match state.Mappings with
                | Some current -> Array.append [| value |] current
                | _ -> [| value |]
                |> Some
            { state with Mappings = newMapping }
        
        [<CustomOperation "settings" >]
        member _.Settings (state: IndexRequest, value) = { state with Settings = Some value }
        
        [<CustomOperation "aliases" >]
        member _.Aliases (state: IndexRequest, value) = { state with Aliases = Some value }
        
        member _.addAlias (state: IndexRequest, value) =
            let newAliases =
                match state.Aliases with
                | Some current -> Array.append [| value |] current
                | _ -> [| value |]
                |> Some
            { state with Aliases = newAliases }
        
        [<CustomOperation "parameters" >]
        member _.Parameters (state: IndexRequest, value) = { state with Parameters = Some value }

    type IndexSettingsBuilder () =
        member _.Yield _ =
            { IndexSettings.NumberOfShards = None
              NumberOfReplicas = None
              Static = None
              Dynamic = None }
        
        [<CustomOperation "shards" >]
        member _.NumberOfShards (state: IndexSettings, value) = { state with NumberOfShards = Some value }
        
        [<CustomOperation "replicas" >]
        member _.NumberOfReplicas (state: IndexSettings, value) = { state with NumberOfReplicas = Some value }
        
        [<CustomOperation "static" >]
        member _.Static (state: IndexSettings, value) = { state with Static = Some value }
        
        [<CustomOperation "dynamic" >]
        member _.Dynamic (state: IndexSettings, value) = { state with Dynamic = Some value }

    type StaticIndexSettingsBuilder () =
        member _.Yield _ =
            { StaticIndexSettings.NumberOfRoutingShards = None
              ShardCheckOnStartup = None
              Hidden = None
              Codec = None
              RoutingPartitionSize = None
              SoftDeletesRetention = None
              LoadFixedBitsetFiltersEagerly = None }
        
        [<CustomOperation "routingShards" >]
        member _.NumberOfRoutingShards (state: StaticIndexSettings, value) = { state with NumberOfRoutingShards = value }
        
        [<CustomOperation "shardCheckOnStartup" >]
        member _.ShardCheckOnStartup (state: StaticIndexSettings, value) = { state with ShardCheckOnStartup = Some value }
        
        [<CustomOperation "hidden" >]
        member _.Hidden (state: StaticIndexSettings, value) = { state with Hidden = Some value }
        
        [<CustomOperation "codec" >]
        member _.Codec (state: StaticIndexSettings, value) = { state with Codec = Some value }
        
        [<CustomOperation "routingPartitionSize" >]
        member _.RoutingPartitionSize (state: StaticIndexSettings, value) = { state with RoutingPartitionSize = Some value }
        
        [<CustomOperation "softDeletesRetention" >]
        member _.SoftDeletesRetention (state: StaticIndexSettings, value) = { state with SoftDeletesRetention = Some value }
        
        [<CustomOperation "loadFixedBitsetFiltersEagerly" >]
        member _.LoadFixedBitsetFiltersEagerly (state: StaticIndexSettings, value) = { state with LoadFixedBitsetFiltersEagerly = Some value }

    type DynamicIndexSettingsBuilder () =
        member _.Yield _ =
            { DynamicIndexSettings.RefreshInterval = None
              AutoExpandReplicas = None
              SearchIdleAfter = None
              MaxResultWindow = None
              MaxInnerResultWindow = None
              MaxReScoreWindow = None
              MaxDocValueFieldsSearch = None
              MaxScriptFields = None }
        
        [<CustomOperation "refreshInterval" >]
        member _.RefreshInterval (state: DynamicIndexSettings, value) = { state with RefreshInterval = Some value }
        
        [<CustomOperation "autoExpandReplicas" >]
        member _.AutoExpandReplicas (state: DynamicIndexSettings, value) = { state with AutoExpandReplicas = Some value }
        
        [<CustomOperation "searchIdleAfter" >]
        member _.SearchIdleAfter (state: DynamicIndexSettings, value) = { state with SearchIdleAfter = Some value }
        
        [<CustomOperation "maxResultWindow" >]
        member _.MaxResultWindow (state: DynamicIndexSettings, value) = { state with MaxResultWindow = Some value }
        
        [<CustomOperation "maxInnerResultWindow" >]
        member _.MaxInnerResultWindow (state: DynamicIndexSettings, value) = { state with MaxInnerResultWindow = Some value }
        
        [<CustomOperation "maxReScoreWindow" >]
        member _.MaxReScoreWindow (state: DynamicIndexSettings, value) = { state with MaxReScoreWindow = Some value }
        
        [<CustomOperation "maxDocValueFieldsSearch" >]
        member _.MaxDocValueFieldsSearch (state: DynamicIndexSettings, value) = { state with MaxDocValueFieldsSearch = Some value }
        
        [<CustomOperation "maxScriptFields" >]
        member _.MaxScriptFields (state: DynamicIndexSettings, value) = { state with MaxScriptFields = Some value }

    type IndexAliasBuilder () =
        member _.Yield _ =
            { IndexAlias.Name = String.Empty
              Filter = None
              IndexRouting = None
              IsHidden = None
              IsWriteIndex = None
              Routing = None
              SearchRouting = None }
        
        [<CustomOperation "name" >]
        member _.Name (state: IndexAlias, value) = { state with Name = value }
        
        [<CustomOperation "filter" >]
        member _.Filter (state: IndexAlias, value) = { state with Filter = Some value }
        
        [<CustomOperation "indexRouting" >]
        member _.IndexRouting (state: IndexAlias, value) = { state with IndexRouting = Some value }
        
        [<CustomOperation "isHidden" >]
        member _.IsHidden (state: IndexAlias, value) = { state with IsHidden = Some value }
        
        [<CustomOperation "isWriteIndex" >]
        member _.IsWriteIndex (state: IndexAlias, value) = { state with IsWriteIndex = Some value }
        
        [<CustomOperation "routing" >]
        member _.Routing (state: IndexAlias, value) = { state with Routing = Some value }
        
        [<CustomOperation "searchRouting" >]
        member _.SearchRouting (state: IndexAlias, value) = { state with SearchRouting = Some value }

    type IndexRequestQueryParamsBuilder () =
        member _.Yield _ =
            { IndexRequestQueryParams.WaitForActiveShards = None
              MasterTimeout = None
              Timeout = None }
        
        [<CustomOperation "waitForActiveShards" >]
        member _.WaitForActiveShards (state: IndexRequestQueryParams, value) = { state with WaitForActiveShards = value }
        
        [<CustomOperation "masterTimeout" >]
        member _.MasterTimeout (state: IndexRequestQueryParams, value) = { state with MasterTimeout = Some value }
        
        [<CustomOperation "timeout" >]
        member _.Timeout (state: IndexRequestQueryParams, value) = { state with Timeout = Some value }

    type MappingDefinitionBuilder () =
        member _.Yield _ =
            { MappingDefinition.Name = String.Empty
              Type = TextTypes.Text |> FieldType.Text
              Mappings = Array.empty }
        
        [<CustomOperation "name" >]
        member _.Name (state: MappingDefinition, value) = { state with Name = value }
        
        [<CustomOperation "fieldType" >]
        member _.Type (state: MappingDefinition, value) = { state with Type = value }
        
        [<CustomOperation "mappings" >]
        member _.Mappings (state: MappingDefinition, value) = { state with Mappings = value }
        
        member _.addMapping (state: MappingDefinition, value) =
            let newMapping =
                state.Mappings
                |> Array.append [| value |]
            { state with Mappings = newMapping }
        
    let createIndexRequest = IndexRequestBuilder()
    let indexSettings = IndexSettingsBuilder()
    let staticIndexSettings = StaticIndexSettingsBuilder()
    let dynamicIndexSettings = DynamicIndexSettingsBuilder()
    let indexAlias = IndexAliasBuilder()
    let indexRequestQueryParams = IndexRequestQueryParamsBuilder()
    let mappingDefinition = MappingDefinitionBuilder()
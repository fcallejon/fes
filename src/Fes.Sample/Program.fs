open System
open Fes
open Fes.Contracts
open Fes.Contracts.Fields
open Fes.Contracts.Indices
open Fes.Contracts.Mappings
open Fes.Contracts.Units

[<EntryPoint>]
let main _ =
    let client =
        ElasticsearchClient <| Uri "http://localhost:9200"
        
    let inline printResult title (result: Result<'a, exn>) =
        printf title
        match result with
        | Ok o -> printfn $"OK -> {o}"
        | Error e -> printfn $"Error -> {e.Message}"

    let mapping =
        [| { MappingDefinition.Name = "field1"
             Type = FieldTypes.Text |> Fields.Text
             Mappings = [| Mapping.FieldMapping.Analyzer "analyzer_name" |] } |]

    let settings =
        { IndexSettings.NumberOfShards = Some 3us
          NumberOfReplicas = Some 0us
          NumberOfRoutingShards = None
          ShardCheckOnStartup = None
          Hidden = None
          Codec = None
          LoadFixedBitsetFiltersEagerly = None
          RoutingPartitionSize = None
          SoftDeletesRetention = None
          RefreshInterval = None }

    let req =
        { IndexRequest.Name = "index_test"
          Mappings = Some mapping
          Settings = Some settings
          Aliases = Some [| IndexAlias.mk "Test" |]
          Parameters = None }

    let createResult : Result<IndexCreateResponse, exn> =
        client.mkIndex req |> Async.RunSynchronously

    printResult "Create: " createResult

    
    let updateSettings =
        { IndexSettings.RefreshInterval = Some (TimeoutUnit.Seconds 2<TimeUnits.s>)
          NumberOfShards = None
          NumberOfReplicas = None
          NumberOfRoutingShards = None
          ShardCheckOnStartup = None
          Hidden = None
          Codec = None
          LoadFixedBitsetFiltersEagerly = None
          RoutingPartitionSize = None
          SoftDeletesRetention = None }
    let updateReq =
      { UpdateIndexSettingsRequest.Target = Some "index_test"
        Mappings = Some mapping
        Settings = Some updateSettings
        Aliases = Some [| IndexAlias.mk "Test" |]
        Parameters = None }

    let updateResult : Result<ElasticsearchGenericResponse, exn> =
        client.updateIndexSettings updateReq |> Async.RunSynchronously

    printResult "Update: " updateResult

    0

open System
open Fes
open Fes.Contracts.Api
open Fes.DSL
open Fes.DSL.Fields
open Fes.DSL.Indices
open Fes.DSL.Aliases
open Fes.DSL.Mappings
open Fes.DSL.Units
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
   
type SampleDocument =
    { Field1: string }
with
    static member ToJson doc =
        jobj [ "field1" .= doc.Field1 ]

[<EntryPoint>]
let main _ =
    let client =
        ElasticsearchClient <| Uri "http://localhost:9200"
        
    let inline printResult title (result: Result<'a, exn>) =
        printf title
        match result with
        | Ok o -> printfn $"OK -> {o}"
        | Error e -> printfn $"Error -> {e.Message}"

    // Create an Index
    let mapping =
        [| { MappingDefinition.Name = "field1"
             Type = FieldTypes.Text |> Fields.Text
             Mappings = [| Mapping.FieldMapping.Analyzer "analyzer_name" |] } |]

    let settings =
        { IndexSettings.NumberOfShards = Some 3us
          NumberOfReplicas = Some 0us
          Static = None
          Dynamic = None }

    let req =
        { IndexRequest.Name = "index_test"
          Mappings = Some mapping
          Settings = Some settings
          Aliases = Some [| IndexAlias.mk "Test" |]
          Parameters = None }

    let createResult : Result<IndexCreateResponse, exn> =
        client.mkIndex req |> Async.RunSynchronously

    printResult "Create: " createResult

    // Update Index Settings
    let updateSettings =
        { IndexSettings.Dynamic =
            Some { DynamicIndexSettings.RefreshInterval = Some (TimeoutUnit.Seconds 1<TimeUnits.s>)
                   AutoExpandReplicas = None
                   SearchIdleAfter = None
                   MaxResultWindow = None
                   MaxInnerResultWindow = None
                   MaxReScoreWindow = None
                   MaxDocValueFieldsSearch = None
                   MaxScriptFields = None }
          NumberOfShards = None
          NumberOfReplicas = None
          Static = None }
    let updateReq =
      { UpdateIndexSettingsRequest.Target = Some "index_test"
        Settings = Some updateSettings
        Parameters = None }

    let updateResult : Result<ElasticsearchGenericResponse, exn> =
        client.updateIndexSettings updateReq |> Async.RunSynchronously

    printResult "Update: " updateResult
    
    // Create Alias for Index
    let addAlias =
        { AliasAction.Names = AliasNames.Alias "alias_test"
          On = ActionOn.Index "index_test"
          IsHidden = None
          MustExists = None
          IsWriteIndex = None
          Routing = None
          IndexRouting = None
          SearchRouting = None }
        |> Action.Add 
    
    let aliasCmd =
        { AliasCommandRequest.Actions = [| addAlias |]
          Parameters = Some { AliasQueryParameter.Timeout = Some <| (TimeoutUnit.Seconds 30<TimeUnits.s>)
                              MasterTimeout = None } }

    let aliasCommandResult : Result<ElasticsearchGenericResponse, exn> =
        client.executeCommand aliasCmd |> Async.RunSynchronously

    printResult "Alias Command: " aliasCommandResult

    // Index a doc with custom Id
    let docCustomId = { SampleDocument.Field1 = DateTime.UtcNow.ToString "O" }
    let indexDocCustomId =
        { IndexDocument.GetDocumentJson = konst (toJson docCustomId)
          Target = "index_test"
          Id = Some <| Guid.NewGuid().ToString("N")
          Parameters = None }

    let aliasCommandResult : Result<IndexDocumentResponse, exn> =
        client.indexDocument indexDocCustomId |> Async.RunSynchronously

    printResult "Index Document: " aliasCommandResult

    0

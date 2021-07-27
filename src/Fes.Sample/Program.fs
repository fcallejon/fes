open System
open FSharpPlus
open FSharpPlus.Data
open Fes
open Fes.Contracts.Api
open Fes.DSL
open Fes.DSL.Aliases
open Fes.DSL.Fields
open Fes.DSL.Indices
open Fes.DSL.Mappings
open Fes.DSL.Search
open Fes.DSL.Units
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators

open Fes.Sample

type SampleDocument =
    { Field1: string
      Field2: string }
with
    override this.ToString() =
        $"Field1: %s{this.Field1}\tField2: %s{this.Field2}"

    static member ToJson doc =
        jobj [ "field1" .= doc.Field1
               "field2" .= doc.Field2 ]
        
    static member OfJson json =
        match json with
        | JObject o ->
            monad {
                let! field1 = o .@ "field1"
                let! field2 = o .@ "field2"
                return { SampleDocument.Field1 = field1
                         Field2 = field2 }
            }
        | x -> Decode.Fail.strExpected x

[<EntryPoint>]
let main _ =
    let client =
        ElasticsearchClient <| Uri "http://localhost:9200/"
    let indexName = "index_test_3"
        
    let inline printResult title (result: Result<'a, exn>) =
        printf title
        match result with
        | Ok o -> printfn $"OK -> {o}"
        | Error e -> printfn $"Error -> {e.Message}"
        
    let inline printSearchResult response = 
        printfn "--------------------------------------------"
        printResult "Search Document: " response
        response
        |> Result.map snd
        |> (fun docs ->
            match docs with
            | Ok documents ->
                printfn "Documents:"
                documents
                |> Array.iter (fun d -> printfn $"\t%s{d.ToString()}")
            | Error _ -> ())
        printfn "--------------------------------------------"

    // Create an Index
    let mapping =
        [| { MappingDefinition.Name = "field1"
             Type = FieldTypes.DateTypes.Date |> Fields.Date
             Mappings = [|  |] }
           { MappingDefinition.Name = "field2"
             Type = FieldTypes.Keyword |> Fields.Keywords
             Mappings = [|  |] } |]

    let settings =
        { IndexSettings.NumberOfShards = Some 3us
          NumberOfReplicas = Some 0us
          Static = None
          Dynamic = None }

    let req =
        { IndexRequest.Name = indexName
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
      { UpdateIndexSettingsRequest.Target = Some indexName
        Settings = Some updateSettings
        Parameters = None }

    let updateResult : Result<ElasticsearchGenericResponse, exn> =
        client.updateIndexSettings updateReq |> Async.RunSynchronously

    printResult "Update: " updateResult
    
    // Create Alias for Index
    let addAlias =
        { AliasAction.Names = AliasNames.Alias "alias_test"
          On = ActionOn.Index indexName
          IsHidden = None
          MustExists = None
          IsWriteIndex = None
          Routing = None
          IndexRouting = None
          SearchRouting = None
          Filter = None }
        |> Action.Add 
    
    let aliasCmd =
        { AliasCommandRequest.Actions = [| addAlias |]
          Parameters = Some { AliasQueryParameter.Timeout = Some <| (TimeoutUnit.Seconds 30<TimeUnits.s>)
                              MasterTimeout = None } }

    let aliasCommandResult : Result<ElasticsearchGenericResponse, exn> =
        client.executeCommand aliasCmd |> Async.RunSynchronously

    printResult "Alias Command: " aliasCommandResult

    // Index a doc with custom Id
    let email = $"fer_mail_%i{DateTime.UtcNow.Ticks}@myemailserver.com"
    let docCustomId = { SampleDocument.Field1 = DateTime.UtcNow.ToString "O"; Field2 = email }
    let indexParams =
        { IndexDocumentQueryParameters.WaitForActiveShards = Some IndexDocumentWaitForActiveShards.All
          Refresh = Some IndexDocumentRefresh.True
          IfSeqNo = None
          IfPrimaryTerm = None
          OpType = None
          Pipeline = None
          Routing = None
          Version = None
          VersionType = None
          Timeout = None
          RequireAlias = None }
    let indexDocCustomId =
        { IndexDocument.GetDocumentJson = konst (toJson docCustomId)
          Target = indexName
          Id = Some <| Guid.NewGuid().ToString("N")
          Parameters = Some indexParams }

    let aliasCommandResult : Result<IndexDocumentResponse, exn> =
        client.indexDocument indexDocCustomId |> Async.RunSynchronously

    printResult "Index Document: " aliasCommandResult
    
    // Search a doc using field1
    let searchRequest = Search.mkTermSearch indexName "field1" docCustomId.Field1
    let searchResponse : Result<SearchResponse * SampleDocument[], exn> =
        ElasticsearchClient.search client searchRequest
        |> Async.RunSynchronously

    printSearchResult searchResponse
    
    // Search a doc using field2
    let searchRequest2 = Search.mkQueryString indexName None "fer_mail*"
    let searchResponse2 : Result<SearchResponse * SampleDocument[], exn> =
        ElasticsearchClient.search client searchRequest2
        |> Async.RunSynchronously

    printSearchResult searchResponse2
    
    0

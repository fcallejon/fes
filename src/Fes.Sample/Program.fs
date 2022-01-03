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
open Fes.Builders
open Fes.Builders.Indices
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
        
let getEsServer _ =
    let fromEnv = Environment.GetEnvironmentVariable("FES_ES_SERVER")
    match fromEnv with
    | _ when String.IsNullOrWhiteSpace(fromEnv) -> Uri "http://localhost:9200/"
    | server -> Uri server
    
let getIndexName _ =
    let fromEnv = Environment.GetEnvironmentVariable("FES_ES_INDEX_NAME")
    match fromEnv with
    | _ when String.IsNullOrWhiteSpace(fromEnv) -> "index_test_using_ce"
    | indexName -> indexName

[<EntryPoint>]
let main _ =
    let client =
        getEsServer()
        |> ElasticsearchClient

    let indexName = getIndexName ()
        
    let printResult title (result: Result<'a, exn>) =
        printf title
        match result with
        | Ok o -> printfn $"OK -> {o}"
        | Error e ->
            match e with
            | :? AggregateException as ae ->
                ae.InnerExceptions
                |> Seq.iter (fun ie -> printfn $"Error -> {ie.Message} \r\n{ie.InnerException.Message}")
            | _ -> printfn $"Error -> {e.Message}"
        
    let printSearchResult response = 
        printfn "--------------------------------------------"
        printResult "Search Document: " response
        response
        |> Result.map (fun x -> x.Hits.Hits)
        |> (fun docs ->
            match docs with
            | Ok documents ->
                printfn "Documents:"
                documents
                |> Array.iter (fun d -> printfn $"\t%s{d.ToString()}")
            | Error _ -> ())
        printfn "--------------------------------------------"

    let req =
        createIndexRequest {
            name indexName
            mappings
                [|
                    mappingDefinition {
                        name "field1"
                        fieldType (FieldTypes.DateTypes.Date |> Fields.Date)
                    }
                    mappingDefinition {
                        name "field2"
                        fieldType (FieldTypes.Keyword |> Fields.Keywords)
                    }
                    mappingDefinition {
                        name "nestedField1"
                        fieldType Fields.Nested
                        mappings
                            [| ([| ("innerField1", FieldTypes.Integer |> Fields.Numeric)
                                   ("innerField2", FieldTypes.Keyword |> Fields.Keywords ) |]
                                |> Mapping.FieldMapping.Properties) |]
                    }
                |]
            settings (
                indexSettings {
                    shards 3us
                    replicas 0us
                })
            aliases [| indexAlias { name "Test" } |]
        }
        

    let createResult : Result<IndexCreateResponse, exn> =
        client.createIndex req |> Async.RunSynchronously

    printResult "Create: " createResult

    // Update Index Settings
    let updateReq =
        updateIndexSettingsRequest {
            target indexName
            settings (
                indexSettings{
                    dynamic (dynamicIndexSettings {
                            refreshInterval (TimeoutUnit.Seconds 1<TimeUnits.s>) })
                })
        }

    let updateResult : Result<ElasticsearchGenericResponse, exn> =
        client.updateIndexSettings updateReq |> Async.RunSynchronously

    printResult "Update: " updateResult
    
    // Create Alias for Index
    let aliasCmd =
        aliasCommandRequest {
            add (
                aliasAction {
                    names (AliasNames.Alias "alias_test")
                    on (ActionOn.Index indexName)
                })
            parameters (
                aliasQueryParameter {
                    timeout (TimeoutUnit.Seconds 30<TimeUnits.s>)
                })
        }

    let aliasCommandResult : Result<ElasticsearchGenericResponse, exn> =
        client.executeCommand aliasCmd |> Async.RunSynchronously

    printResult "Alias Command: " aliasCommandResult

    // Index a doc with custom Id
    let email = $"fer_mail_%i{DateTime.UtcNow.Ticks}@myemailserver.com"
    let docCustomId = { SampleDocument.Field1 = DateTime.UtcNow.ToString "O"; Field2 = email }
        
    let indexDocCustomId =
        indexDocument<SampleDocument> {
            document docCustomId
            id (Guid.NewGuid().ToString())
            target indexName
            parameters (
                indexDocumentParameters {
                    waitForActiveShards IndexDocumentWaitForActiveShards.All
                    refresh IndexDocumentRefresh.True
                })
        }

    let indexDocCustomIdResult : Result<IndexDocumentResponse, exn> =
        ElasticsearchClient.indexDocument client indexDocCustomId |> Async.RunSynchronously

    printResult "Index Document: " indexDocCustomIdResult
    
    // Search a doc using field1
    let searchRequest = Search.mkTermSearch indexName "field1" docCustomId.Field1
    let searchResponse : Result<SearchResponse<SampleDocument>, exn> =
        ElasticsearchClient.search client searchRequest
        |> Async.RunSynchronously

    printSearchResult searchResponse
    
    // Search a doc using field2
    let searchRequest2 = Search.mkQueryString indexName None "fer_mail*"
    let searchResponse2 : Result<SearchResponse<SampleDocument>, exn> =
        ElasticsearchClient.search client searchRequest2
        |> Async.RunSynchronously

    printSearchResult searchResponse2
    
    0
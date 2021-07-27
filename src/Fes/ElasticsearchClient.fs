namespace Fes

open System
open System.Net.Http
open FSharpPlus
open FSharpPlus.Data
open Fes.Contracts.Api
open Fes.DSL.Aliases
open Fes.DSL.Indices
open Fes.DSL.Search
open Fleece.SystemTextJson

type ElasticsearchClient (baseUri: Uri) =
    let localClient =
        let client = new HttpClient()
        client.BaseAddress <- baseUri
        client
        
    member _.mkIndex (index: IndexRequest) : AsyncResult<IndexCreateResponse, exn> =
        Http.run index localClient
        
    member _.updateIndexSettings (update: UpdateIndexSettingsRequest) : AsyncResult<ElasticsearchGenericResponse, exn> =
        Http.run update localClient

    member _.executeCommand (command: AliasCommandRequest) : AsyncResult<ElasticsearchGenericResponse, exn> =
        Http.run command localClient
        
    member _.indexDocument (indexDocument: IndexDocument) : AsyncResult<IndexDocumentResponse, exn> =
        Http.run indexDocument localClient
        
    member _.search (searchCommand: SearchCommandRequest) : AsyncResult<SearchResponse, exn> =
        Http.run searchCommand localClient
        
[<RequireQualifiedAccess>]
module ElasticsearchResponse =
    
    let inline parseDocument (response: SearchResponse) : Result<'a[], exn> =
        let inline mkElement document : Result<'a, exn> = 
            match ofJson document.RawSource with
            | ParseResult.Ok element -> Ok element
            | ParseResult.Error e -> e.ToString() |> exn |> Error

        response.Hits.Hits
        |> Array.map mkElement 
        |> sequence
    
    let inline documentWithResponse (response: SearchResponse) : Result<SearchResponse * 'a[], exn> =
        let mkTuple values = response, values
        in response
        |> parseDocument
        |> Result.map mkTuple
        
[<RequireQualifiedAccess>]
module ElasticsearchClient =
    let inline search (client: ElasticsearchClient) (searchCommand: SearchCommandRequest) =
        client.search searchCommand
        |> Async.map (Result.bind ElasticsearchResponse.documentWithResponse)
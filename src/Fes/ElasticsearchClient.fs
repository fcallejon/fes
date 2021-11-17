namespace Fes

open System
open System.Net.Http
open Fes.Contracts.Api
open Fes.DSL.Aliases
open Fes.DSL.Indices
open Fes.DSL.Search


// TODO: need to rethink this
type ElasticsearchClient (baseUri: Uri) =
    let localClient =
        let client = new HttpClient()
        client.BaseAddress <- baseUri
        client
        
    member _.Client with get() = localClient
        
    member _.createIndex (index: IndexRequest) : AsyncResult<IndexCreateResponse, exn> =
        Http.run index localClient
        
    member _.updateIndexSettings (update: UpdateIndexSettingsRequest) : AsyncResult<ElasticsearchGenericResponse, exn> =
        Http.run update localClient

    member _.executeCommand (command: AliasCommandRequest) : AsyncResult<ElasticsearchGenericResponse, exn> =
        Http.run command localClient

[<RequireQualifiedAccess>]        
module ElasticsearchClient =
    let inline search (client: ElasticsearchClient) searchCommand : AsyncResult<SearchResponse<'T>, exn> =
        Http.run searchCommand client.Client
        
    let inline indexDocument (client: ElasticsearchClient) indexDocument : AsyncResult<IndexDocumentResponse, exn> =
        Http.run indexDocument client.Client
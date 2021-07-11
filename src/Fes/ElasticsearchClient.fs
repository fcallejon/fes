namespace Fes

open System
open System.Net.Http
open Fes.Contracts.Api
open Fes.DSL.Aliases
open Fes.DSL.Indices

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
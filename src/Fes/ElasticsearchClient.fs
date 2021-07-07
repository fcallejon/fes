namespace Fes

open System
open System.Net.Http
open Fes.Contracts.Aliases
open Fes.Contracts.Indices

type ElasticsearchClient (baseUri: Uri) =
    let localClient =
        let client = new HttpClient()
        client.BaseAddress <- baseUri
        client
        
    member this.mkIndex (index: IndexRequest) : AsyncResult<IndexCreateResponse, exn> =
        Http.run index localClient
        
    member this.updateIndexSettings (update: UpdateIndexSettingsRequest) : AsyncResult<ElasticsearchGenericResponse, exn> =
        Http.run update localClient

    member this.executeCommand (command: AliasCommandRequest) : AsyncResult<ElasticsearchGenericResponse, exn> =
        Http.run command localClient
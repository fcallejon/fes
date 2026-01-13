namespace Fes.Tests

open System
open System.Text.Json.Serialization
open FSharpPlus
open Fes
open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

type SampleDocument =
    { [<JsonPropertyName("field1")>] Field1: string
      [<JsonPropertyName("field2")>] Field2: string }
    override this.ToString() =
        $"Field1: %s{this.Field1}\tField2: %s{this.Field2}"

/// A wrapper type for IndexRequest that includes a document body
type IndexDocumentRequest<'TDoc> =
    { Request: IndexRequest
      Document: 'TDoc }
    static member inline ToRequest(req: IndexDocumentRequest<'TDoc>) : Result<Http.RequestMsg, exn> =
        req.Request
        |> IndexRequest.ToRequest
        |> Result.map (Http.Request.withJsonBody req.Document)

module IndexDocumentCommands =
    [<Fact>]
    let ``Index Document command return correct HTTP call`` () =
        let docId = Guid.NewGuid().ToString()
        let dateTime = DateTime.UtcNow.ToString "O"
        let email =
            $"fer_mail_%i{DateTime.UtcNow.Ticks}@myemailserver.com"
        let expected =
            $"""Method: POST, RequestUri: '/indexName/_doc/{docId}?refresh=true&wait_for_active_shards=all', Version: 1.1, Content: System.Net.Http.StringContent, Headers:
{{
  Content-Type: application/json; charset=utf-8
  Content-Length: 98
}}
{{"field1":"{dateTime}","field2":"{email}"}}"""

        let doc =
            { SampleDocument.Field1 = dateTime
              Field2 = email }

        // Create the index request using auto-generated builder
        let req = indexRequest {
            index "indexName"
            id docId
            refresh Refresh.True
            wait_for_active_shards (box "all" : WaitForActiveShards)
        }

        // Combine with document for full request
        let fullRequest = { Request = req; Document = doc }

        fullRequest
        |> shouldEqual expected

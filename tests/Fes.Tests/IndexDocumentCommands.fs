namespace Fes.Tests

open System
open FSharpPlus
open Fes.Builders.IndexDocumentBuilder
open Fes.Contracts.Api
open Fleece.SystemTextJson
open Fleece.SystemTextJson.Operators
open Xunit

type SampleDocument =
    { Field1: string
      Field2: string }
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

                return
                    { SampleDocument.Field1 = field1
                      Field2 = field2 }
            }
        | x -> Decode.Fail.strExpected x

module IndexDocumentCommands =
    [<Fact>]
    let ``Index Document command return correct HTTP call`` () =
        let docId = Guid.NewGuid().ToString()
        let expected =
            $"""Method: PUT, RequestUri: 'indexName/_doc/{docId}?refresh=true&wait_for_active_shards=all', Version: 1.1, Content: System.Net.Http.StringContent, Headers:
{{
  Content-Type: application/json; charset=utf-8
}}"""

        let email =
            $"fer_mail_%i{DateTime.UtcNow.Ticks}@myemailserver.com"

        let docCustomId =
            { SampleDocument.Field1 = DateTime.UtcNow.ToString "O"
              Field2 = email }

        indexDocument<SampleDocument> {
            document docCustomId
            id docId
            target "indexName"

            parameters (
                indexDocumentParameters {
                    waitForActiveShards IndexDocumentWaitForActiveShards.All
                    refresh IndexDocumentRefresh.True
                }
            )
        }
        |> shouldEqual expected

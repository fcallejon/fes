open System
open System.Net.Http
open System.Text.Json.Serialization
open FSharpPlus
open Fes
open Fes.DSL.Models.Types
open Fes.DSL.Operations

type SampleDocument =
    { [<JsonPropertyName("field1")>] Field1: string
      [<JsonPropertyName("field2")>] Field2: string }
    override this.ToString() =
        $"Field1: %s{this.Field1}\tField2: %s{this.Field2}"

let getEsServer _ =
    let fromEnv = Environment.GetEnvironmentVariable("FES_ES_SERVER")
    match fromEnv with
    | _ when String.IsNullOrWhiteSpace(fromEnv) -> Uri "http://localhost:9200/"
    | server -> Uri server

let getIndexName _ =
    let fromEnv = Environment.GetEnvironmentVariable("FES_ES_INDEX_NAME")
    match fromEnv with
    | _ when String.IsNullOrWhiteSpace(fromEnv) -> "index_test_generated"
    | indexName -> indexName

[<EntryPoint>]
let main _ =
    let client =
        let client = new HttpClient()
        client.BaseAddress <- getEsServer()
        client

    // Debug helper to print request JSON
    let debugRequest (req: HttpRequestMessage) =
        printfn "=== REQUEST DEBUG ==="
        printfn $"Method: {req.Method}"
        printfn $"URI: {req.RequestUri}"
        if req.Content <> null then
            let json = req.Content.ReadAsStringAsync().GetAwaiter().GetResult()
            printfn $"Body:\n{json}"
        printfn "====================="

    let inline executeElasticsearchCall req =
        match Http.toRequest req with
        | Result.Ok httpReq -> debugRequest httpReq
        | Result.Error e -> printfn $"Failed to create request: {e.Message}"

        let arrow =
            client.SendAsync >> TaskResult.ofTask
            |> ElasticsearchClient.execute
        arrow req

    let indexName = getIndexName ()

    let printResult title (result: Result<'a, exn>) =
        printf title
        match result with
        | Result.Ok o -> printfn $"OK -> {o}"
        | Result.Error e ->
            match e with
            | :? AggregateException as ae ->
                ae.InnerExceptions
                |> Seq.iter (fun ie -> printfn $"Error -> {ie.Message}")
            | _ -> printfn $"Error -> {e.Message}"

    // =========================================================================
    // Create Index using auto-generated operation builder
    // =========================================================================

    // Create mappings using generated types - initialize all fields explicitly
    let indexMappings : MappingTypeMapping =
        { AllField = Option.None
          DateDetection = Option.None
          Dynamic = Option.None
          DynamicDateFormats = Option.None
          DynamicTemplates = Option.None
          FieldNames = Option.None
          IndexField = Option.None
          Meta = Option.None
          NumericDetection = Option.None
          Properties = Option.Some (Map.ofList [
              "field1", box {| ``type`` = "text" |}
              "field2", box {| ``type`` = "text" |}
          ])
          Routing = Option.None
          Size = Option.None
          Source = Option.None
          Runtime = Option.None
          Enabled = Option.None
          Subobjects = Option.None
          DataStreamTimestamp = Option.None }

    let createReq =
        indicesCreateRequest {
            index indexName
            mappings indexMappings
        }

    let createResult : Result<IndicesCreateResponse, exn> =
        (executeElasticsearchCall createReq).GetAwaiter().GetResult()

    printResult "Create Index (generated): " createResult

    // =========================================================================
    // Update Aliases using auto-generated operation builder
    // =========================================================================

    let addAction : UpdateAliasesAddAction =
        { Alias = Option.Some "alias_test_generated"
          Aliases = Option.None
          Filter = Option.None
          Index = Option.Some indexName
          Indices = Option.None
          IndexRouting = Option.None
          IsHidden = Option.None
          IsWriteIndex = Option.None
          Routing = Option.None
          SearchRouting = Option.None
          MustExist = Option.None }

    let aliasAction : UpdateAliasesAction =
        { Add = Option.Some addAction
          Remove = Option.None
          RemoveIndex = Option.None }

    let aliasReq =
        indicesUpdateAliasesRequest {
            actions [| aliasAction |]
        }

    let aliasResult : Result<AcknowledgedResponseBase, exn> =
        (executeElasticsearchCall aliasReq).GetAwaiter().GetResult()

    printResult "Update Aliases (generated): " aliasResult

    // =========================================================================
    // Delete Index using auto-generated operation builder
    // =========================================================================

    let deleteReq =
        indicesDeleteRequest {
            index (box indexName)
        }

    let deleteResult : Result<IndicesDeleteResponse, exn> =
        (executeElasticsearchCall deleteReq).GetAwaiter().GetResult()

    printResult "Delete Index (generated): " deleteResult

    0

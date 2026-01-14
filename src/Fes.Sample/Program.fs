open System
open System.Net.Http
open System.Text.Json.Serialization
open Fes
open Fes.DSL.Models.Types
open Fes.DSL.Operations

// =============================================================================
// Sample Document Types
// =============================================================================

type Product =
    { [<JsonPropertyName("name")>] Name: string
      [<JsonPropertyName("category")>] Category: string
      [<JsonPropertyName("price")>] Price: float
      [<JsonPropertyName("in_stock")>] InStock: bool
      [<JsonPropertyName("description")>] Description: string }

// =============================================================================
// Configuration
// =============================================================================

let getEsServer _ =
    let fromEnv = Environment.GetEnvironmentVariable("FES_ES_SERVER")
    match fromEnv with
    | _ when String.IsNullOrWhiteSpace(fromEnv) -> Uri "http://localhost:9200/"
    | server -> Uri server

let getIndexName _ =
    let fromEnv = Environment.GetEnvironmentVariable("FES_ES_INDEX_NAME")
    match fromEnv with
    | _ when String.IsNullOrWhiteSpace(fromEnv) -> "products_sample"
    | indexName -> indexName

// =============================================================================
// Main Program
// =============================================================================

[<EntryPoint>]
let main _ =
    let client =
        let client = new HttpClient()
        client.BaseAddress <- getEsServer()
        client

    let debugRequest (req: HttpRequestMessage) =
        printfn "=== REQUEST ==="
        printfn $"Method: {req.Method}"
        printfn $"URI: {req.RequestUri}"
        if req.Content <> null then
            let json = req.Content.ReadAsStringAsync().GetAwaiter().GetResult()
            printfn $"Body:\n{json}"
        printfn "==============="

    let inline executeElasticsearchCall req =
        match Http.toRequest req with
        | Result.Ok httpReq -> debugRequest httpReq
        | Result.Error e -> printfn $"Failed to create request: {e.Message}"

        let arrow =
            client.SendAsync >> TaskResult.ofTask
            |> ElasticsearchClient.execute
        arrow req

    let printResult title (result: Result<'a, exn>) =
        printfn $"\n>>> {title}"
        match result with
        | Result.Ok o -> printfn $"OK -> {o}"
        | Result.Error e ->
            match e with
            | :? AggregateException as ae ->
                ae.InnerExceptions |> Seq.iter (fun ie -> printfn $"Error -> {ie.Message}")
            | _ -> printfn $"Error -> {e.Message}"

    let indexName = getIndexName ()

    // =========================================================================
    // 1. Create Index with mappings
    // =========================================================================
    printfn "\n========== 1. CREATE INDEX =========="

    let indexMappings : MappingTypeMapping =
        { AllField = Option.None; DateDetection = Option.None; Dynamic = Option.None
          DynamicDateFormats = Option.None; DynamicTemplates = Option.None
          FieldNames = Option.None; IndexField = Option.None; Meta = Option.None
          NumericDetection = Option.None
          Properties = Option.Some (Map.ofList [
              "name", box {| ``type`` = "text" |}
              "category", box {| ``type`` = "keyword" |}
              "price", box {| ``type`` = "float" |}
              "in_stock", box {| ``type`` = "boolean" |}
              "description", box {| ``type`` = "text" |}
          ])
          Routing = Option.None; Size = Option.None; Source = Option.None
          Runtime = Option.None; Enabled = Option.None; Subobjects = Option.None
          DataStreamTimestamp = Option.None }

    let createReq = indicesCreateRequest {
        index indexName
        mappings indexMappings
    }

    let createResult : Result<IndicesCreateResponse, exn> =
        (executeElasticsearchCall createReq).GetAwaiter().GetResult()
    printResult "Create Index" createResult

    // =========================================================================
    // 2. Index sample documents using bulk API
    // =========================================================================
    printfn "\n========== 2. INDEX DOCUMENTS =========="

    let products = [
        "product_1", { Name = "Laptop Pro"; Category = "electronics"; Price = 1299.99; InStock = true
                       Description = "High performance laptop with 16GB RAM" }
        "product_2", { Name = "Wireless Mouse"; Category = "electronics"; Price = 29.99; InStock = true
                       Description = "Ergonomic wireless mouse with long battery life" }
        "product_3", { Name = "Coffee Maker"; Category = "kitchen"; Price = 89.99; InStock = true
                       Description = "Programmable coffee maker with thermal carafe" }
        "product_4", { Name = "Running Shoes"; Category = "sports"; Price = 119.99; InStock = false
                       Description = "Lightweight running shoes for marathon training" }
        "product_5", { Name = "Desk Lamp"; Category = "office"; Price = 45.00; InStock = true
                       Description = "LED desk lamp with adjustable brightness" }
        "product_6", { Name = "Headphones"; Category = "electronics"; Price = 199.99; InStock = true
                       Description = "Noise cancelling wireless headphones" }
        "product_7", { Name = "Yoga Mat"; Category = "sports"; Price = 35.00; InStock = true
                       Description = "Non-slip yoga mat for home workouts" }
        "product_8", { Name = "Blender"; Category = "kitchen"; Price = 65.00; InStock = true
                       Description = "High-speed blender for smoothies" }
    ]

    for docId, product in products do
        let docReq = indexRequest {
            index indexName
            id docId
            refresh Refresh.True
        }
        // Create wrapper type with ToRequest for document indexing
        let fullReq =
            {| docReq with Body = Some (box product) |}

        // Use Http module directly for document with body
        let httpReq =
            docReq
            |> IndexRequest.ToRequest
            |> Result.map (Http.Request.withJsonBody product)

        match httpReq with
        | Result.Ok req ->
            debugRequest req
            try
                let result = client.SendAsync(req).GetAwaiter().GetResult()
                printfn $"\n>>> Index {docId}: {result.StatusCode}"
            with ex ->
                printfn $"\n>>> Index {docId}: Error - {ex.Message}"
        | Result.Error e ->
            printfn $"\n>>> Index {docId}: Error - {e.Message}"

    // =========================================================================
    // 3. Search with query string (simple search)
    // =========================================================================
    printfn "\n========== 3. QUERY STRING SEARCH =========="

    let searchReq1 = searchRequest {
        index (box indexName : Indices)
        q "wireless"
        size 10.0
    }

    let searchResult1 : Result<SearchResponseBody, exn> =
        (executeElasticsearchCall searchReq1).GetAwaiter().GetResult()
    printResult "Query String Search (wireless)" searchResult1

    // =========================================================================
    // 4. Search with size 0 for aggregations only
    // =========================================================================
    printfn "\n========== 4. AGGREGATIONS =========="

    // Use the searchRequest builder with aggregations
    let termsAgg : AggregationsTermsAggregation =
        { CollectMode = Option.None; Exclude = Option.None; ExecutionHint = Option.None
          Field = Option.Some "category"; Include = Option.None; MinDocCount = Option.None
          Missing = Option.None; MissingOrder = Option.None; MissingBucket = Option.None
          ValueType = Option.None; Order = Option.None; Script = Option.None
          ShardMinDocCount = Option.None; ShardSize = Option.None
          ShowTermDocCountError = Option.None; Size = Option.Some 10.0; Format = Option.None }

    let aggContainer : AggregationsAggregationContainer =
        { Aggregations = Option.None; Meta = Option.None; AdjacencyMatrix = Option.None
          AutoDateHistogram = Option.None; Avg = Option.None; AvgBucket = Option.None
          Boxplot = Option.None; BucketScript = Option.None; BucketSelector = Option.None
          BucketSort = Option.None; BucketCountKsTest = Option.None
          BucketCorrelation = Option.None; Cardinality = Option.None
          CartesianBounds = Option.None; CartesianCentroid = Option.None
          CategorizeText = Option.None; ChangePoint = Option.None; Children = Option.None
          Composite = Option.None; CumulativeCardinality = Option.None
          CumulativeSum = Option.None; DateHistogram = Option.None; DateRange = Option.None
          Derivative = Option.None; DiversifiedSampler = Option.None
          ExtendedStats = Option.None; ExtendedStatsBucket = Option.None
          FrequentItemSets = Option.None; Filter = Option.None; Filters = Option.None
          GeoBounds = Option.None; GeoCentroid = Option.None; GeoDistance = Option.None
          GeohashGrid = Option.None; GeoLine = Option.None; GeotileGrid = Option.None
          GeohexGrid = Option.None; Global = Option.None; Histogram = Option.None
          IpRange = Option.None; IpPrefix = Option.None; Inference = Option.None
          Line = Option.None; MatrixStats = Option.None; Max = Option.None
          MaxBucket = Option.None; MedianAbsoluteDeviation = Option.None; Min = Option.None
          MinBucket = Option.None; Missing = Option.None; MovingAvg = Option.None
          MovingPercentiles = Option.None; MovingFn = Option.None; MultiTerms = Option.None
          Nested = Option.None; Normalize = Option.None; Parent = Option.None
          PercentileRanks = Option.None; Percentiles = Option.None
          PercentilesBucket = Option.None; RandomSampler = Option.None; Range = Option.None
          RareTerms = Option.None; Rate = Option.None; ReverseNested = Option.None
          Sampler = Option.None; ScriptedMetric = Option.None; SerialDiff = Option.None
          SignificantTerms = Option.None; SignificantText = Option.None; Stats = Option.None
          StatsBucket = Option.None; StringStats = Option.None; Sum = Option.None
          SumBucket = Option.None; Terms = Option.Some termsAgg; TimeSeries = Option.None
          TopHits = Option.None; TTest = Option.None; TopMetrics = Option.None
          ValueCount = Option.None; WeightedAvg = Option.None
          VariableWidthHistogram = Option.None }

    let searchReq2 = searchRequest {
        index (box indexName : Indices)
        size 0.0
        aggregations (Map.ofList [ "by_category", aggContainer ])
    }

    let searchResult2 : Result<SearchResponseBody, exn> =
        (executeElasticsearchCall searchReq2).GetAwaiter().GetResult()
    printResult "Terms Aggregation (by category)" searchResult2

    // =========================================================================
    // 5. Cleanup - Delete Index
    // =========================================================================
    printfn "\n========== 5. CLEANUP =========="

    let deleteReq = indicesDeleteRequest {
        index (box indexName : Indices)
    }

    let deleteResult : Result<IndicesDeleteResponse, exn> =
        (executeElasticsearchCall deleteReq).GetAwaiter().GetResult()
    printResult "Delete Index" deleteResult

    0

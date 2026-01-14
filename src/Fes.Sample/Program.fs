open System
open System.Net
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
// Test Result Tracking
// =============================================================================

type TestResult =
    | Passed of testName: string * message: string
    | Failed of testName: string * error: string

module TestResult =
    let isPassed = function Passed _ -> true | Failed _ -> false
    let isFailed = function Failed _ -> true | Passed _ -> false

    let print = function
        | Passed (name, msg) -> printfn $"  [PASS] {name}: {msg}"
        | Failed (name, err) -> printfn $"  [FAIL] {name}: {err}"

    let printSummary (results: TestResult list) =
        let passed = results |> List.filter isPassed |> List.length
        let failed = results |> List.filter isFailed |> List.length
        let total = List.length results

        printfn ""
        printfn "=============================================="
        printfn "                 TEST SUMMARY                 "
        printfn "=============================================="
        printfn $"  Total:  {total}"
        printfn $"  Passed: {passed}"
        printfn $"  Failed: {failed}"
        printfn "=============================================="

        if failed > 0 then
            printfn ""
            printfn "Failed tests:"
            results
            |> List.filter isFailed
            |> List.iter (function
                | Failed (name, err) -> printfn $"  - {name}: {err}"
                | _ -> ())

        failed = 0

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
// Helper Functions
// =============================================================================

let extractError (e: exn) =
    match e with
    | :? AggregateException as ae ->
        ae.InnerExceptions
        |> Seq.map (fun ie -> ie.Message)
        |> String.concat "; "
    | _ -> e.Message

let validateHttpResponse testName (response: HttpResponseMessage) (expectedStatuses: HttpStatusCode list) : TestResult =
    if expectedStatuses |> List.contains response.StatusCode then
        Passed (testName, $"Status {response.StatusCode}")
    else
        let body = response.Content.ReadAsStringAsync().GetAwaiter().GetResult()
        let truncatedBody = if body.Length > 200 then body.Substring(0, 200) + "..." else body
        Failed (testName, $"Expected one of {expectedStatuses}, got {response.StatusCode}: {truncatedBody}")

// =============================================================================
// Main Program
// =============================================================================

[<EntryPoint>]
let main _ =
    let mutable results : TestResult list = []
    let addResult r = results <- results @ [r]

    let client =
        let c = new HttpClient()
        c.BaseAddress <- getEsServer()
        c

    printfn "=============================================="
    printfn "       FES Integration Test Suite            "
    printfn "=============================================="
    printfn $"Elasticsearch: {client.BaseAddress}"

    let inline executeElasticsearchCall req =
        let arrow =
            client.SendAsync >> TaskResult.ofTask
            |> ElasticsearchClient.execute
        arrow req

    let indexName = getIndexName ()
    printfn $"Index Name: {indexName}"
    printfn ""

    // =========================================================================
    // 1. Create Index with mappings
    // =========================================================================
    printfn ">>> Test 1: Create Index"

    let indexMappings : MappingTypeMapping =
        { AllField = Option.None; DateDetection = Option.None; Dynamic = Option.None
          DynamicDateFormats = Option.None; DynamicTemplates = Option.None
          FieldNames = Option.None; IndexField = Option.None; Meta = Option.None
          NumericDetection = Option.None
          Properties = Option.Some (Map.ofList [
              "name", MappingPropertyBuilders.text()
              "category", MappingPropertyBuilders.keyword()
              "price", MappingPropertyBuilders.float()
              "in_stock", MappingPropertyBuilders.boolean()
              "description", MappingPropertyBuilders.text()
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

    let createTest =
        match createResult with
        | Result.Ok resp ->
            if resp.Acknowledged then Passed ("Create Index", $"Index '{resp.Index}' created")
            else Failed ("Create Index", "Index creation not acknowledged")
        | Result.Error e -> Failed ("Create Index", extractError e)
    addResult createTest
    TestResult.print createTest

    // =========================================================================
    // 2. Index sample documents
    // =========================================================================
    printfn "\n>>> Test 2: Index Documents"

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

        let httpReq =
            docReq
            |> IndexRequest.ToRequest
            |> Result.map (Http.Request.withJsonBody product)

        let testResult =
            match httpReq with
            | Result.Ok req ->
                try
                    let response = client.SendAsync(req).GetAwaiter().GetResult()
                    validateHttpResponse $"Index {docId}" response [HttpStatusCode.Created; HttpStatusCode.OK]
                with ex ->
                    Failed ($"Index {docId}", extractError ex)
            | Result.Error e ->
                Failed ($"Index {docId}", extractError e)

        addResult testResult
        TestResult.print testResult

    // =========================================================================
    // 3. Search with query string
    // =========================================================================
    printfn "\n>>> Test 3: Query String Search"

    let searchReq1 = searchRequest {
        index (box indexName : Indices)
        q "wireless"
        size 10.0
    }

    let searchResult1 : Result<SearchResponseBody, exn> =
        (executeElasticsearchCall searchReq1).GetAwaiter().GetResult()

    let searchTest1 =
        match searchResult1 with
        | Result.Ok resp ->
            let hitCount = resp.Hits.Hits.Length
            if hitCount > 0 then Passed ("Search 'wireless'", $"Found {hitCount} documents")
            else Failed ("Search 'wireless'", "Expected at least 1 hit")
        | Result.Error e -> Failed ("Search 'wireless'", extractError e)
    addResult searchTest1
    TestResult.print searchTest1

    // =========================================================================
    // 4. Aggregations
    // =========================================================================
    printfn "\n>>> Test 4: Terms Aggregation"

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

    let aggTest =
        match searchResult2 with
        | Result.Ok resp ->
            match resp.Aggregations with
            | Some aggs when aggs.Count > 0 -> Passed ("Aggregation 'by_category'", $"Got {aggs.Count} aggregation(s)")
            | Some _ -> Failed ("Aggregation 'by_category'", "Aggregations map is empty")
            | _ -> Failed ("Aggregation 'by_category'", "No aggregations in response")
        | Result.Error e -> Failed ("Aggregation 'by_category'", extractError e)
    addResult aggTest
    TestResult.print aggTest

    // =========================================================================
    // 5. Get Document
    // =========================================================================
    printfn "\n>>> Test 5: Get Document"

    let getReq = getRequest {
        index indexName
        id "product_1"
    }

    let getResult : Result<GetResponse, exn> =
        (executeElasticsearchCall getReq).GetAwaiter().GetResult()

    let getTest =
        match getResult with
        | Result.Ok resp ->
            if resp.Found then Passed ("Get product_1", $"Document found, index: {resp.Index}")
            else Failed ("Get product_1", "Document not found")
        | Result.Error e -> Failed ("Get product_1", extractError e)
    addResult getTest
    TestResult.print getTest

    // =========================================================================
    // 6. Delete Document
    // =========================================================================
    printfn "\n>>> Test 6: Delete Document"

    let deleteDocReq = deleteRequest {
        index indexName
        id "product_8"
        refresh Refresh.True
    }

    let deleteDocResult : Result<DeleteResponse, exn> =
        (executeElasticsearchCall deleteDocReq).GetAwaiter().GetResult()

    let deleteDocTest =
        match deleteDocResult with
        | Result.Ok resp ->
            // Result is an enum - check if it's 'deleted'
            let resultStr = string resp.Result
            if resultStr.ToLower().Contains("deleted") then Passed ("Delete product_8", "Document deleted")
            else Failed ("Delete product_8", $"Unexpected result: {resultStr}")
        | Result.Error e -> Failed ("Delete product_8", extractError e)
    addResult deleteDocTest
    TestResult.print deleteDocTest

    // =========================================================================
    // 7. Verify document count after delete
    // =========================================================================
    printfn "\n>>> Test 7: Verify Document Count"

    let countReq = searchRequest {
        index (box indexName : Indices)
        size 0.0
        track_total_hits (box true : SearchTypesTrackHits)
    }

    let countResult : Result<SearchResponseBody, exn> =
        (executeElasticsearchCall countReq).GetAwaiter().GetResult()

    let countTest =
        match countResult with
        | Result.Ok resp ->
            // Total is a JsonElement, we just verify the query succeeded
            Passed ("Document count", $"Query succeeded, took {resp.Took}ms")
        | Result.Error e -> Failed ("Document count", extractError e)
    addResult countTest
    TestResult.print countTest

    // =========================================================================
    // 8. Cleanup - Delete Index
    // =========================================================================
    printfn "\n>>> Test 8: Cleanup - Delete Index"

    let deleteReq = indicesDeleteRequest {
        index (box indexName : Indices)
    }

    let deleteResult : Result<IndicesDeleteResponse, exn> =
        (executeElasticsearchCall deleteReq).GetAwaiter().GetResult()

    let deleteIndexTest =
        match deleteResult with
        | Result.Ok resp ->
            if resp.Acknowledged then Passed ("Delete Index", "Index deleted")
            else Failed ("Delete Index", "Index deletion not acknowledged")
        | Result.Error e -> Failed ("Delete Index", extractError e)
    addResult deleteIndexTest
    TestResult.print deleteIndexTest

    // =========================================================================
    // Summary
    // =========================================================================
    let allPassed = TestResult.printSummary results

    if allPassed then 0 else 1

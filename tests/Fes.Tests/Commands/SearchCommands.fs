namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module SearchCommands =
    [<Fact>]
    let ``Search request with query string returns correct HTTP call`` () =
        let searchReq = searchRequest {
            index (box "products" : Indices)
            q "wireless mouse"
            size 10.0
        }

        let result = searchReq |> toRequestString

        // Check HTTP method and URI
        Assert.Contains("Method: POST", result)
        Assert.Contains("RequestUri: '/products/_search?q=wireless mouse&size=10'", result)

    [<Fact>]
    let ``Search request with pagination returns correct HTTP call`` () =
        let searchReq = searchRequest {
            index (box "products" : Indices)
            size 20.0
            from 40.0
        }

        let result = searchReq |> toRequestString

        // Check HTTP method and URI with pagination params
        Assert.Contains("Method: POST", result)
        Assert.Contains("RequestUri: '/products/_search?size=20&from=40'", result)

    [<Fact>]
    let ``Search request with multiple options returns correct HTTP call`` () =
        let searchReq = searchRequest {
            index (box "products" : Indices)
            q "*"
            size 5.0
            timeout "30s"
            track_total_hits (box true : SearchTypesTrackHits)
        }

        let result = searchReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_search", result)
        Assert.Contains("q=*", result)
        Assert.Contains("size=5", result)
        Assert.Contains("timeout=30s", result)
        Assert.Contains("track_total_hits=True", result)

    [<Fact>]
    let ``Search request with aggregations returns correct HTTP call`` () =
        // Create a simple terms aggregation
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

        let searchReq = searchRequest {
            index (box "products" : Indices)
            size 0.0
            aggregations (Map.ofList [ "by_category", aggContainer ])
        }

        let result = searchReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_search", result)
        Assert.Contains("Content-Type: application/json", result)
        // Check aggregation is in the body
        Assert.Contains("\"aggregations\"", result)
        Assert.Contains("\"by_category\"", result)
        Assert.Contains("\"terms\"", result)
        Assert.Contains("\"field\":\"category\"", result)

    [<Fact>]
    let ``Search request with source filtering returns correct HTTP call`` () =
        let searchReq = searchRequest {
            index (box "products" : Indices)
            _source_includes (box [| "name"; "price" |] : Fields)
            _source_excludes (box [| "description" |] : Fields)
            size 10.0
        }

        let result = searchReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_search", result)

    [<Fact>]
    let ``Search request with scroll returns correct HTTP call`` () =
        let searchReq = searchRequest {
            index (box "products" : Indices)
            scroll "5m"
            size 100.0
        }

        let result = searchReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_search", result)
        Assert.Contains("scroll=5m", result)
        Assert.Contains("size=100", result)

    [<Fact>]
    let ``Search request with search type returns correct HTTP call`` () =
        let searchReq = searchRequest {
            index (box "products" : Indices)
            search_type SearchType.DfsQueryThenFetch
            size 10.0
        }

        let result = searchReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_search", result)
        Assert.Contains("search_type=DfsQueryThenFetch", result)

    [<Fact>]
    let ``Async search submit request returns correct HTTP call`` () =
        let asyncReq = asyncSearchSubmitRequest {
            index (box "products" : Indices)
            wait_for_completion_timeout "1s"
            keep_alive "5m"
            keep_on_completion true
        }

        let result = asyncReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_async_search", result)
        Assert.Contains("wait_for_completion_timeout=1s", result)
        Assert.Contains("keep_alive=5m", result)
        Assert.Contains("keep_on_completion=True", result)

    [<Fact>]
    let ``Async search get request returns correct HTTP call`` () =
        let getReq = asyncSearchGetRequest {
            id "async_search_id_123"
            keep_alive "10m"
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/_async_search/async_search_id_123", result)
        Assert.Contains("keep_alive=10m", result)

    [<Fact>]
    let ``Async search delete request returns correct HTTP call`` () =
        let deleteReq = asyncSearchDeleteRequest {
            id "async_search_id_123"
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/_async_search/async_search_id_123", result)

    [<Fact>]
    let ``Multi search request returns correct HTTP call`` () =
        let msearchReq = msearchRequest {
            index (box "products" : Indices)
        }

        let result = msearchReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_msearch", result)

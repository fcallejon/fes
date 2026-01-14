namespace Fes.Tests

open System
open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module DocumentCommands =

    [<Fact>]
    let ``Get document request returns correct HTTP call`` () =
        let getReq = getRequest {
            index "products"
            id "product_123"
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("RequestUri: '/products/_doc/product_123'", result)

    [<Fact>]
    let ``Get document with options returns correct HTTP call`` () =
        let getReq = getRequest {
            index "products"
            id "product_123"
            routing (box "user_1" : Routing)
            realtime false
            refresh true
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/products/_doc/product_123", result)
        Assert.Contains("routing=user_1", result)
        Assert.Contains("realtime=false", result)
        Assert.Contains("refresh=true", result)

    [<Fact>]
    let ``Get document with source filtering returns correct HTTP call`` () =
        let getReq = getRequest {
            index "products"
            id "product_123"
            _source_includes (box [| "name"; "price" |] : Fields)
            _source_excludes (box [| "description" |] : Fields)
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/products/_doc/product_123", result)

    [<Fact>]
    let ``Get document with version returns correct HTTP call`` () =
        let getReq = getRequest {
            index "products"
            id "product_123"
            version 5.0
            version_type VersionType.External
        }

        let result = getReq |> toRequestString

        Assert.Contains("Method: GET", result)
        Assert.Contains("/products/_doc/product_123", result)
        Assert.Contains("version=5", result)
        Assert.Contains("version_type=external", result)

    [<Fact>]
    let ``Delete document request returns correct HTTP call`` () =
        let deleteReq = deleteRequest {
            index "products"
            id "product_123"
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("RequestUri: '/products/_doc/product_123'", result)

    [<Fact>]
    let ``Delete document with options returns correct HTTP call`` () =
        let deleteReq = deleteRequest {
            index "products"
            id "product_123"
            refresh Refresh.True
            timeout "30s"
            routing (box "user_1" : Routing)
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/products/_doc/product_123", result)
        Assert.Contains("refresh=true", result)
        Assert.Contains("timeout=30s", result)
        Assert.Contains("routing=user_1", result)

    [<Fact>]
    let ``Delete document with optimistic concurrency returns correct HTTP call`` () =
        let deleteReq = deleteRequest {
            index "products"
            id "product_123"
            if_seq_no 10.0
            if_primary_term 1.0
        }

        let result = deleteReq |> toRequestString

        Assert.Contains("Method: DELETE", result)
        Assert.Contains("/products/_doc/product_123", result)
        Assert.Contains("if_seq_no=10", result)
        Assert.Contains("if_primary_term=1", result)

    [<Fact>]
    let ``Create document request returns correct HTTP call`` () =
        let createReq = createRequest {
            index "products"
            id "product_new"
        }

        let result = createReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("RequestUri: '/products/_create/product_new'", result)

    [<Fact>]
    let ``Create document with options returns correct HTTP call`` () =
        let createReq = createRequest {
            index "products"
            id "product_new"
            refresh Refresh.WaitFor
            timeout "1m"
            pipeline "my_pipeline"
        }

        let result = createReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_create/product_new", result)
        Assert.Contains("refresh=wait_for", result)
        Assert.Contains("timeout=1m", result)
        Assert.Contains("pipeline=my_pipeline", result)

    [<Fact>]
    let ``Bulk request returns correct HTTP call`` () =
        let bulkReq = bulkRequest {
            index "products"
            refresh Refresh.True
        }

        let result = bulkReq |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("/products/_bulk", result)
        Assert.Contains("refresh=true", result)

    [<Fact>]
    let ``Bulk request with options returns correct HTTP call`` () =
        let bulkReq = bulkRequest {
            index "products"
            pipeline "enrichment"
            timeout "5m"
            wait_for_active_shards (box "all" : WaitForActiveShards)
        }

        let result = bulkReq |> toRequestString

        Assert.Contains("Method: PUT", result)
        Assert.Contains("/products/_bulk", result)
        Assert.Contains("pipeline=enrichment", result)
        Assert.Contains("timeout=5m", result)
        Assert.Contains("wait_for_active_shards=all", result)

    [<Fact>]
    let ``Index request with basic options returns correct HTTP call`` () =
        // Note: The generated IndexRequest requires both index and id
        let indexReq = indexRequest {
            index "products"
            id "auto_123"
            refresh Refresh.True
        }

        let result = indexReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_doc/auto_123", result)
        Assert.Contains("refresh=true", result)

    [<Fact>]
    let ``Index request with id returns correct HTTP call`` () =
        let docId = "product_456"
        let indexReq = indexRequest {
            index "products"
            id docId
            refresh Refresh.True
        }

        let result = indexReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains($"/products/_doc/{docId}", result)
        Assert.Contains("refresh=true", result)

    [<Fact>]
    let ``Index request with routing and pipeline returns correct HTTP call`` () =
        let indexReq = indexRequest {
            index "products"
            id "product_789"
            routing (box "category_electronics" : Routing)
            pipeline "product_enrichment"
            timeout "30s"
        }

        let result = indexReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_doc/product_789", result)
        Assert.Contains("routing=category_electronics", result)
        Assert.Contains("pipeline=product_enrichment", result)
        Assert.Contains("timeout=30s", result)

    [<Fact>]
    let ``Exists request returns correct HTTP call`` () =
        let existsReq = existsRequest {
            index "products"
            id "product_123"
        }

        let result = existsReq |> toRequestString

        Assert.Contains("Method: HEAD", result)
        Assert.Contains("/products/_doc/product_123", result)

    [<Fact>]
    let ``Exists request with options returns correct HTTP call`` () =
        let existsReq = existsRequest {
            index "products"
            id "product_123"
            routing (box "user_1" : Routing)
        }

        let result = existsReq |> toRequestString

        Assert.Contains("Method: HEAD", result)
        Assert.Contains("/products/_doc/product_123", result)
        Assert.Contains("routing=user_1", result)

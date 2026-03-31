namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module UpdateDocumentCommands =

    [<Fact>]
    let ``Update document request returns correct HTTP call`` () =
        let updateReq = updateRequest {
            index "products"
            id "product_123"
        }

        let result = updateReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("RequestUri: '/products/_update/product_123'", result)

    [<Fact>]
    let ``Update document with refresh option returns correct HTTP call`` () =
        let updateReq = updateRequest {
            index "products"
            id "product_123"
            refresh Refresh.WaitFor
        }

        let result = updateReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_update/product_123", result)
        Assert.Contains("refresh=wait_for", result)

    [<Fact>]
    let ``Update document with retry_on_conflict returns correct HTTP call`` () =
        let updateReq = updateRequest {
            index "products"
            id "product_123"
            retry_on_conflict 3.0
        }

        let result = updateReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_update/product_123", result)
        Assert.Contains("retry_on_conflict=3", result)

    [<Fact>]
    let ``Update document with routing and timeout returns correct HTTP call`` () =
        let updateReq = updateRequest {
            index "products"
            id "product_123"
            routing (box "user_1" : Routing)
            timeout "30s"
        }

        let result = updateReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_update/product_123", result)
        Assert.Contains("routing=user_1", result)
        Assert.Contains("timeout=30s", result)

    [<Fact>]
    let ``Update document with optimistic concurrency returns correct HTTP call`` () =
        let updateReq = updateRequest {
            index "products"
            id "product_123"
            if_seq_no 5.0
            if_primary_term 1.0
        }

        let result = updateReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_update/product_123", result)
        Assert.Contains("if_seq_no=5", result)
        Assert.Contains("if_primary_term=1", result)

    [<Fact>]
    let ``Update document request includes JSON body`` () =
        // UpdateRequest always sends a JSON body (the partial doc / script to apply)
        let updateReq = updateRequest {
            index "products"
            id "product_123"
            detect_noop true
        }

        let result = updateReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_update/product_123", result)
        // The request body should always be present for update operations
        Assert.Contains("Content-Type: application/json", result)

    [<Fact>]
    let ``Update document with doc_as_upsert returns correct HTTP call`` () =
        let updateReq = updateRequest {
            index "products"
            id "product_new"
            doc_as_upsert true
            refresh Refresh.True
        }

        let result = updateReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_update/product_new", result)
        Assert.Contains("refresh=true", result)

    [<Fact>]
    let ``Mget request returns correct HTTP call`` () =
        // Elasticsearch multi-get uses POST /{index}/_mget
        let mgetReq = mgetRequest {
            index "products"
        }

        let result = mgetReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_mget", result)

    [<Fact>]
    let ``Mget request with options returns correct HTTP call`` () =
        let mgetReq = mgetRequest {
            index "products"
            realtime false
            refresh true
            routing (box "user_1" : Routing)
        }

        let result = mgetReq |> toRequestString

        Assert.Contains("Method: POST", result)
        Assert.Contains("/products/_mget", result)
        Assert.Contains("realtime=false", result)
        Assert.Contains("routing=user_1", result)

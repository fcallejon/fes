module Fes.Tests.EndpointTests

open Xunit
open FsUnit.Xunit
open Fes.Generated
open Fes.Generated.Operations
open Elastic.Transport

// ============================================================================
// ToEndpoint tests — verify HTTP method and query string generation
// ============================================================================

[<Fact>]
let ``Search request produces POST method`` () =
    let req = searchRequest {
        index (Types.Indices.IndexName "products")
    }
    let (endpoint, postData) = SearchRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST
    postData.IsSome |> should be True

[<Fact>]
let ``Search request includes query params`` () =
    let req = searchRequest {
        index (Types.Indices.IndexName "products")
        q "wireless"
    }
    let (endpoint, _) = SearchRequest.ToEndpoint(req)
    endpoint.PathAndQuery |> should haveSubstring "q=wireless"

[<Fact>]
let ``Get request produces GET method with no body`` () =
    let req = getRequest {
        index "products"
        id "product_1"
    }
    let (endpoint, postData) = GetRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.GET
    postData.IsNone |> should be True

[<Fact>]
let ``Delete request produces DELETE method`` () =
    let req = deleteRequest {
        index "products"
        id "product_1"
    }
    let (endpoint, postData) = DeleteRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.DELETE
    postData.IsNone |> should be True

[<Fact>]
let ``Indices create request produces PUT method`` () =
    let req = indicesCreateRequest {
        index "my-index"
    }
    let (endpoint, postData) = IndicesCreateRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.PUT
    postData.IsSome |> should be True

[<Fact>]
let ``Search request path contains index name not DU representation`` () =
    let req = searchRequest {
        index (Types.Indices.IndexName "products")
    }
    let (endpoint, _) = SearchRequest.ToEndpoint(req)
    endpoint.PathAndQuery |> should haveSubstring "/products/_search"
    endpoint.PathAndQuery |> should not' (haveSubstring "IndexName")

[<Fact>]
let ``Get request path contains index and id`` () =
    let req = getRequest {
        index "my-index"
        id "doc-123"
    }
    let (endpoint, _) = GetRequest.ToEndpoint(req)
    endpoint.PathAndQuery |> should haveSubstring "/my-index/"
    endpoint.PathAndQuery |> should haveSubstring "/doc-123"

[<Fact>]
let ``Boolean query params serialise as lowercase`` () =
    let req = searchRequest {
        index (Types.Indices.IndexName "products")
        explain true
    }
    let (endpoint, _) = SearchRequest.ToEndpoint(req)
    endpoint.PathAndQuery |> should haveSubstring "explain=true"

// ============================================================================
// Index (document indexing)
// ============================================================================

[<Fact>]
let ``Index request produces POST method with body`` () =
    let req = indexRequest {
        index "products"
        id "product_1"
        document {| name = "test" |}
    }
    let (endpoint, postData) = IndexRequest.ToEndpoint(req)
    endpoint.Method |> should equal HttpMethod.POST
    postData.IsSome |> should be True

[<Fact>]
let ``Index request path contains index and id`` () =
    let req = indexRequest {
        index "my-index"
        id "doc-123"
        document {| title = "hello" |}
    }
    let (endpoint, _) = IndexRequest.ToEndpoint(req)
    endpoint.PathAndQuery |> should haveSubstring "/my-index/"
    endpoint.PathAndQuery |> should haveSubstring "/doc-123"

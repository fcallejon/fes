module Fes.Tests.UrlTests

open Xunit
open FsUnit.Xunit
open Elastic.Transport
open Fes.Generated
open Fes.Generated.Operations

// ============================================================================
// Search
// ============================================================================

[<Fact>]
let ``POST /products/_search`` () =
    let req = searchRequest { index (Types.Indices.IndexName "products") }
    let (ep, _) = SearchRequest.ToEndpoint(req)
    ep.Method |> should equal HttpMethod.POST
    ep.PathAndQuery |> should equal "/products/_search"

[<Fact>]
let ``POST /products/_search with query params`` () =
    let req = searchRequest {
        index (Types.Indices.IndexName "products")
        q "test"
        size 10
    }
    let (ep, _) = SearchRequest.ToEndpoint(req)
    ep.PathAndQuery |> should haveSubstring "/products/_search"
    ep.PathAndQuery |> should haveSubstring "q=test"
    ep.PathAndQuery |> should haveSubstring "size=10"

// ============================================================================
// Get
// ============================================================================

[<Fact>]
let ``GET /products/_doc/1`` () =
    let req = getRequest { index "products"; id "1" }
    let (ep, body) = GetRequest.ToEndpoint(req)
    ep.Method |> should equal HttpMethod.GET
    ep.PathAndQuery |> should equal "/products/_doc/1"
    body.IsNone |> should be True

// ============================================================================
// Delete
// ============================================================================

[<Fact>]
let ``DELETE /products/_doc/1`` () =
    let req = deleteRequest { index "products"; id "1" }
    let (ep, body) = DeleteRequest.ToEndpoint(req)
    ep.Method |> should equal HttpMethod.DELETE
    ep.PathAndQuery |> should equal "/products/_doc/1"
    body.IsNone |> should be True

// ============================================================================
// Indices.Create
// ============================================================================

[<Fact>]
let ``PUT /my-index for indices create`` () =
    let req = indicesCreateRequest { index "my-index" }
    let (ep, body) = IndicesCreateRequest.ToEndpoint(req)
    ep.Method |> should equal HttpMethod.PUT
    ep.PathAndQuery |> should equal "/my-index"
    body.IsSome |> should be True

// ============================================================================
// Indices.Delete
// ============================================================================

[<Fact>]
let ``DELETE /my-index for indices delete`` () =
    let req = indicesDeleteRequest { index (Types.Indices.IndexName "my-index") }
    let (ep, _) = IndicesDeleteRequest.ToEndpoint(req)
    ep.Method |> should equal HttpMethod.DELETE
    ep.PathAndQuery |> should equal "/my-index"

// ============================================================================
// Cat
// ============================================================================

[<Fact>]
let ``GET /_cat/indices/products`` () =
    let req = catIndicesRequest { index (Types.Indices.IndexName "products") }
    let (ep, _) = CatIndicesRequest.ToEndpoint(req)
    ep.Method |> should equal HttpMethod.GET
    ep.PathAndQuery |> should startWith "/_cat/indices/products"

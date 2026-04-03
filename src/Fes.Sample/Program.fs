open Fes
open Fes.Generated
open Fes.Generated.Operations
open Fes.Generated.Builders

// =============================================================================
// FES Sample — demonstrates the new DSL
// =============================================================================

[<EntryPoint>]
let main _ =
    // ── Connect to Elasticsearch ────────────────────────────────────────
    let transport = ES.connect "http://localhost:9200"

    // Or with auth:
    // let transport = ES.connectWithApiKey "http://localhost:9200" "my-api-key"

    // Or with full config:
    // let transport = esTransport {
    //     uri "http://localhost:9200"
    //     apiKey "my-key"
    //     requestTimeout 30.
    //     maxRetries 3
    //     compression true
    // }

    // ── Create an index ─────────────────────────────────────────────────
    printfn "Creating index..."
    let createReq = indicesCreateRequest {
        index "products"
    }
    let (ep, _) = IndicesCreateRequest.ToEndpoint(createReq)
    printfn $"  Endpoint: {ep.Method} {ep.PathAndQuery}"

    // ── Search with query string ────────────────────────────────────────
    printfn "\nSearching..."
    let searchReq = searchRequest {
        index (Types.Indices.IndexName "products")
        q "wireless"
        size 10
    }
    let (ep, body) = SearchRequest.ToEndpoint(searchReq)
    printfn $"  Endpoint: {ep.Method} {ep.PathAndQuery}"
    printfn $"  Has body: {body.IsSome}"

    // ── Query DSL ───────────────────────────────────────────────────────
    printfn "\nQuery DSL examples..."

    // Bool query
    let boolQ = Query.bool {
        Filter = None; MinimumShouldMatch = None
        Must = None; MustNot = None; Should = None
    }
    let boolJson = Json.serialize boolQ
    printfn $"  Bool query: {boolJson}"

    // Match query with field
    let matchQ =
        Query.match' "name" (matchQuery { query (System.Text.Json.JsonDocument.Parse("\"laptop\"").RootElement) })
    let matchJson = Json.serialize matchQ
    printfn $"  Match query: {matchJson}"

    // Term query with field
    let termQ =
        Query.term "status" { CaseInsensitive = None; Value = Unchecked.defaultof<_> }
    let termJson = Json.serialize termQ
    printfn $"  Term query: {termJson}"

    // ── Aggregations ────────────────────────────────────────────────────
    printfn "\nAggregation examples..."

    let termsAgg = Aggregation.terms (termsAggregation {
        field "category"
        size 10
    })
    let aggJson = Json.serialize termsAgg
    printfn $"  Terms agg: {aggJson}"

    // ── Get document ────────────────────────────────────────────────────
    printfn "\nGet document..."
    let getReq = getRequest {
        index "products"
        id "product_1"
    }
    let (ep, _) = GetRequest.ToEndpoint(getReq)
    printfn $"  Endpoint: {ep.Method} {ep.PathAndQuery}"

    // ── Delete document ─────────────────────────────────────────────────
    printfn "\nDelete document..."
    let deleteReq = deleteRequest {
        index "products"
        id "product_1"
    }
    let (ep, _) = DeleteRequest.ToEndpoint(deleteReq)
    printfn $"  Endpoint: {ep.Method} {ep.PathAndQuery}"

    // ── Delete index ────────────────────────────────────────────────────
    printfn "\nDelete index..."
    let deleteIdxReq = indicesDeleteRequest {
        index (Types.Indices.IndexName "products")
    }
    let (ep, _) = IndicesDeleteRequest.ToEndpoint(deleteIdxReq)
    printfn $"  Endpoint: {ep.Method} {ep.PathAndQuery}"

    printfn "\nDone!"
    0

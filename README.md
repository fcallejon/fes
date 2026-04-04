# FEs

FEs is an F# client for Elasticsearch.

### Motivation

Although
[Elastic.Clients.Elasticsearch](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/introduction.html)
is great to use from C#, using it from F# means doing weird stuff around lambdas and such.

FEs provides an F#-native DSL with computation expression builders generated from the
[Elasticsearch OpenAPI specification](https://github.com/elastic/elasticsearch-specification),
and uses [Elastic.Transport](https://github.com/elastic/elastic-transport-net) under the hood for
connection pooling, retries, node failover, and Elastic Cloud support.

## How to use it

There is no NuGet package yet, so to use this library it will have to be cloned/downloaded, built and referenced as a
project output.

1. Add the following opens:
   ```fsharp
   open Fes
   open Fes.Generated
   open Fes.Generated.Operations
   open Fes.Generated.Builders
   ```

2. Connect to Elasticsearch:
   ```fsharp
   // Simple single-node connection
   let transport = ES.connect "http://localhost:9200"

   // With API key authentication
   let transport = ES.connectWithApiKey "http://localhost:9200" "my-api-key"

   // With Elastic Cloud
   let transport = ES.connectCloud "my-cloud-id" "my-api-key"

   // Full configuration via computation expression
   let transport = esTransport {
       uri "http://localhost:9200"
       apiKey "my-key"
       requestTimeout 30.
       maxRetries 3
       compression true
   }
   ```

3. Build a request using computation expression builders:
   ```fsharp
   // Create an index
   let createReq = indicesCreateRequest {
       index "products"
   }

   // Search with query string
   let searchReq = searchRequest {
       index (Types.Indices.IndexName "products")
       q "wireless"
       size 10
   }

   // Get a document
   let getReq = getRequest {
       index "products"
       id "product_1"
   }

   // Delete a document
   let deleteReq = deleteRequest {
       index "products"
       id "product_1"
   }
   ```

4. Send the request:
   ```fsharp
   // sendAsync returns TaskResult<'TResponse, exn>
   let result = ES.sendAsync<SearchResponse, _> transport searchReq

   // Or inspect the endpoint without sending
   let (endpoint, postData) = SearchRequest.ToEndpoint(searchReq)
   printfn $"  {endpoint.Method} {endpoint.PathAndQuery}"
   ```

### Query DSL

FEs also provides builders for queries and aggregations:

```fsharp
// Match query
let matchQ =
    Query.match' "name" (matchQuery {
        query (JsonDocument.Parse("\"laptop\"").RootElement)
    })

// Term query
let termQ =
    Query.term "status" { CaseInsensitive = None; Value = Unchecked.defaultof<_> }

// Bool query
let boolQ = Query.bool {
    Filter = None; MinimumShouldMatch = None
    Must = None; MustNot = None; Should = None
}

// Aggregations
let termsAgg = Aggregation.terms (termsAggregation {
    field "category"
    size 10
})
```

## Road map (WIP)

- [X] Adopt [Elastic.Transport](https://github.com/elastic/elastic-transport-net) (connection pooling, retries, failover, Elastic Cloud)
- [X] Code generation from the [Elasticsearch OpenAPI specification](https://github.com/elastic/elasticsearch-specification)
- [X] DSL for Indices (Create, Update, Manage Aliases)
- [X] DSL to Index Documents
- [X] DSL for Search (Queries & Aggregations)
- [X] CE builders for all generated operations
- [X] Elasticsearch-specific exception handling
- [ ] Publish NuGet package

## Contributing

I'm doing this as a weekend-only project, if you are interested in contributing please do. Adding tests would be a great
place to help, but the [Elasticsearch REST API](https://www.elastic.co/guide/en/elasticsearch/reference/current/rest-apis.html) is
really big so help there will also be appreciated 😁.

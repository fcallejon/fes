# FEs

FEs is an F# client for [Elasticsearch](https://www.elastic.co/elasticsearch), generated from the official
Elasticsearch OpenAPI specification. It provides idiomatic F# computation expressions (CE) for every Elasticsearch
operation, keeps dependencies minimal, and is HTTP-client-agnostic.

### Motivation

Both [Elasticsearch.Net](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/elasticsearch-net.html)
and [NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html) are great from C#, but
using them from F# often requires awkward lambda wrappers. FEs aims to feel natural in idiomatic F#.

### Key features

- **Full Elasticsearch API coverage** — DSL and CE builders auto-generated from the ES OpenAPI spec
- **`TaskResult<'T, exn>`-based API** — composable async pipelines without exceptions in the happy path
- **HTTP-client-agnostic** — bring your own `HttpClient`; FEs just builds `HttpRequestMessage` values
- **`System.Text.Json`** for serialisation — no heavy runtime dependencies
- **Targets .NET 10**

## How to use it

> No NuGet package yet — clone the repo, build, and reference the output directly.

### 1. Open the namespaces

```fsharp
open System.Net.Http
open Fes
open Fes.DSL.Models.Types
open Fes.DSL.Operations
```

### 2. Create an `HttpClient`

```fsharp
let client = new HttpClient(BaseAddress = Uri "http://localhost:9200/")
```

### 3. Build a helper to execute calls

`ElasticsearchClient.execute` takes any function `HttpRequestMessage -> TaskResult<HttpResponseMessage, exn>` and
returns a generic `'request -> TaskResult<'response, exn>` arrow:

```fsharp
let inline runCall req =
    let arrow =
        client.SendAsync >> TaskResult.ofTask
        |> ElasticsearchClient.execute
    arrow req
```

### 4. Make calls using CE builders

**Create an index:**

```fsharp
let createReq = indicesCreateRequest {
    index "my-index"
}

let result : Result<IndicesCreateResponse, exn> =
    (runCall createReq).GetAwaiter().GetResult()
```

**Index a document:**

```fsharp
let indexReq = indexRequest {
    index "my-index"
    id    "doc-1"
}

let result : Result<IndexResponse, exn> =
    (runCall indexReq).GetAwaiter().GetResult()
```

**Search:**

```fsharp
let searchReq = searchRequest {
    index (box "my-index" : Indices)
    q     "hello world"
    size  10.0
}

let result : Result<SearchResponseBody, exn> =
    (runCall searchReq).GetAwaiter().GetResult()
```

**Delete a document:**

```fsharp
let deleteReq = deleteRequest {
    index "my-index"
    id    "doc-1"
}

let result : Result<DeleteResponse, exn> =
    (runCall deleteReq).GetAwaiter().GetResult()
```

See [`src/Fes.Sample/Program.fs`](src/Fes.Sample/Program.fs) for a full end-to-end integration test that exercises
index creation, document indexing, search, aggregations, get, delete, and cleanup.

## DSL code generation

All DSL types and CE builders under `src/Fes/DSL/` are auto-generated from
[`scripts/esapi.2025-01.yaml`](scripts/esapi.2025-01.yaml) via
[`scripts/generate-dsl.fsx`](scripts/generate-dsl.fsx).

To regenerate after updating the spec:

```bash
dotnet fsi scripts/generate-dsl.fsx
```

## Road map

- [X] Full Elasticsearch API coverage via OpenAPI code generation
- [X] DSL for Indices (create, update, aliases)
- [X] DSL to Index Documents (index, bulk, delete, get)
- [X] DSL for Search (query, aggregations, async search)
- [X] HTTP-client-agnostic design (`ElasticsearchClient.execute`)
- [X] `TaskResult<'T, exn>` pipeline helpers
- [X] Error deserialisation from Elasticsearch error responses
- [ ] NuGet package publication
- [ ] Retry / resilience helpers
- [ ] Update to latest Elasticsearch OpenAPI spec

## Contributing

This is a weekend project — contributions are very welcome! Good places to start:

- Adding or improving unit/integration tests
- Updating the OpenAPI spec and regenerating the DSL
- Improving error messages and response types
- Anything in the [Road map](#road-map) above

See the [ES REST API docs](https://www.elastic.co/guide/en/elasticsearch/reference/current/rest-apis.html) for the full
API surface. Feel free to open an issue before starting larger changes. 😁

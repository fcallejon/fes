# FEs

FEs is an F# client for Elasticsearch, built on top of `System.Net.Http` and `System.Text.Json`.

### Motivation

Although both [Elasticsearch.Net](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/elasticsearch-net.html)
and [NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html) are great for C#, using
them from F# requires awkward lambda-heavy patterns. FEs provides an idiomatic F# DSL and pipeline-based HTTP client.

## How to use it

There is no NuGet package yet — clone the repo, build, and reference the output.

### 1. Set up your HTTP client and execute helper

```fsharp
open System.Net.Http
open Fes
open Fes.DSL.Models.Types
open Fes.DSL.Operations

let client =
    let c = new HttpClient()
    c.BaseAddress <- Uri "http://localhost:9200/"
    c

// Wire together: build request → send → deserialise response
let inline executeElasticsearchCall req =
    let arrow =
        client.SendAsync >> TaskResult.ofTask
        |> ElasticsearchClient.execute
    arrow req
```

`ElasticsearchClient.execute` accepts any `HttpCall` (a function `HttpRequestMessage -> TaskResult<HttpResponseMessage, exn>`)
and returns a function from any FEs request type to `TaskResult<'response, exn>`.

### 2. Create an index

```fsharp
let createReq = indicesCreateRequest {
    index "my-index"
    mappings {
        Properties = Some (Map.ofList [
            "name",        MappingPropertyBuilders.text()
            "category",    MappingPropertyBuilders.keyword()
            "price",       MappingPropertyBuilders.float()
            "in_stock",    MappingPropertyBuilders.boolean()
        ])
        // all other fields default to None
    }
}

let result : Result<IndicesCreateResponse, exn> =
    (executeElasticsearchCall createReq).GetAwaiter().GetResult()
```

### 3. Index a document

```fsharp
let docReq = indexRequest {
    index "my-index"
    id "doc-1"
    refresh Refresh.True
}

let httpReq =
    docReq
    |> IndexRequest.ToRequest
    |> Result.map (Http.Request.withJsonBody myDocument)

match httpReq with
| Ok req ->
    let response = client.SendAsync(req).GetAwaiter().GetResult()
    // response is an HttpResponseMessage
| Error e -> printfn $"Request build error: {e.Message}"
```

### 4. Search

```fsharp
let searchReq = searchRequest {
    index (box "my-index" : Indices)
    q "wireless"
    size 10.0
}

let searchResult : Result<SearchResponseBody, exn> =
    (executeElasticsearchCall searchReq).GetAwaiter().GetResult()

match searchResult with
| Ok resp -> printfn $"Hits: {resp.Hits.Hits.Length}"
| Error e -> printfn $"Error: {e.Message}"
```

### 5. Error handling

Elasticsearch errors are deserialised into `ElasticsearchException`, which exposes `ErrorType`, `Reason`,
`Status`, `RootCause`, and optional `Cause`, `Phase`, and `FailedShards`.

```fsharp
match result with
| Ok resp    -> // success path
| Error e    ->
    match e with
    | :? ElasticsearchException as esErr ->
        printfn $"ES error: {esErr.ErrorType} — {esErr.Reason}"
    | _ ->
        printfn $"Network/parse error: {e.Message}"
```

See `src/Fes.Sample/Program.fs` for a complete working example with all operations.

## Road map (WIP)

- [X] DSL for Indices (create, update, delete, aliases)
- [X] DSL for Documents (index, get, delete)
- [X] DSL for Search (query DSL, aggregations)
- [X] Idiomatic F# pipeline via `TaskResult`
- [X] Structured error handling with `ElasticsearchException`
- [ ] NuGet package
- [ ] Retry / resilience support
- [ ] Async streaming for large responses

## Contributing

Weekend-only project — contributions welcome! Adding tests or implementing missing operations are great entry points.
The [ES REST API](https://www.elastic.co/guide/en/elasticsearch/reference/current/rest-apis.html) is large; any
coverage is appreciated.

See `src/Fes.Sample/Program.fs` for working examples of the current API style.

# FEs

FEs tries to be an F# client for Elasticsearch.

### Motivation

Although
both [Elasticsearch.Net](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/elasticsearch-net.html)
and [NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html) are great to use from C#,
using them from F# means doing weird stuff around lambdas and such.

FEs uses [FSharp.SystemTextJson](https://github.com/Tarmil/FSharp.SystemTextJson) for JSON serialization, giving clean
F#-idiomatic control over Elasticsearch documents.

## How to use it

There is no nuget yet sadly, meaning to use this library it will have to be clone/downloaded, build and use the output.

1. Add the following opens:
   ```f#
   open System.Net.Http
   open Fes
   open Fes.DSL.Models.Types
   open Fes.DSL.Operations
   ```
2. Set up the HTTP client and a helper to execute Elasticsearch calls:
   ```f#
   let client =
       let c = new HttpClient()
       c.BaseAddress <- Uri "http://localhost:9200/"
       c

   let inline executeElasticsearchCall req =
       let arrow =
           client.SendAsync >> TaskResult.ofTask
           |> ElasticsearchClient.execute
       arrow req
   ```
3. Make a call using the generated operation builders (e.g. get a document):
   ```f#
   let getReq = getRequest {
       index "my-index"
       id "doc-1"
   }

   let result : Result<GetResponse, exn> =
       (executeElasticsearchCall getReq).GetAwaiter().GetResult()
   ```

See [`src/Fes.Sample/Program.fs`](src/Fes.Sample/Program.fs) for a full working example covering index creation,
document indexing, search, and cleanup.

## Road map (WIP)

- [X] DSL for Indices
  - [X] DSL to Create Indices
  - [X] DSL to Update Indices
  - [X] DSL to Manage Aliases
  - [X] Add CE constructs
- [ ] DSL to Index Documents
  - [X] Initial Implementation to index Documents
  - [X] Add CE constructs for initial implementations
- [ ] DSL for Search
  - [X] Initial Implementation for Queries
  - [X] Add CE constructs for initial implementations
- [ ] Http Client
  - [X] Initial Exceptions/Errors handling
  - [ ] Rethink Http Client
    - [X] Http Client independent
    - [X] Improve Exceptions/Errors handling
  - [ ] Add retries
 
## Contributing

I'm doing this as a weekend-only project, if you are interested in contributing please do. Adding tests would be a great
place to help, but [ES Rest API](https://www.elastic.co/guide/en/elasticsearch/reference/7.13/rest-apis.html) it's
really big so help there will also be appreciated.

Also moving and rethinking the Http Client or anything in [Roadmap](#road-map-wip) is welcome 😁.

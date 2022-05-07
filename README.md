# FEs

FEs tries to be an F# client for Elasticsearch.

### Motivation

Although
both [Elasticsearch.Net](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/elasticsearch-net.html)
and [NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html) are great to use from C#,
using them from F# means doing weird stuff around lambdas and such.

Also using [Fleece](https://github.com/fsprojects/fleece) to decode/encode JSON gives better control over documents
going back and forth.

#### About Fleece

I'm in the process of updating it to the [future version](https://github.com/fsprojects/Fleece/tree/gusty/redesign). For
this reason there are a few warnings that will be output by the build.

## How to use it

There is no nuget yet sadly, meaning to use this library it will have to be clone/downloaded, build and use the output.

1. Add the following opens:
   ```f#
   open Fes
   open Fes.DSL
   open Fes.Builders
   open Fes.Builders.Indices
   ```
2. Create the mapping for an `Index`:
   ```f#
   let req =
        createIndexRequest {
            name "indexName"
            mappings
                [|
                    mappingDefinition {
                        name "field1"
                        fieldType (FieldTypes.DateTypes.Date |> Fields.Date)
                    }
                    mappingDefinition {
                        name "field2"
                        fieldType (FieldTypes.Keyword |> Fields.Keywords)
                    }
                    mappingDefinition {
                        name "nestedField1"
                        fieldType Fields.Nested
                        mappings
                            [| ([| ("innerField1", FieldTypes.Integer |> Fields.Numeric)
                                   ("innerField2", FieldTypes.Keyword |> Fields.Keywords ) |]
                                |> Mapping.FieldMapping.Properties) |]
                    }
                |]
            settings (
                indexSettings {
                    shards 3us
                    replicas 0us
                })
            aliases [| indexAlias { name "Test" } |]
        }
   ```
4. Make the call:
   At the moment any Http Client will work. The following is just an example using some Http functions from Fes that I'm
   planning to move outside of the "core" library. Both `Http.toRequest` and `Http.Response.toResult` would map from and
   to `HttpRequestMessage` and `HttpResponseMessage` respectively.

   ```f#
    [<RequireQualifiedAccess>]
    module ElasticsearchClient =
    open System.Net.Http
   
    let inline execute (client: HttpClient) req =
        (Http.toRequest >> Async.retn) req
        |> AsyncResult.bind (client.SendAsync >> AsyncResult.waitTask)
        |> AsyncResult.bind Http.Response.toResult

    let client =
        let client = new HttpClient()
        client.BaseAddress <- getEsServer()
        client
    let inline executeElasticsearchCall (req: 'a) =
        ElasticsearchClient.execute client req
    let createResult : Result<IndexCreateResponse, exn> =
        executeElasticsearchCall req |> Async.RunSynchronously
   ```
## Road map (WIP)

- [ ] Update Fleece (WIP)
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

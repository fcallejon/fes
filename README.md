# FEs

FEs tries to be an F# client for Elasticsearch.

### Motivation

Although both [Elasticsearch.Net](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/elasticsearch-net.html) and [NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html) are great to use from C#, using them from F# means doing weird stuff around lambdas and such.

Also using [Fleece](https://github.com/fsprojects/fleece) to decode/encode JSON gives better control over documents going back and forth.

#### About Fleece

I'm in the process of updating it to the [future version](https://github.com/fsprojects/Fleece/tree/gusty/redesign) therefore there are some warnings been output by the build.

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
   ```f#
      let createResult : Result<IndexCreateResponse, exn> =
        executeElasticsearchCall req |> Async.RunSynchronously
   ```

## Contributing

I'm doing this as a weekend-only project, if you are interested in contributing please do. Adding tests would be a great place to help, but [ES Rest API](https://www.elastic.co/guide/en/elasticsearch/reference/7.13/rest-apis.html) it's really big so help there will also be appreciated.
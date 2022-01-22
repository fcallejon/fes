namespace Fes.Tests

open Fes.DSL
open Fes.DSL.Aliases
open Xunit
open Fes.Builders.Indices.IndexRequestBuilder
open Fes.Builders.AliasCommandRequestBuilder
open Fes.Builders.UpdateIndexRequestBuilder

module IndexCommands =
    [<Fact>]
    let ``Create Index command return correct HTTP call`` () =
        let expected =
            """Method: PUT, RequestUri: 'indexName', Version: 1.1, Content: System.Net.Http.StringContent, Headers:
{
  Content-Type: application/json; charset=utf-8
  Content-Length: 275
}
{"aliases":{"Test":{}},"settings":{"number_of_shards":3,"number_of_replicas":0},"mappings":{"properties":{"field1":{"type":"date"},"field2":{"type":"keyword"},"nestedField1":{"type":"nested","properties":{"innerField1":{"type":"integer"},"innerField2":{"type":"keyword"}}}}}}"""

        createIndexRequest {
            name "indexName"

            mappings [| mappingDefinition {
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

                            mappings [| ([| ("innerField1", FieldTypes.Integer |> Fields.Numeric)
                                            ("innerField2", FieldTypes.Keyword |> Fields.Keywords) |]
                                         |> Mapping.FieldMapping.Properties) |]
                        } |]

            settings (
                indexSettings {
                    shards 3us
                    replicas 0us
                }
            )

            aliases [| indexAlias { name "Test" } |]
        }
        |> shouldEqual expected
        

    [<Fact>]
    let ``Alias Index command return correct HTTP call`` () =
        let expected =
            """Method: POST, RequestUri: '_aliases?timeout=30s', Version: 1.1, Content: System.Net.Http.StringContent, Headers:
{
  Content-Type: application/json; charset=utf-8
  Content-Length: 64
}
{"actions":[{"add":{"index":"indexName","alias":"alias_test"}}]}"""
            
        aliasCommandRequest {
            add (
                aliasAction {
                    names (AliasNames.Alias "alias_test")
                    on (ActionOn.Index "indexName")
                })
            parameters (
                aliasQueryParameter {
                    timeout (TimeoutUnit.Seconds 30<TimeUnits.s>)
                })
        }
        |> shouldEqual expected
        
    [<Fact>]
    let ``Update Index command return correct HTTP call`` () =
        let expected = """Method: PUT, RequestUri: 'indexName/_settings', Version: 1.1, Content: System.Net.Http.StringContent, Headers:
{
  Content-Type: application/json; charset=utf-8
  Content-Length: 35
}
{"index":{"refresh_interval":"1s"}}"""
        
        updateIndexSettingsRequest {
            target "indexName"
            settings (
                indexSettings{
                    dynamic (dynamicIndexSettings {
                            refreshInterval (TimeoutUnit.Seconds 1<TimeUnits.s>) })
                })
        }
        |> shouldEqual expected
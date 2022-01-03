namespace Fes.Tests

open Fes.DSL.Aliases
open Fes.DSL.Fields
open Fes.DSL.Mappings
open Fes.DSL.Units
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
}"""

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
}"""
            
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
}"""
        
        updateIndexSettingsRequest {
            target "indexName"
            settings (
                indexSettings{
                    dynamic (dynamicIndexSettings {
                            refreshInterval (TimeoutUnit.Seconds 1<TimeUnits.s>) })
                })
        }
        |> shouldEqual expected
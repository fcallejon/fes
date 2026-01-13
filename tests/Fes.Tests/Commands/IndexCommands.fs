namespace Fes.Tests

open Fes.DSL.Models.Types
open Fes.DSL.Operations
open Xunit

module IndexCommands =
    let shouldContainParts (parts: string list) (actual: string) =
        for part in parts do
            if not (actual.Contains(part)) then
                failwith $"Expected '{part}' not found in:\n{actual}"

    [<Fact>]
    let ``Create Index command return correct HTTP call`` () =
        // Create mappings using generated types - initialize all fields explicitly
        let indexMappings : MappingTypeMapping =
            { AllField = Option.None
              DateDetection = Option.None
              Dynamic = Option.None
              DynamicDateFormats = Option.None
              DynamicTemplates = Option.None
              FieldNames = Option.None
              IndexField = Option.None
              Meta = Option.None
              NumericDetection = Option.None
              Properties = Option.Some (Map.ofList [
                  "field1", box {| ``type`` = "date" |}
                  "field2", box {| ``type`` = "keyword" |}
                  "nestedField1", box {|
                      ``type`` = "nested"
                      properties = {|
                          innerField1 = {| ``type`` = "integer" |}
                          innerField2 = {| ``type`` = "keyword" |}
                      |}
                  |}
              ])
              Routing = Option.None
              Size = Option.None
              Source = Option.None
              Runtime = Option.None
              Enabled = Option.None
              Subobjects = Option.None
              DataStreamTimestamp = Option.None }

        // Create settings - TypesIndexSettings is obj, so we use an anonymous record
        let indexSettings : TypesIndexSettings = box {|
            number_of_shards = 3
            number_of_replicas = 0
        |}

        // Create aliases using generated types - initialize all fields explicitly
        let emptyAlias : TypesAlias =
            { Filter = Option.None
              IndexRouting = Option.None
              IsHidden = Option.None
              IsWriteIndex = Option.None
              Routing = Option.None
              SearchRouting = Option.None }

        let indexAliases : Map<string, TypesAlias> =
            Map.ofList [ "Test", emptyAlias ]

        let createReq =
            indicesCreateRequest {
                index "indexName"
                mappings indexMappings
                settings indexSettings
                aliases indexAliases
            }

        let result = createReq |> toRequestString

        // Check HTTP method and URI (note: generated paths have leading /)
        Assert.Contains("Method: PUT", result)
        Assert.Contains("RequestUri: '/indexName'", result)
        Assert.Contains("Content-Type: application/json", result)

        // Check JSON structure (note: anonymous records serialize to snake_case)
        shouldContainParts [
            "\"aliases\""
            "\"Test\""
            "\"settings\""
            "\"number_of_shards\":3"
            "\"number_of_replicas\":0"
            "\"mappings\""
            "\"properties\""
            "\"field1\""
            "\"field2\""
            "\"nestedField1\""
            "\"inner_field1\""
            "\"inner_field2\""
        ] result


    [<Fact>]
    let ``Alias Index command return correct HTTP call`` () =
        // Initialize all fields explicitly to avoid null reference issues
        let addAction : UpdateAliasesAddAction =
            { Alias = Option.Some "alias_test"
              Aliases = Option.None
              Filter = Option.None
              Index = Option.Some "indexName"
              Indices = Option.None
              IndexRouting = Option.None
              IsHidden = Option.None
              IsWriteIndex = Option.None
              Routing = Option.None
              SearchRouting = Option.None
              MustExist = Option.None }

        let aliasAction : UpdateAliasesAction =
            { Add = Option.Some addAction
              Remove = Option.None
              RemoveIndex = Option.None }

        let aliasReq =
            indicesUpdateAliasesRequest {
                actions [| aliasAction |]
                timeout "30s"
            }

        let result = aliasReq |> toRequestString

        // Check HTTP method and URI
        Assert.Contains("Method: POST", result)
        Assert.Contains("RequestUri: '/_aliases?timeout=30s'", result)
        Assert.Contains("Content-Type: application/json", result)

        // Check JSON structure
        shouldContainParts [
            "\"actions\""
            "\"add\""
            "\"index\":\"indexName\""
            "\"alias\":\"alias_test\""
        ] result

    [<Fact>]
    let ``Update Index command return correct HTTP call`` () =
        // TypesIndexSettings is obj, so we use an anonymous record for settings
        let indexSettings : TypesIndexSettings = box {|
            index = {|
                refresh_interval = "1s"
            |}
        |}

        let updateReq =
            indicesPutSettingsRequest {
                index (box "indexName" : Indices)
                body indexSettings
            }

        let result = updateReq |> toRequestString

        // Check HTTP method and URI
        Assert.Contains("Method: PUT", result)
        Assert.Contains("RequestUri: '/indexName/_settings'", result)
        Assert.Contains("Content-Type: application/json", result)

        // Check JSON structure
        shouldContainParts [
            "\"index\""
            "refresh_interval"
        ] result

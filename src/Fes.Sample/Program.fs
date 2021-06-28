open System
open Fes.Domain

[<EntryPoint>]
let main _ =
    let mapping =
        [|
            { MappingDefinition.Name = "field1"
              Type = FieldTypes.Text |> Fields.Text
              Mappings = [| Mapping.FieldMapping.Analyzer "analyzer_name" |] }
        |]
    let req =
      { IndexRequest.Name = "index_test"
        Mappings = Some mapping
        Settings = Some { IndexSettings.NumberOfReplicas = Some 1us
                          NumberOfShards = Some 3us }
        Aliases = None
        Parameters = None }
    let t =
        Fes.Http.fromBaseUri <| Uri "http://localhost:9200"
        |> Fes.Http.run (IndexRequest.ToRequest req)
        |> Async.RunSynchronously
    printfn $"%A{t}"
    
    0
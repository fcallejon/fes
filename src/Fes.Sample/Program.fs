open System
open Fes
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
        Settings = None
        Aliases = Some [| IndexAlias.mk "Test" |]
        Parameters = None }
      
    let t : Result<IndexCreateResponse, exn> =
        Http.fromBaseUri <| Uri "http://localhost:9200"
        |> Http.run (IndexRequest.ToRequest req)
        |> Async.RunSynchronously
        
    match t with
    | Ok o -> printfn $"{o}"
    | Error e -> printfn $"{e.Message}"
    0
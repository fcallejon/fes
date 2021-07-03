open System
open Fes
open Fes.Contracts
open Fes.Contracts.Fields
open Fes.Contracts.Indices
open Fes.Contracts.Mappings

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
        Settings = Some { IndexSettings.NumberOfShards = Some 3us; NumberOfReplicas = Some 0us }
        Aliases = Some [| IndexAlias.mk "Test" |]
        Parameters = None }
      
    let t : Result<IndexCreateResponse, exn> =
        Http.fromBaseUri <| Uri "http://localhost:9200"
        |> Http.run req
        |> Async.RunSynchronously
        
    match t with
    | Ok o -> printfn $"{o}"
    | Error e -> printfn $"{e.Message}"
    
    let update =
      { IndexRequest.Name = "index_test"
        Mappings = Some mapping
        Settings = Some { IndexSettings.NumberOfShards = Some 3us; NumberOfReplicas = Some 0us }
        Aliases = Some [| IndexAlias.mk "Test" |]
        Parameters = None }
      
    let t2 : Result<IndexCreateResponse, exn> =
        Http.fromBaseUri <| Uri "http://localhost:9200"
        |> Http.run req
        |> Async.RunSynchronously
        
    match t2 with
    | Ok o -> printfn $"{o}"
    | Error e -> printfn $"{e.Message}"
    
    0
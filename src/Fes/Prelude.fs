namespace Fes

open System

[<AutoOpen>]
module Prelude =
    open System.Threading.Tasks

    let inline konst x _ = x
    
    let inline teeOk f r =
        (function
        | Ok x -> f x
        | Error _ -> ()) |> ignore
        r

    let inline teeError f r =
        (function
        | Ok _ -> ()
        | Error x -> f x) |> ignore
        r

    type AsyncBuilder with
        member x.Bind(task: Task<'a>, f: 'a -> Async<'b>) =
            async.Bind((task |> Async.AwaitTask), f)
            
[<AutoOpen>]
module Strings =
    let joinByChar (sep: char) (x: string[]) =
        String.Join(sep, x)
        
[<AutoOpen>]
module FleeceOperators =
    open Fleece
    open Fleece.SystemTextJson

    /// Creates a new Json key-value pair for a Json object if the value option is present
    let inline jpairOptWith toJson (key: string) value = match value with Some value -> (key, toJson value) | _ -> (null, JNull)

    /// Creates a new Json key-value pair for a Json object if the value option is present
    let inline jpairOpt (key: string) value = jpairOptWith toJson key value
    
    /// Creates a new Json key-value pair for a Json object if the value is present in the option
    let inline (.=?) (key: string) value = jpairOpt key value
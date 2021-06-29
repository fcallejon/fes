namespace Fes

open FSharpPlus
open FSharpPlus.Data
open Fleece.SystemTextJson

type AsyncResult<'a, 'b> = Async<Result<'a, 'b>>
[<AutoOpen>]
module Prelude =
    let inline konst x _ = x

[<RequireQualifiedAccess>]
module Enum =
    let inline fromInt<'a> (v: int) =
        match System.Enum.TryParse(typeof<'a>, string v) with
        | true, eval -> Ok <| (eval :?> 'a)
        | _ -> exn $"%i{v} is an invalid value" |> Error  

[<RequireQualifiedAccess>]
module Result =
    let retn = Ok

[<RequireQualifiedAccess>]
module Async =
    let bind f a = async {
        let! x = a
        return! f x }

    let retn x = async { return x }

[<RequireQualifiedAccess>]
module AsyncResult =

    let retn x = x |> Result.retn |> Async.retn
    
    let map f =
        f |> Result.map |> Async.map
    
    let mapError f =
        f |> Result.mapError |> Async.map
        
    let bind f a = async {
        match! a with
        | Ok x -> return! f x
        | Error err -> return (Error err) }
    
    let bindError f a = async {
        match! a with
        | Ok x -> return Ok x
        | Error err -> return! f err }
    
[<RequireQualifiedAccess>]
module JsonEnum =
    let inline fromInt<'a> (v: int) =
        let toDecodeError e = Decode.Fail.parseError e "While parsing enum value."
        Enum.fromInt<'a> v
        |> Result.bindError toDecodeError
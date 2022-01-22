namespace Fes

open FSharpPlus
open FSharpPlus.Data
open Fleece.SystemTextJson

[<RequireQualifiedAccess>]
module Enum =
    let inline fromInt<'a> (v: int) =
        match System.Enum.TryParse(typeof<'a>, string v) with
        | true, eval -> Ok <| (eval :?> 'a)
        | _ -> exn $"%i{v} is an invalid value" |> Error  
    
[<RequireQualifiedAccess>]
module JsonEnum =
    open Fleece
    let inline fromInt<'a> (v: int) =
        let toDecodeError e = Decode.Fail.parseError e "While parsing enum value."
        Enum.fromInt<'a> v
        |> Result.bindError toDecodeError
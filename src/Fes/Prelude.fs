namespace Fes

open System

[<AutoOpen>]
module Prelude =
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

[<AutoOpen>]
module Strings =
    let joinByChar (sep: char) (x: string[]) =
        String.Join(sep, x)

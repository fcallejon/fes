namespace Fes

open System

[<AutoOpen>]
module Prelude =
    let inline konst x _ = x

    let inline teeOk f r =
        match r with
        | Ok x -> f x |> ignore
        | Error _ -> ()
        r

    let inline teeError f r =
        match r with
        | Ok _ -> ()
        | Error x -> f x |> ignore
        r

[<AutoOpen>]
module Strings =
    let joinByChar (sep: char) (x: string[]) =
        String.Join(sep, x)

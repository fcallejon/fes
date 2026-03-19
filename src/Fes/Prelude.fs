namespace Fes

open System

[<AutoOpen>]
module Prelude =
    /// Returns its first argument, ignoring the second. Useful for ignoring piped values.
    let inline konst x _ = x

    /// Applies f to the Ok value for side effects, then returns r unchanged.
    /// Note: f is not called if r is Error.
    let inline teeOk f r =
        (function
        | Ok x -> f x
        | Error _ -> ()) |> ignore
        r

    /// Applies f to the Error value for side effects, then returns r unchanged.
    /// Note: f is not called if r is Ok.
    let inline teeError f r =
        (function
        | Ok _ -> ()
        | Error x -> f x) |> ignore
        r

[<AutoOpen>]
module Strings =
    /// Joins an array of strings with the given separator character.
    let joinByChar (sep: char) (x: string[]) =
        String.Join(sep, x)

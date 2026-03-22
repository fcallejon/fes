namespace Fes

[<RequireQualifiedAccess>]
module Result =
    let retn = Ok
    
    let ofChoice =
        function
        | Choice1Of2 o -> Result.Ok o
        | Choice2Of2 e -> Result.Error e

    /// Collect a list of Results into a single Result containing a list.
    /// Returns the first Error encountered, or Ok with all values if all succeed.
    let sequence (results: Result<'a, 'e> list) : Result<'a list, 'e> =
        List.foldBack
            (fun r acc ->
                match r, acc with
                | Ok x, Ok xs -> Ok (x :: xs)
                | Error e, _ -> Error e
                | _, Error e -> Error e)
            results
            (Ok [])
namespace Fes

[<RequireQualifiedAccess>]
module Result =
    let retn = Ok
    
    let ofChoice =
        function
        | Choice1Of2 o -> Result.Ok o
        | Choice2Of2 e -> Result.Error e

    /// Calls f x, returning Ok with the result or Error with the caught exception.
    let inline protect (f: 'a -> 'b) (x: 'a) : Result<'b, exn> =
        try Ok (f x)
        with ex -> Error ex
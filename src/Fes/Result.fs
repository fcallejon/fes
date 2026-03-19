namespace Fes

[<RequireQualifiedAccess>]
module Result =
    /// Wraps a value in Ok. Alias for Ok.
    let retn = Ok

    /// Converts a Choice value to a Result.
    /// Choice1Of2 becomes Ok; Choice2Of2 becomes Error.
    let ofChoice =
        function
        | Choice1Of2 o -> Result.Ok o
        | Choice2Of2 e -> Result.Error e
namespace Fes

[<RequireQualifiedAccess>]
module Result =
    let retn = Ok
    
    let inline ofChoice x =
        match x with
        | Choice1Of2 o -> Result.Ok o
        | Choice2Of2 e -> Result.Error e
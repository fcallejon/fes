namespace Fes

[<RequireQualifiedAccess>]
module Result =
    let retn = Ok
    
    let ofChoice =
        function
        | Choice1Of2 o -> Result.Ok o
        | Choice2Of2 e -> Result.Error e
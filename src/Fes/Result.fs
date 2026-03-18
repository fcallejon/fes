namespace Fes

[<RequireQualifiedAccess>]
module Result =
    let retn = Ok
    
    let ofChoice =
        function
        | Choice1Of2 o -> Result.Ok o
        | Choice2Of2 e -> Result.Error e

    let toOption =
        function
        | Ok x -> Some x
        | Error _ -> None

    let ofOption (error: 'e) =
        function
        | Some x -> Ok x
        | None -> Error error
namespace Fes

[<AutoOpen>]
module Prelude =
    open System.Threading.Tasks

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

    type AsyncBuilder with
        member x.Bind(task: Task<'a>, f: 'a -> Async<'b>) =
            async.Bind((task |> Async.AwaitTask), f)
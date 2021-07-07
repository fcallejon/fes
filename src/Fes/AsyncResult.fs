namespace Fes

open System.Threading.Tasks

type AsyncResult<'a, 'b> = Async<Result<'a, 'b>>

[<RequireQualifiedAccess>]
module AsyncResult =
    open Fes

    let retn x = async.Return(Ok x)

    let bind f x = async {
        match! x with
        | Ok r -> return! f r
        | Error e -> return Error e }

    let inline map f m = bind (f >> retn) m

    let inline mapError f x = x |> Async.map (Result.mapError f)

    let inline ofChoice x = x |> Async.map Result.ofChoice
    
    let inline waitTask<'a> (t: Task<'a>) : AsyncResult<'a, exn> = async {
        let! tr = t
        return! retn tr }
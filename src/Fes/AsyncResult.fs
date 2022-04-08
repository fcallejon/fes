namespace Fes

open System.Threading.Tasks

type AsyncResult<'a, 'b> = Async<Result<'a, 'b>>

[<RequireQualifiedAccess>]
module AsyncResult =
    open Fes

    let retn x = async.Return(Ok x)

    let bind f x =
        async {
            match! x with
            | Ok r -> return! f r
            | Error e -> return Error e
        }

    let inline map f m = bind (f >> retn) m

    let inline mapError f x = x |> Async.map (Result.mapError f)

    let inline ofChoice x = x |> Async.map Result.ofChoice

    let inline waitTask<'a> (t: Task<'a>) : AsyncResult<'a, exn> =
        async {
            try
                let! tr = t
                return! retn tr
            with
            | e -> return Error e
        }


    let mapIn (f: 'a2 -> 'a) (a: 'a -> AsyncResult<'b, exn>) : 'a2 -> AsyncResult<'b, exn> =
        f >> a
    
    let mapOut (f: 'b -> 'c) (a: 'a -> AsyncResult<'b, exn>) : 'a -> AsyncResult<'c, exn> =
        a >> map f
    
    let bindIn (f: 'a2 -> AsyncResult<'a, exn>) (a: 'a -> AsyncResult<'b, exn>) : 'a2 -> AsyncResult<'b, exn> =
        f >> bind a
        
    let bindOut (f:'b -> AsyncResult<'c, exn>) (a:'a -> AsyncResult<'b, exn>) : 'a -> AsyncResult<'c, exn> =
        a >> bind f
      
    let after (f:'a * 'b -> _) (g:'a -> AsyncResult<'b, exn>) : 'a -> AsyncResult<'b, exn> =
        fun a -> g a |> map (fun b -> let _ = f (a,b) in b)
namespace Fes

open System.Threading.Tasks

type TaskResult<'a, 'b> = Task<Result<'a, 'b>>

[<RequireQualifiedAccess>]
module TaskResult =
    let retn x : TaskResult<'a, 'b> = Task.FromResult(Ok x)

    let bind (f: 'a -> TaskResult<'b, 'e>) (x: TaskResult<'a, 'e>) : TaskResult<'b, 'e> =
        task {
            match! x with
            | Ok r -> return! f r
            | Error e -> return Error e
        }

    let inline map f m = bind (f >> retn) m

    let inline mapError f (x: TaskResult<'a, 'e>) : TaskResult<'a, 'e2> =
        x |> TaskHelpers.map (Result.mapError f)

    let inline ofChoice (x: Task<Choice<'a, 'e>>) : TaskResult<'a, 'e> =
        x |> TaskHelpers.map Result.ofChoice

    let inline ofTask<'a> (t: Task<'a>) : TaskResult<'a, exn> =
        task {
            try
                let! tr = t
                return Ok tr
            with
            | e -> return Error e
        }

    let mapIn (f: 'a2 -> 'a) (a: 'a -> TaskResult<'b, 'e>) : 'a2 -> TaskResult<'b, 'e> =
        f >> a

    let mapOut (f: 'b -> 'c) (a: 'a -> TaskResult<'b, 'e>) : 'a -> TaskResult<'c, 'e> =
        a >> map f

    let bindIn (f: 'a2 -> TaskResult<'a, 'e>) (a: 'a -> TaskResult<'b, 'e>) : 'a2 -> TaskResult<'b, 'e> =
        f >> bind a

    let bindOut (f: 'b -> TaskResult<'c, 'e>) (a: 'a -> TaskResult<'b, 'e>) : 'a -> TaskResult<'c, 'e> =
        a >> bind f

    let after (f: 'a * 'b -> _) (g: 'a -> TaskResult<'b, 'e>) : 'a -> TaskResult<'b, 'e> =
        fun a -> g a |> map (fun b -> let _ = f (a, b) in b)

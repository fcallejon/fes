namespace Fes

open System.Threading.Tasks

/// Represents an asynchronous operation that may succeed with 'a or fail with 'b.
type TaskResult<'a, 'b> = Task<Result<'a, 'b>>

[<RequireQualifiedAccess>]
module TaskResult =
    /// Wraps a value in a successfully completed TaskResult.
    let retn x : TaskResult<'a, 'b> = Task.FromResult(Ok x)

    /// Sequentially composes two async Result-producing operations.
    /// If the first produces Error, the error is propagated without calling f.
    let bind (f: 'a -> TaskResult<'b, 'e>) (x: TaskResult<'a, 'e>) : TaskResult<'b, 'e> =
        task {
            match! x with
            | Ok r -> return! f r
            | Error e -> return Error e
        }

    /// Transforms the Ok value of a TaskResult by applying f.
    let inline map f m = bind (f >> retn) m

    /// Transforms the Error value of a TaskResult by applying f.
    let inline mapError f (x: TaskResult<'a, 'e>) : TaskResult<'a, 'e2> =
        x |> TaskHelpers.map (Result.mapError f)

    /// Converts a Task<Choice<'a,'e>> to a TaskResult, mapping Choice1Of2 → Ok and Choice2Of2 → Error.
    let inline ofChoice (x: Task<Choice<'a, 'e>>) : TaskResult<'a, 'e> =
        x |> TaskHelpers.map Result.ofChoice

    /// Lifts a plain Task into a TaskResult, catching any exception as Error.
    let inline ofTask<'a> (t: Task<'a>) : TaskResult<'a, exn> =
        task {
            try
                let! tr = t
                return Ok tr
            with
            | e -> return Error e
        }

    /// Pre-composes a synchronous input transformation before a TaskResult-producing function.
    let mapIn (f: 'a2 -> 'a) (a: 'a -> TaskResult<'b, exn>) : 'a2 -> TaskResult<'b, exn> =
        f >> a

    /// Post-composes a TaskResult-producing function with a synchronous output transformation.
    let mapOut (f: 'b -> 'c) (a: 'a -> TaskResult<'b, exn>) : 'a -> TaskResult<'c, exn> =
        a >> map f

    /// Pre-composes two TaskResult-producing functions, threading the output of f into a.
    let bindIn (f: 'a2 -> TaskResult<'a, exn>) (a: 'a -> TaskResult<'b, exn>) : 'a2 -> TaskResult<'b, exn> =
        f >> bind a

    /// Post-composes two TaskResult-producing functions, threading the output of a into f.
    let bindOut (f: 'b -> TaskResult<'c, exn>) (a: 'a -> TaskResult<'b, exn>) : 'a -> TaskResult<'c, exn> =
        a >> bind f

    /// Runs a side-effecting function on the input/output pair after g completes successfully,
    /// then returns the original Ok value unchanged.
    let after (f: 'a * 'b -> _) (g: 'a -> TaskResult<'b, exn>) : 'a -> TaskResult<'b, exn> =
        fun a -> g a |> map (fun b -> let _ = f (a, b) in b)

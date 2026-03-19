namespace Fes

open System.Threading.Tasks

[<RequireQualifiedAccess>]
module TaskHelpers =
    /// Wraps a value in a successfully completed Task.
    let inline retn x = Task.FromResult(x)

    /// Sequentially composes two async operations, passing the result of the first to f.
    let inline bind (f: 'a -> Task<'b>) (t: Task<'a>) : Task<'b> =
        task {
            let! a = t
            return! f a
        }

    /// Transforms the result of an async operation by applying f to its value.
    let inline map (f: 'a -> 'b) (t: Task<'a>) : Task<'b> =
        task {
            let! a = t
            return f a
        }

    /// Post-composes an async operation with a synchronous transformation.
    let mapOut (f: 'b -> 'c) (a: 'a -> Task<'b>) : 'a -> Task<'c> =
        a >> map f

    /// Pre-composes two async operations, piping the output of f into a.
    let bindOut (f: 'c -> Task<'a>) (a: 'a -> Task<'b>) : 'c -> Task<'b> =
        f >> bind a

    /// Pre-composes an async operation with a synchronous input transformation.
    let mapIn (f: 'a2 -> 'a) (a: 'a -> Task<'b>) : 'a2 -> Task<'b> =
        f >> a

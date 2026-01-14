namespace Fes

open System.Threading.Tasks

[<RequireQualifiedAccess>]
module TaskHelpers =
    let inline retn x = Task.FromResult(x)

    let inline bind (f: 'a -> Task<'b>) (t: Task<'a>) : Task<'b> =
        task {
            let! a = t
            return! f a
        }

    let inline map (f: 'a -> 'b) (t: Task<'a>) : Task<'b> =
        task {
            let! a = t
            return f a
        }

    let mapOut (f: 'b -> 'c) (a: 'a -> Task<'b>) : 'a -> Task<'c> =
        a >> map f

    let bindOut (f: 'c -> Task<'a>) (a: 'a -> Task<'b>) : 'c -> Task<'b> =
        f >> bind a

    let mapIn (f: 'a2 -> 'a) (a: 'a -> Task<'b>) : 'a2 -> Task<'b> =
        f >> a

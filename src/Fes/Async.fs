namespace Fes

[<RequireQualifiedAccess>]
module Async =
    let inline retn x = async { return x }
    let inline bind f a = async.Bind(a, f)
    let inline map f = bind (f >> retn)   

    let mapOut (f: 'b -> 'c) (a:'a -> Async<'b>) : 'a -> Async<'c> =
        a >> map f
        
    let bindOut (f: 'c -> Async<'a>) (a:'a -> Async<'b>) : 'c -> Async<'b> =
        f >> bind a
        
    let mapIn (f:'a2 -> 'a) (a:'a -> Async<'b>) : 'a2 -> Async<'b> =
        f >> a
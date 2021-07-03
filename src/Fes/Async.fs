namespace Fes

[<RequireQualifiedAccess>]
module Async =
    let inline retn x = async { return x }
    let inline bind  f vA = async.Bind(  vA, f)
    let inline map   f    = bind (f >> retn)
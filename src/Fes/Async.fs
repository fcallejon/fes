﻿namespace Fes

[<RequireQualifiedAccess>]
module Async =
    let inline retn x = async { return x }
    let inline bind f a = async.Bind(a, f)
    let inline map f = bind (f >> retn)
    
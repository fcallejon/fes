namespace Fes.Tests

open Xunit


[<AutoOpen>]
module Assert =
    let inline shouldEqual expected requestCommand =
        requestCommand
        |> Fes.Http.toRequest
        |> Result.map string
        |> (function
            | Ok x -> Assert.Equal(expected, x, true, true, true)
            | Error e -> raise e)
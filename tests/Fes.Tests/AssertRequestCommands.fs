namespace Fes.Tests

open System
open FSharpPlus
open Xunit
open Fes

[<AutoOpen>]
module Assert =

    let inline private getBody (request: Http.RequestMsg) =
        match request.Method.Method.ToUpperInvariant() with
        | "POST"
        | "PUT"
        | "PATCH" when request.Content <> null ->
            request.Content.ReadAsStringAsync()
            |> TaskResult.ofTask
            |> fun t -> t.Result
        | _ ->
            String.Empty
            |> Result.retn

    let inline toRequestString requestCommand =
        let getCallAndBody req =
            fun body -> sprintf $"{string req}\r\n{body}"
            <!> (getBody req)

        requestCommand
        |> Http.toRequest
        |> Result.bind getCallAndBody
        |> (function
            | Ok x -> x
            | Error e -> raise e)

    let inline shouldEqual expected requestCommand =
        let result = toRequestString requestCommand
        Assert.Equal(expected, result, true, true, true)

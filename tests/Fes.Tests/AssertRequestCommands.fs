namespace Fes.Tests

open System
open Fes
open FSharpPlus
open Xunit

[<AutoOpen>]
module Assert =
    
    let inline private getBody (request: Http.RequestMsg) =
        match request.Method.Method.ToUpperInvariant() with
        | "POST"
        | "PUT"
        | "PATCH" ->
            request.Content.ReadAsStringAsync()
            |> AsyncResult.waitTask
            |> Async.RunSynchronously
        | _ ->
            String.Empty
            |> Result.retn
    let inline shouldEqual expected requestCommand =
        let getCallAndBody req =
            fun body -> sprintf $"{string req}\r\n{body}"
            <!> (getBody req)
        
        requestCommand
        |> Http.toRequest
        |> Result.bind getCallAndBody
        |> (function
            | Ok x -> Assert.Equal(expected, x, true, true, true)
            | Error e -> raise e)
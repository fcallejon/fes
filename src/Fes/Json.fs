namespace Fes

open Fleece.SystemTextJson

module Json =
    type JRes<'a> =
        | Ok of 'a
        | Error of string

    open Fleece
    let inline tryGetValue k (from: Encoding) =
        match from with
        | JObject o ->
            o.Properties
            |> Seq.tryFind (fun (key, _) -> key = k)
        | _ -> None
    
[<AutoOpen>]
module JRes =
    open Json
    let bind (f: 'a -> JRes<'b>) (r: JRes<'a>) : JRes<'b> =
        match r with
        | Ok r' -> f r'
        | Error e -> Error e
        
    let map (f: 'a -> 'b) (r: JRes<'a>) : JRes<'b> =
        bind (f >> Ok) r
        
    type ParserBuilder() =
        member _.Return x = Ok x
        member _.ReturnFrom = id
        member _.Bind (x, f) = bind f x

[<RequireQualifiedAccess>]
module JsonRes =
    open Fleece
    open Json
    let inline from json =
        let inline _from (_: ^a, b: ^b) =
            ((^a or ^b): (static member OfJson: ^b -> (JsonValue -> ^b JRes)) b)
        _from (Encoding, Unchecked.defaultof<'a>) json
        
    let inline ofString s =
        let _map =
            function
            | ParseResult.Ok o -> Result.Ok o
            | ParseResult.Error e -> Result.Error <| exn $"%O{e}"
        
        Encoding.Parse s
        |> (ofJson >> _map)
        |> Async.retn
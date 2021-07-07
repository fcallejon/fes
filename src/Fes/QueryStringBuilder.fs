namespace Fes

[<RequireQualifiedAccess>]
module QueryStringBuilder =
    open System
    
    let mk (values: option<string>[]) =
        let v =
            values
            |> Array.choose id
        in String.Join("&", v) |> sprintf "?%s"
        |> Result.Ok

[<AutoOpen>]
module private QueryParams =
    let inline toQueryParams x =
        (^T: (static member ToQueryParams : ^T -> Result<string, exn>) x)
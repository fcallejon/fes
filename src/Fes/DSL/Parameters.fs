namespace Fes.DSL

open Fes

[<AutoOpen>]
module QueryStringParametersOption =
    let inline csvOpt x = x |> Option.map (joinByChar ',')
    
    let inline csv x = joinByChar ',' x

[<RequireQualifiedAccess>]
type ExpandWildcardsOptions =
    | All
    | Open
    | Closed
    | Hidden
    | None
    member this.ToString =
        function
        | All -> "all"
        | Open -> "open"
        | Closed -> "closed"
        | Hidden -> "hidden"
        | None -> "none"